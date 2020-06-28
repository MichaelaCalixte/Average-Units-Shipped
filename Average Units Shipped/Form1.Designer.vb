<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtEnterUnits = New System.Windows.Forms.TextBox()
        Me.tpAverageUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDisplayData = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(106, 25)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(57, 17)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "Units:"
        '
        'lblDays
        '
        Me.lblDays.Location = New System.Drawing.Point(299, 26)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(84, 20)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "Day:"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(61, 353)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(84, 30)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.tpAverageUnitsShipped.SetToolTip(Me.btnEnter, "Click here to display results")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(191, 353)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 30)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.tpAverageUnitsShipped.SetToolTip(Me.btnReset, "Clic here to clear data")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(321, 353)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.tpAverageUnitsShipped.SetToolTip(Me.btnExit, "Click here to exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.SystemColors.Control
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResults.Location = New System.Drawing.Point(91, 309)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(316, 35)
        Me.lblResults.TabIndex = 6
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEnterUnits
        '
        Me.txtEnterUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEnterUnits.Location = New System.Drawing.Point(191, 23)
        Me.txtEnterUnits.Name = "txtEnterUnits"
        Me.txtEnterUnits.Size = New System.Drawing.Size(87, 20)
        Me.txtEnterUnits.TabIndex = 1
        Me.tpAverageUnitsShipped.SetToolTip(Me.txtEnterUnits, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter Units" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtDisplayData
        '
        Me.txtDisplayData.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDisplayData.Location = New System.Drawing.Point(61, 68)
        Me.txtDisplayData.Multiline = True
        Me.txtDisplayData.Name = "txtDisplayData"
        Me.txtDisplayData.ReadOnly = True
        Me.txtDisplayData.Size = New System.Drawing.Size(361, 226)
        Me.txtDisplayData.TabIndex = 7
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(520, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDisplayData)
        Me.Controls.Add(Me.txtEnterUnits)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblUnits)
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResults As Label
    Friend WithEvents txtEnterUnits As TextBox
    Friend WithEvents tpAverageUnitsShipped As ToolTip
    Friend WithEvents txtDisplayData As TextBox
End Class
