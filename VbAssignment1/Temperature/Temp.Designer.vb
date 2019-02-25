<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Temp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LbInput = New System.Windows.Forms.ListBox()
        Me.BtnCal = New System.Windows.Forms.Button()
        Me.LTitle = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.UnitOri = New System.Windows.Forms.ComboBox()
        Me.UnitConvert = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LbInput
        '
        Me.LbInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInput.FormattingEnabled = True
        Me.LbInput.ItemHeight = 20
        Me.LbInput.Location = New System.Drawing.Point(33, 112)
        Me.LbInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LbInput.Name = "LbInput"
        Me.LbInput.Size = New System.Drawing.Size(159, 164)
        Me.LbInput.TabIndex = 0
        '
        'BtnCal
        '
        Me.BtnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCal.Location = New System.Drawing.Point(305, 141)
        Me.BtnCal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCal.Name = "BtnCal"
        Me.BtnCal.Size = New System.Drawing.Size(100, 28)
        Me.BtnCal.TabIndex = 4
        Me.BtnCal.Text = "Convert"
        Me.BtnCal.UseVisualStyleBackColor = True
        '
        'LTitle
        '
        Me.LTitle.AutoSize = True
        Me.LTitle.BackColor = System.Drawing.Color.RoyalBlue
        Me.LTitle.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LTitle.Location = New System.Drawing.Point(93, 9)
        Me.LTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTitle.Name = "LTitle"
        Me.LTitle.Size = New System.Drawing.Size(294, 29)
        Me.LTitle.TabIndex = 5
        Me.LTitle.Text = "Temperature Conversion"
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(305, 220)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(100, 28)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'UnitOri
        '
        Me.UnitOri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitOri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitOri.FormattingEnabled = True
        Me.UnitOri.Location = New System.Drawing.Point(33, 59)
        Me.UnitOri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UnitOri.Name = "UnitOri"
        Me.UnitOri.Size = New System.Drawing.Size(160, 28)
        Me.UnitOri.TabIndex = 7
        '
        'UnitConvert
        '
        Me.UnitConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitConvert.FormattingEnabled = True
        Me.UnitConvert.Location = New System.Drawing.Point(269, 59)
        Me.UnitConvert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UnitConvert.Name = "UnitConvert"
        Me.UnitConvert.Size = New System.Drawing.Size(160, 28)
        Me.UnitConvert.TabIndex = 8
        '
        'Temp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Temperature.My.Resources.Resources._118380
        Me.ClientSize = New System.Drawing.Size(482, 353)
        Me.Controls.Add(Me.UnitConvert)
        Me.Controls.Add(Me.UnitOri)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LTitle)
        Me.Controls.Add(Me.BtnCal)
        Me.Controls.Add(Me.LbInput)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Temp"
        Me.Text = "Temperature"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbInput As ListBox
    Friend WithEvents BtnCal As Button
    Friend WithEvents LTitle As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents UnitOri As ComboBox
    Friend WithEvents UnitConvert As ComboBox
End Class
