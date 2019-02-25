Public Class Temp
    Private Sub Temp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'The original units for the combobox
        UnitOri.Items.Add("Celsius")
        UnitOri.Items.Add("Fahrenheit")
        UnitOri.Items.Add("Kelvin")

        'The units to be converted for the combobox 
        UnitConvert.Items.Add("Fahrenheit")
        UnitConvert.Items.Add("Celsius")
        UnitConvert.Items.Add("Kelvin")

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
        If (OriIndex.ToString().Equals("Celsius") And ConvertIndex.ToString.Equals("Fahrenheit")) Then 'Parameteres to determine which unit has been seleced
            For i As Integer = 0 To TargetItem - 1 'For loop to go through every inputs 
                CalInt = (Val(LbInput.Items.Item(i)) * 9.0) / 5.0 + 32 'Formula for conversion
                Conversion.Show() 'Showing the conversion page
                Conversion.LbResults.Items.Add(CalInt) 'Adding the converted answer to the listbox in the conversion
                Conversion.LblOri.Text = "Celsius" 'Setting text for the original unit in the conversion form
                Conversion.LblResults.Text = "Fahrenheit" 'Setting text for the converted unit in the conversion form
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i)) 'Adding the original inputed value to the conversion form 
            Next
        ElseIf (OriIndex.ToString().Equals("Celsius") And ConvertIndex.ToString.Equals("Kelvin")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) + 273.15
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LblOri.Text = "Celsius"
                Conversion.LblResults.Text = "Kelvin"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
            Next
        ElseIf (OriIndex.ToString().Equals("Fahrenheit") And ConvertIndex.ToString.Equals("Celsius")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i)) - 32) * 5 / 9
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LblOri.Text = "Fahrenheit"
                Conversion.LblResults.Text = "Celcius"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
            Next
        ElseIf (OriIndex.ToString().Equals("Fahrenheit") And ConvertIndex.ToString.Equals("Kelvin")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = ((Val(LbInput.Items.Item(i)) + 459.67) * 5 / 9)
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LblOri.Text = "Fahrenehit"
                Conversion.LblResults.Text = "Kelvin"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
            Next
        ElseIf (OriIndex.ToString().Equals("Kelvin") And ConvertIndex.ToString.Equals("Celsius")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = (Val(LbInput.Items.Item(i))) - 273.15
                Conversion.Show()
                Conversion.LbResults.Items.Add(Format(CalInt, "#.00"))
                Conversion.LblOri.Text = "Kelvin"
                Conversion.LblResults.Text = "Celcius"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
            Next
        ElseIf (OriIndex.ToString().Equals("Kelvin") And ConvertIndex.ToString.Equals("Fahrenheit")) Then
            For i As Integer = 0 To TargetItem - 1
                CalInt = ((Val(LbInput.Items.Item(i)) - 273.15) * 9 / 5) + 32
                Conversion.Show()
                Conversion.LbResults.Items.Add(CalInt)
                Conversion.LblOri.Text = "Kelvin"
                Conversion.LblResults.Text = "Fahrenehit"
                Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
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
End Class
