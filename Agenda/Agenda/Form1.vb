
Imports Agenda.ManageBD
Public Class Form1

    Public manejadorSQL As New ManageBD
    Public manejadorTABLE As New ManageBD


    Private Sub ActividadesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Me.Validate()
        Me.ActividadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AgendaBDDataSet)



        '   If ActividadesDataGridView.CurrentRow.Cells(5).Value = 1 Then
        'ActividadesTableAdapter.labelFIN(CInt(ActividadesDataGridView.CurrentRow.Cells(0).Value))
        ' ActividadesDataGridView.CurrentRow.Cells(6).Value = DateValue(Now)
        '  Me.TableAdapterManager.UpdateAll(Me.AgendaBDDataSet)
        '  MsgBox("registro marcado como Terminado")
        '  End If




    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AgendaBDDataSet.actividades' table. You can move, or remove it, as needed.

        Me.ActividadesTableAdapter.Fill(Me.AgendaBDDataSet.actividades)


    End Sub



    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Me.ActividadesTableAdapter.nuevaACT(ActividadTextBox.Text, SolicitaTextBox.Text)
        '  Me.ActividadesTableAdapter.Fill(Me.AgendaBDDataSet.actividades)




    End Sub





    Private Sub ActividadesDataGridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ActividadesDataGridView.CellEnter
        ' ActividadesDataGridView.CurrentRow.Cells(1).Value = DateValue(Now)
    End Sub


    Sub conectNEW()
        Dim x As New OleDb.OleDbConnection
        x.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files\Agenda\agendaBD.accdb;Jet OLEDB:Database Password=nirvana22"

        Try
            x.Open()
            Dim sql As String = "insert into actividades (fecha_alta,Actividad,Solicita) Values('17/12/2017','prueba 12','uriel sanchez')"
            Dim cmd As New OleDb.OleDbCommand(sql, x)

            cmd.ExecuteNonQuery()

            x.Close()
        Catch e As Exception
            Dim err As String = e.ToString
            MsgBox("problemas en " & err)
            x.Close()
        End Try

    End Sub



    Sub conecta2()
        Dim x As New OleDb.OleDbConnection
        x.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Z743075\Documents\Agenda\agendaBD.accdb;Jet OLEDB:Database Password=nirvana22"

        x.Open()            'INSERT INTO `actividades` (`Actividad`, `Solicita`) VALUES (?, ?)

        Dim sql As String = "select * from actividades"
        Dim xx As New OleDb.OleDbDataAdapter(sql, x)
        Dim tabla As New DataTable

        xx.Fill(tabla)

        ActividadesDataGridView.DataSource = tabla

        x.Close()

    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim sql As String = "insert into actividades (fecha_alta,Actividad,Solicita) Values('31/12/2017','prueba 1.35','frida  sanchez')"

        manejadorSQL.modificaBD(sql)
        manejadorTABLE.fillTable("select * from actividades where fecha_termino is null order by Importancia asc", Me.ActividadesDataGridView)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim number As Integer
        ' Dim varDia As String = Format(DateValue(Now), "dd/mm/yyyy")
        number = ActividadesDataGridView.CurrentRow.Cells(0).Value


        Dim sql As String = "update actividades set  fecha_inicio =  Format(now(), 'dd/mm/yyyy') where ((Idact =" & number & " ) AND ((fecha_inicio IS NULL)) and ((fecha_termino IS NULL)))"

        ' MsgBox(varDia)
        manejadorSQL.modificaBD(sql)
        manejadorTABLE.fillTable("select * from actividades where fecha_termino is null order by Importancia asc", Me.ActividadesDataGridView)




    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        '  MsgBox(varDia)

        Dim number As Integer
        ' Dim varDia As String = Format(DateValue(Now), "dd/mm/yyyy")
        number = ActividadesDataGridView.CurrentRow.Cells(0).Value

        If CheckBox1.CheckState = 0 Then
        Else
            Dim sql As String = "update actividades set  fecha_termino =  Format(now(), 'dd/mm/yyyy'),completado = 1  where ((Idact =" & number & " ) AND ((fecha_inicio IS NOT NULL)) and ((fecha_termino IS NULL)))"

            ' MsgBox(varDia)
            manejadorSQL.modificaBD(sql)
            manejadorTABLE.fillTable("select * from actividades where fecha_termino is null order by Importancia asc", Me.ActividadesDataGridView)

        End If
        CheckBox1.CheckState = 0
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Nueva_Act.Show()
        Button3.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Me.ActividadesDataGridView.Location = New System.Drawing.Point(8, 94)
        TextBox1.Visible = True
        TextBox2.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        ListBox1.Visible = True


    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Metodo de nueva tarea
        If TextBox1.Text = "" Then
            MsgBox("Ingresa una  actividad para continuar", MsgBoxStyle.Information, "Agenda")
        Else

            If CInt(ListBox1.Text) > 5 Or CInt(ListBox1.Text) < 1 Then
                MsgBox("Determine un valor entre 1 y 5", MsgBoxStyle.Exclamation, "Agenda")
                Exit Sub
            End If

            Dim sql As String = "insert into actividades (fecha_alta,Actividad,Solicita,Importancia) Values(Format(now(), 'dd/mm/yyyy'),'" & TextBox1.Text & "' , '" & TextBox2.Text & "' , " & CInt(ListBox1.Text) & ")"

            manejadorSQL.modificaBD(sql)
            manejadorTABLE.fillTable("select * from actividades where fecha_termino is null order by Importancia asc", Me.ActividadesDataGridView)

            ocultarCampos()

        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ocultarCampos()

    End Sub

    Sub ocultarCampos()
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        ListBox1.Text = Nothing
        Button2.Focus()
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        ListBox1.Visible = False
        Button3.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        Me.ActividadesDataGridView.Location = New System.Drawing.Point(8, 43)

    End Sub


    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        upperText(TextBox1)

    End Sub

    Sub upperText(ByVal texto As Object)
        texto.Text = UCase(texto.Text)
    End Sub


    Private Sub TextBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        upperText(TextBox2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim number As Integer
        Dim indexC As Object

        ' number = ActividadesDataGridView.CurrentRow.Cells(0).Value
        indexC = ActividadesDataGridView.CurrentRow.Cells(0).Value
        number = indexC.ToString
        Dim warning As String = MsgBox("Se va a eliminar el registro seleccionado, ¿Deseas continuar?", MsgBoxStyle.OkCancel, "Eliminar")

        If warning = vbOK Then
            Dim sql As String = "DELETE FROM actividades WHERE (Idact = " & number & " ) "
            ' Me.ActividadesTableAdapter.DeleteQuery(number)

            manejadorSQL.modificaBD(sql)
            manejadorTABLE.fillTable("select * from actividades where fecha_termino is null  order by Importancia asc", Me.ActividadesDataGridView)
        Else
        End If
        number = Nothing
        warning = Nothing
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Nueva_Act.Show()
    End Sub



    Private Sub ActividadesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ActividadesDataGridView.CellContentClick

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TimeCounter.Show()
    End Sub
End Class
