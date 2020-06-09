Imports System.Data.OleDb

Public Class ManageBD


    Private Function cadena()
        '  Dim RoadPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mauricio Barahona\Documents\Agenda\agendaBD.mdb;" 'Jet OLEDB:Database Password=nirvana22"

        '  Dim RoadPath As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\agendaBD.mdb"

        Dim RoadPath As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\Agenda\agendaBD.mdb"
        Return RoadPath
    End Function

    Public Sub modificaBD(ByVal varSQL As String) ' metodo que sirve para ejecutar cualquier consulta tipo INSERT,UPDATE o DELETE
        Try
            Dim objConexion As New OleDb.OleDbConnection
            objConexion.ConnectionString = cadena()
            objConexion.Open()

            Try

                Dim SQLcommand As New OleDb.OleDbCommand(varSQL, objConexion)

                SQLcommand.ExecuteNonQuery()
                objConexion.Close()

            Catch e As Exception
                MsgBox("Exception on SQL statement : Puede ser que el registro este duplicado, verificar caso o contactar con Soporte  " & vbCrLf + e.ToString())
                objConexion.Close()
            End Try
        Catch e As Exception
            MsgBox("Exception on OLE method" & vbCrLf + e.ToString())

        End Try
    End Sub


    Public Sub fillTable(ByVal SQLselect As String, ByVal tableGrid As DataGridView)     ' METODO PARA ACTUALIZAR LA TABLA DE ACTIVIDADES

        Dim objConexion As New OleDb.OleDbConnection
        objConexion.ConnectionString = cadena()
        objConexion.Open()


        Dim objTable As New OleDb.OleDbDataAdapter(SQLselect, objConexion)
        Dim tabla As New DataTable

        objTable.Fill(tabla)

        tableGrid.DataSource = tabla
        objConexion.Close()

    End Sub



End Class
