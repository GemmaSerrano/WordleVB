
Imports System.Data.OleDb

Public Class FHistorico


    'En la tabla Historico, parece que están las partidas que están terminadas, pero sin pasar a Records
    'Cuando se termina la partida se crean en Historica y cuando yo entro, si hay registros los pasará a Records y los
    'quitará de Historica

    Dim pathDB As String = Application.StartupPath + "\wordle.mdb"
        Dim dataSet As DataSet
        Dim connection As OleDbConnection
        Dim dataAdapterList() As OleDbDataAdapter

    Private Sub FHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarHistorial()
        Historical_pass()
    End Sub
    Public Sub CargarHistorial()
            Try
                connection = New OleDbConnection
                Dim dataAdapterHistorico As OleDbDataAdapter
                dataSet = New DataSet

                connection.ConnectionString = "PROVIDER=Microsoft.Jet.OleDb.4.0; Data Source= " + pathDB
                connection.Open()

                'Recuperamos en el DataAdapter la tabla Historico de la BD
                dataAdapterHistorico = New OleDbDataAdapter("SELECT * FROM Historico", connection)

                'Rellenamos el DataSet con la info creando una tabla Historico
                dataAdapterHistorico.Fill(dataSet, "Historico")

                connection.Close()

            ' Asignar el DataSet al DataGridView
            DTGHistorico.DataSource = dataSet.Tables("Historico")

        Catch ex As Exception
                MessageBox.Show("Error al cargar la tabla" & ex.Message)
            End Try
        End Sub


        Private Sub Historical_pass()

            ' Verificar si la tabla tiene filas
            If dataSet.Tables("Historico").Rows.Count = 0 Then
                MessageBox.Show("No hay registros que pasar")
            Else
                PasarTablaRecords()
                For Each fila As DataRow In dataSet.Tables("Historico").Rows

                Next
            End If

        End Sub


        Public Sub PasarTablaRecords()
            Try
                Dim connection As New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0; Data Source=" & pathDB)
                connection.Open()

                ' Confirmación antes de mover los datos
                If MessageBox.Show("Tienes partidas por pasar a la tabla Records! ¿Quieres actualizar los datos?", "Confirmación",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    connection.Close()
                    Exit Sub
                End If



                connection.Close()

            Catch ex As Exception
                MessageBox.Show("Error al transferir las partidas: " & ex.Message)
            End Try
        End Sub


End Class


