Imports Agenda.ManageBD

Public Class Nueva_Act

    Public manejadorSQL As New ManageBD
    Public manejadorTABLE As New ManageBD

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)







    End Sub



    Private Sub Nueva_Act_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        manejadorTABLE.fillTable("select * from actividades where fecha_termino IS NOT NULL", Me.DataGridView2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class