<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        pnlTotal = New Panel()
        lblTotal = New Label()
        lblTotalTitle = New Label()
        pnlUrgent = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        pnlProcessing = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        pnlResolved = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        pnlTotal.SuspendLayout()
        pnlUrgent.SuspendLayout()
        pnlProcessing.SuspendLayout()
        pnlResolved.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Yu Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(239, 23)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(400, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "EMERGENCY DASHBOARD"
        lblTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pnlTotal
        ' 
        pnlTotal.BorderStyle = BorderStyle.FixedSingle
        pnlTotal.Controls.Add(lblTotal)
        pnlTotal.Controls.Add(lblTotalTitle)
        pnlTotal.Location = New Point(29, 86)
        pnlTotal.Name = "pnlTotal"
        pnlTotal.Size = New Size(350, 130)
        pnlTotal.TabIndex = 1
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(149, 59)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(32, 25)
        lblTotal.TabIndex = 1
        lblTotal.Text = "12"
        ' 
        ' lblTotalTitle
        ' 
        lblTotalTitle.AutoSize = True
        lblTotalTitle.Location = New Point(102, 17)
        lblTotalTitle.Name = "lblTotalTitle"
        lblTotalTitle.Size = New Size(139, 25)
        lblTotalTitle.TabIndex = 0
        lblTotalTitle.Text = "TOTAL REPORTS"
        ' 
        ' pnlUrgent
        ' 
        pnlUrgent.Controls.Add(Label1)
        pnlUrgent.Controls.Add(Label2)
        pnlUrgent.Location = New Point(397, 86)
        pnlUrgent.Name = "pnlUrgent"
        pnlUrgent.Size = New Size(350, 130)
        pnlUrgent.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(163, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(22, 25)
        Label1.TabIndex = 1
        Label1.Text = "3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(102, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 25)
        Label2.TabIndex = 0
        Label2.Text = "URGENT REPORTS"
        ' 
        ' pnlProcessing
        ' 
        pnlProcessing.Controls.Add(Label3)
        pnlProcessing.Controls.Add(Label4)
        pnlProcessing.Location = New Point(29, 245)
        pnlProcessing.Name = "pnlProcessing"
        pnlProcessing.Size = New Size(350, 130)
        pnlProcessing.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(159, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(22, 25)
        Label3.TabIndex = 1
        Label3.Text = "4"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(115, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 25)
        Label4.TabIndex = 0
        Label4.Text = "PROCESSING"
        ' 
        ' pnlResolved
        ' 
        pnlResolved.Controls.Add(Label6)
        pnlResolved.Controls.Add(Label5)
        pnlResolved.Location = New Point(397, 235)
        pnlResolved.Name = "pnlResolved"
        pnlResolved.Size = New Size(350, 140)
        pnlResolved.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(129, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 25)
        Label5.TabIndex = 0
        Label5.Text = "RESOLVED"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(162, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(22, 25)
        Label6.TabIndex = 1
        Label6.Text = "5"
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(878, 494)
        Controls.Add(pnlResolved)
        Controls.Add(pnlProcessing)
        Controls.Add(pnlUrgent)
        Controls.Add(pnlTotal)
        Controls.Add(lblTitle)
        Name = "DashboardForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Emergency Dashboard"
        pnlTotal.ResumeLayout(False)
        pnlTotal.PerformLayout()
        pnlUrgent.ResumeLayout(False)
        pnlUrgent.PerformLayout()
        pnlProcessing.ResumeLayout(False)
        pnlProcessing.PerformLayout()
        pnlResolved.ResumeLayout(False)
        pnlResolved.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlTotal As Panel
    Friend WithEvents lblTotalTitle As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents pnlUrgent As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlProcessing As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlResolved As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
