Public Class Form1

    ' VB doesn't have comment blocks
    ' :'(
    ' Krishna Glick
    ' COP2010
    ' THE Edwin Harris, like for realzies
    ' I wrote this code while sick w/ sore throat and fever. I don't think I have the reading skills atm to copy someone elses code.
    ' I blame google code documentation for anything that appears to be copied.
    ' Also, Armando. It was his fault.

    ' This keeps track of which text box to throw numbers into.
    Private activeBox As TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This sets the active box at the start so you aren't all like "wtf man, your crap don't work!"
        activeBox = TextBoxValue1
    End Sub

    Private Sub ButtonNumeric1_Click(sender As Object, e As EventArgs) Handles ButtonNumeric1.Click
        ' This adds the number below to the string of the active box! Copy and paste comments, whoo!
        activeBox.Text &= 1
    End Sub

    Private Sub ButtonNumeric2_Click(sender As Object, e As EventArgs) Handles ButtonNumeric2.Click
        ' This adds the number below to the string of the active box!
        activeBox.Text &= 2
    End Sub

    Private Sub ButtonNumeric3_Click(sender As Object, e As EventArgs) Handles ButtonNumeric3.Click
        ' This adds the number below to the string of the active box!
        activeBox.Text &= 3
    End Sub

    Private Sub ButtonNumeric4_Click(sender As Object, e As EventArgs) Handles ButtonNumeric4.Click
        ' This adds the number below to the string of the active box!
        activeBox.Text &= 4
    End Sub

    Private Sub ButtonNumeric5_Click(sender As Object, e As EventArgs) Handles ButtonNumeric5.Click
        ' This adds the number below to the string of the active box!
        activeBox.Text &= 5
    End Sub

    Private Sub ButtonNumeric6_Click(sender As Object, e As EventArgs) Handles ButtonNumeric6.Click
        ' This adds the number below to the string of the active box!
        activeBox.Text &= 6
    End Sub

    Private Sub ButtonNumeric7_Click(sender As Object, e As EventArgs) Handles ButtonNumeric7.Click
        ' This adds the number below to the string of the active box!
        activeBox.Text &= 7
    End Sub

    Private Sub ButtonNumeric8_Click(sender As Object, e As EventArgs) Handles ButtonNumeric8.Click
        ' This adds the number below to the string of the active box!
        activeBox.Text &= 8
    End Sub

    Private Sub ButtonNumeric9_Click(sender As Object, e As EventArgs) Handles ButtonNumeric9.Click
        ' This adds the number below to the string of the active box!
        activeBox.Text &= 9
    End Sub

    Private Sub ButtonNumeric0_Click(sender As Object, e As EventArgs) Handles ButtonNumeric0.Click
        ' This adds the number below to the string of the active box!
        activeBox.Text &= 0
    End Sub

    Private Sub ButtonNumericDecimal_Click(sender As Object, e As EventArgs) Handles ButtonNumericDecimal.Click
        ' This adds a decimal to the active box IF one isn't already there. All that time in QA paid off!
        If Not (activeBox.Text.Contains(".")) Then
            activeBox.Text &= "."
        End If

    End Sub

    Private Sub ButtonMathAdd_Click(sender As Object, e As EventArgs) Handles ButtonMathAdd.Click
        ' Performs math (see function name for which math) assuming values are available within both boxes.
        If (TextBoxValue1.Text <> "" And TextBoxValue2.Text <> "") Then
            TextBoxResult.Text = Convert.ToDouble(TextBoxValue1.Text) + Convert.ToDouble(TextBoxValue2.Text)
        End If
    End Sub

    Private Sub ButtonMathSubtract_Click(sender As Object, e As EventArgs) Handles ButtonMathSubtract.Click
        ' Performs math (see function name for which math) assuming values are available within both boxes.
        If (TextBoxValue1.Text <> "" And TextBoxValue2.Text <> "") Then
            TextBoxResult.Text = Convert.ToDouble(TextBoxValue1.Text) - Convert.ToDouble(TextBoxValue2.Text)
        End If
    End Sub

    Private Sub ButtonMathMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMathMultiply.Click
        ' Performs math (see function name for which math) assuming values are available within both boxes.
        If (TextBoxValue1.Text <> "" And TextBoxValue2.Text <> "") Then
            TextBoxResult.Text = Convert.ToDouble(TextBoxValue1.Text) * Convert.ToDouble(TextBoxValue2.Text)
        End If
    End Sub

    Private Sub ButtonMathDivide_Click(sender As Object, e As EventArgs) Handles ButtonMathDivide.Click
        ' Performs math (see function name for which math) assuming values are available within both boxes.
        If (TextBoxValue1.Text <> "" And TextBoxValue2.Text <> "") Then
            TextBoxResult.Text = Convert.ToDouble(TextBoxValue1.Text) / Convert.ToDouble(TextBoxValue2.Text)
        End If
    End Sub

    Private Sub ButtonClearActive_Click(sender As Object, e As EventArgs) Handles ButtonClearActive.Click
        ' Clears the active text box, easier then mashing delete.
        activeBox.Text = ""
    End Sub

    Private Sub ButtonClearAll_Click(sender As Object, e As EventArgs) Handles ButtonClearAll.Click
        ' Clears all the text boxes for maximum overdrive.
        TextBoxValue1.Text = ""
        TextBoxValue2.Text = ""
        TextBoxResult.Text = ""
    End Sub

    Private Sub ButtonDeleteText_Click(sender As Object, e As EventArgs) Handles ButtonDeleteText.Click
        ' This is some clever crap right here. If the text box isn't empty it'll remove one character
        ' starting from the length of the current string, minus one, and of one distance.
        ' Additionally, if your number is 36.5 and you hit delete, it will delete the .5 and not just 5! Damn, I'm clever.
        If (activeBox.Text <> "") Then
            activeBox.Text = activeBox.Text.Remove(activeBox.Text.Length - 1, 1)
            ' The index of a character that is not within a string is -1
            If (activeBox.Text.IndexOf(".") <> -1) Then
                ' All this excess if statements are because this damned thing would just error out on the second condition within an And conditional. T.T
                ' If the character to the left of the one we just deleted, the last one, is '.' then delete it as well.
                If (activeBox.Text.IndexOf(".") = activeBox.Text.Length - 1) Then
                    activeBox.Text = activeBox.Text.Remove(activeBox.Text.Length - 1, 1)
                End If
            End If
        End If
    End Sub

    Private Sub TextBoxValue1_Enter(sender As Object, e As EventArgs) Handles TextBoxValue1.Enter
        ' This changes the active text box to the below textbox name.
        activeBox = TextBoxValue1
    End Sub

    Private Sub TextBoxValue2_Enter(sender As Object, e As EventArgs) Handles TextBoxValue2.Enter
        ' This changes the active text box to the below textbox name.
        activeBox = TextBoxValue2
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        ' This is voodoo magic.
        Application.Exit()
    End Sub

    ' I mean what kinda language doesn't have comment blocks?! Dear god!
    ' I like my approach because it saves me from validating non-numeric input from users who like to use their keyboard, and it looks like a calculator.

    ' Anything below this is just crap to handle the menu.
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        ' What to display when user clicks 
        MsgBox("You select one of the two input text boxes and the system will recognize which it is, and allow you to insert numbers into it using the numeric buttons available.", MsgBoxStyle.Information, "Help")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Closes the application
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' What to display when About is clicked
        MsgBox("Programmed, Designed, and Mastermined by Krishna Glick" & vbCrLf & "Not outsourced to a low wage Indian programmer", MsgBoxStyle.Information, "WhoDunnit")
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        ' Calls the add function
        ButtonMathAdd_Click(Nothing, Nothing)
    End Sub

    Private Sub SubtractToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubtractToolStripMenuItem.Click
        ' Calls the subtract function
        ButtonMathSubtract_Click(Nothing, Nothing)
    End Sub

    Private Sub MultiplyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplyToolStripMenuItem.Click
        ' Calls the multiply function
        ButtonMathMultiply_Click(Nothing, Nothing)
    End Sub

    Private Sub DivideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivideToolStripMenuItem.Click
        ' Calls the divide function
        ButtonMathDivide_Click(Nothing, Nothing)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ' Calls the delete function
        ButtonDeleteText_Click(Nothing, Nothing)
    End Sub

    Private Sub ClearActiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearActiveToolStripMenuItem.Click
        ' Calls the clear active function
        ButtonClearActive_Click(Nothing, Nothing)
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        ' Calls the clear all function
        ButtonClearAll_Click(Nothing, Nothing)
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub
End Class