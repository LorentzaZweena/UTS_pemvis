<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidentDatabaseForm
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
        dgvIncidents = New DataGridView()
        colID = New DataGridViewTextBoxColumn()
        colReporter = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colLocation = New DataGridViewTextBoxColumn()
        colPriority = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        btnRefresh = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        CType(dgvIncidents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(453, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(180, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "INCIDENT DATABASE"
        ' 
        ' dgvIncidents
        ' 
        dgvIncidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvIncidents.Columns.AddRange(New DataGridViewColumn() {colID, colReporter, colType, colLocation, colPriority, colStatus})
        dgvIncidents.Location = New Point(12, 63)
        dgvIncidents.Name = "dgvIncidents"
        dgvIncidents.RowHeadersWidth = 62
        dgvIncidents.Size = New Size(953, 375)
        dgvIncidents.TabIndex = 1
        ' 
        ' colID
        ' 
        colID.HeaderText = "ID"
        colID.MinimumWidth = 8
        colID.Name = "colID"
        colID.Width = 150
        ' 
        ' colReporter
        ' 
        colReporter.HeaderText = "Reporter"
        colReporter.MinimumWidth = 8
        colReporter.Name = "colReporter"
        colReporter.Width = 150
        ' 
        ' colType
        ' 
        colType.HeaderText = "Incident Type"
        colType.MinimumWidth = 8
        colType.Name = "colType"
        colType.Width = 150
        ' 
        ' colLocation
        ' 
        colLocation.HeaderText = "Location"
        colLocation.MinimumWidth = 8
        colLocation.Name = "colLocation"
        colLocation.Width = 150
        ' 
        ' colPriority
        ' 
        colPriority.HeaderText = "Priority"
        colPriority.MinimumWidth = 8
        colPriority.Name = "colPriority"
        colPriority.Width = 150
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 8
        colStatus.Name = "colStatus"
        colStatus.Width = 150
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(36, 464)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(176, 464)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(172, 34)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "UPDATE STATUS"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(371, 464)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 4
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' IncidentDatabaseForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(983, 567)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnRefresh)
        Controls.Add(dgvIncidents)
        Controls.Add(lblTitle)
        Name = "IncidentDatabaseForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Incident Database"
        CType(dgvIncidents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvIncidents As DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colReporter As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colLocation As DataGridViewTextBoxColumn
    Friend WithEvents colPriority As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class
