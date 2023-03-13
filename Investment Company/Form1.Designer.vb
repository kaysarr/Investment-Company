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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddInvestor = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblData = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblTextname = New System.Windows.Forms.Label()
        Me.lblInvestorAmount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(433, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(332, 396)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenFileToolStripMenuItem.Text = "Import File"
        '
        'btnAddInvestor
        '
        Me.btnAddInvestor.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddInvestor.Location = New System.Drawing.Point(6, 29)
        Me.btnAddInvestor.Name = "btnAddInvestor"
        Me.btnAddInvestor.Size = New System.Drawing.Size(120, 50)
        Me.btnAddInvestor.TabIndex = 2
        Me.btnAddInvestor.Text = "Add Investor"
        Me.btnAddInvestor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Remove Investor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstData
        '
        Me.lstData.Font = New System.Drawing.Font("MS PGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 19
        Me.lstData.Location = New System.Drawing.Point(150, 85)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(257, 289)
        Me.lstData.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(368, 428)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(39, 13)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "Label1"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("MS PGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(150, 53)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(257, 26)
        Me.txtSearch.TabIndex = 5
        '
        'lblTextname
        '
        Me.lblTextname.AutoSize = True
        Me.lblTextname.Location = New System.Drawing.Point(147, 37)
        Me.lblTextname.Name = "lblTextname"
        Me.lblTextname.Size = New System.Drawing.Size(44, 13)
        Me.lblTextname.TabIndex = 6
        Me.lblTextname.Text = "Search:"
        '
        'lblInvestorAmount
        '
        Me.lblInvestorAmount.BackColor = System.Drawing.Color.Azure
        Me.lblInvestorAmount.Location = New System.Drawing.Point(147, 396)
        Me.lblInvestorAmount.Name = "lblInvestorAmount"
        Me.lblInvestorAmount.Size = New System.Drawing.Size(80, 23)
        Me.lblInvestorAmount.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Investors:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(433, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInvestorAmount)
        Me.Controls.Add(Me.lblTextname)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddInvestor)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddInvestor As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lstData As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblData As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblTextname As Label
    Friend WithEvents lblInvestorAmount As Label
    Friend WithEvents Label1 As Label
End Class
