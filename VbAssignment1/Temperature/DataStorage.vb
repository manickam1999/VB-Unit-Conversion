Public Class DataStorage
    Private Sub DataStorage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UnitOri.Items.Add("Terabyte")
        UnitOri.Items.Add("Gigabyte")

        UnitConvert.Items.Add("Gigabyte")
        UnitConvert.Items.Add("Terabyte")

        UnitOri.SelectedIndex = 0
        UnitConvert.SelectedIndex = 0
    End Sub

    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        Dim TargetItem As Integer
        Dim OriIndex As String
        Dim ConvertIndex As String
        Dim CalInt As Double
        TargetItem = LbInput.Items.Count
        OriIndex = UnitOri.SelectedItem
        ConvertIndex = UnitConvert.SelectedItem

        If (OriIndex.ToString().Equals("Terabyte") And ConvertIndex.ToString.Equals("Gigabyte")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 1024
                Conversion.Show()
                Conversion.LbResults.Items.Add(Format(CalInt, "#.00"))
                Conversion.LblOri.Text = "Terabyte"
                Conversion.LblResults.Text = "Gigabyte"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(Format(i, "#.00")))
            Next

        ElseIf (OriIndex.ToString().Equals("Gigabyte") And ConvertIndex.ToString.Equals("Terabyte")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i)) / 1024)
                Conversion.Show()
                Conversion.LbResults.Items.Add(Format(CalInt, "#.0000"))
                Conversion.LblOri.Text = "Gigabyte"
                Conversion.LblResults.Text = "Terabyte"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(Format(i, "#.0000")))
            Next

        Else
            MsgBox("You are trying to convert between the same unit", 64 + 0, "Error")

        End If
    End Sub
End Class