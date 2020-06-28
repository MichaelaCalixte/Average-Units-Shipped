Public Class frmAverageUnitsShipped
    'Declaring the variables that wll be used
    Dim unitAmount(6) As Integer
    Dim unitAverage As Double
    Dim unitCounter As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resetting/Clearing teh entries for the textboxes as well as the labels
        txtEnterUnits.Clear()
        txtDisplayData.Clear()
        lblDays.Text = " "
        lblDays.Text = "Day 1"
        txtEnterUnits.Focus()

    End Sub


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If IsNumeric(Me.txtEnterUnits.Text) Then
            'Validating that the user input are integers
            If Integer.TryParse(txtEnterUnits.Text, unitAmount(unitCounter)) Then
                'use vbCrfl so that you can go onto the next line and continue counting the days
                txtDisplayData.Text += txtEnterUnits.Text + vbCrLf
                txtEnterUnits.Clear() 'clear the textbox so that another value can be entered
                unitCounter += 1 '1 is added onto the days
                lblDays.Text = "Day: " + Convert.ToString(unitCounter + 1) 'to display the day and the number
            Else
                MsgBox("Please enter a whole number for units")
                txtEnterUnits.Focus()

            End If
        Else
            MsgBox("Please enter a numeric Value")
        End If
        'PROCESSING
        'using if to dispaly Day 7 in the days label when the user has inputed 7 units for 7 days
        If unitCounter = 7 Then
            lblDays.Text = "Day: 7"
            btnEnter.Enabled = False
            txtEnterUnits.Enabled = False
        End If
        unitAverage = unitAmount.Average
        'OUTPUT
        lblResults.Text = "Average per day: " + Convert.ToString(Math.Round((unitAverage), 2))
    End Sub

    Private Sub frmAverageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class





