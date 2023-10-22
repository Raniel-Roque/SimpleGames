<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lucky9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lucky9))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Reset = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Pass = New System.Windows.Forms.Button()
        Me.Carat = New System.Windows.Forms.Button()
        Me.PlayerPic1 = New System.Windows.Forms.PictureBox()
        Me.PlayerPic2 = New System.Windows.Forms.PictureBox()
        Me.PlayerPic3 = New System.Windows.Forms.PictureBox()
        Me.ComPic3 = New System.Windows.Forms.PictureBox()
        Me.ComPic2 = New System.Windows.Forms.PictureBox()
        Me.ComPic1 = New System.Windows.Forms.PictureBox()
        Me.Draw = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerPic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerPic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComPic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComPic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComPic1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(707, 37)
        Me.MenuStrip1.TabIndex = 7
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
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(64, 25)
        Me.ToolStripMenuItem2.Text = "Cash: "
        Me.ToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SimpleGames.My.Resources.Resources.Table
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Reset)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.Pass)
        Me.Panel1.Controls.Add(Me.Carat)
        Me.Panel1.Controls.Add(Me.PlayerPic1)
        Me.Panel1.Controls.Add(Me.PlayerPic2)
        Me.Panel1.Controls.Add(Me.PlayerPic3)
        Me.Panel1.Controls.Add(Me.ComPic3)
        Me.Panel1.Controls.Add(Me.ComPic2)
        Me.Panel1.Controls.Add(Me.ComPic1)
        Me.Panel1.Controls.Add(Me.Draw)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 526)
        Me.Panel1.TabIndex = 21
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Reset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Reset.FlatAppearance.BorderSize = 3
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reset.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(477, 420)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(104, 39)
        Me.Reset.TabIndex = 26
        Me.Reset.Text = "RESET"
        Me.Reset.UseVisualStyleBackColor = False
        Me.Reset.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.SimpleGames.My.Resources.Resources.back_blue_basic_white
        Me.PictureBox7.Location = New System.Drawing.Point(123, 224)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(60, 84)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 25
        Me.PictureBox7.TabStop = False
        '
        'Pass
        '
        Me.Pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Pass.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Pass.FlatAppearance.BorderSize = 3
        Me.Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pass.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.Location = New System.Drawing.Point(366, 247)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(104, 39)
        Me.Pass.TabIndex = 19
        Me.Pass.Text = "PASS"
        Me.Pass.UseVisualStyleBackColor = False
        Me.Pass.Visible = False
        '
        'Carat
        '
        Me.Carat.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Carat.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Carat.FlatAppearance.BorderSize = 3
        Me.Carat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Carat.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Carat.Location = New System.Drawing.Point(224, 247)
        Me.Carat.Name = "Carat"
        Me.Carat.Size = New System.Drawing.Size(104, 39)
        Me.Carat.TabIndex = 20
        Me.Carat.Text = "CARAT"
        Me.Carat.UseVisualStyleBackColor = False
        Me.Carat.Visible = False
        '
        'PlayerPic1
        '
        Me.PlayerPic1.BackColor = System.Drawing.Color.Transparent
        Me.PlayerPic1.Image = CType(resources.GetObject("PlayerPic1.Image"), System.Drawing.Image)
        Me.PlayerPic1.Location = New System.Drawing.Point(224, 297)
        Me.PlayerPic1.Name = "PlayerPic1"
        Me.PlayerPic1.Size = New System.Drawing.Size(60, 84)
        Me.PlayerPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlayerPic1.TabIndex = 24
        Me.PlayerPic1.TabStop = False
        '
        'PlayerPic2
        '
        Me.PlayerPic2.BackColor = System.Drawing.Color.Transparent
        Me.PlayerPic2.Image = CType(resources.GetObject("PlayerPic2.Image"), System.Drawing.Image)
        Me.PlayerPic2.Location = New System.Drawing.Point(318, 297)
        Me.PlayerPic2.Name = "PlayerPic2"
        Me.PlayerPic2.Size = New System.Drawing.Size(60, 84)
        Me.PlayerPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlayerPic2.TabIndex = 23
        Me.PlayerPic2.TabStop = False
        '
        'PlayerPic3
        '
        Me.PlayerPic3.BackColor = System.Drawing.Color.Transparent
        Me.PlayerPic3.Image = CType(resources.GetObject("PlayerPic3.Image"), System.Drawing.Image)
        Me.PlayerPic3.Location = New System.Drawing.Point(410, 297)
        Me.PlayerPic3.Name = "PlayerPic3"
        Me.PlayerPic3.Size = New System.Drawing.Size(60, 84)
        Me.PlayerPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlayerPic3.TabIndex = 22
        Me.PlayerPic3.TabStop = False
        '
        'ComPic3
        '
        Me.ComPic3.BackColor = System.Drawing.Color.Transparent
        Me.ComPic3.Image = CType(resources.GetObject("ComPic3.Image"), System.Drawing.Image)
        Me.ComPic3.Location = New System.Drawing.Point(410, 148)
        Me.ComPic3.Name = "ComPic3"
        Me.ComPic3.Size = New System.Drawing.Size(60, 84)
        Me.ComPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ComPic3.TabIndex = 21
        Me.ComPic3.TabStop = False
        '
        'ComPic2
        '
        Me.ComPic2.BackColor = System.Drawing.Color.Transparent
        Me.ComPic2.Image = CType(resources.GetObject("ComPic2.Image"), System.Drawing.Image)
        Me.ComPic2.Location = New System.Drawing.Point(318, 148)
        Me.ComPic2.Name = "ComPic2"
        Me.ComPic2.Size = New System.Drawing.Size(60, 84)
        Me.ComPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ComPic2.TabIndex = 20
        Me.ComPic2.TabStop = False
        '
        'ComPic1
        '
        Me.ComPic1.BackColor = System.Drawing.Color.Transparent
        Me.ComPic1.Image = CType(resources.GetObject("ComPic1.Image"), System.Drawing.Image)
        Me.ComPic1.Location = New System.Drawing.Point(224, 148)
        Me.ComPic1.Name = "ComPic1"
        Me.ComPic1.Size = New System.Drawing.Size(60, 84)
        Me.ComPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ComPic1.TabIndex = 19
        Me.ComPic1.TabStop = False
        '
        'Draw
        '
        Me.Draw.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Draw.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Draw.FlatAppearance.BorderSize = 3
        Me.Draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Draw.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Draw.Location = New System.Drawing.Point(477, 420)
        Me.Draw.Name = "Draw"
        Me.Draw.Size = New System.Drawing.Size(104, 39)
        Me.Draw.TabIndex = 16
        Me.Draw.Text = "DRAW"
        Me.Draw.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(118, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 28)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "BET:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(193, 420)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(278, 39)
        Me.TextBox1.TabIndex = 18
        '
        'Result
        '
        '
        'Lucky9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(707, 412)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lucky9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lucky 9"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerPic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerPic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerPic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComPic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComPic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComPic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Draw As Button
    Friend WithEvents Pass As Button
    Friend WithEvents Carat As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComPic1 As PictureBox
    Friend WithEvents PlayerPic1 As PictureBox
    Friend WithEvents PlayerPic2 As PictureBox
    Friend WithEvents PlayerPic3 As PictureBox
    Friend WithEvents ComPic3 As PictureBox
    Friend WithEvents ComPic2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Result As Timer
    Friend WithEvents Reset As Button
End Class
