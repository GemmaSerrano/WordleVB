Imports System.Data.OleDb

Public Class FWordle
    Public lbfilas As Integer
    Public lbcolumnas As Integer
    Public playerName As String
    Public aciertos As Integer
    Public FDictionary As New FDictionary
    Public FViewRecords As New FViewRecors
    Public tiempo As Integer

    Dim currentRow As Integer = 0 ' Fila actual (0 a 5)
    Dim currentLetterIndex As Integer = 0 ' Índice de la letra dentro de la fila (0 a 4)
    Dim wordLength As Integer = 5 ' Longitud de la palabra
    Dim maxAttempts As Integer = 6 ' Número máximo de intentos
    Dim labels(5, 4) As Label ' Matriz para almacenar las etiquetas (6 filas, 5 columnas)
    Dim secretWord As String

    'Ruta de la base de datos
    Dim pathDB As String = Application.StartupPath + "\wordle.mdb"
    Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathDB


    Private Sub FWordle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableButtons(False)

    End Sub
    Private Sub StartGame()
        playerName = InputBox("Enter your name:", "Welcome to Wordle")
        FDictionary.CargarDatos()
        CreateRows()
        EnableButtons(True)  'Habilitado al cominenzo de juego
        secretWord = GetWord()
        currentRow = 0
        currentLetterIndex = 0

        ' Asignar eventos a los botones del teclado virtual
        For Each ctrl As Control In FLPLetters.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)

                ' Si es un botón de letra, asignar el evento PressKeys
                If btn.Text <> "ENTER" AndAlso btn.Text <> "<X>" Then
                    AddHandler btn.Click, AddressOf PressKeys
                End If

                ' Si es el botón de borrar "<X", asignar el evento DeleteLastLetter
                If btn.Text = "<X" Then
                    AddHandler Button28.Click, AddressOf DeleteLastLetter
                End If

                ' Si es el botón "ENTER", asignar el evento CheckWord
                If btn.Text = "ENTER" Then
                    AddHandler btn.Click, AddressOf CheckWord
                End If
            End If
        Next
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        StartGame()

    End Sub


    'Crea las label del juego
    Private Sub CreateRows()
        ' Tamaño y espacio de las etiquetas (labels)
        Dim labelSize As Integer = 34 ' Ajusté el tamaño para mejor visibilidad
        Dim spacing As Integer = 5
        Dim leftMargin As Integer = 100
        Dim topMargin As Integer = 35 ' Ajuste para que no se superponga con otros controles

        ' Crear 6 filas y 5 columnas (Wordle clásico)
        For i As Integer = 0 To 5
            For j As Integer = 0 To 4
                Dim lb As New Label() ' Variable para cada casilla

                ' Propiedades
                lb.Name = $"label{i}{j}"
                lb.Text = ""
                lb.Width = labelSize
                lb.Height = labelSize
                lb.TextAlign = ContentAlignment.MiddleCenter
                lb.BorderStyle = BorderStyle.FixedSingle
                lb.Font = New Font("Arial", 16, FontStyle.Bold)
                lb.BackColor = Color.White ' Fondo blanco por defecto

                ' Ubicación
                lb.Left = leftMargin + j * (labelSize + spacing)
                lb.Top = topMargin + i * (labelSize + spacing)
                labels(i, j) = lb
                ' Agregar al formulario
                Me.Controls.Add(lb)
            Next
        Next
    End Sub

    'Se obtendrá la palabra aleatoria del Diccionario de bd

    Public Function GetWord() As String
        Dim palabra As String = ""

        Try
            ' Verificar si el DataGridView y la tabla tienen datos
            If FDictionary Is Nothing OrElse FDictionary.DGVDiccionario Is Nothing OrElse FDictionary.DGVDiccionario.Rows.Count = 0 Then
                MessageBox.Show("No hay palabras en el diccionario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return "ERROR"
            End If
            ' Generar un índice aleatorio basado en el número de filas disponibles
            Dim rand As New Random()
            Dim index As Integer = rand.Next(0, FDictionary.DGVDiccionario.Rows.Count)

            ' Obtener la palabra aleatoria desde la celda correcta y que no sea Nothing
            Dim cellValue As Object = FDictionary.DGVDiccionario.Rows(index).Cells("palabra").Value
            If cellValue IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cellValue.ToString()) Then
                palabra = cellValue.ToString().ToUpper()
            Else
                MessageBox.Show("Error: La celda seleccionada está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                palabra = "ERROR"
            End If

            ' SALIDA: PalabraAdivinar 
            Debug.Print("Palabra a adivinar: " & palabra)
        Catch ex As Exception
            MessageBox.Show("Error al obtener palabra aleatoria: " & ex.Message)
            palabra = "ERROR"
        End Try

        Return palabra
    End Function



    'Se habilitan los botones de la parte inferior o habilitarlos
    Public Sub EnableButtons(enable As Boolean)
        ' Verifica que FLPLetters existe antes de modificar los controles
        If Me.Controls.Contains(FLPLetters) Then
            ' Recorre todos los controles dentro de FLPLetters
            For Each ctrl As Control In FLPLetters.Controls
                ' Verifica si el control es un botón antes de modificar su estado
                If TypeOf ctrl Is Button Then
                    ctrl.Enabled = enable
                End If
            Next
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub



    'Poner las letras en las casillas de izq. a derecha
    Private Sub PressKeys(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        ' Solo añadir letra si no hemos alcanzado las 5 letras en la fila
        If currentLetterIndex < wordLength Then
            labels(currentRow, currentLetterIndex).Text = btn.Text
            currentLetterIndex += 1
        End If
    End Sub

    Private Sub DeleteLastLetter()
        ' Solo borrar si hay al menos una letra en la fila
        If currentLetterIndex > 0 Then
            currentLetterIndex -= 1 ' Retrocede una posición
            If labels IsNot Nothing AndAlso labels(currentRow, currentLetterIndex) IsNot Nothing Then
                labels(currentRow, currentLetterIndex).Text = "" ' Borra la letra
            End If
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles Button28.Click
        DeleteLastLetter()
    End Sub
    Private Sub CheckWord()
        ' Solo verificar si la fila tiene 5 letras ingresadas
        If currentLetterIndex = wordLength Then
            Dim word As String = ""

            ' Construir la palabra a partir de las etiquetas de la fila actual
            For i As Integer = 0 To wordLength - 1
                word &= labels(currentRow, i).Text
            Next

            ' Comparar con la palabra secreta y cambiar colores
            For i As Integer = 0 To wordLength - 1
                Dim letter As String = labels(currentRow, i).Text

                ' Si la letra está en la posición correcta (verde)
                If letter = secretWord(i) Then
                    labels(currentRow, i).BackColor = Color.Green
                    labels(currentRow, i).ForeColor = Color.White
                    UpdateKeyboardColor(letter, Color.Green, Color.White)

                    ' Si la letra está en la palabra pero en otra posición (amarillo)
                ElseIf secretWord.Contains(letter) Then
                    labels(currentRow, i).BackColor = Color.Yellow
                    labels(currentRow, i).ForeColor = Color.Black
                    UpdateKeyboardColor(letter, Color.Yellow, Color.Black)

                    ' Si la letra no está en la palabra (gris)
                Else
                    labels(currentRow, i).BackColor = Color.Gray
                    labels(currentRow, i).ForeColor = Color.White
                    UpdateKeyboardColor(letter, Color.Gray, Color.White)
                End If
            Next

            ' Comprobar si la palabra es correcta
            If word = secretWord Then
                tiempo = 23
                GuardarPartida()
                EnableButtons(False) ' Deshabilitar teclado al ganar
                MessageBox.Show("¡Felicidades! Has adivinado la palabra.", "Wordle")
            Else
                ' Pasar a la siguiente fila si quedan intentos
                If currentRow < maxAttempts - 1 Then
                    currentRow += 1
                    currentLetterIndex = 0
                Else
                    EnableButtons(False) ' Deshabilitar teclado al perder
                    MessageBox.Show("Has perdido. La palabra correcta era: " & secretWord, "Fin del juego")

                End If
            End If
        Else
            MessageBox.Show("Debes ingresar 5 letras antes de presionar ENTER.")
        End If
    End Sub

    Private Sub UpdateKeyboardColor(letter As String, bgColor As Color, fgColor As Color)
        For Each ctrl As Control In FLPLetters.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                If btn.Text = letter Then
                    btn.BackColor = bgColor
                    btn.ForeColor = fgColor
                End If
            End If
        Next
    End Sub



    'Guardar partida en la tabla Partidas de la BD, en MODO CONECTADO
    Private Sub GuardarPartida()
        Dim con As New OleDbConnection(ConnectionString)
        Try
            con.Open()
            Dim cmd As New OleDbCommand("INSERT INTO Partidas (FechaHora, Acierto, Jugador, Tiempo) VALUES (?,?,?,?)", con)
            cmd.Parameters.AddWithValue("@FechaHora", DateTime.Now.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@Acierto", aciertos)
            cmd.Parameters.AddWithValue("@Jugador", playerName)
            cmd.Parameters.AddWithValue("@Tiempo", tiempo)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Puntuación guardada correctamente")
            FViewRecords.CargarPartidas()
        Catch ex As Exception
            MessageBox.Show("Error al guardar puntuación: " & ex.Message)
        End Try
    End Sub
    Private Sub DictionaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DictionaryToolStripMenuItem.Click
        FDictionary.ShowDialog()
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem.Click
        FViewRecords.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub HistoricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoricoToolStripMenuItem.Click
        FHistorico.ShowDialog()
    End Sub
End Class
