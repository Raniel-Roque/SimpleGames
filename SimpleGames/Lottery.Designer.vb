<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lottery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lottery))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Spin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Spinning = New System.Windows.Forms.Timer(Me.components)
        Me.Slot1 = New System.Windows.Forms.PictureBox()
        Me.Slot2 = New System.Windows.Forms.PictureBox()
        Me.Slot3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Slot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Help, Me.HomeToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6)
        Me.MenuStrip1.Size = New System.Drawing.Size(411, 37)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Help
        '
        Me.Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Help.Image = Global.SimpleGames.My.Resources.Resources._640px_Question_mark
        Me.Help.Name = "Help"
        Me.Help.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Help.Size = New System.Drawing.Size(28, 25)
        Me.Help.Text = "ToolStripMenuItem1"
        Me.Help.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
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
        'Spin
        '
        Me.Spin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Spin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Spin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Spin.FlatAppearance.BorderSize = 3
        Me.Spin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Spin.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spin.Location = New System.Drawing.Point(280, 249)
        Me.Spin.Name = "Spin"
        Me.Spin.Size = New System.Drawing.Size(104, 39)
        Me.Spin.TabIndex = 10
        Me.Spin.Text = "SPIN"
        Me.Spin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 28)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "BET:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(95, 249)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 39)
        Me.TextBox1.TabIndex = 15
        '
        'Spinning
        '
        Me.Spinning.Interval = 300
        '
        'Slot1
        '
        Me.Slot1.BackColor = System.Drawing.Color.White
        Me.Slot1.Image = CType(resources.GetObject("Slot1.Image"), System.Drawing.Image)
        Me.Slot1.Location = New System.Drawing.Point(55, 72)
        Me.Slot1.Name = "Slot1"
        Me.Slot1.Size = New System.Drawing.Size(100, 95)
        Me.Slot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Slot1.TabIndex = 13
        Me.Slot1.TabStop = False
        '
        'Slot2
        '
        Me.Slot2.BackColor = System.Drawing.Color.White
        Me.Slot2.Image = CType(resources.GetObject("Slot2.Image"), System.Drawing.Image)
        Me.Slot2.Location = New System.Drawing.Point(161, 72)
        Me.Slot2.Name = "Slot2"
        Me.Slot2.Size = New System.Drawing.Size(100, 95)
        Me.Slot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Slot2.TabIndex = 12
        Me.Slot2.TabStop = False
        '
        'Slot3
        '
        Me.Slot3.BackColor = System.Drawing.Color.White
        Me.Slot3.Image = CType(resources.GetObject("Slot3.Image"), System.Drawing.Image)
        Me.Slot3.Location = New System.Drawing.Point(267, 72)
        Me.Slot3.Name = "Slot3"
        Me.Slot3.Size = New System.Drawing.Size(100, 95)
        Me.Slot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Slot3.TabIndex = 9
        Me.Slot3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.SimpleGames.My.Resources.Resources.Lottery_Frame
        Me.PictureBox4.InitialImage = Nothing
        Me.PictureBox4.Location = New System.Drawing.Point(0, -32)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(413, 369)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Lottery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(411, 303)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Slot1)
        Me.Controls.Add(Me.Slot2)
        Me.Controls.Add(Me.Slot3)
        Me.Controls.Add(Me.Spin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox4)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lottery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lottery"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Slot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Spin As Button
    Friend WithEvents Slot3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Slot2 As PictureBox
    Friend WithEvents Slot1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Spinning As Timer
    Friend WithEvents Help As ToolStripMenuItem
End Class
