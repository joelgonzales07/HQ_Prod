Option Explicit Off
Public Class rpt_balancemasterlist
    Dim conn As HQ_Connection
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim rpt As New CrystalReport8
        CrystalReportViewer1.ReportSource = rpt
    End Sub

End Class