<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JEP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JEP))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Bet = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ComPaper = New System.Windows.Forms.Button()
        Me.ComScissor = New System.Windows.Forms.Button()
        Me.ComRock = New System.Windows.Forms.Button()
        Me.ComPic = New System.Windows.Forms.PictureBox()
        Me.PlayerPaper = New System.Windows.Forms.Button()
        Me.PlayerScissor = New System.Windows.Forms.Button()
        Me.PlayerPic = New System.Windows.Forms.PictureBox()
        Me.PlayerRock = New System.Windows.Forms.Button()
        Me.ComRandomizer = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerRandomizer = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerResultedLabel = New System.Windows.Forms.Label()
        Me.ComResultedLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6)
        Me.MenuStrip1.Size = New System.Drawing.Size(619, 37)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HomeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HomeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(28, 25)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShowShortcutKeys = False
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(60, 25)
        Me.ToolStripMenuItem2.Text = "Cash:"
        Me.ToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"COMPUTER", "PLAYER 2"})
        Me.ComboBox1.Location = New System.Drawing.Point(413, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 27)
        Me.ComboBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "PLAYER 1"
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Play.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play.Location = New System.Drawing.Point(255, 268)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(109, 50)
        Me.Play.TabIndex = 20
        Me.Play.Text = "PLAY"
        Me.Play.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(434, 273)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 39)
        Me.TextBox1.TabIndex = 22
        '
        'Bet
        '
        Me.Bet.AutoSize = True
        Me.Bet.BackColor = System.Drawing.Color.Transparent
        Me.Bet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bet.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bet.ForeColor = System.Drawing.Color.Black
        Me.Bet.Location = New System.Drawing.Point(365, 279)
        Me.Bet.Name = "Bet"
        Me.Bet.Size = New System.Drawing.Size(68, 28)
        Me.Bet.TabIndex = 21
        Me.Bet.Text = "BET:"
        '
        'Result
        '
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SimpleGames.My.Resources.Resources.Street_Fighter_VS_logo
        Me.PictureBox3.Location = New System.Drawing.Point(255, 112)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(109, 109)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'ComPaper
        '
        Me.ComPaper.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComPaper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComPaper.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ComPaper.FlatAppearance.BorderSize = 2
        Me.ComPaper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComPaper.Image = Global.SimpleGames.My.Resources.Resources.PaperL_Button
        Me.ComPaper.Location = New System.Drawing.Point(456, 263)
        Me.ComPaper.Name = "ComPaper"
        Me.ComPaper.Size = New System.Drawing.Size(60, 60)
        Me.ComPaper.TabIndex = 18
        Me.ComPaper.UseVisualStyleBackColor = False
        Me.ComPaper.Visible = False
        '
        'ComScissor
        '
        Me.ComScissor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ComScissor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComScissor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ComScissor.FlatAppearance.BorderSize = 2
        Me.ComScissor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ComScissor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComScissor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComScissor.Image = Global.SimpleGames.My.Resources.Resources.ScissorL_Button
        Me.ComScissor.Location = New System.Drawing.Point(390, 263)
        Me.ComScissor.Name = "ComScissor"
        Me.ComScissor.Size = New System.Drawing.Size(60, 60)
        Me.ComScissor.TabIndex = 17
        Me.ComScissor.UseVisualStyleBackColor = False
        Me.ComScissor.Visible = False
        '
        'ComRock
        '
        Me.ComRock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ComRock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComRock.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ComRock.FlatAppearance.BorderSize = 2
        Me.ComRock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ComRock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComRock.Image = Global.SimpleGames.My.Resources.Resources.RockL_Button
        Me.ComRock.Location = New System.Drawing.Point(522, 263)
        Me.ComRock.Name = "ComRock"
        Me.ComRock.Size = New System.Drawing.Size(60, 60)
        Me.ComRock.TabIndex = 16
        Me.ComRock.UseVisualStyleBackColor = False
        Me.ComRock.Visible = False
        '
        'ComPic
        '
        Me.ComPic.Image = Global.SimpleGames.My.Resources.Resources.HandUpL
        Me.ComPic.Location = New System.Drawing.Point(370, 75)
        Me.ComPic.Name = "ComPic"
        Me.ComPic.Size = New System.Drawing.Size(237, 182)
        Me.ComPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ComPic.TabIndex = 15
        Me.ComPic.TabStop = False
        '
        'PlayerPaper
        '
        Me.PlayerPaper.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PlayerPaper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayerPaper.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.PlayerPaper.FlatAppearance.BorderSize = 2
        Me.PlayerPaper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PlayerPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PlayerPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayerPaper.Image = Global.SimpleGames.My.Resources.Resources.PaperR_Button
        Me.PlayerPaper.Location = New System.Drawing.Point(95, 262)
        Me.PlayerPaper.Name = "PlayerPaper"
        Me.PlayerPaper.Size = New System.Drawing.Size(60, 60)
        Me.PlayerPaper.TabIndex = 14
        Me.PlayerPaper.UseVisualStyleBackColor = False
        Me.PlayerPaper.Visible = False
        '
        'PlayerScissor
        '
        Me.PlayerScissor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PlayerScissor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayerScissor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.PlayerScissor.FlatAppearance.BorderSize = 2
        Me.PlayerScissor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PlayerScissor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PlayerScissor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayerScissor.Image = Global.SimpleGames.My.Resources.Resources.ScissorR_Button
        Me.PlayerScissor.Location = New System.Drawing.Point(161, 262)
        Me.PlayerScissor.Name = "PlayerScissor"
        Me.PlayerScissor.Size = New System.Drawing.Size(60, 60)
        Me.PlayerScissor.TabIndex = 13
        Me.PlayerScissor.UseVisualStyleBackColor = False
        Me.PlayerScissor.Visible = False
        '
        'PlayerPic
        '
        Me.PlayerPic.Image = Global.SimpleGames.My.Resources.Resources.HandUpR
        Me.PlayerPic.Location = New System.Drawing.Point(12, 75)
        Me.PlayerPic.Name = "PlayerPic"
        Me.PlayerPic.Size = New System.Drawing.Size(237, 182)
        Me.PlayerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PlayerPic.TabIndex = 12
        Me.PlayerPic.TabStop = False
        '
        'PlayerRock
        '
        Me.PlayerRock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PlayerRock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayerRock.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.PlayerRock.FlatAppearance.BorderSize = 2
        Me.PlayerRock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PlayerRock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PlayerRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayerRock.Image = Global.SimpleGames.My.Resources.Resources.RockR_Button
        Me.PlayerRock.Location = New System.Drawing.Point(29, 263)
        Me.PlayerRock.Name = "PlayerRock"
        Me.PlayerRock.Size = New System.Drawing.Size(60, 60)
        Me.PlayerRock.TabIndex = 7
        Me.PlayerRock.UseVisualStyleBackColor = False
        Me.PlayerRock.Visible = False
        '
        'ComRandomizer
        '
        '
        'PlayerRandomizer
        '
        '
        'PlayerResultedLabel
        '
        Me.PlayerResultedLabel.AutoSize = True
        Me.PlayerResultedLabel.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerResultedLabel.Location = New System.Drawing.Point(73, 260)
        Me.PlayerResultedLabel.Name = "PlayerResultedLabel"
        Me.PlayerResultedLabel.Size = New System.Drawing.Size(98, 42)
        Me.PlayerResultedLabel.TabIndex = 23
        Me.PlayerResultedLabel.Text = "WIN"
        Me.PlayerResultedLabel.Visible = False
        '
        'ComResultedLabel
        '
        Me.ComResultedLabel.AutoSize = True
        Me.ComResultedLabel.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComResultedLabel.Location = New System.Drawing.Point(436, 260)
        Me.ComResultedLabel.Name = "ComResultedLabel"
        Me.ComResultedLabel.Size = New System.Drawing.Size(98, 42)
        Me.ComResultedLabel.TabIndex = 24
        Me.ComResultedLabel.Text = "WIN"
        Me.ComResultedLabel.Visible = False
        '
        'JEP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(619, 334)
        Me.Controls.Add(Me.ComResultedLabel)
        Me.Controls.Add(Me.PlayerResultedLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Bet)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ComPaper)
        Me.Controls.Add(Me.ComScissor)
        Me.Controls.Add(Me.ComRock)
        Me.Controls.Add(Me.ComPic)
        Me.Controls.Add(Me.PlayerPaper)
        Me.Controls.Add(Me.PlayerScissor)
        Me.Controls.Add(Me.PlayerPic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PlayerRock)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "JEP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jack En' Poy"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PlayerRock As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PlayerPic As PictureBox
    Friend WithEvents PlayerScissor As Button
    Friend WithEvents PlayerPaper As Button
    Friend WithEvents ComPic As PictureBox
    Friend WithEvents ComPaper As Button
    Friend WithEvents ComScissor As Button
    Friend WithEvents ComRock As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Play As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Bet As Label
    Friend WithEvents Result As Timer
    Friend WithEvents ComRandomizer As Timer
    Friend WithEvents PlayerRandomizer As Timer
    Friend WithEvents PlayerResultedLabel As Label
    Friend WithEvents ComResultedLabel As Label
End Class
