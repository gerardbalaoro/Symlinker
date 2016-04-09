<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Junction = New System.Windows.Forms.RadioButton()
        Me.HardLink = New System.Windows.Forms.RadioButton()
        Me.DirectoryLink = New System.Windows.Forms.RadioButton()
        Me.Symlink = New System.Windows.Forms.RadioButton()
        Me.LinkSource = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BrowseTarget = New System.Windows.Forms.Button()
        Me.BrowseLink = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkDestination = New System.Windows.Forms.TextBox()
        Me.CreateLink = New System.Windows.Forms.Button()
        Me.Info = New System.Windows.Forms.ToolTip(Me.components)
        Me.FileBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.LinkBrowse = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Junction)
        Me.GroupBox1.Controls.Add(Me.HardLink)
        Me.GroupBox1.Controls.Add(Me.DirectoryLink)
        Me.GroupBox1.Controls.Add(Me.Symlink)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Link Type"
        '
        'Junction
        '
        Me.Junction.AutoSize = True
        Me.Junction.Location = New System.Drawing.Point(128, 41)
        Me.Junction.Name = "Junction"
        Me.Junction.Size = New System.Drawing.Size(65, 17)
        Me.Junction.TabIndex = 3
        Me.Junction.TabStop = True
        Me.Junction.Text = "Junction"
        Me.Info.SetToolTip(Me.Junction, resources.GetString("Junction.ToolTip"))
        Me.Junction.UseVisualStyleBackColor = True
        '
        'HardLink
        '
        Me.HardLink.AutoSize = True
        Me.HardLink.Location = New System.Drawing.Point(6, 41)
        Me.HardLink.Name = "HardLink"
        Me.HardLink.Size = New System.Drawing.Size(71, 17)
        Me.HardLink.TabIndex = 2
        Me.HardLink.TabStop = True
        Me.HardLink.Text = "Hard Link"
        Me.Info.SetToolTip(Me.HardLink, resources.GetString("HardLink.ToolTip"))
        Me.HardLink.UseVisualStyleBackColor = True
        '
        'DirectoryLink
        '
        Me.DirectoryLink.AutoSize = True
        Me.DirectoryLink.Location = New System.Drawing.Point(128, 18)
        Me.DirectoryLink.Name = "DirectoryLink"
        Me.DirectoryLink.Size = New System.Drawing.Size(90, 17)
        Me.DirectoryLink.TabIndex = 1
        Me.DirectoryLink.TabStop = True
        Me.DirectoryLink.Text = "Directory Link"
        Me.Info.SetToolTip(Me.DirectoryLink, "Symbolic links can point to any file or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "folder either on the local computer or " &
        "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "using a SMB path to point at targets " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "over a network. They do not use any dis" &
        "k space.")
        Me.DirectoryLink.UseVisualStyleBackColor = True
        '
        'Symlink
        '
        Me.Symlink.AutoSize = True
        Me.Symlink.Location = New System.Drawing.Point(6, 18)
        Me.Symlink.Name = "Symlink"
        Me.Symlink.Size = New System.Drawing.Size(90, 17)
        Me.Symlink.TabIndex = 0
        Me.Symlink.TabStop = True
        Me.Symlink.Text = "Symbolic Link"
        Me.Info.SetToolTip(Me.Symlink, "Symbolic links can point to any file or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "folder either on the local computer or " &
        "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "using a SMB path to point at targets " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "over a network. They do not use any dis" &
        "k space.")
        Me.Symlink.UseVisualStyleBackColor = True
        '
        'LinkSource
        '
        Me.LinkSource.Location = New System.Drawing.Point(12, 105)
        Me.LinkSource.Name = "LinkSource"
        Me.LinkSource.Size = New System.Drawing.Size(269, 20)
        Me.LinkSource.TabIndex = 2
        Me.Info.SetToolTip(Me.LinkSource, "Select file to be linked")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Link Source"
        '
        'BrowseTarget
        '
        Me.BrowseTarget.Location = New System.Drawing.Point(287, 104)
        Me.BrowseTarget.Name = "BrowseTarget"
        Me.BrowseTarget.Size = New System.Drawing.Size(31, 23)
        Me.BrowseTarget.TabIndex = 4
        Me.BrowseTarget.Text = "..."
        Me.BrowseTarget.UseVisualStyleBackColor = True
        '
        'BrowseLink
        '
        Me.BrowseLink.Location = New System.Drawing.Point(287, 149)
        Me.BrowseLink.Name = "BrowseLink"
        Me.BrowseLink.Size = New System.Drawing.Size(31, 23)
        Me.BrowseLink.TabIndex = 7
        Me.BrowseLink.Text = "..."
        Me.BrowseLink.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Link Destination"
        '
        'LinkDestination
        '
        Me.LinkDestination.Location = New System.Drawing.Point(12, 150)
        Me.LinkDestination.Name = "LinkDestination"
        Me.LinkDestination.Size = New System.Drawing.Size(269, 20)
        Me.LinkDestination.TabIndex = 5
        Me.Info.SetToolTip(Me.LinkDestination, "Select the link destination")
        '
        'CreateLink
        '
        Me.CreateLink.Location = New System.Drawing.Point(200, 178)
        Me.CreateLink.Name = "CreateLink"
        Me.CreateLink.Size = New System.Drawing.Size(118, 35)
        Me.CreateLink.TabIndex = 9
        Me.CreateLink.Text = "Create Link"
        Me.CreateLink.UseVisualStyleBackColor = True
        '
        'Info
        '
        Me.Info.AutomaticDelay = 1000
        '
        'FileBrowse
        '
        Me.FileBrowse.Title = "Select File to Link"
        '
        'LinkBrowse
        '
        Me.LinkBrowse.Title = "Select Link Destination"
        '
        'FolderBrowse
        '
        Me.FolderBrowse.Description = "Select Folder to Link"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(16, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "© 2016 Gerard Balaoro"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 223)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CreateLink)
        Me.Controls.Add(Me.BrowseLink)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkDestination)
        Me.Controls.Add(Me.BrowseTarget)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkSource)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(346, 262)
        Me.MinimumSize = New System.Drawing.Size(346, 262)
        Me.Name = "Form1"
        Me.Text = "Symlinker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Junction As RadioButton
    Friend WithEvents HardLink As RadioButton
    Friend WithEvents DirectoryLink As RadioButton
    Friend WithEvents Symlink As RadioButton
    Friend WithEvents LinkSource As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BrowseTarget As Button
    Friend WithEvents BrowseLink As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkDestination As TextBox
    Friend WithEvents CreateLink As Button
    Friend WithEvents Info As ToolTip
    Friend WithEvents FileBrowse As OpenFileDialog
    Friend WithEvents LinkBrowse As SaveFileDialog
    Friend WithEvents FolderBrowse As FolderBrowserDialog
    Friend WithEvents Label4 As Label
End Class
