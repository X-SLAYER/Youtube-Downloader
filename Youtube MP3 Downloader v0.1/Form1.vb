Imports System.Net
Imports System.Text
Imports System.IO
Imports System.ComponentModel
Imports System
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Net.WebRequestMethods
Imports System.Linq

Public Class Form1

    '=========================================================================
    '=>YOUTUBE : >> SUBSCRIBE FOR MORE :https://www.youtube.com/c/XSLAYERTN  |
    '=>FACEBOOK : >> https://www.facebook.com/XSLAYER404/                    |
    '=>INSTAGRAM : >> https://www.instagram.com/ih3_b                        |
    '=>GITHUB : >> https://github.com/X-SLAYER                               |
    '=========================================================================

    Public Sub New()
        InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False
        txtLocal.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        CMType.SelectedIndex = 0
    End Sub

    Dim ITEM As New Dictionary(Of Req, ListViewItem)
    Dim LV As New Dictionary(Of WebClient, ListViewItem)
    Dim playlist As New List(Of String)

    Public Sub GET_INFO(ByVal URL As String)
        On Error Resume Next
        Dim itm As New ListViewItem
        itm.UseItemStyleForSubItems = False
        itm.Text = "Checking URL ..."
        itm.SubItems.Add("Getting Data...").ForeColor = Color.Blue
        itm.SubItems.Add("Getting Data...").ForeColor = Color.Blue
        itm.SubItems.Add(CMType.SelectedItem).BackColor = ColorTranslator.FromHtml("#FED6D4")
        itm.ImageIndex = CMType.SelectedIndex
        itm.Group = LvDownloads.Groups(GetGroup(CMType.SelectedIndex))
        Dim Info As New Info
        Info.ftype = "." & CMType.SelectedItem.ToString.ToLower()
        itm.Tag = Info
        LvDownloads.Items.Add(itm)
        Dim X As New Req
        X.ftype = CMType.SelectedItem.ToString.ToLower()
        If CMType.SelectedIndex = 0 Then
            X.quality = "128"
        Else
            X.quality = "1080"
        End If
        X.SetURI("https://y2mate.com/fr/analyze/ajax")
        AddHandler X.ConvertStart, AddressOf ConvertToStart
        AddHandler X.RequestComplete, AddressOf SearchComplete
        ITEM.Add(X, itm)
        X.Requ(URL)
    End Sub

    Private Sub ConvertToStart(sender As Object, e As String)
        Try
            LvDownloads.Items(ITEM(sender).Index).Text = ModifyName(Regex.Match(e, "data_vtitle = \\""(.*?)\\"";").Groups(1).Value)
            If sender.Errone Then
                LvDownloads.Items(ITEM(sender).Index).SubItems(1).ForeColor = Color.OrangeRed
                LvDownloads.Items(ITEM(sender).Index).SubItems(2).Text = "Can Not Process This Video ... Try It Again"
            Else
                LvDownloads.Items(ITEM(sender).Index).SubItems(1).ForeColor = Color.BlueViolet
                LvDownloads.Items(ITEM(sender).Index).SubItems(2).Text = "Converting ..."
            End If
      
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SearchComplete(sender As Object, e As String)
        Try
            If Not sender.Errone Then
                LvDownloads.Items(ITEM(sender).Index).Tag.DirectURL = Regex.Match(e, "<a href=\\""(.*?)\\""").Groups(1).Value
                Dim URI As String = LvDownloads.Items(ITEM(sender).Index).Tag.DirectURL.ToString.Replace("\", Nothing) & LvDownloads.Items(ITEM(sender).Index).Tag.ftype
                Dim Path As String = txtLocal.Text & "\" & ModifyName(LvDownloads.Items(ITEM(sender).Index).Text) & LvDownloads.Items(ITEM(sender).Index).Tag.ftype.ToString.ToLower()
                LvDownloads.Items(ITEM(sender).Index).SubItems(1).ForeColor = Color.Blue
                LvDownloads.Items(ITEM(sender).Index).SubItems(2).Text = "Downloading ..."
                Using X As New WebClient
                    AddHandler X.DownloadFileCompleted, AddressOf FINISHED
                    AddHandler X.DownloadProgressChanged, AddressOf Progress
                    X.DownloadFileTaskAsync(New Uri(URI), Path)
                    LV.Add(X, LvDownloads.Items(ITEM(sender).Index))
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Progress(sender As Object, e As DownloadProgressChangedEventArgs)
        On Error Resume Next
        LvDownloads.Items(LV(sender).Index).SubItems(1).Text = F(e.BytesReceived) & " / " & F(e.TotalBytesToReceive)
    End Sub
    Private Sub FINISHED(sender As Object, e As AsyncCompletedEventArgs)
        On Error Resume Next
        If e.Cancelled = True Then
            LvDownloads.Items(LV(sender).Index).SubItems(2).Text = "Cancelled..."
            LvDownloads.Items(LV(sender).Index).SubItems(1).ForeColor = Color.Purple
            LvDownloads.Items(LV(sender).Index).SubItems(2).ForeColor = Color.Purple
        ElseIf Not e.Error Is Nothing Then
            LvDownloads.Items(LV(sender).Index).SubItems(2).Text = e.Error.Message
            LvDownloads.Items(LV(sender).Index).SubItems(1).ForeColor = Color.Red
            LvDownloads.Items(LV(sender).Index).SubItems(2).ForeColor = Color.Red
        ElseIf Not e.UserState Is Nothing Then
            LvDownloads.Items(LV(sender).Index).SubItems(2).Text = "Successfully..."
            LvDownloads.Items(LV(sender).Index).SubItems(1).ForeColor = Color.Green
            LvDownloads.Items(LV(sender).Index).SubItems(2).ForeColor = Color.Green
        End If
    End Sub

    Public Sub START(ByVal str As String)
        Dim thread As New Thread(New ThreadStart(Sub() GET_INFO(str)))
        thread.Start()
    End Sub

#Region "Used Functions"

    Private Sub btnBrowser_Click(sender As Object, e As EventArgs) Handles btnBrowser.Click ' Browse Folder
        Dim I As New FolderBrowserDialog
        I.ShowNewFolderButton = True
        I.RootFolder = Environment.SpecialFolder.Desktop
        I.Description = "Save Audio File"
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLocal.Text = I.SelectedPath
        End If
    End Sub

    Private Function F(ByVal type As Double) As String 'File Size
        Dim types As String() = {"B", "KB", "MB", "GB"}
        Dim typees As Double = type
        Dim CSA As Integer = 0
        While typees >= 1024 AndAlso CSA + 1 < types.Length
            CSA += 1
            typees = typees / 1024
        End While
        Return [String].Format("{0:0.##} {1}", typees, types(CSA))
    End Function

    Private Function ModifyName(ByVal URL As String) As String 'Caracters That Windowse Cant Accepte Will Be Removed
        Return URL.Replace("\", Nothing).Replace("/", Nothing).Replace(":", Nothing).Replace("*", Nothing).Replace("?", Nothing).Replace("""", Nothing).Replace("<", Nothing).Replace(">", Nothing).Replace("|", Nothing)
    End Function

    Public Sub ExtractPlayList(ByVal ID As String)
        Try
            Using request As New xNet.HttpRequest
                request.Proxy = Nothing
                request.UserAgent = xNet.Http.ChromeUserAgent
                request.KeepAlive = True
                request.Cookies = New xNet.CookieDictionary(False)
                request.IgnoreProtocolErrors = True
                request.AllowAutoRedirect = False

                Dim response As String = request.Get("https://www.youtube.com/playlist?list=" & ID, Nothing).ToString()
                Dim SL As New List(Of String)
                For Each o As Match In New Regex("video-id=""(.*?)""").Matches(response)
                    If Not o.Groups(1).Value = "" Then
                        SL.Add("https://www.youtube.com/watch?v=" & o.Groups(1).Value)
                    End If
                Next
                playlist = SL.Distinct().ToList
                For Each Video In playlist
                    GET_INFO(Video)
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Pl.LinkColor = Color.Blue
        Pl.Text = "Click To Inset Playlist"
    End Sub

    Public Function GetGroup(ByVal Index As Integer) As String
        If Index = 0 Then
            Return "G2"
        Else
            Return "G1"
        End If
    End Function

#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not (txturl.Text = String.Empty) Then
            START(txturl.Text)
            txturl.Text = Nothing
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.youtube.com/c/XSLAYERTN")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Pl.LinkClicked
        Dim str As String = InputBox("Insert PlayList ID " & vbCrLf & "Exp:" & vbCrLf & "PLCyh6pZgFej_MBsk2W59CkMIRpVlZ6DfS", "Insert PlayList ID", "")
        If str = String.Empty Then
            Exit Sub
        End If
        Pl.LinkColor = Color.Green
        Pl.Text = "Getting PlayList Videos ..."
        Dim Tr As New Thread(New ThreadStart(Sub() ExtractPlayList(str)))
        Tr.Start()
    End Sub
End Class
