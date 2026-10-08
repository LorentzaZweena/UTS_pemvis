<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidentForm
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
        lblTitle = New Label()
        lblReporter = New Label()
        txtReporter = New TextBox()
        lblType = New Label()
        cmbIncidentType = New ComboBox()
        lblLocation = New Label()
        txtLocation = New TextBox()
        lblDescription = New Label()
        txtDescription = New TextBox()
        lblPriority = New Label()
        radLow = New RadioButton()
        radMedium = New RadioButton()
        radHigh = New RadioButton()
        radCritical = New RadioButton()
        dtpIncidentTime = New DateTimePicker()
        Label1 = New Label()
        btnSubmit = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(282, 23)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(263, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "REPORT EMERGENCY INCIDENT"
        ' 
        ' lblReporter
        ' 
        lblReporter.AutoSize = True
        lblReporter.Location = New Point(39, 76)
        lblReporter.Name = "lblReporter"
        lblReporter.Size = New Size(132, 25)
        lblReporter.TabIndex = 1
        lblReporter.Text = "Reporter Name"
        ' 
        ' txtReporter
        ' 
        txtReporter.Location = New Point(201, 76)
        txtReporter.Name = "txtReporter"
        txtReporter.Size = New Size(269, 31)
        txtReporter.TabIndex = 2
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Location = New Point(39, 129)
        lblType.Name = "lblType"
        lblType.Size = New Size(117, 25)
        lblType.TabIndex = 3
        lblType.Text = "Incident Type"
        ' 
        ' cmbIncidentType
        ' 
        cmbIncidentType.FormattingEnabled = True
        cmbIncidentType.Items.AddRange(New Object() {"Fire", "Medical Emergency", "Accident", "Missing Person", "Natural Disaster", "Security Threat", "Other"})
        cmbIncidentType.Location = New Point(162, 129)
        cmbIncidentType.Name = "cmbIncidentType"
        cmbIncidentType.Size = New Size(308, 33)
        cmbIncidentType.TabIndex = 4
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Location = New Point(39, 187)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(79, 25)
        lblLocation.TabIndex = 5
        lblLocation.Text = "Location"
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(137, 187)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(333, 31)
        txtLocation.TabIndex = 6
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(39, 241)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(102, 25)
        lblDescription.TabIndex = 7
        lblDescription.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(147, 241)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(323, 31)
        txtDescription.TabIndex = 8
        ' 
        ' lblPriority
        ' 
        lblPriority.AutoSize = True
        lblPriority.Location = New Point(508, 76)
        lblPriority.Name = "lblPriority"
        lblPriority.Size = New Size(112, 25)
        lblPriority.TabIndex = 9
        lblPriority.Text = "Priority Level"
        ' 
        ' radLow
        ' 
        radLow.AutoSize = True
        radLow.Location = New Point(508, 113)
        radLow.Name = "radLow"
        radLow.Size = New Size(69, 29)
        radLow.TabIndex = 10
        radLow.TabStop = True
        radLow.Text = "Low"
        radLow.UseVisualStyleBackColor = True
        ' 
        ' radMedium
        ' 
        radMedium.AutoSize = True
        radMedium.Location = New Point(508, 158)
        radMedium.Name = "radMedium"
        radMedium.Size = New Size(103, 29)
        radMedium.TabIndex = 11
        radMedium.TabStop = True
        radMedium.Text = "Medium"
        radMedium.UseVisualStyleBackColor = True
        ' 
        ' radHigh
        ' 
        radHigh.AutoSize = True
        radHigh.Location = New Point(508, 207)
        radHigh.Name = "radHigh"
        radHigh.Size = New Size(75, 29)
        radHigh.TabIndex = 12
        radHigh.TabStop = True
        radHigh.Text = "High"
        radHigh.UseVisualStyleBackColor = True
        ' 
        ' radCritical
        ' 
        radCritical.AutoSize = True
        radCritical.Location = New Point(508, 252)
        radCritical.Name = "radCritical"
        radCritical.Size = New Size(89, 29)
        radCritical.TabIndex = 13
        radCritical.TabStop = True
        radCritical.Text = "Critical"
        radCritical.UseVisualStyleBackColor = True
        ' 
        ' dtpIncidentTime
        ' 
        dtpIncidentTime.Location = New Point(210, 302)
        dtpIncidentTime.Name = "dtpIncidentTime"
        dtpIncidentTime.Size = New Size(300, 31)
        dtpIncidentTime.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 308)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 25)
        Label1.TabIndex = 15
        Label1.Text = "Incident Date & Time"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(39, 365)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(177, 34)
        btnSubmit.TabIndex = 16
        btnSubmit.Text = "SUBMIT REPORT"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(232, 365)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 17
        btnReset.Text = "RESET"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' IncidentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnSubmit)
        Controls.Add(Label1)
        Controls.Add(dtpIncidentTime)
        Controls.Add(radCritical)
        Controls.Add(radHigh)
        Controls.Add(radMedium)
        Controls.Add(radLow)
        Controls.Add(lblPriority)
        Controls.Add(txtDescription)
        Controls.Add(lblDescription)
        Controls.Add(txtLocation)
        Controls.Add(lblLocation)
        Controls.Add(cmbIncidentType)
        Controls.Add(lblType)
        Controls.Add(txtReporter)
        Controls.Add(lblReporter)
        Controls.Add(lblTitle)
        Name = "IncidentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Report Emergency Incident"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblReporter As Label
    Friend WithEvents txtReporter As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents cmbIncidentType As ComboBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblPriority As Label
    Friend WithEvents radLow As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radHigh As RadioButton
    Friend WithEvents radCritical As RadioButton
    Friend WithEvents dtpIncidentTime As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReset As Button
End Class
