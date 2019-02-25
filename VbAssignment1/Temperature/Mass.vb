Public Class Mass
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub Mass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The original units for the combobox 
        UnitOri.Items.Add("Kilogram")
        UnitOri.Items.Add("Pound")
        UnitOri.Items.Add("Stone")

        'The units to be converted for the combobox 
        UnitConvert.Items.Add("Stone")
        UnitConvert.Items.Add("Pound")
        UnitConvert.Items.Add("Kilogram")

        'Presetting the units for the comboboxes
        UnitOri.SelectedIndex = 0
        UnitConvert.SelectedIndex = 0
    End Sub

    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        Dim TargetItem As Integer
        Dim OriIndex As String
        Dim ConvertIndex As String
        Dim CalInt As Double
        TargetItem = LbInput.Items.Count 'Setting the value of targetitem as the Listbox items count
        OriIndex = UnitOri.SelectedItem 'Setting the choosen original unit 
        ConvertIndex = UnitConvert.SelectedItem 'Setting the chose unit to be converted
        If (OriIndex.ToString().Equals("Kilogram") And ConvertIndex.ToString.Equals("Pound")) Then 'Parameteres to determine which unit has been seleced
            For i As Integer = 0 To TargetItem - 1 'For loop to go through every inputs 
                CalInt = Val(LbInput.Items.Item(i)) * 2.20462 'Formula for conversion
                Conversion.Show() 'Showing the conversion page
                Conversion.LbResults.Items.Add(CalInt) 'Adding the converted answer to the listbox in the conversion form 
                Conversion.LblOri.Text = "Kilogram" 'Setting text for the original unit in the conversion form
                Conversion.LblResults.Text = "Pound" 'Setting text for the converted unit in the conversion form
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i)) 'Adding the original inputed value to the conversion form 
            Next
        ElseIf (OriIndex.ToString().Equals("Pound") And ConvertIndex.ToString.Equals("Kilogram")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 0.453592
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LblOri.Text = "Pound"
                Conversion.LblResults.Text = "Kilogram"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
            Next
        ElseIf (OriIndex.ToString().Equals("Kilogram") And ConvertIndex.ToString.Equals("Stone")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 0.157473
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LblOri.Text = "Kilogram"
                Conversion.LblResults.Text = "Stone"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
            Next
        ElseIf (OriIndex.ToString().Equals("Stone") And ConvertIndex.ToString.Equals("Kilogram")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 6.35029
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LblOri.Text = "Stone"
                Conversion.LblResults.Text = "Kilogram"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
            Next
        ElseIf (OriIndex.ToString().Equals("Pound") And ConvertIndex.ToString.Equals("Stone")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 0.0714286
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LblOri.Text = "Pound"
                Conversion.LblResults.Text = "Stone"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
            Next
        ElseIf (OriIndex.ToString().Equals("Stone") And ConvertIndex.ToString.Equals("Pound")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) * 14
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LblOri.Text = "Stone"
                Conversion.LblResults.Text = "Pound"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
            Next
        Else
            MsgBox("You are trying to convert between the same unit", 64 + 0, "Error") 'Error Nessage if they try to convert between the same units

        End If
    End Sub
End Class