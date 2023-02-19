Imports System.IO
Imports System.Threading

Public Class Form1

    Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Dim aray As String()
    Private Sub L1_DragDrop(sender As Object, e As DragEventArgs) Handles L1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            If Not BGWMain.IsBusy Then
                L1.Items.Clear()
                aray = e.Data.GetData(DataFormats.FileDrop)
                BGWMain.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub L1_DragEnter(sender As Object, e As DragEventArgs) Handles L1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub BGWMain_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWMain.DoWork
        For Each s As String In aray
            Dim T As New Thread(AddressOf Th) : T.Start(s)
        Next
    End Sub

    Private Sub BtnEcDc_Click(sender As Object, e As EventArgs) Handles BtnEcDc.Click
        If BGWMain.IsBusy Then Return
        If BtnEcDc.Text = "Encrypt" Then
            BtnEcDc.Text = "Decrypt"
        Else
            BtnEcDc.Text = "Encrypt"
        End If
    End Sub

    Private Sub Th(ByVal s As String)
        Try
            If BtnEcDc.Text = "Encrypt" Then
                File.WriteAllBytes(s, EnCryptGen2(File.ReadAllBytes(s)))
                L1.Items.Add(New FileInfo(s).Name & " (Encrypted By CyberAddict)")
            Else
                File.WriteAllBytes(s, DeCryptGen2(File.ReadAllBytes(s)))
                L1.Items.Add(New FileInfo(s).Name & " (Decrypted By CyberAddict)")
            End If
        Catch
            Try
                L1.Items.Add(New FileInfo(s).Name & " (Failed)")
            Catch : End Try
        End Try
        Try
            L1.SelectedIndex = L1.Items.Count - 1
        Catch : End Try
    End Sub


#Region "Fungsi"

    Private Function EnCryptGen2(ByVal input As Byte(), Optional ByVal key As String = "~{AITGen2}~", Optional ByVal EC As System.Security.Cryptography.RijndaelManaged = Nothing, Optional ByVal SHA256 As System.Security.Cryptography.SHA256Cng = Nothing) As Byte()
        If EC Is Nothing Then EC = Rij()
        If SHA256 Is Nothing Then SHA256 = Sha()
        Try
            EC.Key = SHA256.ComputeHash(Hasnya(key))
            EC.Mode = Security.Cryptography.CipherMode.ECB
            Return EC.CreateEncryptor.TransformFinalBlock(input, 0, input.Length)
        Catch : End Try
        Return Nothing
    End Function

    Private Function DeCryptGen2(ByVal input As Byte(), Optional ByVal key As String = "~{AITGen2}~", Optional ByVal DC As System.Security.Cryptography.RijndaelManaged = Nothing, Optional ByVal SHA256 As System.Security.Cryptography.SHA256Cng = Nothing) As Byte()
        If DC Is Nothing Then DC = Rij()
        If SHA256 Is Nothing Then SHA256 = Sha()
        Try
            DC.Key = SHA256.ComputeHash(Hasnya(key))
            DC.Mode = Security.Cryptography.CipherMode.ECB
            Return DC.CreateDecryptor.TransformFinalBlock(input, 0, input.Length)
        Catch : End Try
        Return Nothing
    End Function



    Private Function Rij() As System.Security.Cryptography.RijndaelManaged
        Return New System.Security.Cryptography.RijndaelManaged
    End Function

    Private Function Sha() As System.Security.Cryptography.SHA256Cng
        Return New System.Security.Cryptography.SHA256Cng
    End Function

    Private Function Hasnya(ByVal key As String) As Byte()
        Return System.Text.ASCIIEncoding.Unicode.GetBytes(key)
    End Function

#End Region

End Class
