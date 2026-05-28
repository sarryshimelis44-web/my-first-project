Public Class Form1

    ' ✅ VARIABLES
    Dim playerScore As Integer = 0
    Dim computerScore As Integer = 0
    Dim drawScore As Integer = 0

    Dim rockCount As Integer = 0
    Dim paperCount As Integer = 0
    Dim scissorsCount As Integer = 0
    Dim lizardCount As Integer = 0
    Dim spockCount As Integer = 0

    Dim rnd As New Random()

    ' ✅ FORM LOAD (SET BUTTON COLORS HERE)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 🎨 Button colors
        btnRock.BackColor = Color.IndianRed
        btnPaper.BackColor = Color.DodgerBlue
        btnScissors.BackColor = Color.Gold
        btnLizard.BackColor = Color.ForestGreen
        btnSpock.BackColor = Color.MediumPurple

        btnExit.BackColor = Color.DarkRed
        btnReset.BackColor = Color.Gray

        ' Make colors visible (IMPORTANT)
        btnRock.FlatStyle = FlatStyle.Flat
        btnPaper.FlatStyle = FlatStyle.Flat
        btnScissors.FlatStyle = FlatStyle.Flat
        btnLizard.FlatStyle = FlatStyle.Flat
        btnSpock.FlatStyle = FlatStyle.Flat
        btnExit.FlatStyle = FlatStyle.Flat
        btnReset.FlatStyle = FlatStyle.Flat

    End Sub

    ' ✅ COMPUTER CHOICE
    Function GetComputerChoice() As String
        Dim num As Integer = rnd.Next(0, 5)

        Select Case num
            Case 0
                Return "Rock"
            Case 1
                Return "Paper"
            Case 2
                Return "Scissors"
            Case 3
                Return "Lizard"
            Case 4
                Return "Spock"
        End Select

        Return ""
    End Function

    ' ✅ RESULT LOGIC
    Function GetResult(player As String, computer As String) As String

        If player = computer Then
            Return "Draw"
        End If

        If (player = "Rock" And (computer = "Scissors" Or computer = "Lizard")) Or
           (player = "Paper" And (computer = "Rock" Or computer = "Spock")) Or
           (player = "Scissors" And (computer = "Paper" Or computer = "Lizard")) Or
           (player = "Lizard" And (computer = "Paper" Or computer = "Spock")) Or
           (player = "Spock" And (computer = "Rock" Or computer = "Scissors")) Then
            Return "Win"
        Else
            Return "Lose"
        End If

    End Function

    ' ✅ MAIN GAME FUNCTION
    Sub PlayGame(playerChoice As String)

        Dim computerChoice As String = GetComputerChoice()
        Dim result As String = GetResult(playerChoice, computerChoice)

        If result = "Win" Then
            playerScore += 1
        ElseIf result = "Lose" Then
            computerScore += 1
        Else
            drawScore += 1
        End If

        lblPlayer.Text = "Player: " & playerScore
        lblComputer.Text = "Computer: " & computerScore
        lblDraw.Text = "Draw: " & drawScore
        lblResult.Text = result

        lstHistory.Items.Add("You: " & playerChoice &
                             " | Computer: " & computerChoice &
                             " → " & result)

        UpdateMostUsed(playerChoice)

    End Sub

    ' ✅ MOST USED
    Sub UpdateMostUsed(choice As String)

        Select Case choice
            Case "Rock"
                rockCount += 1
            Case "Paper"
                paperCount += 1
            Case "Scissors"
                scissorsCount += 1
            Case "Lizard"
                lizardCount += 1
            Case "Spock"
                spockCount += 1
        End Select

        Dim max As Integer = Math.Max(Math.Max(Math.Max(Math.Max(rockCount, paperCount), scissorsCount), lizardCount), spockCount)

        If max = rockCount Then
            lblMostUsed.Text = "Most Used: Rock"
        ElseIf max = paperCount Then
            lblMostUsed.Text = "Most Used: Paper"
        ElseIf max = scissorsCount Then
            lblMostUsed.Text = "Most Used: Scissors"
        ElseIf max = lizardCount Then
            lblMostUsed.Text = "Most Used: Lizard"
        Else
            lblMostUsed.Text = "Most Used: Spock"
        End If

    End Sub

    ' ✅ BUTTON EVENTS
    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        PlayGame("Rock")
    End Sub

    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        PlayGame("Paper")
    End Sub

    Private Sub btnScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        PlayGame("Scissors")
    End Sub

    Private Sub btnLizard_Click(sender As Object, e As EventArgs) Handles btnLizard.Click
        PlayGame("Lizard")
    End Sub

    Private Sub btnSpock_Click(sender As Object, e As EventArgs) Handles btnSpock.Click
        PlayGame("Spock")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        playerScore = 0
        computerScore = 0
        drawScore = 0

        rockCount = 0
        paperCount = 0
        scissorsCount = 0
        lizardCount = 0
        spockCount = 0

        lblPlayer.Text = "Player: 0"
        lblComputer.Text = "Computer: 0"
        lblDraw.Text = "Draw: 0"
        lblResult.Text = "Result will appear here"
        lblMostUsed.Text = "Most Used: None"

        lstHistory.Items.Clear()

    End Sub

End Class