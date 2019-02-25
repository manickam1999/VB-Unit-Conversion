<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.components = New System.ComponentModel.Container()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblDes = New System.Windows.Forms.Label()
        Me.BtnTemp = New System.Windows.Forms.Button()
        Me.BtnTime = New System.Windows.Forms.Button()
        Me.TxtInput = New System.Windows.Forms.RichTextBox()
        Me.BtnLength = New System.Windows.Forms.Button()
        Me.BtnMass = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BackColor = System.Drawing.Color.Navy
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblTitle.Location = New System.Drawing.Point(9, 7)
        Me.LblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(440, 32)
        Me.LblTitle.TabIndex = 2
        Me.LblTitle.Text = "Welcome to Saints Unit Converter"
        '
        'LblDes
        '
        Me.LblDes.AutoSize = True
        Me.LblDes.BackColor = System.Drawing.Color.RoyalBlue
        Me.LblDes.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblDes.Location = New System.Drawing.Point(11, 63)
        Me.LblDes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDes.Name = "LblDes"
        Me.LblDes.Size = New System.Drawing.Size(325, 96)
        Me.LblDes.TabIndex = 3
        Me.LblDes.Text = "Please enter your values below :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Separate them by pressing enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " after each va" &
    "lue "
        '
        'BtnTemp
        '
        Me.BtnTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTemp.Location = New System.Drawing.Point(269, 284)
        Me.BtnTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTemp.Name = "BtnTemp"
        Me.BtnTemp.Size = New System.Drawing.Size(133, 32)
        Me.BtnTemp.TabIndex = 4
        Me.BtnTemp.Text = "Temperature"
        Me.BtnTemp.UseVisualStyleBackColor = True
        '
        'BtnTime
        '
        Me.BtnTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTime.Location = New System.Drawing.Point(269, 338)
        Me.BtnTime.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTime.Name = "BtnTime"
        Me.BtnTime.Size = New System.Drawing.Size(128, 32)
        Me.BtnTime.TabIndex = 5
        Me.BtnTime.Text = "Time"
        Me.BtnTime.UseVisualStyleBackColor = True
        '
        'TxtInput
        '
        Me.TxtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInput.Location = New System.Drawing.Point(12, 181)
        Me.TxtInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TxtInput.Size = New System.Drawing.Size(208, 238)
        Me.TxtInput.TabIndex = 1
        Me.TxtInput.Text = ""
        '
        'BtnLength
        '
        Me.BtnLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLength.Location = New System.Drawing.Point(269, 230)
        Me.BtnLength.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLength.Name = "BtnLength"
        Me.BtnLength.Size = New System.Drawing.Size(133, 32)
        Me.BtnLength.TabIndex = 3
        Me.BtnLength.Text = "Length"
        Me.BtnLength.UseVisualStyleBackColor = True
        '
        'BtnMass
        '
        Me.BtnMass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMass.Location = New System.Drawing.Point(269, 181)
        Me.BtnMass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMass.Name = "BtnMass"
        Me.BtnMass.Size = New System.Drawing.Size(133, 32)
        Me.BtnMass.TabIndex = 2
        Me.BtnMass.Text = "Mass"
        Me.BtnMass.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(269, 387)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(128, 32)
        Me.BtnClear.TabIndex = 7
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Temperature.My.Resources.Resources._118380
        Me.ClientSize = New System.Drawing.Size(483, 453)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnMass)
        Me.Controls.Add(Me.BtnLength)
        Me.Controls.Add(Me.TxtInput)
        Me.Controls.Add(Me.BtnTime)
        Me.Controls.Add(Me.BtnTemp)
        Me.Controls.Add(Me.LblDes)
        Me.Controls.Add(Me.LblTitle)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblDes As Label
    Friend WithEvents BtnTemp As Button
    Friend WithEvents BtnTime As Button
    Friend WithEvents TxtInput As RichTextBox
    Friend WithEvents BtnLength As Button
    Friend WithEvents BtnMass As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnClear As Button
End Class
