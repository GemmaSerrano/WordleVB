Imports System.Data.OleDb

Public Class FDictionary
    Dim pathDB As String = Application.StartupPath + "\wordle.mdb"
    Dim dataSet As DataSet
    Dim connection As OleDbConnection
    Dim dataAdapterList() As OleDbDataAdapter
    Dim dataAdapterDiccionario As OleDbDataAdapter
    Dim cbDiccionario As OleDbCommandBuilder
    Public FViewRecords As New FViewRecors


    Private Sub FDictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    'Modo desconectado
    Public Sub CargarDatos()
        Try
            'Creamos objeto conexión y lo definimos
            connection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pathDB)

            dataSet = New DataSet

            'Nos conectamos
            connection.Open()

            'Recuperamos en el DataAdapter la tabla Words de la BD
            dataAdapterDiccionario = New OleDbDataAdapter("SELECT * FROM Diccionario", connection)

            'Rellenamos el DataSet con la info creando una tabla Words
            dataAdapterDiccionario.Fill(dataSet, "Diccionario")

            'Usamos CommandBuilder para hacer actualizaciones automáticas
            cbDiccionario = New OleDbCommandBuilder(dataAdapterDiccionario)

            'Guardamos los DataAdapter para usarlos despues en un bucle para actualizarlos
            dataAdapterList = New OleDbDataAdapter() {dataAdapterDiccionario}

            ' Asignar el DataSet al DataGridView
            DGVDiccionario.DataSource = dataSet.Tables("Diccionario")

            'Nos desconectamos
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar palabras: " & ex.Message)
        End Try
    End Sub

    'Método para actualizar los datos de la tabla, que llamamos en botón
    Private Sub UploadData()
        Try
            'Abrimos conexion.
            connection.Open()
            'Actualizamos en el servidor la informacion de todos los adaptadores.
            For i = 0 To dataAdapterList.Length - 1
                dataAdapterList(i).Update(dataSet.Tables(i))
            Next
            'Cerramos conexion.
            connection.Close()

            MsgBox("Datos actualizados.")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            connection.Close()
        End Try
    End Sub

    'Al pulsar botón guardar, actualizamos la tabla


    Private Sub FMaintenance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        UploadData()
    End Sub
End Class

