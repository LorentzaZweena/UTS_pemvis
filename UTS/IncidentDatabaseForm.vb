Public Class IncidentDatabaseForm
    Private Sub IncidentDatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIncidentData()
    End Sub

    Private Sub LoadIncidentData()

        dgvIncidents.Rows.Clear()

        For Each row As DataRow In Reports.Rows

            dgvIncidents.Rows.Add(
                row("ID"),
                row("Reporter"),
                row("IncidentType"),
                row("Location"),
                row("Priority"),
                row("Status")
            )

        Next

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadIncidentData()

        MessageBox.Show(
            "Incident database refreshed.",
            "Refresh",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub dgvIncidents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIncidents.CellContentClick

    End Sub
End Class