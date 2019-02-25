<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Time
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
        Me.LTitle = New System.Windows.Forms.Label()
        Me.UnitOri = New System.Windows.Forms.ComboBox()
        Me.UnitConvert = New System.Windows.Forms.ComboBox()
        Me.LbInput = New System.Windows.Forms.ListBox()
        Me.BtnCal = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LTitle
        '
        Me.LTitle.AutoSize = True
        Me.LTitle.BackColor = System.Drawing.Color.RoyalBlue
        Me.LTitle.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LTitle.Location = New System.Drawing.Point(93, 7)
        Me.LTitle.Name = "LTitle"
        Me.LTitle.Size = New System.Drawing.Size(169, 22)
        Me.LTitle.TabIndex = 6
        Me.LTitle.Text = "Time Conversion"
        '
        'UnitOri
        '
        Me.UnitOri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitOri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitOri.FormattingEnabled = True
        Me.UnitOri.Location = New System.Drawing.Point(25, 48)
        Me.UnitOri.Name = "UnitOri"
        Me.UnitOri.Size = New System.Drawing.Size(121, 25)
        Me.UnitOri.TabIndex = 8
        '
        'UnitConvert
        '
        Me.UnitConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitConvert.FormattingEnabled = True
        Me.UnitConvert.Location = New System.Drawing.Point(202, 48)
        Me.UnitConvert.Name = "UnitConvert"
        Me.UnitConvert.Size = New System.Drawing.Size(121, 25)
        Me.UnitConvert.TabIndex = 9
        '
        'LbInput
        '
        Me.LbInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInput.FormattingEnabled = True
        Me.LbInput.ItemHeight = 17
        Me.LbInput.Location = New System.Drawing.Point(25, 91)
        Me.LbInput.Name = "LbInput"
        Me.LbInput.Size = New System.Drawing.Size(120, 123)
        Me.LbInput.TabIndex = 10
        '
        'BtnCal
        '
        Me.BtnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCal.Location = New System.Drawing.Point(229, 115)
        Me.BtnCal.Name = "BtnCal"
        Me.BtnCal.Size = New System.Drawing.Size(75, 23)
        Me.BtnCal.TabIndex = 11
        Me.BtnCal.Text = "Convert"
        Me.BtnCal.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(229, 179)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Time
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Temperature.My.Resources.Resources._118380
        Me.ClientSize = New System.Drawing.Size(362, 287)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCal)
        Me.Controls.Add(Me.LbInput)
        Me.Controls.Add(Me.UnitConvert)
        Me.Controls.Add(Me.UnitOri)
        Me.Controls.Add(Me.LTitle)
        Me.Name = "Time"
        Me.Text = "Time"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTitle As Label
    Friend WithEvents UnitOri As ComboBox
    Friend WithEvents UnitConvert As ComboBox
    Friend WithEvents LbInput As ListBox
    Friend WithEvents BtnCal As Button
    Friend WithEvents BtnExit As Button
End Class
