<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TimeFormat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextMask = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TimeOut = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirPanelDeControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.action = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.timeInterval = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.timeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.timeStart = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T = New System.Windows.Forms.Timer(Me.components)
        Me.BarIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Title)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TimeFormat)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextMask)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TimeOut)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.action)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.timeInterval)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.timeEnd)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.timeStart)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 475)
        Me.Panel1.TabIndex = 0
        '
        'Title
        '
        Me.Title.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimeReminder.My.MySettings.Default, "NotifyTitle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Title.Location = New System.Drawing.Point(206, 148)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(225, 25)
        Me.Title.TabIndex = 19
        Me.Title.Text = Global.TimeReminder.My.MySettings.Default.NotifyTitle
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(206, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Titulo:"
        '
        'TimeFormat
        '
        Me.TimeFormat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimeReminder.My.MySettings.Default, "NotifyTimeMask", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TimeFormat.Location = New System.Drawing.Point(206, 288)
        Me.TimeFormat.Name = "TimeFormat"
        Me.TimeFormat.Size = New System.Drawing.Size(225, 25)
        Me.TimeFormat.TabIndex = 17
        Me.TimeFormat.Text = Global.TimeReminder.My.MySettings.Default.NotifyTimeMask
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(206, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Mascara de Tiempo:"
        '
        'TextMask
        '
        Me.TextMask.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimeReminder.My.MySettings.Default, "NotifyTextMask", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextMask.Location = New System.Drawing.Point(206, 218)
        Me.TextMask.Name = "TextMask"
        Me.TextMask.Size = New System.Drawing.Size(225, 25)
        Me.TextMask.TabIndex = 15
        Me.TextMask.Text = Global.TimeReminder.My.MySettings.Default.NotifyTextMask
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(206, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Texto:"
        '
        'TimeOut
        '
        Me.TimeOut.CustomFormat = ""
        Me.TimeOut.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.TimeReminder.My.MySettings.Default, "NotifyTimeout", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeOut.Location = New System.Drawing.Point(206, 358)
        Me.TimeOut.Name = "TimeOut"
        Me.TimeOut.ShowUpDown = True
        Me.TimeOut.Size = New System.Drawing.Size(225, 25)
        Me.TimeOut.TabIndex = 13
        Me.TimeOut.Value = Global.TimeReminder.My.MySettings.Default.NotifyTimeout
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(206, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tiempo:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlowLayoutPanel1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHide)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExit)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 408)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(454, 67)
        Me.FlowLayoutPanel1.TabIndex = 11
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirPanelDeControlToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(192, 54)
        '
        'AbrirPanelDeControlToolStripMenuItem
        '
        Me.AbrirPanelDeControlToolStripMenuItem.Image = CType(resources.GetObject("AbrirPanelDeControlToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirPanelDeControlToolStripMenuItem.Name = "AbrirPanelDeControlToolStripMenuItem"
        Me.AbrirPanelDeControlToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AbrirPanelDeControlToolStripMenuItem.Text = "&Abrir Panel de Control"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'btnHide
        '
        Me.btnHide.AutoSize = True
        Me.btnHide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnHide.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Location = New System.Drawing.Point(271, 10)
        Me.btnHide.Margin = New System.Windows.Forms.Padding(10)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Padding = New System.Windows.Forms.Padding(10)
        Me.btnHide.Size = New System.Drawing.Size(173, 47)
        Me.btnHide.TabIndex = 1
        Me.btnHide.Text = "OCULTAR Y ENCENDER"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(181, 10)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(10)
        Me.btnExit.Size = New System.Drawing.Size(70, 47)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "SALIR"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'action
        '
        Me.action.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimeReminder.My.MySettings.Default, "Accion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.action.FormattingEnabled = True
        Me.action.Items.AddRange(New Object() {"Beep (Sonido)", "Notificación", "Not. en Cursor"})
        Me.action.Location = New System.Drawing.Point(18, 358)
        Me.action.Name = "action"
        Me.action.Size = New System.Drawing.Size(153, 25)
        Me.action.TabIndex = 10
        Me.action.Text = Global.TimeReminder.My.MySettings.Default.Accion
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Acción:"
        '
        'timeInterval
        '
        Me.timeInterval.CustomFormat = ""
        Me.timeInterval.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.TimeReminder.My.MySettings.Default, "TimeInterval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.timeInterval.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeInterval.Location = New System.Drawing.Point(18, 288)
        Me.timeInterval.Name = "timeInterval"
        Me.timeInterval.ShowUpDown = True
        Me.timeInterval.Size = New System.Drawing.Size(153, 25)
        Me.timeInterval.TabIndex = 8
        Me.timeInterval.Value = Global.TimeReminder.My.MySettings.Default.TimeInterval
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Intervalo:"
        '
        'timeEnd
        '
        Me.timeEnd.Checked = Global.TimeReminder.My.MySettings.Default.TimeEndEnabled
        Me.timeEnd.CustomFormat = ""
        Me.timeEnd.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.TimeReminder.My.MySettings.Default, "TimeEnd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.timeEnd.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimeReminder.My.MySettings.Default, "TimeEndEnabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeEnd.Location = New System.Drawing.Point(18, 218)
        Me.timeEnd.Name = "timeEnd"
        Me.timeEnd.ShowCheckBox = True
        Me.timeEnd.ShowUpDown = True
        Me.timeEnd.Size = New System.Drawing.Size(153, 25)
        Me.timeEnd.TabIndex = 6
        Me.timeEnd.Value = Global.TimeReminder.My.MySettings.Default.TimeEnd
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fin:"
        '
        'timeStart
        '
        Me.timeStart.Checked = Global.TimeReminder.My.MySettings.Default.TimeStartEnabled
        Me.timeStart.CustomFormat = ""
        Me.timeStart.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.TimeReminder.My.MySettings.Default, "TimeStart", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.timeStart.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimeReminder.My.MySettings.Default, "TimeStartEnabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeStart.Location = New System.Drawing.Point(18, 148)
        Me.timeStart.Name = "timeStart"
        Me.timeStart.ShowCheckBox = True
        Me.timeStart.ShowUpDown = True
        Me.timeStart.Size = New System.Drawing.Size(153, 25)
        Me.timeStart.TabIndex = 4
        Me.timeStart.Value = Global.TimeReminder.My.MySettings.Default.TimeStart
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Comienzo:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 100)
        Me.Panel2.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(14, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 19)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Pablo Facciano - 2019"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(10, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Time Reminder"
        '
        'T
        '
        Me.T.Interval = 500
        '
        'BarIcon
        '
        Me.BarIcon.BalloonTipTitle = "Time Reminder"
        Me.BarIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BarIcon.Icon = CType(resources.GetObject("BarIcon.Icon"), System.Drawing.Icon)
        Me.BarIcon.Text = "Time Reminder"
        Me.BarIcon.Visible = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnHide
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(456, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Reminder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timeStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents timeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents timeInterval As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents action As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents T As System.Windows.Forms.Timer
    Friend WithEvents BarIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirPanelDeControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextMask As System.Windows.Forms.TextBox
    Friend WithEvents TimeFormat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
