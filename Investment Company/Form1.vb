Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim lines As String
        Dim values As String
        Dim filedata As String

        lstData.Items.Clear()

        Try
            If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
                lblData.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox("Failed.")
        End Try

        Dim filepath As String = OpenFileDialog1.FileName

        For Each line As String In File.ReadAllLines(filepath)
            lstData.Items.Add(line)
        Next


        lblInvestorAmount.Text = lstData.Items.Count.ToString() / 3

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblData.Hide()


    End Sub

    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (lstData.SelectedIndex > -1) Then
            lstData.Items.RemoveAt(lstData.SelectedIndex + 2)
            lstData.Items.RemoveAt(lstData.SelectedIndex + 1)
            lstData.Items.RemoveAt(lstData.SelectedIndex)
        End If

        lblInvestorAmount.Text = lstData.Items.Count.ToString() / 3

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim intName As Integer = lstData.FindString(txtSearch.Text)
        lstData.SelectedIndex = intName
        If txtSearch.Text = "" Then
            lstData.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnAddInvestor_Click(sender As Object, e As EventArgs) Handles btnAddInvestor.Click
        lblInvestorAmount.Text = lstData.Items.Count.ToString() / 3
    End Sub

    Private Sub lstData_SystemColorsChanged(sender As Object, e As EventArgs) Handles lstData.SystemColorsChanged

    End Sub
End Class
