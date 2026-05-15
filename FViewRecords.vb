Imports System.Data.OleDb

Public Class FViewRecors
    Dim pathDB As String = Application.StartupPath + "\wordle.mdb"
    Dim dataSet As DataSet
    Dim connection As OleDbConnection
    Dim dataAdapterList() As OleDbDataAdapter
    Public Sub FViewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPartidas()
    End Sub

    '
    Public Sub CargarPartidas()
        Try
            connection = New OleDbConnection
            Dim dataAdapterPartidas As OleDbDataAdapter
            dataSet = New DataSet

            connection.ConnectionString = "PROVIDER=Microsoft.Jet.OleDb.4.0; Data Source= " + pathDB
            connection.Open()

            'Recuperamos en el DataAdapter la tabla Partidas de la BD
            dataAdapterPartidas = New OleDbDataAdapter("SELECT * FROM Partidas", connection)

            'Rellenamos el DataSet con la info creando una tabla Partidas
            dataAdapterPartidas.Fill(dataSet, "Partidas")

            connection.Close()

            ' Asignar el DataSet al DataGridView
            DTGRecords.DataSource = dataSet.Tables("Partidas")
            DTGRecords.ReadOnly = True



        Catch ex As Exception
            MessageBox.Show("Error al cargar la tabla" & ex.Message)
        End Try
    End Sub

    'Calcular el tiempo de juego en segundos
    Private Sub CalcularTiempo()
        Dim total As Integer

        ' Verificar si la tabla "Partidas" tiene filas
        If dataSet.Tables("Partidas") IsNot Nothing Then
            For Each fila As DataRow In dataSet.Tables("Partidas").Rows
                total += Val(fila("Premio"))
            Next
        End If

    End Sub

End Class