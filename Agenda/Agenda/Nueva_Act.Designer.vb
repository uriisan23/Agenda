<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_Act
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nueva_Act))
        Me.AgendaBDDataSet1 = New Agenda.agendaBDDataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActividadesTableAdapter1 = New Agenda.agendaBDDataSetTableAdapters.actividadesTableAdapter()
        Me.TableAdapterManager1 = New Agenda.agendaBDDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.FechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolicitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompletadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaterminoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AgendaBDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AgendaBDDataSet1
        '
        Me.AgendaBDDataSet1.DataSetName = "agendaBDDataSet"
        Me.AgendaBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.AgendaBDDataSet1
        Me.BindingSource1.Position = 0
        '
        'ActividadesTableAdapter1
        '
        Me.ActividadesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.actividadesTableAdapter = Me.ActividadesTableAdapter1
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = Agenda.agendaBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaaltaDataGridViewTextBoxColumn, Me.ActividadDataGridViewTextBoxColumn, Me.SolicitaDataGridViewTextBoxColumn, Me.FechainicioDataGridViewTextBoxColumn, Me.CompletadoDataGridViewTextBoxColumn, Me.FechaterminoDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ActividadesBindingSource
        Me.DataGridView2.GridColor = System.Drawing.Color.LightBlue
        Me.DataGridView2.Location = New System.Drawing.Point(9, 35)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(877, 421)
        Me.DataGridView2.TabIndex = 1
        '
        'FechaaltaDataGridViewTextBoxColumn
        '
        Me.FechaaltaDataGridViewTextBoxColumn.DataPropertyName = "fecha_alta"
        Me.FechaaltaDataGridViewTextBoxColumn.HeaderText = "Alta"
        Me.FechaaltaDataGridViewTextBoxColumn.Name = "FechaaltaDataGridViewTextBoxColumn"
        Me.FechaaltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaaltaDataGridViewTextBoxColumn.Width = 70
        '
        'ActividadDataGridViewTextBoxColumn
        '
        Me.ActividadDataGridViewTextBoxColumn.DataPropertyName = "Actividad"
        Me.ActividadDataGridViewTextBoxColumn.HeaderText = "Actividad"
        Me.ActividadDataGridViewTextBoxColumn.Name = "ActividadDataGridViewTextBoxColumn"
        Me.ActividadDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActividadDataGridViewTextBoxColumn.Width = 450
        '
        'SolicitaDataGridViewTextBoxColumn
        '
        Me.SolicitaDataGridViewTextBoxColumn.DataPropertyName = "Solicita"
        Me.SolicitaDataGridViewTextBoxColumn.HeaderText = "Solicita"
        Me.SolicitaDataGridViewTextBoxColumn.Name = "SolicitaDataGridViewTextBoxColumn"
        Me.SolicitaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechainicioDataGridViewTextBoxColumn
        '
        Me.FechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio"
        Me.FechainicioDataGridViewTextBoxColumn.HeaderText = "Inicia"
        Me.FechainicioDataGridViewTextBoxColumn.Name = "FechainicioDataGridViewTextBoxColumn"
        Me.FechainicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechainicioDataGridViewTextBoxColumn.Width = 70
        '
        'CompletadoDataGridViewTextBoxColumn
        '
        Me.CompletadoDataGridViewTextBoxColumn.DataPropertyName = "completado"
        Me.CompletadoDataGridViewTextBoxColumn.HeaderText = "Completado"
        Me.CompletadoDataGridViewTextBoxColumn.Name = "CompletadoDataGridViewTextBoxColumn"
        Me.CompletadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompletadoDataGridViewTextBoxColumn.Width = 70
        '
        'FechaterminoDataGridViewTextBoxColumn
        '
        Me.FechaterminoDataGridViewTextBoxColumn.DataPropertyName = "fecha_termino"
        Me.FechaterminoDataGridViewTextBoxColumn.HeaderText = "Termino"
        Me.FechaterminoDataGridViewTextBoxColumn.Name = "FechaterminoDataGridViewTextBoxColumn"
        Me.FechaterminoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaterminoDataGridViewTextBoxColumn.Width = 70
        '
        'ActividadesBindingSource
        '
        Me.ActividadesBindingSource.DataMember = "actividades"
        Me.ActividadesBindingSource.DataSource = Me.BindingSource1
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(853, 460)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 28)
        Me.Button3.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Button3, "Salir")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Nueva_Act
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(894, 503)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Nueva_Act"
        Me.Text = "Actividades Terminadas"
        CType(Me.AgendaBDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AgendaBDDataSet1 As Agenda.agendaBDDataSet
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ActividadesTableAdapter1 As Agenda.agendaBDDataSetTableAdapters.actividadesTableAdapter
    Friend WithEvents TableAdapterManager1 As Agenda.agendaBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ActividadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FechaaltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActividadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SolicitaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompletadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaterminoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
