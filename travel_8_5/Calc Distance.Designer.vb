<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calcForm
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
        Me.lblDepart = New System.Windows.Forms.Label()
        Me.lblDest = New System.Windows.Forms.Label()
        Me.ComboBoxDepart = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDest = New System.Windows.Forms.ComboBox()
        Me.btnLookUp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDepart
        '
        Me.lblDepart.AutoSize = True
        Me.lblDepart.Location = New System.Drawing.Point(26, 36)
        Me.lblDepart.Name = "lblDepart"
        Me.lblDepart.Size = New System.Drawing.Size(54, 13)
        Me.lblDepart.TabIndex = 0
        Me.lblDepart.Text = "Departure"
        '
        'lblDest
        '
        Me.lblDest.AutoSize = True
        Me.lblDest.Location = New System.Drawing.Point(212, 36)
        Me.lblDest.Name = "lblDest"
        Me.lblDest.Size = New System.Drawing.Size(60, 13)
        Me.lblDest.TabIndex = 1
        Me.lblDest.Text = "Destination"
        '
        'ComboBoxDepart
        '
        Me.ComboBoxDepart.FormattingEnabled = True
        Me.ComboBoxDepart.Items.AddRange(New Object() {"Boston", "Chicago", "Dallas", "Las Vegas", "Los Angeles", "Miami", "New Orleans", "Toronto", "Vancouver", "Washington DC"})
        Me.ComboBoxDepart.Location = New System.Drawing.Point(29, 68)
        Me.ComboBoxDepart.Name = "ComboBoxDepart"
        Me.ComboBoxDepart.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDepart.TabIndex = 2
        '
        'ComboBoxDest
        '
        Me.ComboBoxDest.FormattingEnabled = True
        Me.ComboBoxDest.Items.AddRange(New Object() {"Boston", "Chicago", "Dallas", "Las Vegas", "Los Angeles", "Miami", "New Orleans", "Toronto", "Vancouver", "Washington DC"})
        Me.ComboBoxDest.Location = New System.Drawing.Point(206, 68)
        Me.ComboBoxDest.Name = "ComboBoxDest"
        Me.ComboBoxDest.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDest.TabIndex = 3
        '
        'btnLookUp
        '
        Me.btnLookUp.Location = New System.Drawing.Point(29, 168)
        Me.btnLookUp.Name = "btnLookUp"
        Me.btnLookUp.Size = New System.Drawing.Size(75, 23)
        Me.btnLookUp.TabIndex = 4
        Me.btnLookUp.Text = "Look Up"
        Me.btnLookUp.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(29, 217)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(172, 168)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 6
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Location = New System.Drawing.Point(172, 144)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(49, 13)
        Me.lblDistance.TabIndex = 7
        Me.lblDistance.Text = "Distance"
        '
        'calcForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 277)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLookUp)
        Me.Controls.Add(Me.ComboBoxDest)
        Me.Controls.Add(Me.ComboBoxDepart)
        Me.Controls.Add(Me.lblDest)
        Me.Controls.Add(Me.lblDepart)
        Me.Name = "calcForm"
        Me.Text = "Calc Distance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDepart As System.Windows.Forms.Label
    Friend WithEvents lblDest As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDepart As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDest As System.Windows.Forms.ComboBox
    Friend WithEvents btnLookUp As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblDistance As System.Windows.Forms.Label

End Class
