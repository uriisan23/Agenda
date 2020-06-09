<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeCounter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimeCounter))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextDate = New System.Windows.Forms.TextBox()
        Me.Textday = New System.Windows.Forms.TextBox()
        Me.TextPeriod = New System.Windows.Forms.TextBox()
        Me.TextCase = New System.Windows.Forms.TextBox()
        Me.TextDescript = New System.Windows.Forms.TextBox()
        Me.TextTime = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ActivityTxtView = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtRegistro = New System.Windows.Forms.Button()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.btGlobal = New System.Windows.Forms.Button()
        Me.btCase = New System.Windows.Forms.Button()
        Me.btnResumen = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.horasDataGrid = New System.Windows.Forms.DataGridView()
        Me.RegistrosViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgendaBDDataSet = New Agenda.agendaBDDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RegistrosViewTableAdapter = New Agenda.agendaBDDataSetTableAdapters.RegistrosViewTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextType = New System.Windows.Forms.ComboBox()
        Me.TipoHrsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoHrsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgendaBDDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoHrsTableAdapter = New Agenda.agendaBDDataSetTableAdapters.TipoHrsTableAdapter()
        Me.btCleanner = New System.Windows.Forms.Button()
        Me.ImgTimer = New System.Windows.Forms.PictureBox()
        Me.TextSec = New System.Windows.Forms.TextBox()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CasoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinutosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdregistroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistradoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrosViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoHrsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoHrsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaBDDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(988, 229)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Eliminar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextDate
        '
        Me.TextDate.Location = New System.Drawing.Point(16, 548)
        Me.TextDate.Margin = New System.Windows.Forms.Padding(4)
        Me.TextDate.Name = "TextDate"
        Me.TextDate.Size = New System.Drawing.Size(100, 20)
        Me.TextDate.TabIndex = 3
        '
        'Textday
        '
        Me.Textday.Location = New System.Drawing.Point(132, 548)
        Me.Textday.Margin = New System.Windows.Forms.Padding(4)
        Me.Textday.Name = "Textday"
        Me.Textday.Size = New System.Drawing.Size(134, 20)
        Me.Textday.TabIndex = 4
        '
        'TextPeriod
        '
        Me.TextPeriod.Location = New System.Drawing.Point(284, 548)
        Me.TextPeriod.Margin = New System.Windows.Forms.Padding(4)
        Me.TextPeriod.Name = "TextPeriod"
        Me.TextPeriod.Size = New System.Drawing.Size(132, 20)
        Me.TextPeriod.TabIndex = 5
        '
        'TextCase
        '
        Me.TextCase.Location = New System.Drawing.Point(436, 548)
        Me.TextCase.Margin = New System.Windows.Forms.Padding(4)
        Me.TextCase.Name = "TextCase"
        Me.TextCase.Size = New System.Drawing.Size(132, 20)
        Me.TextCase.TabIndex = 6
        '
        'TextDescript
        '
        Me.TextDescript.Location = New System.Drawing.Point(16, 613)
        Me.TextDescript.Margin = New System.Windows.Forms.Padding(4)
        Me.TextDescript.Multiline = True
        Me.TextDescript.Name = "TextDescript"
        Me.TextDescript.Size = New System.Drawing.Size(780, 49)
        Me.TextDescript.TabIndex = 7
        '
        'TextTime
        '
        Me.TextTime.Location = New System.Drawing.Point(932, 613)
        Me.TextTime.Margin = New System.Windows.Forms.Padding(4)
        Me.TextTime.Name = "TextTime"
        Me.TextTime.Size = New System.Drawing.Size(64, 20)
        Me.TextTime.TabIndex = 1
        Me.TextTime.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ActivityTxtView)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.BtRegistro)
        Me.GroupBox1.Controls.Add(Me.btRefresh)
        Me.GroupBox1.Controls.Add(Me.btGlobal)
        Me.GroupBox1.Controls.Add(Me.btCase)
        Me.GroupBox1.Controls.Add(Me.btnResumen)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.horasDataGrid)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(16, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1206, 466)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'ActivityTxtView
        '
        Me.ActivityTxtView.Location = New System.Drawing.Point(20, 20)
        Me.ActivityTxtView.Name = "ActivityTxtView"
        Me.ActivityTxtView.Size = New System.Drawing.Size(960, 20)
        Me.ActivityTxtView.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'BtRegistro
        '
        Me.BtRegistro.FlatAppearance.BorderSize = 0
        Me.BtRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtRegistro.Location = New System.Drawing.Point(252, 422)
        Me.BtRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.BtRegistro.Name = "BtRegistro"
        Me.BtRegistro.Size = New System.Drawing.Size(208, 39)
        Me.BtRegistro.TabIndex = 17
        Me.BtRegistro.Text = "Registrar Actividad"
        Me.BtRegistro.UseVisualStyleBackColor = True
        '
        'btRefresh
        '
        Me.btRefresh.FlatAppearance.BorderSize = 0
        Me.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btRefresh.Location = New System.Drawing.Point(988, 158)
        Me.btRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(188, 26)
        Me.btRefresh.TabIndex = 16
        Me.btRefresh.Text = "Registros"
        Me.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'btGlobal
        '
        Me.btGlobal.FlatAppearance.BorderSize = 0
        Me.btGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGlobal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btGlobal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btGlobal.Location = New System.Drawing.Point(988, 126)
        Me.btGlobal.Margin = New System.Windows.Forms.Padding(4)
        Me.btGlobal.Name = "btGlobal"
        Me.btGlobal.Size = New System.Drawing.Size(188, 26)
        Me.btGlobal.TabIndex = 15
        Me.btGlobal.Text = "Ver todos los Registros"
        Me.btGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btGlobal.UseVisualStyleBackColor = True
        '
        'btCase
        '
        Me.btCase.FlatAppearance.BorderSize = 0
        Me.btCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btCase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btCase.Location = New System.Drawing.Point(988, 94)
        Me.btCase.Margin = New System.Windows.Forms.Padding(4)
        Me.btCase.Name = "btCase"
        Me.btCase.Size = New System.Drawing.Size(188, 26)
        Me.btCase.TabIndex = 14
        Me.btCase.Text = "Ver por Casos"
        Me.btCase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCase.UseVisualStyleBackColor = True
        '
        'btnResumen
        '
        Me.btnResumen.FlatAppearance.BorderSize = 0
        Me.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnResumen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnResumen.Location = New System.Drawing.Point(988, 63)
        Me.btnResumen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResumen.Name = "btnResumen"
        Me.btnResumen.Size = New System.Drawing.Size(188, 26)
        Me.btnResumen.TabIndex = 13
        Me.btnResumen.Text = "Ver Horas por Registrar"
        Me.btnResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResumen.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(20, 431)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(208, 22)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Seleccionar Actividad"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'horasDataGrid
        '
        Me.horasDataGrid.AllowUserToAddRows = False
        Me.horasDataGrid.AllowUserToDeleteRows = False
        Me.horasDataGrid.AutoGenerateColumns = False
        Me.horasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.horasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.DiaDataGridViewTextBoxColumn, Me.PeriodoDataGridViewTextBoxColumn, Me.CasoDataGridViewTextBoxColumn, Me.ActividadDataGridViewTextBoxColumn, Me.MinutosDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.IdregistroDataGridViewTextBoxColumn, Me.RegistradoDataGridViewTextBoxColumn})
        Me.horasDataGrid.DataSource = Me.RegistrosViewBindingSource
        Me.horasDataGrid.Location = New System.Drawing.Point(20, 62)
        Me.horasDataGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.horasDataGrid.Name = "horasDataGrid"
        Me.horasDataGrid.ReadOnly = True
        Me.horasDataGrid.Size = New System.Drawing.Size(960, 354)
        Me.horasDataGrid.TabIndex = 0
        '
        'RegistrosViewBindingSource
        '
        Me.RegistrosViewBindingSource.DataMember = "RegistrosView"
        Me.RegistrosViewBindingSource.DataSource = Me.AgendaBDDataSet
        '
        'AgendaBDDataSet
        '
        Me.AgendaBDDataSet.DataSetName = "agendaBDDataSet"
        Me.AgendaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1020, 604)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 39)
        Me.Button2.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.Button2, "Inicia/Detiene el contador")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(844, 661)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 24)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "+ Agregar Nueva"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RegistrosViewTableAdapter
        '
        Me.RegistrosViewTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(16, 531)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(176, 531)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Dia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(328, 531)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Periodo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(480, 529)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Caso"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(254, 594)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Actividad"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(814, 594)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tipo de Actividad"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(938, 594)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Tiempo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(1078, 604)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(48, 39)
        Me.Button5.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.Button5, "Detiene el contador y actualiza el tiempo en el registro")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextType
        '
        Me.TextType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TipoHrsBindingSource, "Idtype", True))
        Me.TextType.DataSource = Me.TipoHrsBindingSource1
        Me.TextType.DisplayMember = "Tipo"
        Me.TextType.FormattingEnabled = True
        Me.TextType.Location = New System.Drawing.Point(812, 613)
        Me.TextType.Margin = New System.Windows.Forms.Padding(4)
        Me.TextType.Name = "TextType"
        Me.TextType.Size = New System.Drawing.Size(100, 21)
        Me.TextType.TabIndex = 20
        Me.TextType.ValueMember = "Idtype"
        '
        'TipoHrsBindingSource
        '
        Me.TipoHrsBindingSource.DataMember = "TipoHrs"
        Me.TipoHrsBindingSource.DataSource = Me.AgendaBDDataSet
        '
        'TipoHrsBindingSource1
        '
        Me.TipoHrsBindingSource1.DataMember = "TipoHrs"
        Me.TipoHrsBindingSource1.DataSource = Me.AgendaBDDataSetBindingSource
        '
        'AgendaBDDataSetBindingSource
        '
        Me.AgendaBDDataSetBindingSource.DataSource = Me.AgendaBDDataSet
        Me.AgendaBDDataSetBindingSource.Position = 0
        '
        'TipoHrsTableAdapter
        '
        Me.TipoHrsTableAdapter.ClearBeforeFill = True
        '
        'btCleanner
        '
        Me.btCleanner.FlatAppearance.BorderSize = 0
        Me.btCleanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCleanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCleanner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btCleanner.Location = New System.Drawing.Point(1004, 661)
        Me.btCleanner.Margin = New System.Windows.Forms.Padding(4)
        Me.btCleanner.Name = "btCleanner"
        Me.btCleanner.Size = New System.Drawing.Size(118, 24)
        Me.btCleanner.TabIndex = 21
        Me.btCleanner.Text = "- Limpiar Campos"
        Me.btCleanner.UseVisualStyleBackColor = True
        '
        'ImgTimer
        '
        Me.ImgTimer.Image = CType(resources.GetObject("ImgTimer.Image"), System.Drawing.Image)
        Me.ImgTimer.Location = New System.Drawing.Point(1132, 604)
        Me.ImgTimer.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgTimer.Name = "ImgTimer"
        Me.ImgTimer.Size = New System.Drawing.Size(48, 37)
        Me.ImgTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ImgTimer.TabIndex = 22
        Me.ImgTimer.TabStop = False
        Me.ImgTimer.Visible = False
        '
        'TextSec
        '
        Me.TextSec.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TextSec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.TextSec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TextSec.Location = New System.Drawing.Point(1169, 606)
        Me.TextSec.Margin = New System.Windows.Forms.Padding(4)
        Me.TextSec.Name = "TextSec"
        Me.TextSec.Size = New System.Drawing.Size(19, 11)
        Me.TextSec.TabIndex = 23
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 75
        '
        'DiaDataGridViewTextBoxColumn
        '
        Me.DiaDataGridViewTextBoxColumn.DataPropertyName = "Dia"
        Me.DiaDataGridViewTextBoxColumn.HeaderText = "Dia"
        Me.DiaDataGridViewTextBoxColumn.Name = "DiaDataGridViewTextBoxColumn"
        Me.DiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiaDataGridViewTextBoxColumn.Width = 70
        '
        'PeriodoDataGridViewTextBoxColumn
        '
        Me.PeriodoDataGridViewTextBoxColumn.DataPropertyName = "Periodo"
        Me.PeriodoDataGridViewTextBoxColumn.HeaderText = "Periodo"
        Me.PeriodoDataGridViewTextBoxColumn.Name = "PeriodoDataGridViewTextBoxColumn"
        Me.PeriodoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CasoDataGridViewTextBoxColumn
        '
        Me.CasoDataGridViewTextBoxColumn.DataPropertyName = "Caso"
        Me.CasoDataGridViewTextBoxColumn.HeaderText = "Caso"
        Me.CasoDataGridViewTextBoxColumn.Name = "CasoDataGridViewTextBoxColumn"
        Me.CasoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CasoDataGridViewTextBoxColumn.Width = 120
        '
        'ActividadDataGridViewTextBoxColumn
        '
        Me.ActividadDataGridViewTextBoxColumn.DataPropertyName = "Actividad"
        Me.ActividadDataGridViewTextBoxColumn.HeaderText = "Actividad"
        Me.ActividadDataGridViewTextBoxColumn.Name = "ActividadDataGridViewTextBoxColumn"
        Me.ActividadDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActividadDataGridViewTextBoxColumn.Width = 300
        '
        'MinutosDataGridViewTextBoxColumn
        '
        Me.MinutosDataGridViewTextBoxColumn.DataPropertyName = "Minutos"
        Me.MinutosDataGridViewTextBoxColumn.HeaderText = "Minutos"
        Me.MinutosDataGridViewTextBoxColumn.Name = "MinutosDataGridViewTextBoxColumn"
        Me.MinutosDataGridViewTextBoxColumn.ReadOnly = True
        Me.MinutosDataGridViewTextBoxColumn.Width = 50
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdregistroDataGridViewTextBoxColumn
        '
        Me.IdregistroDataGridViewTextBoxColumn.DataPropertyName = "Idregistro"
        Me.IdregistroDataGridViewTextBoxColumn.HeaderText = "Idregistro"
        Me.IdregistroDataGridViewTextBoxColumn.Name = "IdregistroDataGridViewTextBoxColumn"
        Me.IdregistroDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdregistroDataGridViewTextBoxColumn.Visible = False
        '
        'RegistradoDataGridViewTextBoxColumn
        '
        Me.RegistradoDataGridViewTextBoxColumn.DataPropertyName = "Registrado"
        Me.RegistradoDataGridViewTextBoxColumn.HeaderText = "Registrado"
        Me.RegistradoDataGridViewTextBoxColumn.Name = "RegistradoDataGridViewTextBoxColumn"
        Me.RegistradoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1256, 748)
        Me.Controls.Add(Me.TextSec)
        Me.Controls.Add(Me.ImgTimer)
        Me.Controls.Add(Me.btCleanner)
        Me.Controls.Add(Me.TextType)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextDescript)
        Me.Controls.Add(Me.TextCase)
        Me.Controls.Add(Me.TextPeriod)
        Me.Controls.Add(Me.Textday)
        Me.Controls.Add(Me.TextDate)
        Me.Controls.Add(Me.TextTime)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TimeCounter"
        Me.Text = "Registro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrosViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoHrsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoHrsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaBDDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextDate As System.Windows.Forms.TextBox
    Friend WithEvents Textday As System.Windows.Forms.TextBox
    Friend WithEvents TextPeriod As System.Windows.Forms.TextBox
    Friend WithEvents TextCase As System.Windows.Forms.TextBox
    Friend WithEvents TextDescript As System.Windows.Forms.TextBox
    Friend WithEvents TextTime As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents horasDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AgendaBDDataSet As Agenda.agendaBDDataSet
    Friend WithEvents RegistrosViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrosViewTableAdapter As Agenda.agendaBDDataSetTableAdapters.RegistrosViewTableAdapter
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextType As System.Windows.Forms.ComboBox
    Friend WithEvents AgendaBDDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoHrsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoHrsTableAdapter As Agenda.agendaBDDataSetTableAdapters.TipoHrsTableAdapter
    Friend WithEvents TipoHrsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents btGlobal As System.Windows.Forms.Button
    Friend WithEvents btCase As System.Windows.Forms.Button
    Friend WithEvents btnResumen As System.Windows.Forms.Button
    Friend WithEvents BtRegistro As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btCleanner As System.Windows.Forms.Button
    Friend WithEvents ImgTimer As System.Windows.Forms.PictureBox
    Friend WithEvents TextSec As System.Windows.Forms.TextBox
    Friend WithEvents ActivityTxtView As System.Windows.Forms.TextBox
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CasoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActividadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinutosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdregistroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistradoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
