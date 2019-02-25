Public Class Menu
    Dim counter As Integer = 0
    Private Sub BtnTemp_Click(sender As Object, e As EventArgs) Handles BtnTemp.Click
        Dim ErrorStatus As Boolean = False 'Boolean to check if there are any errors
        Dim LengthStatus As Boolean = False 'Boolean to check if it exceeds the length 
        Dim ShowStatus As Boolean = False 'Boolean to check if it meets all the requirements before the page is shown
        Dim highlights As New List(Of String)

        Temp.LbInput.Items.Clear() 'Clear all the inputs 
        For i As Integer = 0 To Val(TxtInput.Lines.Count) - 1
            If TxtInput.Lines(i).Trim() = "" Then 'Ignores newline inputs
                'Placeholder Comment 
            ElseIf IsNumeric(TxtInput.Lines(i).Trim()) Then 'Tests for Numbers
                If TxtInput.Lines(i).Trim().Length < 11 Then 'Test for numbers above 10 digits
                    Temp.LbInput.Items.Add(TxtInput.Lines(i).Trim())
                    ShowStatus = True
                Else
                    highlights.Add(TxtInput.Lines(i).Trim())
                    LengthStatus = True
                End If
            Else
                ErrorStatus = True
                highlights.Add(TxtInput.Lines(i).Trim())
            End If
        Next
        If ErrorStatus = True Then
            ErrorHighlight(TxtInput, highlights)
            MsgBox("Your input must only be in numbers and less than 11 digits, check for invalid inputs!", 16 + 0, "Error")
        ElseIf LengthStatus = True Then
            ErrorHighlight(TxtInput, highlights)
            MsgBox("Your input must be less than 11 digits !", 16 + 0, "Error")
        ElseIf ShowStatus = False Then
            MsgBox("There is no input detected !", 16 + 0, "Error")
        ElseIf ErrorStatus = False And LengthStatus = False And ShowStatus = True Then
            Temp.Show()
        End If
    End Sub

    Private Sub BtnTime_Click(sender As Object, e As EventArgs) Handles BtnTime.Click
        Dim ErrorStatus As Boolean = False
        Dim LengthStatus As Boolean = False
        Dim ShowStatus As Boolean = False
        Dim highlights As New List(Of String)

        Time.LbInput.Items.Clear()
        For i As Integer = 0 To Val(TxtInput.Lines.Count) - 1
            If TxtInput.Lines(i).Trim() = "" Then 'Ignores newline inputs
                'Placeholder Comment 
            ElseIf IsNumeric(TxtInput.Lines(i).Trim()) Then 'Tests for Numbers
                If TxtInput.Lines(i).Trim().Length < 11 Then
                    Time.LbInput.Items.Add(TxtInput.Lines(i).Trim())
                    ShowStatus = True
                Else
                    highlights.Add(TxtInput.Lines(i).Trim())
                    LengthStatus = True
                End If
            Else
                ErrorStatus = True
                highlights.Add(TxtInput.Lines(i).Trim())
            End If
        Next
        If ErrorStatus = True Then
            ErrorHighlight(TxtInput, highlights)
            MsgBox("Your input must only be in numbers and less than 11 digits, check for invalid inputs!", 16 + 0, "Error")
        ElseIf LengthStatus = True Then
            ErrorHighlight(TxtInput, highlights)
            MsgBox("Your input must be less than 11 digits !", 16 + 0, "Error")
        ElseIf ShowStatus = False Then
            MsgBox("There is no input detected !", 16 + 0, "Error")
        ElseIf ErrorStatus = False And LengthStatus = False And ShowStatus = True Then
            Time.Show()
        End If
    End Sub

    Private Sub TxtInput_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblDes_Click(sender As Object, e As EventArgs) Handles LblDes.Click

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLength_Click(sender As Object, e As EventArgs) Handles BtnLength.Click
        Dim ErrorStatus As Boolean = False
        Dim LengthStatus As Boolean = False
        Dim ShowStatus As Boolean = False
        Dim highlights As New List(Of String)

        Length.LbInput.Items.Clear()
        For i As Integer = 0 To Val(TxtInput.Lines.Count) - 1
            If TxtInput.Lines(i).Trim() = "" Then 'Ignores newline inputs
                'Placeholder Comment 
            ElseIf IsNumeric(TxtInput.Lines(i).Trim()) Then 'Tests for Numbers
                If TxtInput.Lines(i).Trim().Length < 11 Then
                    Length.LbInput.Items.Add(TxtInput.Lines(i).Trim())
                    ShowStatus = True
                Else
                    highlights.Add(TxtInput.Lines(i).Trim())
                    LengthStatus = True
                End If
            Else
                ErrorStatus = True
                highlights.Add(TxtInput.Lines(i).Trim())
            End If
        Next
        If ErrorStatus = True Then
            ErrorHighlight(TxtInput, highlights)
            MsgBox("Your input must only be in numbers and less than 11 digits, check for invalid inputs!", 16 + 0, "Error")
        ElseIf LengthStatus = True Then
            ErrorHighlight(TxtInput, highlights)
            MsgBox("Your input must be less than 11 digits !", 16 + 0, "Error")
        ElseIf ShowStatus = False Then
            MsgBox("There is no input detected !", 16 + 0, "Error")
        ElseIf ErrorStatus = False And LengthStatus = False And ShowStatus = True Then
            Length.Show()
        End If
    End Sub

    Private Sub ErrorHighlight(tb As RichTextBox, list As List(Of String)) 'The function that changes errors to red by rebuilding the whole textbox
        Dim tempArray() As String = tb.Lines 'receives a textbox and a list as parameters
        tb.Text = ""
        For i As Integer = 0 To tempArray.Length - 1 'loops through the whole textbox of based on its lines
            Dim line As String = tempArray(i)
            For Each check As String In list 'loops through the detected errors and checks whether the for loop is touching on the lines of these errors

                If line.Equals(check.Trim()) Or line.Count > 10 Then
                    tb.SelectionColor = Color.Red 'if error change to red
                    Exit For
                Else ' if not continue black
                    tb.SelectionColor = Color.Black
                End If
            Next
            If i = tempArray.Length - 1 Then
                tb.AppendText(line.Trim()) 'then append it back into the textbox thus rebuilding the whole sequence with error highlighting
                tb.SelectionColor = Color.Black
            Else
                tb.AppendText(line + Environment.NewLine)
            End If
        Next
    End Sub

    Private Sub TxtInput_TextChanged_1(sender As Object, e As EventArgs) Handles TxtInput.TextChanged
        Timer1.Interval = 500 'Starts a timer to check whether user's newly entered value is still an error
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter = counter + 1
        If counter = 3 Then
            Dim highlights As New List(Of String) 'The subroutine that is called every 1000ms tick by the Timer
            For i = 0 To TxtInput.Lines.Length - 1
                If IsNumeric(TxtInput.Lines(i)) Then
                    ' Placeholder
                Else
                    highlights.Add(TxtInput.Lines(i))
                End If
            Next
            ErrorHighlight(TxtInput, highlights)
            Timer1.Stop()
            counter = 0
        End If
    End Sub

    Private Sub BtnMass_Click(sender As Object, e As EventArgs) Handles BtnMass.Click
        Dim ErrorStatus As Boolean = False
        Dim LengthStatus As Boolean = False
        Dim ShowStatus As Boolean = False
        Dim highlights As New List(Of String)

        Mass.LbInput.Items.Clear()
        For i As Integer = 0 To Val(TxtInput.Lines.Count) - 1
            If TxtInput.Lines(i).Trim() = "" Then 'Ignores newline inputs
                'Placeholder Comment 
            ElseIf IsNumeric(TxtInput.Lines(i).Trim()) Then 'Tests for Numbers
                If TxtInput.Lines(i).Trim().Length < 11 Then
                    Mass.LbInput.Items.Add(TxtInput.Lines(i).Trim())
                    ShowStatus = True
                Else
                    highlights.Add(TxtInput.Lines(i).Trim())
                    LengthStatus = True
                End If
            Else
                ErrorStatus = True
                highlights.Add(TxtInput.Lines(i).Trim())
            End If
        Next
        If ErrorStatus = True Then
            ErrorHighlight(TxtInput, highlights)
            MsgBox("Your input must only be in numbers and less than 11 digits, check for invalid inputs!", 16 + 0, "Error")
        ElseIf LengthStatus = True Then
            ErrorHighlight(TxtInput, highlights)
            MsgBox("Your input must be less than 11 digits !", 16 + 0, "Error")
        ElseIf ShowStatus = False Then
            MsgBox("There is no input detected !", 16 + 0, "Error")
        ElseIf ErrorStatus = False And LengthStatus = False And ShowStatus = True Then
            Mass.Show()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtInput.Clear() 'Clears all the inputs in the Rich textbox
    End Sub
End Class