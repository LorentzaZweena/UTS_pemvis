Public Class MainForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim dashboard As New DashboardForm()

        dashboard.MdiParent = Me
        dashboard.Show()
    End Sub

    Private Sub IncidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidentToolStripMenuItem.Click

    End Sub

    Private Sub NewIncidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewIncidentToolStripMenuItem.Click
        Dim incident As New IncidentForm()

        incident.MdiParent = Me
        incident.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeData()
    End Sub

    Private Sub IncidentDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidentDatabaseToolStripMenuItem.Click
        Dim database As New IncidentDatabaseForm()

        database.MdiParent = Me
        database.Show()
    End Sub
End Class
