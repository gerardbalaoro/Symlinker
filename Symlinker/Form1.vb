Imports System.IO
Imports System.Security.Principal

Public Class Form1

    Dim Link, Target, Type, FinalArg, Results, TypeFull As String

    Private Sub BrowseLink_Click(sender As Object, e As EventArgs) Handles BrowseLink.Click
        If LinkBrowse.ShowDialog = DialogResult.OK Then
            LinkDestination.Text = LinkBrowse.FileName
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated = False Then
            MsgBox("Application requires administrative" _
                & vbNewLine & "rights to run properly." _
                & vbNewLine & "Please run as administrator.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Dim LogResults = My.Computer.FileSystem.SpecialDirectories.Temp & "\Symlinker.txt"

    Private Sub ClearFields()
        Link = Nothing
        Target = Nothing
        LinkSource.Text = Nothing
        LinkDestination.Text = Nothing
    End Sub

    Private Sub CreateLink_Click(sender As Object, e As EventArgs) Handles CreateLink.Click
        If CheckValidity() Then
            Try
                MakeLink()
            Catch ex As Exception
                MsgBox(" Exception found: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            ClearFields()
        Else
            MsgBox("Invalid Entry." & vbNewLine & "Either selected item does not exist or link destination exists.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function CheckValidity() As Boolean
        Dim crit1, crit2, crit3 As Boolean
        crit1 = False
        crit2 = False
        crit3 = False
        If LinkSource.Text <> Nothing And LinkDestination.Text <> Nothing Then crit1 = True
        If File.Exists(LinkSource.Text) Or Directory.Exists(LinkSource.Text) = True Then crit2 = True
        If File.Exists(LinkDestination.Text) = False Or Directory.Exists(LinkDestination.Text) = False Then crit3 = True
        If crit1 = True And crit2 = True And crit3 = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub MakeLink()
        Target = LinkSource.Text
        Link = LinkDestination.Text
        If Symlink.Checked Then
            Type = Nothing
        ElseIf HardLink.Checked
            Type = "/H"
        ElseIf DirectoryLink.Checked
            Type = "/D"
        ElseIf Junction.Checked
            Type = "/J"
        Else
            Type = Nothing
        End If
        FinalArg = "mklink " & Type & " """ & Link & """ """ & Target & """"
        For Each type As RadioButton In GroupBox1.Controls
            If type.Checked Then
                TypeFull = type.Text
            End If
        Next
        Dim CMDThread As New Threading.Thread(AddressOf CMDAutomate)
        CMDThread.Start()
    End Sub

    Private Sub BrowseTarget_Click(sender As Object, e As EventArgs) Handles BrowseTarget.Click
        If Junction.Checked Or DirectoryLink.Checked Then
            If FolderBrowse.ShowDialog = DialogResult.OK Then
                LinkSource.Text = FolderBrowse.SelectedPath
            End If
        Else
            If FileBrowse.ShowDialog = DialogResult.OK Then
                LinkSource.Text = Path.GetFullPath(FileBrowse.FileName)
            End If
        End If
    End Sub

    Private Sub CMDAutomate()
        Dim myprocess As New Process
        Dim StartInfo As New System.Diagnostics.ProcessStartInfo
        StartInfo.FileName = "cmd.exe"
        StartInfo.Arguments = "/c " & FinalArg & " > " & LogResults
        StartInfo.RedirectStandardInput = True
        StartInfo.RedirectStandardOutput = True
        StartInfo.RedirectStandardError = True
        StartInfo.UseShellExecute = False
        StartInfo.CreateNoWindow = True
        myprocess.StartInfo = StartInfo
        myprocess.Start()
        Dim SR As System.IO.StreamReader = myprocess.StandardOutput
        Dim SW As System.IO.StreamWriter = myprocess.StandardInput
        Dim SE As IO.StreamReader = myprocess.StandardError
        If SE.ReadToEnd <> Nothing AndAlso SE.ReadToEnd.Contains("a") Then MsgBox(SE.ReadToEnd, MsgBoxStyle.Critical)
        Dim output = File.ReadAllText(LogResults)
        If output <> Nothing AndAlso output.Contains("a") Then MsgBox(output.ToString)
        SR.Close()
        SW.Close()
        SE.Close()
    End Sub


End Class
