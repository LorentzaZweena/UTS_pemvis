Imports System.Data
Module EmergencyData
    Public Reports As New DataTable()

    Public Sub InitializeData()

        If Reports.Columns.Count > 0 Then
            Return
        End If

        Reports.Columns.Add("ID", GetType(Integer))
        Reports.Columns.Add("Reporter", GetType(String))
        Reports.Columns.Add("IncidentType", GetType(String))
        Reports.Columns.Add("Location", GetType(String))
        Reports.Columns.Add("Description", GetType(String))
        Reports.Columns.Add("Priority", GetType(String))
        Reports.Columns.Add("IncidentTime", GetType(DateTime))
        Reports.Columns.Add("Status", GetType(String))

    End Sub

End Module
