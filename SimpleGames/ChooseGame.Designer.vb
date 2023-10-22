<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChooseGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChooseGame))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lucky9 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lottery = New System.Windows.Forms.Button()
        Me.CToss = New System.Windows.Forms.Button()
        Me.JEP = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 32.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Casino Games"
        '
        'Lucky9
        '
        Me.Lucky9.BackColor = System.Drawing.Color.Transparent
        Me.Lucky9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lucky9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Lucky9.FlatAppearance.BorderSize = 0
        Me.Lucky9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Lucky9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Lucky9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lucky9.Image = Global.SimpleGames.My.Resources.Resources.Lucky9
        Me.Lucky9.Location = New System.Drawing.Point(21, 101)
        Me.Lucky9.Name = "Lucky9"
        Me.Lucky9.Size = New System.Drawing.Size(100, 100)
        Me.Lucky9.TabIndex = 1
        Me.Lucky9.UseVisualStyleBackColor = False
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
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 37)
        Me.MenuStrip1.TabIndex = 5
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
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(83, 25)
        Me.ToolStripMenuItem2.Text = "Cash: ₱0"
        Me.ToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Lottery
        '
        Me.Lottery.BackColor = System.Drawing.Color.Transparent
        Me.Lottery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lottery.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Lottery.FlatAppearance.BorderSize = 0
        Me.Lottery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Lottery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Lottery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lottery.Image = Global.SimpleGames.My.Resources.Resources.Lottery
        Me.Lottery.Location = New System.Drawing.Point(127, 101)
        Me.Lottery.Name = "Lottery"
        Me.Lottery.Size = New System.Drawing.Size(100, 100)
        Me.Lottery.TabIndex = 6
        Me.Lottery.UseVisualStyleBackColor = False
        '
        'CToss
        '
        Me.CToss.BackColor = System.Drawing.Color.Transparent
        Me.CToss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CToss.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CToss.FlatAppearance.BorderSize = 0
        Me.CToss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.CToss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CToss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CToss.Image = Global.SimpleGames.My.Resources.Resources.Coin_Flip
        Me.CToss.Location = New System.Drawing.Point(233, 101)
        Me.CToss.Name = "CToss"
        Me.CToss.Size = New System.Drawing.Size(100, 100)
        Me.CToss.TabIndex = 7
        Me.CToss.UseVisualStyleBackColor = False
        '
        'JEP
        '
        Me.JEP.BackColor = System.Drawing.Color.Transparent
        Me.JEP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.JEP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.JEP.FlatAppearance.BorderSize = 0
        Me.JEP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.JEP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.JEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JEP.Image = Global.SimpleGames.My.Resources.Resources.JEP
        Me.JEP.Location = New System.Drawing.Point(339, 101)
        Me.JEP.Name = "JEP"
        Me.JEP.Size = New System.Drawing.Size(100, 100)
        Me.JEP.TabIndex = 8
        Me.JEP.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Lucky 9"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(138, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Lottery"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(234, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Coin Toss"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(336, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Jack En' Poy"
        '
        'ChooseGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SimpleGames.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(462, 258)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.JEP)
        Me.Controls.Add(Me.CToss)
        Me.Controls.Add(Me.Lottery)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Lucky9)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChooseGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Casino Games"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Lucky9 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lottery As Button
    Friend WithEvents CToss As Button
    Friend WithEvents JEP As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
