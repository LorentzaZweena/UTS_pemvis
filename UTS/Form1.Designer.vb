<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        DashboardToolStripMenuItem = New ToolStripMenuItem()
        IncidentToolStripMenuItem = New ToolStripMenuItem()
        NewIncidentToolStripMenuItem = New ToolStripMenuItem()
        IncidentDatabaseToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        lblOperator = New ToolStripStatusLabel()
        lblClock = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DashboardToolStripMenuItem, IncidentToolStripMenuItem, ViewToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1178, 33)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DashboardToolStripMenuItem
        ' 
        DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        DashboardToolStripMenuItem.Size = New Size(116, 29)
        DashboardToolStripMenuItem.Text = "Dashboard"
        ' 
        ' IncidentToolStripMenuItem
        ' 
        IncidentToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewIncidentToolStripMenuItem, IncidentDatabaseToolStripMenuItem})
        IncidentToolStripMenuItem.Name = "IncidentToolStripMenuItem"
        IncidentToolStripMenuItem.Size = New Size(91, 29)
        IncidentToolStripMenuItem.Text = "Incident"
        ' 
        ' NewIncidentToolStripMenuItem
        ' 
        NewIncidentToolStripMenuItem.Name = "NewIncidentToolStripMenuItem"
        NewIncidentToolStripMenuItem.Size = New Size(270, 58)
        NewIncidentToolStripMenuItem.Text = "New Incident" + vbLf
        ' 
        ' IncidentDatabaseToolStripMenuItem
        ' 
        IncidentDatabaseToolStripMenuItem.Name = "IncidentDatabaseToolStripMenuItem"
        IncidentDatabaseToolStripMenuItem.Size = New Size(270, 58)
        IncidentDatabaseToolStripMenuItem.Text = "Incident Database"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(65, 29)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(65, 29)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblOperator, lblClock})
        StatusStrip1.Location = New Point(0, 612)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1178, 32)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblOperator
        ' 
        lblOperator.Name = "lblOperator"
        lblOperator.Size = New Size(103, 25)
        lblOperator.Text = "lblOperator"
        ' 
        ' lblClock
        ' 
        lblClock.Name = "lblClock"
        lblClock.Size = New Size(74, 25)
        lblClock.Text = "lblClock"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1178, 644)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Emergency Communication Center"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncidentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewIncidentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncidentDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblOperator As ToolStripStatusLabel
    Friend WithEvents lblClock As ToolStripStatusLabel

End Class
