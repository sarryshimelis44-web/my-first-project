<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnRock = New Button()
        btnPaper = New Button()
        btnScissors = New Button()
        btnLizard = New Button()
        btnSpock = New Button()
        Label1 = New Label()
        lblComputer = New Label()
        lblDraw = New Label()
        lblResult = New Label()
        lblMostUsed = New Label()
        lblPlayer = New Label()
        lstHistory = New ListBox()
        btnExit = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' btnRock
        ' 
        btnRock.Location = New Point(12, 355)
        btnRock.Name = "btnRock"
        btnRock.Size = New Size(94, 29)
        btnRock.TabIndex = 0
        btnRock.Text = "Rock"
        btnRock.UseVisualStyleBackColor = True
        ' 
        ' btnPaper
        ' 
        btnPaper.Location = New Point(157, 355)
        btnPaper.Name = "btnPaper"
        btnPaper.Size = New Size(94, 29)
        btnPaper.TabIndex = 0
        btnPaper.Text = "Paper"
        btnPaper.UseVisualStyleBackColor = True
        ' 
        ' btnScissors
        ' 
        btnScissors.Location = New Point(294, 355)
        btnScissors.Name = "btnScissors"
        btnScissors.Size = New Size(94, 29)
        btnScissors.TabIndex = 0
        btnScissors.Text = "Scissors"
        btnScissors.UseVisualStyleBackColor = True
        ' 
        ' btnLizard
        ' 
        btnLizard.Location = New Point(444, 355)
        btnLizard.Name = "btnLizard"
        btnLizard.Size = New Size(94, 29)
        btnLizard.TabIndex = 0
        btnLizard.Text = "Lizard"
        btnLizard.UseVisualStyleBackColor = True
        ' 
        ' btnSpock
        ' 
        btnSpock.Location = New Point(601, 355)
        btnSpock.Name = "btnSpock"
        btnSpock.Size = New Size(94, 29)
        btnSpock.TabIndex = 0
        btnSpock.Text = "Spock"
        btnSpock.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 1
        ' 
        ' lblComputer
        ' 
        lblComputer.AutoSize = True
        lblComputer.Location = New Point(12, 110)
        lblComputer.Name = "lblComputer"
        lblComputer.Size = New Size(100, 20)
        lblComputer.TabIndex = 1
        lblComputer.Text = """computer: 0"""
        ' 
        ' lblDraw
        ' 
        lblDraw.AutoSize = True
        lblDraw.Location = New Point(12, 155)
        lblDraw.Name = "lblDraw"
        lblDraw.Size = New Size(71, 20)
        lblDraw.TabIndex = 1
        lblDraw.Text = """Draw: 0"""
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(12, 201)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(172, 20)
        lblResult.TabIndex = 1
        lblResult.Text = """Result will appear here"""
        ' 
        ' lblMostUsed
        ' 
        lblMostUsed.AutoSize = True
        lblMostUsed.Location = New Point(12, 239)
        lblMostUsed.Name = "lblMostUsed"
        lblMostUsed.Size = New Size(132, 20)
        lblMostUsed.TabIndex = 1
        lblMostUsed.Text = """Most used: None"""
        ' 
        ' lblPlayer
        ' 
        lblPlayer.AutoSize = True
        lblPlayer.Location = New Point(12, 66)
        lblPlayer.Name = "lblPlayer"
        lblPlayer.Size = New Size(76, 20)
        lblPlayer.TabIndex = 1
        lblPlayer.Text = """Player: 0"""
        ' 
        ' lstHistory
        ' 
        lstHistory.ForeColor = SystemColors.MenuText
        lstHistory.FormattingEnabled = True
        lstHistory.Location = New Point(468, 136)
        lstHistory.Name = "lstHistory"
        lstHistory.Size = New Size(300, 164)
        lstHistory.TabIndex = 2
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(628, 310)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(500, 315)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnExit)
        Controls.Add(lstHistory)
        Controls.Add(lblMostUsed)
        Controls.Add(lblResult)
        Controls.Add(lblDraw)
        Controls.Add(lblPlayer)
        Controls.Add(lblComputer)
        Controls.Add(Label1)
        Controls.Add(btnSpock)
        Controls.Add(btnLizard)
        Controls.Add(btnScissors)
        Controls.Add(btnPaper)
        Controls.Add(btnRock)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRock As Button
    Friend WithEvents btnPaper As Button
    Friend WithEvents btnScissors As Button
    Friend WithEvents btnLizard As Button
    Friend WithEvents btnSpock As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblComputer As Label
    Friend WithEvents lblDraw As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblMostUsed As Label
    Friend WithEvents lblPlayer As Label
    Friend WithEvents lstHistory As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button

End Class
