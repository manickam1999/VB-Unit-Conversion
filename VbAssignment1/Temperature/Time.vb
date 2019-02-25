Public Class Time

    Private Sub Time_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The original units for the combobox
        UnitOri.Items.Add("Year")
        UnitOri.Items.Add("Month")
        UnitOri.Items.Add("Day")

        'The units to be converted for the combobox 
        UnitConvert.Items.Add("Day")
        UnitConvert.Items.Add("Month")
        UnitConvert.Items.Add("Year")
        'Presetting the units for the comboboxes
        UnitOri.SelectedIndex = 0
        UnitConvert.SelectedIndex = 0
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        Dim TargetItem As Integer
        Dim OriIndex As String
        Dim ConvertIndex As String
        Dim CalInt As Double
        TargetItem = LbInput.Items.Count 'Setting the value of targetitem as the Listbox items count
        OriIndex = UnitOri.SelectedItem 'Setting the choosen original unit 
        ConvertIndex = UnitConvert.SelectedItem 'Setting the chose unit to be converted
        If (TargetItem > 0) Then 'For loop to go through every inputs 
            If (OriIndex.ToString().Equals("Year") And ConvertIndex.ToString.Equals("Day")) Then 'Parameteres to determine which unit has been seleced
                For i As Integer = 0 To TargetItem - 1
                    CalInt = (Val(LbInput.Items.Item(i))) * 365 'Formula for conversion
                    Conversion.Show() 'Showing the conversion page
                    Conversion.LbResults.Items.Add(CalInt) 'Adding the converted answer to the listbox in the conversion
                    Conversion.LbOri.Items.Add(LbInput.Items.Item(i)) 'Adding the original inputed value to the conversion form 
                    Conversion.LblOri.Text = "Year" 'Setting text for the original unit in the conversion form
                    Conversion.LblResults.Text = "Day" 'Setting text for the converted unit in the conversion form
                Next
            ElseIf (OriIndex.ToString().Equals("Year") And ConvertIndex.ToString.Equals("Month")) Then
                For i As Integer = 0 To TargetItem - 1
                    CalInt = (Val(LbInput.Items.Item(i))) * 12
                    Conversion.Show()
                    Conversion.LbResults.Items.Add(CalInt)
                    Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
                    Conversion.LblOri.Text = "Year"
                    Conversion.LblResults.Text = "Month"
                Next
            ElseIf (OriIndex.ToString().Equals("Month") And ConvertIndex.ToString.Equals("Day")) Then
                For i As Integer = 0 To TargetItem - 1
                    CalInt = (Val(LbInput.Items.Item(i))) * 30.4167
                    Conversion.Show()
                    Conversion.LbResults.Items.Add(CalInt)
                    Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
                    Conversion.LblOri.Text = "Month"
                    Conversion.LblResults.Text = "Day"
                Next
            ElseIf (OriIndex.ToString().Equals("Month") And ConvertIndex.ToString.Equals("Year")) Then
                For i As Integer = 0 To TargetItem - 1
                    CalInt = (Val(LbInput.Items.Item(i))) / 12
                    Conversion.Show()
                    Conversion.LbResults.Items.Add(CalInt)
                    Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
                    Conversion.LblOri.Text = "Month"
                    Conversion.LblResults.Text = "Year"
                Next
            ElseIf (OriIndex.ToString().Equals("Day") And ConvertIndex.ToString.Equals("Month")) Then
                For i As Integer = 0 To TargetItem - 1
                    CalInt = (Val(LbInput.Items.Item(i))) * 0.0328767
                    Conversion.Show()
                    Conversion.LbResults.Items.Add(CalInt)
                    Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
                    Conversion.LblOri.Text = "Day"
                    Conversion.LblResults.Text = "Month"

                Next
            ElseIf (OriIndex.ToString().Equals("Day") And ConvertIndex.ToString.Equals("Year")) Then
                For i As Integer = 0 To TargetItem - 1
                    CalInt = Val(LbInput.Items.Item(i)) * 0.00273973
                    Conversion.Show()
                    Conversion.LbResults.Items.Add(CalInt)
                    Conversion.LbOri.Items.Add(LbInput.Items.Item(i))
                    Conversion.LblOri.Text = "Day"
                    Conversion.LblResults.Text = "Year"
                Next
            Else
                MsgBox("You are trying to convert between the same unit", 64 + 0, "Error")

            End If

        Else
            MsgBox("There is no value to be converted")
        End If
    End Sub

    Private Sub LbInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbInput.SelectedIndexChanged

    End Sub

    Private Sub UnitOri_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitOri.SelectedIndexChanged

    End Sub

    Private Sub UnitConvert_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitConvert.SelectedIndexChanged

    End Sub
End Class