<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Video Files", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Audio Files", System.Windows.Forms.HorizontalAlignment.Left)
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.btnBrowser = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txturl = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Im = New System.Windows.Forms.ImageList(Me.components)
        Me.CMType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Pl = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LvDownloads = New Youtube_MP3_Downloader_v0._1.ListViewP2P()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLocal
        '
        Me.txtLocal.Location = New System.Drawing.Point(83, 310)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(404, 22)
        Me.txtLocal.TabIndex = 17
        '
        'btnBrowser
        '
        Me.btnBrowser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowser.ForeColor = System.Drawing.Color.Black
        Me.btnBrowser.Location = New System.Drawing.Point(493, 310)
        Me.btnBrowser.Name = "btnBrowser"
        Me.btnBrowser.Size = New System.Drawing.Size(91, 22)
        Me.btnBrowser.TabIndex = 16
        Me.btnBrowser.Text = "Browser"
        Me.btnBrowser.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(440, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 22)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Download"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txturl
        '
        Me.txturl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txturl.ForeColor = System.Drawing.Color.Black
        Me.txturl.Location = New System.Drawing.Point(7, 23)
        Me.txturl.Name = "txturl"
        Me.txturl.Size = New System.Drawing.Size(300, 22)
        Me.txturl.TabIndex = 13
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(139, 344)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(54, 14)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X-SLAYER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 14)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "SUBSCRIBE >> YOUTUBE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Local :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 311)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(475, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "CODED BY X-SLAYER"
        '
        'Im
        '
        Me.Im.ImageStream = CType(resources.GetObject("Im.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Im.TransparentColor = System.Drawing.Color.Transparent
        Me.Im.Images.SetKeyName(0, "m4a.png")
        Me.Im.Images.SetKeyName(1, "Movies-icon.png")
        '
        'CMType
        '
        Me.CMType.BackColor = System.Drawing.Color.White
        Me.CMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CMType.FormattingEnabled = True
        Me.CMType.Items.AddRange(New Object() {"MP3", "MP4"})
        Me.CMType.Location = New System.Drawing.Point(313, 23)
        Me.CMType.Name = "CMType"
        Me.CMType.Size = New System.Drawing.Size(121, 22)
        Me.CMType.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 14)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Name : "
        '
        'Pl
        '
        Me.Pl.AutoSize = True
        Me.Pl.Location = New System.Drawing.Point(47, 6)
        Me.Pl.Name = "Pl"
        Me.Pl.Size = New System.Drawing.Size(110, 14)
        Me.Pl.TabIndex = 26
        Me.Pl.TabStop = True
        Me.Pl.Text = "Click To Inset Playlist"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(310, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 14)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Format :"
        '
        'LvDownloads
        '
        Me.LvDownloads.AllowDrop = True
        Me.LvDownloads.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader1})
        Me.LvDownloads.FullRowSelect = True
        Me.LvDownloads.GridLines = True
        ListViewGroup1.Header = "Video Files"
        ListViewGroup1.Name = "G1"
        ListViewGroup2.Header = "Audio Files"
        ListViewGroup2.Name = "G2"
        Me.LvDownloads.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.LvDownloads.LargeImageList = Me.Im
        Me.LvDownloads.Location = New System.Drawing.Point(5, 51)
        Me.LvDownloads.Name = "LvDownloads"
        Me.LvDownloads.Size = New System.Drawing.Size(577, 252)
        Me.LvDownloads.SmallImageList = Me.Im
        Me.LvDownloads.TabIndex = 23
        Me.LvDownloads.UseCompatibleStateImageBehavior = False
        Me.LvDownloads.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Title"
        Me.ColumnHeader4.Width = 216
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Progress"
        Me.ColumnHeader5.Width = 133
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 112
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Format"
        Me.ColumnHeader1.Width = 110
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 368)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Pl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CMType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.btnBrowser)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txturl)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LvDownloads)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Youtube Downloader v0.3 | X-SLAYER"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLocal As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowser As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txturl As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LvDownloads As Youtube_MP3_Downloader_v0._1.ListViewP2P
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Im As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Pl As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
