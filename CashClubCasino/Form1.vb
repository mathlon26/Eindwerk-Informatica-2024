Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Dim player As Player
    Dim welcomeUserLabels As Label()  '// list of labels
    Dim balanceLabels As Label()
    Dim logoutButtons As Button()
    Dim canNavigate As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        canNavigate = True

        welcomeUserLabels = New Label() {
            GameLayout_UsernameLbl_BombSearch,
            GameLayout_UsernameLbl_BlackJack,
            GameLayout_UsernameLbl_SlotMachines
        }

        balanceLabels = New Label() {
            GameLayout_BalanceLbl_BombSearch,
            GameLayout_BalanceLbl_BlackJack,
            GameLayout_BalanceLbl_SlotMachines
        }

        LoadStart()


    End Sub

    ' // Page Loading //
    Private Sub LoadStart()
        Controller.SelectedTab = StartPage
    End Sub
    Private Sub LoadBombSearcher()
        Controller.SelectedTab = BombSearchPage
        BombSearch_Load()
    End Sub
    Private Sub LoadBlackJack()
        Controller.SelectedTab = BlackJackPage
        BlackJack_Load()
    End Sub
    Private Sub LoadSlotMachines()
        Controller.SelectedTab = SlotMachinesPage
        SlotMachines_Load()
    End Sub

    ' // ################################# [START PAGE] #################################
    ' // Start Page Button Handling
    Private Sub LoginMenu_LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginMenu_LoginBtn.Click
        ' // conditions: player.age > 18, player.name.Length > 2, player.balance != 0
        player = New Player With {
            .age = LoginMenu_AgeNum.Value,
            .balance = LoginMenu_CapitalLbl.Text.Replace("$", ""),
            .game = Game.BombSearch, ' // First game 
            .name = LoginMenu_NameTxt.Text
        }

        '// Update labels
        AddBalance(0)
        UpdateUserName()

        If player.age < 18 Then
            MsgBox("Sorry, you must be at least 18 years old to access this content." & vbCrLf & "Please come back when you are of legal age.")
            Return
        ElseIf player.name.Length < 3 Then
            MsgBox("The username you entered is too short. Usernames must be at least 3 characters long." & vbCrLf & "Please enter a longer username to continue.")
            Return
        ElseIf player.balance = 0 Then
            MsgBox("We're sorry, but your deposit amount does not meet the minimum requirement of $100." & vbCrLf & "Please deposit at least $100 to continue." & vbCrLf & "Thank you for your understanding!")
            Return
        End If

        LoadBombSearcher()
    End Sub

    Private Sub LoginMenu_QuitBtn_Click(sender As Object, e As EventArgs) Handles LoginMenu_QuitBtn.Click
        Me.Close()
    End Sub

    Private Sub UpdateLoginMenuBalance(value As Double)
        Dim setBalance As String
        setBalance = LoginMenu_CapitalLbl.Text.Replace("$", "")
        If setBalance + value >= 0 Then
            LoginMenu_CapitalLbl.Text = setBalance + value & "$"
        End If
    End Sub

    Private Sub LoginMenu_plus1000Btn_Click(sender As Object, e As EventArgs) Handles LoginMenu_plus1000Btn.Click
        UpdateLoginMenuBalance(1000)
    End Sub

    Private Sub LoginMenu_plus100Btn_Click(sender As Object, e As EventArgs) Handles LoginMenu_plus100Btn.Click
        UpdateLoginMenuBalance(100)
    End Sub

    Private Sub LoginMenu_min100Btn_Click(sender As Object, e As EventArgs) Handles LoginMenu_min100Btn.Click
        UpdateLoginMenuBalance(-100)
    End Sub

    Private Sub LoginMenu_min1000Btn_Click(sender As Object, e As EventArgs) Handles LoginMenu_min1000Btn.Click
        UpdateLoginMenuBalance(-1000)
    End Sub



    ' // ################################# [COMMON GAME] #################################

    Private Sub DisableNavigation()
        canNavigate = False
    End Sub

    Private Sub EnableNavigation()
        canNavigate = True
    End Sub

    Private Sub Logout()
        If canNavigate Then
            player = New Player With {
            .balance = 0,
            .name = "",
            .age = 0,
            .game = Game.BombSearch
        }
            LoginMenu_AgeNum.Value = player.age
            LoginMenu_CapitalLbl.Text = player.balance & "$"
            LoginMenu_NameTxt.Text = player.name

            '// Update labels
            AddBalance(0)
            UpdateUserName()

            LoadStart()

        Else
            MsgBox("Can not navigate to other pages while playing a game!")
        End If
    End Sub

    Private Sub UpdateUserName()
        For Each lbl As Label In welcomeUserLabels
            lbl.Text = "Welcome " & player.name
        Next
    End Sub

    Private Sub AddBalance(profit As Double)
        player.balance += profit
        For Each lbl As Label In balanceLabels
            lbl.Text = player.balance & "$"
        Next
    End Sub

    Private Sub SetGameMode(game As Game)

        player.game = game

        Select Case game
            Case Game.BombSearch
                LoadBombSearcher()
            Case Game.BlackJack
                LoadBlackJack()
            Case Game.SlotMachines
                LoadSlotMachines()
        End Select
        GameLayout_Selector_Self_BombSearch.Checked = True
        GameLayout_Selector_Self_BlackJack.Checked = True
        GameLayout_Selector_Self_SlotMachines.Checked = True

    End Sub



    ' // ################################# [BOMBSEARCHER] ################################
    ' // Game Selector
    Dim bombSearchGame As New BombSearch()

    Private Sub GameLayout_Selector_BlackJack_CheckedChanged(sender As Object, e As EventArgs) Handles GameLayout_Selector_BlackJack.CheckedChanged
        If GameLayout_Selector_BlackJack.Checked Then
            If canNavigate Then

                SetGameMode(Game.BlackJack)

            Else
                GameLayout_Selector_Self_BombSearch.Checked = True
                MsgBox("Can not navigate to other pages while playing a game!")
            End If
        End If


    End Sub
    Private Sub GameLayout_Selector_Slots_CheckedChanged(sender As Object, e As EventArgs) Handles GameLayout_Selector_Slots.CheckedChanged
        If GameLayout_Selector_Slots.Checked Then
            If canNavigate Then

                SetGameMode(Game.SlotMachines)

            Else
                GameLayout_Selector_Self_BombSearch.Checked = True
                MsgBox("Can not navigate to other pages while playing a game!")
            End If
        End If
    End Sub

    Private Sub LogoutBtn_BombSearch_Click(sender As Object, e As EventArgs) Handles LogoutBtn_BombSearch.Click
        Logout()
    End Sub

    Private Function GenerateBombsList(ByVal amountOfBombs As Integer, ByVal listSize As Integer)
        Dim bombList(listSize - 1) As Integer

        For i = 0 To UBound(bombList)
            bombList(i) = 0
        Next

        Dim rand As New Random(DateTime.Now.Millisecond)
        Dim count As Integer = 0
        Do While count < amountOfBombs
            Dim index As Integer = rand.Next(0, listSize)
            If bombList(index) = 0 Then
                bombList(index) = 1
                count += 1
            End If
        Loop

        Return bombList ' // list with [listSize] items => | 0: noBomb  |  1: Bomb
    End Function

    Private Sub DrawBombCells(game As BombSearch)

        Dim i As Integer
        i = 0
        For Each cell As PictureBox In bombSearchGame.bombCells
            cell.BackgroundImage = Nothing
            cell.SizeMode = PictureBoxSizeMode.StretchImage
            cell.BackgroundImageLayout = ImageLayout.Zoom
            cell.Image = My.Resources.QuestionBombCard
            cell.Enabled = True
            If game.bombLocations(i) = 1 Then '// Is Bomb
                cell.BackgroundImage = My.Resources.BombImage
            End If
            i += 1
        Next
    End Sub

    Private Function GetBombsInput()
        Return InputBox("There are 25  fields, how many would you like to be a bomb?" & vbCrLf & "The more bombs the more you win!" & vbCrLf & "(Max  20 Bombs)", "Input Required")
    End Function

    Private Function GetBombSearchBetSize()
        Return InputBox("How much would you like to bet?" & vbCrLf & "Enter 'max' for your max bet." & vbCrLf & "(Max Bet = " & player.balance & "$)", "Input Required")
    End Function

    Private Sub PlayBombSearchBtn_Click(sender As Object, e As EventArgs) Handles PlayBombSearchBtn.Click
        DisableNavigation()
        Dim bombCells As PictureBox() = New PictureBox() {
            BombCell1,
            BombCell2,
            BombCell3,
            BombCell4,
            BombCell5,
            BombCell6,
            BombCell7,
            BombCell8,
            BombCell9,
            BombCell10,
            BombCell11,
            BombCell12,
            BombCell13,
            BombCell14,
            BombCell15,
            BombCell16,
            BombCell17,
            BombCell18,
            BombCell19,
            BombCell20,
            BombCell21,
            BombCell22,
            BombCell23,
            BombCell24,
            BombCell25
        }
        bombSearchGame.bombCells = bombCells
        bombSearchGame.ended = False
        PlayBombSearchBtn.Visible = False
        BombSearch_Play()
    End Sub
    Private Sub BombSearch_Play()
        bombSearchGame.bombs = GetBombsInput()
        While bombSearchGame.bombs > 20 Or bombSearchGame.bombs < 5
            MsgBox("You can only enter between 5 and 20 bombs ")
            bombSearchGame.bombs = GetBombsInput()
        End While

        bombSearchGame.betSize = 0
        While bombSearchGame.betSize = 0
            Dim temp_input_betsize = GetBombSearchBetSize()
            Dim betSize_double As Double
            If temp_input_betsize.ToString().ToLower() = "max" Then
                bombSearchGame.betSize = player.balance
            ElseIf Double.TryParse(temp_input_betsize, betSize_double) Then
                If temp_input_betsize >= 100 And temp_input_betsize <= player.balance Then
                    bombSearchGame.betSize = temp_input_betsize
                Else
                    MsgBox("Invalid bet size, note: your bet size must be greater or equal to 100$!")
                End If
            Else
                MsgBox("Invalid Input, note: your bet size must be all numbers!")
            End If
        End While

        player.balance -= bombSearchGame.betSize
        AddBalance(0) ' // Update balance
        Console.Write(bombSearchGame.bombs)
        Console.WriteLine()
        bombSearchGame.multiplierIncrement = 1.25 + ((bombSearchGame.bombs - 7) * 0.25)

        BombSearch_BetSize.Text = "Bet Size: " & bombSearchGame.betSize & "$"
        BombSearch_CurrentMultiplier.Text = "Current Multiplier: 0x"
        BombSearch_CurrentProfit.Text = "Current Payout: 0$"
        BombSearch_PossibleProfit.Text = "Possible Payout: " & (bombSearchGame.multiplierIncrement * (25 - bombSearchGame.bombs)) * bombSearchGame.betSize & "$"

        BombSearch_GameBoard.Visible = True
        BombSearch_CashOutBtn.Visible = True
        BombSearchStats.Visible = True

        bombSearchGame.bombLocations = GenerateBombsList(bombSearchGame.bombs, bombSearchGame.size)

        DrawBombCells(bombSearchGame)
    End Sub
    Private Sub BombSearch_Load()

        Dim rows As Integer
        Dim colls As Integer
        Dim size As Integer
        Dim bombList(size - 1) As Integer
        rows = 5
        colls = 5
        size = rows * colls

        bombSearchGame.size = size
        bombSearchGame.ended = False
        BombSearchStats.Visible = False
        BombSearch_GameBoard.Visible = False
        BombSearch_CashOutBtn.Visible = False

        PlayBombSearchBtn.Visible = True
    End Sub

    Private Sub EndBombSearch()
        MsgBox("Oops! Thats a bummer, you just lost this game..." & vbCrLf & "Better luck next time!")
        For Each cell As PictureBox In bombSearchGame.bombCells
            cell.Image = Nothing
        Next
        MsgBox("This is where all the other bombs were hidden.")

        bombSearchGame.ended = True
        BombSearchStats.Visible = False
        BombSearch_BetSize.Text = "Bet Size: 0$"
        BombSearch_CurrentMultiplier.Text = "Current Multiplier: 0x"
        BombSearch_CurrentProfit.Text = "Current Payout: 0$"
        BombSearch_PossibleProfit.Text = "Possible Payout: 0$"
        BombSearch_GameBoard.Visible = False
        BombSearch_CashOutBtn.Visible = False
        PlayBombSearchBtn.Visible = True
        bombSearchGame.finaleMultiplier = 0
        bombSearchGame.multiplierIncrement = 0
        bombSearchGame.betSize = 0

        EnableNavigation()
    End Sub

    Private Sub BombSearch_CashOutBtn_Click(sender As Object, e As EventArgs) Handles BombSearch_CashOutBtn.Click
        Dim gains As Double
        gains = bombSearchGame.betSize * bombSearchGame.finaleMultiplier
        AddBalance(gains)

        MsgBox("Nice game! You didn't hit any bombs!" & vbCrLf & "Total Payout: " & gains & "$")
        For Each cell As PictureBox In bombSearchGame.bombCells
            cell.Image = Nothing
        Next
        MsgBox("This is where all the bombs were hidden.")

        bombSearchGame.ended = True
        BombSearchStats.Visible = False
        BombSearch_BetSize.Text = "Bet Size: 0$"
        BombSearch_CurrentMultiplier.Text = "Current Multiplier: 0x"
        BombSearch_CurrentProfit.Text = "Current Payout: 0$"
        BombSearch_PossibleProfit.Text = "Possible Payout: 0$"
        BombSearch_GameBoard.Visible = False
        BombSearch_CashOutBtn.Visible = False
        PlayBombSearchBtn.Visible = True
        bombSearchGame.finaleMultiplier = 0
        bombSearchGame.multiplierIncrement = 0
        bombSearchGame.betSize = 0

        EnableNavigation()
    End Sub

    Private Sub BombCell_Click(sender As Object, e As EventArgs) Handles BombCell1.Click, BombCell2.Click, BombCell3.Click, BombCell4.Click, BombCell5.Click, BombCell6.Click, BombCell7.Click, BombCell8.Click, BombCell9.Click, BombCell10.Click, BombCell11.Click, BombCell12.Click, BombCell13.Click, BombCell14.Click, BombCell15.Click, BombCell16.Click, BombCell17.Click, BombCell18.Click, BombCell19.Click, BombCell20.Click, BombCell21.Click, BombCell22.Click, BombCell23.Click, BombCell24.Click, BombCell25.Click
        If bombSearchGame.ended Then
            Return
        End If

        Dim bombCell As PictureBox = DirectCast(sender, PictureBox)
        bombCell.Image = Nothing
        Dim bombIndex As Integer
        bombIndex = bombCell.Name.Replace("BombCell", "")
        bombCell.Enabled = False
        If bombSearchGame.bombLocations(bombIndex - 1) = 1 Then
            EndBombSearch()
        Else
            bombSearchGame.finaleMultiplier += bombSearchGame.multiplierIncrement
            If bombSearchGame.finaleMultiplier = bombSearchGame.multiplierIncrement Then
                MsgBox("Congrats!" & vbCrLf & "You just got a " & bombSearchGame.multiplierIncrement & "x multiplier!" & vbCrLf & "Current multiplier: " & bombSearchGame.finaleMultiplier & "x")
            Else
                MsgBox("Congrats!" & vbCrLf & "You just got another " & bombSearchGame.multiplierIncrement & "x multiplier!" & vbCrLf & "Current multiplier: " & bombSearchGame.finaleMultiplier & "x")
            End If

            BombSearch_CurrentMultiplier.Text = "Current Multiplier: " & bombSearchGame.finaleMultiplier & "x"
            BombSearch_CurrentProfit.Text = "Current Payout: " & bombSearchGame.finaleMultiplier * bombSearchGame.betSize & "$"
        End If
    End Sub

    Private Sub BombSearchHelpBtn_Click(sender As Object, e As EventArgs) Handles BombSearchHelpBtn.Click
        MsgBox("First you set your betsize, this is the amount the multiplier will affect.")
        MsgBox("Then you choose how many bombs you would like to play with. The more bombs, the more risk and thus the bigger your multiplier will be.")
        MsgBox("The game begins. You now need to click on any square in the grid. If the square reveals a bomb, you lose your initial bet. If the square is not a bomb, a multiplier will be added to your bet.")
        MsgBox("You can cash out any time by clicking the 'cash out' button.")
    End Sub





    ' // ################################## [BLACKJACK] ##################################
    ' // Game Selector
    Private Sub GameLayout_Selector_BombSearch_BlackJack_CheckedChanged(sender As Object, e As EventArgs) Handles GameLayout_Selector_BombSearch_BlackJack.CheckedChanged
        If GameLayout_Selector_BombSearch_BlackJack.Checked Then
            If canNavigate Then

                SetGameMode(Game.BombSearch)

            Else
                GameLayout_Selector_Self_BlackJack.Checked = True
                MsgBox("Can not navigate to other pages while playing a game!")
            End If
        End If

    End Sub
    Private Sub GameLayout_Selector_SlotMachines_BlackJack_CheckedChanged(sender As Object, e As EventArgs) Handles GameLayout_Selector_SlotMachines_BlackJack.CheckedChanged
        If GameLayout_Selector_SlotMachines_BlackJack.Checked Then
            If canNavigate Then

                SetGameMode(Game.SlotMachines)

            Else
                GameLayout_Selector_Self_BlackJack.Checked = True
                MsgBox("Can not navigate to other pages while playing a game!")
            End If
        End If
    End Sub

    Private Sub LogoutBtn_BlackJack_Click(sender As Object, e As EventArgs) Handles LogoutBtn_BlackJack.Click
        Logout()
    End Sub


    ' // Vanaf Hier kunt ge doen wat ge wilt
    Private Sub BlackJack_Load()
        ' // Deze functie wordt opgeroepen zodra het spel wordt ingeladen
        ' // Je kan da dus vergelijken met de standaard Form1_Load() functie die ge altijd hebt maar dan voor uw spel
        ' // Wanneer ge in de editor zijt kunt ge normaal gezien rechts boven u "properties" van tab veranderen
        ' // De verschillende nuttig Tabs zijn: BlackJackPage, BombSearchPage, SlotMachinesPage
        ' // Zorg dus dat je op de juiste pagina zit voordat ge iets veranderd!


    End Sub

    Private Sub PlayBlackJackBtn_Click(sender As Object, e As EventArgs) Handles PlayBlackJackBtn.Click
        ' Deze Functie wordt opgeroepen wanneer je op de play knop drukt (start spel)
        DisableNavigation() ' Speler mag niet naar een andere pagina tijdens een spel (laat dit vanboven staan)

    End Sub

    Private Sub EndBlackJack()


        EnableNavigation() ' Speler mag terug naar andere paginas gaan na het spel (laat dit onder staan)
    End Sub

    Private Sub BlackJackHelpBtn_Click(sender As Object, e As EventArgs) Handles BlackJackHelpBtn.Click
        ' Deze Functie wordt opgeroepen wanneer je op de help knop drukt (geef uitleg aan speler)


    End Sub


    ' // Tot hier


    ' // ################################# [SLOTMACHINES] ################################
    ' // Game Selector
    Private Sub GameLayout_Selector_BombSearch_SlotMachines_CheckedChanged(sender As Object, e As EventArgs) Handles GameLayout_Selector_BombSearch_SlotMachines.CheckedChanged
        If canNavigate Then
            If GameLayout_Selector_BombSearch_SlotMachines.Checked Then
                SetGameMode(Game.BombSearch)
            End If
        Else
            GameLayout_Selector_Self_SlotMachines.Checked = True
            MsgBox("Can not navigate to other pages while playing a game!")
        End If
    End Sub
    Private Sub GameLayout_Selector_BlackJack_SlotMachines_CheckedChanged(sender As Object, e As EventArgs) Handles GameLayout_Selector_BlackJack_SlotMachines.CheckedChanged
        If GameLayout_Selector_BlackJack_SlotMachines.Checked Then
            If canNavigate Then

                SetGameMode(Game.BlackJack)

            Else
                GameLayout_Selector_Self_SlotMachines.Checked = True
                MsgBox("Can not navigate to other pages while playing a game!")
            End If
        End If
    End Sub

    Private Sub LogoutBtn_SlotMachines_Click(sender As Object, e As EventArgs) Handles LogoutBtn_SlotMachines.Click
        Logout()
    End Sub

    ' // Vanaf Hier kunt ge doen wat ge wilt
    Private Sub SlotMachines_Load()
        '// Deze functie wordt opgeroepen zodra het spel wordt ingeladen
        ' // Je kan da dus vergelijken met de standaard Form1_Load() functie die ge altijd hebt maar dan voor uw spel
        ' // Wanneer ge in de editor zijt kunt ge normaal gezien rechts boven u "properties" van tab veranderen
        ' // De verschillende nuttig Tabs zijn: BlackJackPage, BombSearchPage, SlotMachinesPage
        ' // Zorg dus dat je op de juiste pagina zit voordat ge iets veranderd!



    End Sub
    Private Sub PlaySlotMachinesBtn_Click(sender As Object, e As EventArgs) Handles PlaySlotMachinesBtn.Click
        ' Deze Functie wordt opgeroepen wanneer je op de play knop drukt (start spel)
        DisableNavigation() ' Speler mag niet naar een andere pagina tijdens een spel (laat dit vanboven staan)

    End Sub

    Private Sub EndSlotMachines()


        EnableNavigation() ' Speler mag terug naar andere paginas gaan na het spel (laat dit onder staan)
    End Sub

    Private Sub SlotMachinesHelpBtn_Click(sender As Object, e As EventArgs) Handles SlotMachinesHelpBtn.Click
        ' Deze Functie wordt opgeroepen wanneer je op de help knop drukt (geef uitleg aan speler)


    End Sub

    ' // Tot hier

End Class

Enum Game
    BombSearch
    BlackJack
    SlotMachines
End Enum
Structure Player
    Public balance As Double
    Public age As Integer
    Public name As String
    Public game As Game
End Structure

Structure BombSearch
    Public size As Integer
    Public bombs As Integer '  // ammount of bombs
    Public finaleMultiplier As Double
    Public multiplierIncrement As Double
    Public bombLocations() As Integer
    Public ended As Boolean
    Public betSize As Double
    Public bombCells As PictureBox()
End Structure