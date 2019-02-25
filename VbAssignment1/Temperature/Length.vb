Public Class Length
    Private Sub LTitle_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Length_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The original units for the combobox 
        UnitOri.Items.Add("Kilometer")
        UnitOri.Items.Add("Mile")
        UnitOri.Items.Add("Nautical Mile")

        'The units to be converted for the combobox 
        UnitConvert.Items.Add("Nautical Mile")
        UnitConvert.Items.Add("Mile")
        UnitConvert.Items.Add("Kilometer")

        'Presetting the units for the comboboxes
        UnitOri.SelectedIndex = 0
        UnitConvert.SelectedIndex = 0
    End Sub

    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        Dim TargetItem As Integer
        Dim OriIndex As String
        Dim ConvertIndex As String
        Dim CalInt As Double
        TargetItem = LbInput.Items.Count 'Setting the value of targetitem of the Listbox items count
        OriIndex = UnitOri.SelectedItem 'Setting the choosen original unit 
        ConvertIndex = UnitConvert.SelectedItem 'Setting the chose unit to be converted
        If (OriIndex.ToString().Equals("Kilometer") And ConvertIndex.ToString.Equals("Mile")) Then 'Parameteres to determine which unit has been seleced
            For i As Integer = 0 To TargetItem - 1 'For loop to go through every inputs 
                CalInt = Val(LbInput.Items.Item(i)) * 0.621371 'Formula for conversion
                Conversion.LbResults.Items.Add(CalInt) 'Adding the converted answer to the listbox in the conversion form 
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i)) 'Adding the original inputed value to the conversion form 
                Conversion.Show() 'Showing the conversion page
                Conversion.LblOri.Text = "Kilometer" 'Setting text for the original unit in the conversion form
                Conversion.LblResults.Text = "Mile" 'Setting text for the converted unit in the conversion form

            Next
        ElseIf (OriIndex.ToString().Equals("Kilometer") And ConvertIndex.ToString.Equals("Nautical Mile")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 0.539957
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
                Conversion.LblOri.Text = "Kilometer"
                Conversion.LblResults.Text = "Nautical"

            Next
        ElseIf (OriIndex.ToString().Equals("Mile") And ConvertIndex.ToString.Equals("Kilometer")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 1.60934
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
                Conversion.LblOri.Text = "Meter"
                Conversion.LblResults.Text = "Kilometer"

            Next
        ElseIf (OriIndex.ToString().Equals("Mile") And ConvertIndex.ToString.Equals("Nautical Mile")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 0.868976
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
                Conversion.LblOri.Text = "Mile"
                Conversion.LblResults.Text = "Nautical Mile"

            Next
        ElseIf (OriIndex.ToString().Equals("Nautical Mile") And ConvertIndex.ToString.Equals("Mile")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 1.15078
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
                Conversion.LblOri.Text = "Nautical Mile"
                Conversion.LblResults.Text = "Mile"

            Next
        ElseIf (OriIndex.ToString().Equals("Nautical Mile") And ConvertIndex.ToString.Equals("Kilometer")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 1.852
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
                Conversion.LblOri.Text = "Nautical Mile"
                Conversion.LblResults.Text = "Kilometer"
            Next
        Else
            MsgBox("You are trying to convert between the same unit", 64 + 0, "Error")

        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub LbInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbInput.SelectedIndexChanged

    End Sub

    Private Sub UnitOri_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitOri.SelectedIndexChanged

    End Sub

    Private Sub LTitle_Click_1(sender As Object, e As EventArgs) Handles LTitle.Click

    End Sub

    Private Sub UnitConvert_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitConvert.SelectedIndexChanged

    End Sub
End Class