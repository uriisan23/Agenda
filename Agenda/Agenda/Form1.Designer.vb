<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ActividadesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Idact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportanciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolicitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaterminoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgendaBDDataSet = New Agenda.agendaBDDataSet()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.TextBox()
        Me.ActividadesTableAdapter = New Agenda.agendaBDDataSetTableAdapters.actividadesTableAdapter()
        Me.TableAdapterManager = New Agenda.agendaBDDataSetTableAdapters.TableAdapterManager()
        CType(Me.ActividadesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActividadesDataGridView
        '
        Me.ActividadesDataGridView.AllowUserToAddRows = False
        Me.ActividadesDataGridView.AutoGenerateColumns = False
        Me.ActividadesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ActividadesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ActividadesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.ActividadesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ActividadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActividadesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idact, Me.FechaaltaDataGridViewTextBoxColumn, Me.ActividadDataGridViewTextBoxColumn, Me.ImportanciaDataGridViewTextBoxColumn, Me.SolicitaDataGridViewTextBoxColumn, Me.FechainicioDataGridViewTextBoxColumn, Me.FechaterminoDataGridViewTextBoxColumn, Me.completado})
        Me.ActividadesDataGridView.DataSource = Me.ActividadesBindingSource
        Me.ActividadesDataGridView.GridColor = System.Drawing.Color.LightSlateGray
        Me.ActividadesDataGridView.Location = New System.Drawing.Point(8, 40)
        Me.ActividadesDataGridView.Name = "ActividadesDataGridView"
        Me.ActividadesDataGridView.Size = New System.Drawing.Size(831, 472)
        Me.ActividadesDataGridView.TabIndex = 1
        '
        'Idact
        '
        Me.Idact.DataPropertyName = "Idact"
        Me.Idact.HeaderText = "Idact"
        Me.Idact.Name = "Idact"
        Me.Idact.Visible = False
        Me.Idact.Width = 5
        '
        'FechaaltaDataGridViewTextBoxColumn
        '
        Me.FechaaltaDataGridViewTextBoxColumn.DataPropertyName = "fecha_alta"
        Me.FechaaltaDataGridViewTextBoxColumn.HeaderText = "fecha_alta"
        Me.FechaaltaDataGridViewTextBoxColumn.Name = "FechaaltaDataGridViewTextBoxColumn"
        '
        'ActividadDataGridViewTextBoxColumn
        '
        Me.ActividadDataGridViewTextBoxColumn.DataPropertyName = "Actividad"
        Me.ActividadDataGridViewTextBoxColumn.HeaderText = "Actividad"
        Me.ActividadDataGridViewTextBoxColumn.Name = "ActividadDataGridViewTextBoxColumn"
        Me.ActividadDataGridViewTextBoxColumn.Width = 350
        '
        'ImportanciaDataGridViewTextBoxColumn
        '
        Me.ImportanciaDataGridViewTextBoxColumn.DataPropertyName = "Importancia"
        Me.ImportanciaDataGridViewTextBoxColumn.HeaderText = "Importancia"
        Me.ImportanciaDataGridViewTextBoxColumn.Name = "ImportanciaDataGridViewTextBoxColumn"
        Me.ImportanciaDataGridViewTextBoxColumn.Width = 80
        '
        'SolicitaDataGridViewTextBoxColumn
        '
        Me.SolicitaDataGridViewTextBoxColumn.DataPropertyName = "Solicita"
        Me.SolicitaDataGridViewTextBoxColumn.HeaderText = "Solicita"
        Me.SolicitaDataGridViewTextBoxColumn.Name = "SolicitaDataGridViewTextBoxColumn"
        '
        'FechainicioDataGridViewTextBoxColumn
        '
        Me.FechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio"
        Me.FechainicioDataGridViewTextBoxColumn.HeaderText = "fecha_inicio"
        Me.FechainicioDataGridViewTextBoxColumn.Name = "FechainicioDataGridViewTextBoxColumn"
        Me.FechainicioDataGridViewTextBoxColumn.Width = 80
        '
        'FechaterminoDataGridViewTextBoxColumn
        '
        Me.FechaterminoDataGridViewTextBoxColumn.DataPropertyName = "fecha_termino"
        Me.FechaterminoDataGridViewTextBoxColumn.HeaderText = "fecha_termino"
        Me.FechaterminoDataGridViewTextBoxColumn.Name = "FechaterminoDataGridViewTextBoxColumn"
        Me.FechaterminoDataGridViewTextBoxColumn.Width = 80
        '
        'completado
        '
        Me.completado.DataPropertyName = "completado"
        Me.completado.HeaderText = "completado"
        Me.completado.Name = "completado"
        Me.completado.Visible = False
        '
        'ActividadesBindingSource
        '
        Me.ActividadesBindingSource.DataMember = "actividades"
        Me.ActividadesBindingSource.DataSource = Me.AgendaBDDataSet
        '
        'AgendaBDDataSet
        '
        Me.AgendaBDDataSet.DataSetName = "agendaBDDataSet"
        Me.AgendaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(788, 9)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(78, 20)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Terminar"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(630, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Iniciar actividad"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(71, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Nueva"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(630, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(115, 20)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(21, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(583, 20)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(310, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Insertar"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(399, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Cancelar"
        Me.Button6.UseVisualStyleBackColor = False
        Me.Button6.Visible = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(819, 527)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 30)
        Me.Button3.TabIndex = 14
        Me.ToolTip2.SetToolTip(Me.Button3, "Salir")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(161, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(770, 523)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(31, 39)
        Me.Button7.TabIndex = 17
        Me.ToolTip2.SetToolTip(Me.Button7, "Historial")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(721, 524)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(33, 37)
        Me.Button8.TabIndex = 19
        Me.ToolTip2.SetToolTip(Me.Button8, "Registrar Horas")
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(770, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(46, 20)
        Me.ListBox1.TabIndex = 18
        Me.ListBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ListBox1.Visible = False
        '
        'ActividadesTableAdapter
        '
        Me.ActividadesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Me.ActividadesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DiasTableAdapter = Nothing
        Me.TableAdapterManager.PrioridadesTableAdapter = Nothing
        Me.TableAdapterManager.RegistroHrsTableAdapter = Nothing
        Me.TableAdapterManager.TipoHrsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Agenda.agendaBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(877, 745)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ActividadesDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        CType(Me.ActividadesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AgendaBDDataSet As Agenda.agendaBDDataSet
    Friend WithEvents ActividadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActividadesTableAdapter As Agenda.agendaBDDataSetTableAdapters.actividadesTableAdapter
    Friend WithEvents TableAdapterManager As Agenda.agendaBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActividadesDataGridView As System.Windows.Forms.DataGridView

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ListBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Idact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaaltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActividadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImportanciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SolicitaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaterminoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button8 As System.Windows.Forms.Button

End Class
