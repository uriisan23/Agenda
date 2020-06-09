
Imports Agenda.ManageBD
Public Class TimeCounter

    Public manejadorSQL As New ManageBD
    Public manejadorTABLE As New ManageBD
    Public varSql As String
    Public bufferReg As Integer
    Public TimeInicio As Integer


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim TotalTime As Integer

        TimeInicio = TimeInicio + 1
        TextSec.Text = CStr(TimeInicio)
        If TimeInicio = 60 Then
            TotalTime = CInt(TextTime.Text) + 1
            TextTime.Text = CStr(TotalTime)
            TimeInicio = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '   If (Timer1.Enabled = True) Then
        '  Timer1.Stop()
        '  Else
        '  Timer1.Start()
        ' End If
        Dim a As String = MsgBox("Esta a punto de borrar un registro de forma permanente" & vbCrLf & "                  Desea Continuar?", MsgBoxStyle.YesNo)
        If a = vbYes Then
            DelLine()
            RefreshView()
        Else

        End If


    End Sub

    Private Sub TimeCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgendaBDDataSet.TipoHrs' Puede moverla o quitarla según sea necesario.
        Me.TipoHrsTableAdapter.Fill(Me.AgendaBDDataSet.TipoHrs)
        'TODO: esta línea de código carga datos en la tabla 'AgendaBDDataSet.RegistrosView' Puede moverla o quitarla según sea necesario.
        'Me.RegistrosViewTableAdapter.Fill(Me.AgendaBDDataSet.RegistrosView)
        Timer1.Stop()
        ' manejadorTABLE.fillTable("select * from RegistroHrs where Registrado = 0 ", Me.horasDataGrid)

        Me.RegistrosViewTableAdapter.FillByReg(Me.AgendaBDDataSet.RegistrosView)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'boton de play/pause
        If Me.TextDescript.Text = "" Or Me.TextCase.Text = "" Then
            MsgBox("Debe ingresar una descripcion y un numero de Caso para Generar Tiempo de una actividad")
            Exit Sub
        End If

        If (Timer1.Enabled = True) Then
            Timer1.Stop()
            ImgTimer.Visible = False
            TextSec.Visible = False
        Else
            Timer1.Start()
            ImgTimer.Visible = True
            TextSec.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'boton de stop
        If Me.TextDescript.Text = "" Or Me.TextCase.Text = "" Then
            MsgBox("Debe ingresar una descripcion y un numero de Caso para Detener el registro de una actividad")
            Exit Sub
        End If

        If Me.Textday.Text = "" Or Me.TextDate.Text = "" Then
            MsgBox("Actividad no registrada, seleccione la opcion de + Agregar Nueva para guardar")
            Timer1.Stop()
            If ImgTimer.Visible = True Then ImgTimer.Visible = False
            If TextSec.Visible = True Then
                TextSec.Text = Nothing
                TextSec.Visible = False
                TimeInicio = 0
            End If

            Exit Sub
        End If

        Timer1.Stop()

        If ImgTimer.Visible = True Then ImgTimer.Visible = False
        If TextSec.Visible = True Then
            TextSec.Text = Nothing
            TextSec.Visible = False
            TimeInicio = 0
        End If

        manejadorSQL.modificaBD(addTime())
        MsgBox("El tiempo de la actividad fue de " + TextTime.Text + " Minutos.", MsgBoxStyle.OkOnly, "Agenda")
        RefreshView()
        cleaner()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.TextDescript.Text = "" Or Me.TextCase.Text = "" Then
            MsgBox("Debe ingresar una descripcion y un numero de Caso para el Registro de una actividad")
            Exit Sub
        End If


        If Me.TextDate.Text <> "" Then
            Dim a As String = MsgBox("                          Ya existe un caso " & Me.TextCase.Text & vbCrLf & vbCrLf & "Se agregara un nuevo registro del caso con nueva fecha." & vbCrLf & "                               Desea Continuar?", MsgBoxStyle.YesNo)
            If a = vbYes Then

                manejadorSQL.modificaBD(newCase())
                RefreshView()
                MsgBox("Se registro con exito el Caso: " & Me.TextCase.Text, MsgBoxStyle.Information)
                cleaner()
                Timer1.Stop()


            Else

            End If
        Else
            manejadorSQL.modificaBD(newCase())
            RefreshView()
            MsgBox("Se registro con exito el Caso: " & Me.TextCase.Text, MsgBoxStyle.Information)
            cleaner()
            Timer1.Stop()
        End If

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'boton "Seleccionar actividad"
        Dim sel As String
        If Me.TextCase.Text <> "" Then
            sel = MsgBox("Hay una actividad en curso, ¿Desea descartar actividad? ", MsgBoxStyle.YesNo, "Agenda")
            If sel = vbYes Then
                getCase()
            Else
            End If
        Else
            getCase()
        End If

    End Sub


    Private Sub btnResumen_Click(sender As Object, e As EventArgs) Handles btnResumen.Click
        Me.RegistrosViewTableAdapter.FillByDay(Me.AgendaBDDataSet.RegistrosView)
    End Sub

    Private Sub btCase_Click(sender As Object, e As EventArgs) Handles btCase.Click
        Me.RegistrosViewTableAdapter.FillByCase(Me.AgendaBDDataSet.RegistrosView)
    End Sub

    Private Sub btGlobal_Click(sender As Object, e As EventArgs) Handles btGlobal.Click
        Me.RegistrosViewTableAdapter.Fill(Me.AgendaBDDataSet.RegistrosView)
    End Sub

    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        Me.RegistrosViewTableAdapter.FillByReg(Me.AgendaBDDataSet.RegistrosView)
    End Sub

    Private Sub BtRegistro_Click(sender As Object, e As EventArgs) Handles BtRegistro.Click
        Dim qst As String

        qst = MsgBox("La actividad quedara marcada como YA REGISTRADA y no podra modificarse esta accion", MsgBoxStyle.YesNo, "Agenda")

        If qst = vbYes Then
            markLine()
            RefreshView()
        Else
            MsgBox("La accion fue cancelada", MsgBoxStyle.Information, "Agenda")
        End If

    End Sub

    Private Sub btCleanner_Click(sender As Object, e As EventArgs) Handles btCleanner.Click
        Dim qst As String

        If bufferReg <> 0 Then
            qst = MsgBox("Hay una actividad selecionada previamente, si desea que los cambios no se guarden oprima ACEPTAR u oprima CANCELAR y despues el boton de Stop para guardar los cambios", MsgBoxStyle.OkCancel, "Agenda")
            If qst = vbOK Then
                cleaner()
            Else

            End If
        Else
            qst = MsgBox("La actividad no esta registrada si desea que los cambios no se guarden oprima ACEPTAR u oprima CANCELAR  Cancelar y despues el boton de Agregar para guardar los cambios", MsgBoxStyle.OkCancel, "Agenda")
            If qst = vbOK Then
                cleaner()
            Else

            End If
        End If

    End Sub


    '_______________________________________________
    '_______________________________________________
    '_____SECCION DE SUB Y FUNCIONES________________
    '_______________________________________________
    '_______________________________________________
    '__ todas las funciones o metodos aqui__________
    '_______________________________________________

    Private Function newCase()
        Dim getDay As Integer = numberDay()
        Dim codKey As String

        codKey = Format(DateValue(Now()), "dd/MM/yyyy") & CStr(getDay) & TextCase.Text & "-" & CStr(TextType.SelectedValue)

        varSql = "insert into RegistroHrs (Fecha,Dia,Caso,Actividad,Minutos,Tipo,Codigo) Values (Format(now(), 'dd/mm/yyyy')," & getDay & ",'" & TextCase.Text & "','" & TextDescript.Text & "'," & TextTime.Text & "," & TextType.SelectedValue & ",'" & codKey & "')"
        Me.TextDate.Text = Format(DateValue(Now()), "dd/MM/yyyy")

        Return varSql
    End Function

    Private Function addTime()
        Dim getDay As Integer = numberDay()
        Dim codKey As String

        codKey = TextDate.Text & returnDay(Textday.Text) & TextCase.Text & "-" & CStr(TextType.SelectedValue)
        varSql = "update RegistroHrs set Minutos = " & CInt(TextTime.Text) & " where Codigo = '" & codKey & "'"

        Return varSql
    End Function
    Private Sub getCase()

        If horasDataGrid.CurrentRow.Cells(0).Value <> DateValue(Now) Then
            MsgBox("Se debe crear otra actividad con el mismo caso, al finalizar seleccionar opcion:  < + Agregar Nueva > ", MsgBoxStyle.Exclamation, "Agenda")
            bufferReg = CStr(horasDataGrid.CurrentRow.Cells(7).Value)
            Me.TextCase.Text = CStr(horasDataGrid.CurrentRow.Cells(3).Value)
            Me.TextDescript.Text = CStr(horasDataGrid.CurrentRow.Cells(4).Value)
            Me.TextTime.Text = 0
            Me.TextType.Text = horasDataGrid.CurrentRow.Cells(6).Value

        Else
            bufferReg = CStr(horasDataGrid.CurrentRow.Cells(7).Value)
            Me.TextDate.Text = CStr(horasDataGrid.CurrentRow.Cells(0).Value)
            Me.Textday.Text = CStr(horasDataGrid.CurrentRow.Cells(1).Value)
            Me.TextCase.Text = CStr(horasDataGrid.CurrentRow.Cells(3).Value)
            Me.TextDescript.Text = CStr(horasDataGrid.CurrentRow.Cells(4).Value)
            Me.TextTime.Text = CStr(horasDataGrid.CurrentRow.Cells(5).Value)
            Me.TextType.Text = horasDataGrid.CurrentRow.Cells(6).Value
        End If
    End Sub

    Private Sub RefreshView()
        'Funcion que se invoca para refrescar datos de grid
        Me.RegistrosViewTableAdapter.FillByReg(Me.AgendaBDDataSet.RegistrosView)
    End Sub

    Public Function numberDay()
        'Funcion que devuelve el numero de dia, inicia lunes = 1 
        Dim day As Integer
        day = Weekday(Now, FirstDayOfWeek.Monday)

        Return day
    End Function

    Private Function returnDay(ByVal a As String)
        Dim IntDay As Integer

        Select Case a
            Case Is = "LUNES"
                IntDay = 1
            Case Else
                Select Case a
                    Case Is = "MARTES"
                        IntDay = 2
                    Case Else
                        Select Case a
                            Case Is = "MIERCOLES"
                                IntDay = 3
                            Case Else
                                Select Case a
                                    Case Is = "JUEVES"
                                        IntDay = 4
                                    Case Else
                                        Select Case a
                                            Case Is = "VIERNES"
                                                IntDay = 5
                                            Case Else
                                                Select Case a
                                                    Case Is = "SABADO"
                                                        IntDay = 6
                                                    Case Else
                                                        Select Case a
                                                            Case Is = "DOMINGO"
                                                                IntDay = 7
                                                        End Select
                                                End Select
                                        End Select
                                End Select
                        End Select
                End Select
        End Select

        Return IntDay
    End Function

    Sub cleaner()
        bufferReg = Nothing
        Me.TextDate.Text = Nothing
        Me.Textday.Text = Nothing
        Me.TextCase.Text = Nothing
        Me.TextDescript.Text = Nothing
        Me.TextTime.Text = 0
        Me.TextType.Text = Nothing
        Me.TextSec.Text = 0
    End Sub

    Private Sub markLine()
        Try
            Dim numberline As Integer

            numberline = horasDataGrid.CurrentRow.Cells(7).Value
            manejadorSQL.modificaBD("update RegistroHrs set Registrado =" & 1 & " where Idregistro = " & numberline)
        Catch e As Exception

        End Try
    End Sub

    Private Sub DelLine()
        Try
            Dim numberline As Integer

            numberline = horasDataGrid.CurrentRow.Cells(7).Value
            manejadorSQL.modificaBD("delete * from RegistroHrs where Idregistro = " & numberline)
        Catch e As Exception

        End Try
    End Sub

    Private Sub TextCase_Leave(sender As Object, e As EventArgs) Handles TextCase.Leave

        TextCase.Text = UCase(TextCase.Text)
    End Sub

    Private Sub horasDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles horasDataGrid.CellContentClick


        ActivityTxtView.Text = horasDataGrid.CurrentRow.Cells(4).Value
    End Sub

   
    Private Sub TimeCounter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If TextCase.Text <> "" Then
            Dim a As String = MsgBox("Se perdera la informacion no guardada" & vbCrLf & "                  Desea Continuar?", MsgBoxStyle.YesNo)
            If a = vbYes Then

            Else
                e.Cancel = True
            End If
        Else
        End If

    End Sub
End Class