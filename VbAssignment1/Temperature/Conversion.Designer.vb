<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conversion
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
        Me.LbResults = New System.Windows.Forms.ListBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LbOri = New System.Windows.Forms.ListBox()
        Me.LblOri = New System.Windows.Forms.Label()
        Me.LblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LbResults
        '
        Me.LbResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResults.FormattingEnabled = True
        Me.LbResults.ItemHeight = 20
        Me.LbResults.Location = New System.Drawing.Point(216, 52)
        Me.LbResults.Margin = New System.Windows.Forms.Padding(4)
        Me.LbResults.Name = "LbResults"
        Me.LbResults.Size = New System.Drawing.Size(218, 164)
        Me.LbResults.TabIndex = 0
        Me.LbResults.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(171, 261)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(100, 28)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LbOri
        '
        Me.LbOri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbOri.FormattingEnabled = True
        Me.LbOri.ItemHeight = 20
        Me.LbOri.Location = New System.Drawing.Point(13, 52)
        Me.LbOri.Margin = New System.Windows.Forms.Padding(4)
        Me.LbOri.Name = "LbOri"
        Me.LbOri.Size = New System.Drawing.Size(182, 164)
        Me.LbOri.TabIndex = 2
        '
        'LblOri
        '
        Me.LblOri.AutoSize = True
        Me.LblOri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOri.Location = New System.Drawing.Point(69, 16)
        Me.LblOri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblOri.Name = "LblOri"
        Me.LblOri.Size = New System.Drawing.Size(71, 25)
        Me.LblOri.TabIndex = 3
        Me.LblOri.Text = "Label1"
        '
        'LblResults
        '
        Me.LblResults.AutoSize = True
        Me.LblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResults.Location = New System.Drawing.Point(277, 16)
        Me.LblResults.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblResults.Name = "LblResults"
        Me.LblResults.Size = New System.Drawing.Size(71, 25)
        Me.LblResults.TabIndex = 4
        Me.LblResults.Text = "Label2"
        '
        'Conversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Temperature.My.Resources.Resources._118380
        Me.ClientSize = New System.Drawing.Size(462, 333)
        Me.Controls.Add(Me.LblResults)
        Me.Controls.Add(Me.LblOri)
        Me.Controls.Add(Me.LbOri)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LbResults)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Conversion"
        Me.Text = "Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbResults As ListBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents LbOri As ListBox
    Friend WithEvents LblOri As Label
    Friend WithEvents LblResults As Label
End Class
