Public Class IncidentForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtReporter.Text.Trim() = "" Then
            MessageBox.Show("Please enter reporter name.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            txtReporter.Focus()
            Exit Sub
        End If


        If cmbIncidentType.SelectedIndex = -1 Then
            MessageBox.Show("Please select incident type.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            cmbIncidentType.Focus()
            Exit Sub
        End If


        If txtLocation.Text.Trim() = "" Then
            MessageBox.Show("Please enter incident location.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            txtLocation.Focus()
            Exit Sub
        End If


        If txtDescription.Text.Trim() = "" Then
            MessageBox.Show("Please enter incident description.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            txtDescription.Focus()
            Exit Sub
        End If


        If Not radLow.Checked AndAlso
       Not radMedium.Checked AndAlso
       Not radHigh.Checked AndAlso
       Not radCritical.Checked Then

            MessageBox.Show("Please select priority level.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Exit Sub
        End If



        Dim priority As String = ""

        If radLow.Checked Then
            priority = "Low"
        ElseIf radMedium.Checked Then
            priority = "Medium"
        ElseIf radHigh.Checked Then
            priority = "High"
        ElseIf radCritical.Checked Then
            priority = "Critical"
        End If



        Dim newID As Integer = 1

        If Reports.Rows.Count > 0 Then
            newID = CInt(Reports.Compute("MAX(ID)", "")) + 1
        End If



        Reports.Rows.Add(
        newID,
        txtReporter.Text.Trim(),
        cmbIncidentType.Text,
        txtLocation.Text.Trim(),
        txtDescription.Text.Trim(),
        priority,
        dtpIncidentTime.Value,
        "Pending"
    )


        MessageBox.Show(
        "Emergency report submitted successfully!" &
        vbCrLf & vbCrLf &
        "Report ID: " & newID,
        "Report Submitted",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    )



        txtReporter.Clear()
        cmbIncidentType.SelectedIndex = -1
        txtLocation.Clear()
        txtDescription.Clear()

        radLow.Checked = False
        radMedium.Checked = False
        radHigh.Checked = False
        radCritical.Checked = False

        dtpIncidentTime.Value = DateTime.Now

        txtReporter.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtReporter.Clear()
        cmbIncidentType.SelectedIndex = -1
        txtLocation.Clear()
        txtDescription.Clear()

        radLow.Checked = False
        radMedium.Checked = False
        radHigh.Checked = False
        radCritical.Checked = False

        dtpIncidentTime.Value = DateTime.Now

        txtReporter.Focus()
    End Sub
End Class