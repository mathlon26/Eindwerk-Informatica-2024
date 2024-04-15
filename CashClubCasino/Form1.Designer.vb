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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Controller = New System.Windows.Forms.TabControl()
        Me.StartPage = New System.Windows.Forms.TabPage()
        Me.LoginMenuPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoginMenu_QuitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginMenu_NameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginMenu_AgeNum = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LoginMenu_plus1000Btn = New System.Windows.Forms.Button()
        Me.LoginMenu_plus100Btn = New System.Windows.Forms.Button()
        Me.LoginMenu_min100Btn = New System.Windows.Forms.Button()
        Me.LoginMenu_min1000Btn = New System.Windows.Forms.Button()
        Me.LoginMenu_CapitalLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoginMenu_LoginBtn = New System.Windows.Forms.Button()
        Me.BombSearchPage = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.BombSearch_CashOutBtn = New System.Windows.Forms.Button()
        Me.BombSearch_GameBoard = New System.Windows.Forms.TableLayoutPanel()
        Me.BombCell1 = New System.Windows.Forms.PictureBox()
        Me.BombCell2 = New System.Windows.Forms.PictureBox()
        Me.BombCell3 = New System.Windows.Forms.PictureBox()
        Me.BombCell4 = New System.Windows.Forms.PictureBox()
        Me.BombCell5 = New System.Windows.Forms.PictureBox()
        Me.BombCell6 = New System.Windows.Forms.PictureBox()
        Me.BombCell7 = New System.Windows.Forms.PictureBox()
        Me.BombCell8 = New System.Windows.Forms.PictureBox()
        Me.BombCell9 = New System.Windows.Forms.PictureBox()
        Me.BombCell10 = New System.Windows.Forms.PictureBox()
        Me.BombCell11 = New System.Windows.Forms.PictureBox()
        Me.BombCell12 = New System.Windows.Forms.PictureBox()
        Me.BombCell15 = New System.Windows.Forms.PictureBox()
        Me.BombCell16 = New System.Windows.Forms.PictureBox()
        Me.BombCell17 = New System.Windows.Forms.PictureBox()
        Me.BombCell18 = New System.Windows.Forms.PictureBox()
        Me.BombCell19 = New System.Windows.Forms.PictureBox()
        Me.BombCell20 = New System.Windows.Forms.PictureBox()
        Me.BombCell21 = New System.Windows.Forms.PictureBox()
        Me.BombCell22 = New System.Windows.Forms.PictureBox()
        Me.BombCell23 = New System.Windows.Forms.PictureBox()
        Me.BombCell24 = New System.Windows.Forms.PictureBox()
        Me.BombCell25 = New System.Windows.Forms.PictureBox()
        Me.BombCell14 = New System.Windows.Forms.PictureBox()
        Me.BombCell13 = New System.Windows.Forms.PictureBox()
        Me.BombSearchStats = New System.Windows.Forms.TableLayoutPanel()
        Me.BombSearch_BetSize = New System.Windows.Forms.Label()
        Me.BombSearch_CurrentMultiplier = New System.Windows.Forms.Label()
        Me.BombSearch_CurrentProfit = New System.Windows.Forms.Label()
        Me.BombSearch_PossibleProfit = New System.Windows.Forms.Label()
        Me.GameLayout_Nav = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GameLayout_BalanceLbl_BombSearch = New System.Windows.Forms.Label()
        Me.GameLayout_UsernameLbl_BombSearch = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GameLayout_Panel = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GameSelector_BombSearch = New System.Windows.Forms.GroupBox()
        Me.GameLayout_Selector_Slots = New System.Windows.Forms.RadioButton()
        Me.GameLayout_Selector_BlackJack = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GameLayout_Selector_Self_BombSearch = New System.Windows.Forms.RadioButton()
        Me.BombSearchHelpBtn = New System.Windows.Forms.Button()
        Me.LogoutBtn_BombSearch = New System.Windows.Forms.Button()
        Me.PlayBombSearchBtn = New System.Windows.Forms.Button()
        Me.BlackJackPage = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GameLayout_BalanceLbl_BlackJack = New System.Windows.Forms.Label()
        Me.GameLayout_UsernameLbl_BlackJack = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GameSelector_BlackJack = New System.Windows.Forms.GroupBox()
        Me.GameLayout_Selector_SlotMachines_BlackJack = New System.Windows.Forms.RadioButton()
        Me.GameLayout_Selector_Self_BlackJack = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GameLayout_Selector_BombSearch_BlackJack = New System.Windows.Forms.RadioButton()
        Me.LogoutBtn_BlackJack = New System.Windows.Forms.Button()
        Me.PlayBlackJackBtn = New System.Windows.Forms.Button()
        Me.BlackJackHelpBtn = New System.Windows.Forms.Button()
        Me.SlotMachinesPage = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GameLayout_BalanceLbl_SlotMachines = New System.Windows.Forms.Label()
        Me.GameLayout_UsernameLbl_SlotMachines = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PlaySlotMachinesBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GameSelector_SlotMachines = New System.Windows.Forms.GroupBox()
        Me.GameLayout_Selector_Self_SlotMachines = New System.Windows.Forms.RadioButton()
        Me.GameLayout_Selector_BlackJack_SlotMachines = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GameLayout_Selector_BombSearch_SlotMachines = New System.Windows.Forms.RadioButton()
        Me.LogoutBtn_SlotMachines = New System.Windows.Forms.Button()
        Me.SlotMachinesHelpBtn = New System.Windows.Forms.Button()
        Me.Controller.SuspendLayout()
        Me.StartPage.SuspendLayout()
        Me.LoginMenuPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginMenu_AgeNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.BombSearchPage.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.BombSearch_GameBoard.SuspendLayout()
        CType(Me.BombCell1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BombCell13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BombSearchStats.SuspendLayout()
        Me.GameLayout_Nav.SuspendLayout()
        Me.GameLayout_Panel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameSelector_BombSearch.SuspendLayout()
        Me.BlackJackPage.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameSelector_BlackJack.SuspendLayout()
        Me.SlotMachinesPage.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameSelector_SlotMachines.SuspendLayout()
        Me.SuspendLayout()
        '
        'Controller
        '
        Me.Controller.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Controller.Controls.Add(Me.StartPage)
        Me.Controller.Controls.Add(Me.BombSearchPage)
        Me.Controller.Controls.Add(Me.BlackJackPage)
        Me.Controller.Controls.Add(Me.SlotMachinesPage)
        Me.Controller.Location = New System.Drawing.Point(0, -20)
        Me.Controller.Name = "Controller"
        Me.Controller.SelectedIndex = 0
        Me.Controller.Size = New System.Drawing.Size(1280, 706)
        Me.Controller.TabIndex = 0
        '
        'StartPage
        '
        Me.StartPage.BackgroundImage = Global.CashClubCasino.My.Resources.Resources._679edc0bd89fc0b1cca71c70ceb7aed3e47bc8b5
        Me.StartPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StartPage.Controls.Add(Me.LoginMenuPanel)
        Me.StartPage.Location = New System.Drawing.Point(4, 22)
        Me.StartPage.Name = "StartPage"
        Me.StartPage.Size = New System.Drawing.Size(1272, 680)
        Me.StartPage.TabIndex = 0
        Me.StartPage.Text = "TabPage3"
        Me.StartPage.UseVisualStyleBackColor = True
        '
        'LoginMenuPanel
        '
        Me.LoginMenuPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoginMenuPanel.BackColor = System.Drawing.Color.Transparent
        Me.LoginMenuPanel.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.dark_overlay
        Me.LoginMenuPanel.ColumnCount = 3
        Me.LoginMenuPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.30221!))
        Me.LoginMenuPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.69779!))
        Me.LoginMenuPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.LoginMenuPanel.Controls.Add(Me.PictureBox1, 1, 0)
        Me.LoginMenuPanel.Controls.Add(Me.LoginMenu_QuitBtn, 1, 8)
        Me.LoginMenuPanel.Controls.Add(Me.Label1, 1, 3)
        Me.LoginMenuPanel.Controls.Add(Me.LoginMenu_NameTxt, 1, 2)
        Me.LoginMenuPanel.Controls.Add(Me.Label2, 1, 1)
        Me.LoginMenuPanel.Controls.Add(Me.LoginMenu_AgeNum, 1, 4)
        Me.LoginMenuPanel.Controls.Add(Me.TableLayoutPanel1, 1, 6)
        Me.LoginMenuPanel.Controls.Add(Me.Label4, 1, 5)
        Me.LoginMenuPanel.Controls.Add(Me.LoginMenu_LoginBtn, 1, 7)
        Me.LoginMenuPanel.Location = New System.Drawing.Point(422, -3)
        Me.LoginMenuPanel.Name = "LoginMenuPanel"
        Me.LoginMenuPanel.RowCount = 10
        Me.LoginMenuPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.92486!))
        Me.LoginMenuPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07514!))
        Me.LoginMenuPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.LoginMenuPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.LoginMenuPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.LoginMenuPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.LoginMenuPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.LoginMenuPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.LoginMenuPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.LoginMenuPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.LoginMenuPanel.Size = New System.Drawing.Size(429, 687)
        Me.LoginMenuPanel.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.image_removebg_preview
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(43, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(313, 210)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LoginMenu_QuitBtn
        '
        Me.LoginMenu_QuitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoginMenu_QuitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginMenu_QuitBtn.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginMenu_QuitBtn.Location = New System.Drawing.Point(43, 604)
        Me.LoginMenu_QuitBtn.Name = "LoginMenu_QuitBtn"
        Me.LoginMenu_QuitBtn.Size = New System.Drawing.Size(313, 57)
        Me.LoginMenu_QuitBtn.TabIndex = 1
        Me.LoginMenu_QuitBtn.Text = "Quit"
        Me.LoginMenu_QuitBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(91, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select Your Age"
        '
        'LoginMenu_NameTxt
        '
        Me.LoginMenu_NameTxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoginMenu_NameTxt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginMenu_NameTxt.Location = New System.Drawing.Point(43, 269)
        Me.LoginMenu_NameTxt.Name = "LoginMenu_NameTxt"
        Me.LoginMenu_NameTxt.Size = New System.Drawing.Size(313, 35)
        Me.LoginMenu_NameTxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(51, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Your User Name"
        '
        'LoginMenu_AgeNum
        '
        Me.LoginMenu_AgeNum.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoginMenu_AgeNum.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginMenu_AgeNum.Location = New System.Drawing.Point(43, 378)
        Me.LoginMenu_AgeNum.Name = "LoginMenu_AgeNum"
        Me.LoginMenu_AgeNum.Size = New System.Drawing.Size(313, 35)
        Me.LoginMenu_AgeNum.TabIndex = 8
        Me.LoginMenu_AgeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.31915!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.68085!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LoginMenu_plus1000Btn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LoginMenu_plus100Btn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LoginMenu_min100Btn, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LoginMenu_min1000Btn, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LoginMenu_CapitalLbl, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(43, 471)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(313, 42)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'LoginMenu_plus1000Btn
        '
        Me.LoginMenu_plus1000Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginMenu_plus1000Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginMenu_plus1000Btn.Location = New System.Drawing.Point(3, 3)
        Me.LoginMenu_plus1000Btn.Name = "LoginMenu_plus1000Btn"
        Me.LoginMenu_plus1000Btn.Size = New System.Drawing.Size(39, 36)
        Me.LoginMenu_plus1000Btn.TabIndex = 0
        Me.LoginMenu_plus1000Btn.Text = "+1000"
        Me.LoginMenu_plus1000Btn.UseVisualStyleBackColor = True
        '
        'LoginMenu_plus100Btn
        '
        Me.LoginMenu_plus100Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginMenu_plus100Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginMenu_plus100Btn.Location = New System.Drawing.Point(48, 3)
        Me.LoginMenu_plus100Btn.Name = "LoginMenu_plus100Btn"
        Me.LoginMenu_plus100Btn.Size = New System.Drawing.Size(30, 36)
        Me.LoginMenu_plus100Btn.TabIndex = 1
        Me.LoginMenu_plus100Btn.Text = "+100"
        Me.LoginMenu_plus100Btn.UseVisualStyleBackColor = True
        '
        'LoginMenu_min100Btn
        '
        Me.LoginMenu_min100Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginMenu_min100Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginMenu_min100Btn.Location = New System.Drawing.Point(189, 3)
        Me.LoginMenu_min100Btn.Name = "LoginMenu_min100Btn"
        Me.LoginMenu_min100Btn.Size = New System.Drawing.Size(44, 36)
        Me.LoginMenu_min100Btn.TabIndex = 2
        Me.LoginMenu_min100Btn.Text = "-100"
        Me.LoginMenu_min100Btn.UseVisualStyleBackColor = True
        '
        'LoginMenu_min1000Btn
        '
        Me.LoginMenu_min1000Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginMenu_min1000Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginMenu_min1000Btn.Location = New System.Drawing.Point(239, 3)
        Me.LoginMenu_min1000Btn.Name = "LoginMenu_min1000Btn"
        Me.LoginMenu_min1000Btn.Size = New System.Drawing.Size(71, 36)
        Me.LoginMenu_min1000Btn.TabIndex = 3
        Me.LoginMenu_min1000Btn.Text = "-1000"
        Me.LoginMenu_min1000Btn.UseVisualStyleBackColor = True
        '
        'LoginMenu_CapitalLbl
        '
        Me.LoginMenu_CapitalLbl.AutoSize = True
        Me.LoginMenu_CapitalLbl.BackColor = System.Drawing.Color.White
        Me.LoginMenu_CapitalLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginMenu_CapitalLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LoginMenu_CapitalLbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LoginMenu_CapitalLbl.Location = New System.Drawing.Point(85, 4)
        Me.LoginMenu_CapitalLbl.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginMenu_CapitalLbl.Name = "LoginMenu_CapitalLbl"
        Me.LoginMenu_CapitalLbl.Size = New System.Drawing.Size(97, 34)
        Me.LoginMenu_CapitalLbl.TabIndex = 4
        Me.LoginMenu_CapitalLbl.Text = "0$"
        Me.LoginMenu_CapitalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(86, 431)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 37)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Starting  Capital"
        '
        'LoginMenu_LoginBtn
        '
        Me.LoginMenu_LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LoginMenu_LoginBtn.BackColor = System.Drawing.Color.White
        Me.LoginMenu_LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginMenu_LoginBtn.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginMenu_LoginBtn.Location = New System.Drawing.Point(43, 540)
        Me.LoginMenu_LoginBtn.Name = "LoginMenu_LoginBtn"
        Me.LoginMenu_LoginBtn.Size = New System.Drawing.Size(313, 58)
        Me.LoginMenu_LoginBtn.TabIndex = 0
        Me.LoginMenu_LoginBtn.Text = "Login"
        Me.LoginMenu_LoginBtn.UseVisualStyleBackColor = False
        '
        'BombSearchPage
        '
        Me.BombSearchPage.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.casino_bg
        Me.BombSearchPage.Controls.Add(Me.TableLayoutPanel6)
        Me.BombSearchPage.Controls.Add(Me.GameLayout_Nav)
        Me.BombSearchPage.Controls.Add(Me.GameLayout_Panel)
        Me.BombSearchPage.Location = New System.Drawing.Point(4, 22)
        Me.BombSearchPage.Name = "BombSearchPage"
        Me.BombSearchPage.Size = New System.Drawing.Size(1272, 680)
        Me.BombSearchPage.TabIndex = 1
        Me.BombSearchPage.Text = "TabPage3"
        Me.BombSearchPage.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.BombSearch_GameBoard, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.BombSearchStats, 0, 1)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(247, 47)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 4
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.47059!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.52941!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 466.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1011, 632)
        Me.TableLayoutPanel6.TabIndex = 6
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.49057!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.50943!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 383.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.BombSearch_CashOutBtn, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 561)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1005, 68)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'BombSearch_CashOutBtn
        '
        Me.BombSearch_CashOutBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombSearch_CashOutBtn.BackgroundImage = CType(resources.GetObject("BombSearch_CashOutBtn.BackgroundImage"), System.Drawing.Image)
        Me.BombSearch_CashOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BombSearch_CashOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BombSearch_CashOutBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BombSearch_CashOutBtn.ForeColor = System.Drawing.Color.Transparent
        Me.BombSearch_CashOutBtn.Location = New System.Drawing.Point(366, 3)
        Me.BombSearch_CashOutBtn.Name = "BombSearch_CashOutBtn"
        Me.BombSearch_CashOutBtn.Size = New System.Drawing.Size(252, 56)
        Me.BombSearch_CashOutBtn.TabIndex = 0
        Me.BombSearch_CashOutBtn.Text = "Cash  Out"
        Me.BombSearch_CashOutBtn.UseVisualStyleBackColor = True
        '
        'BombSearch_GameBoard
        '
        Me.BombSearch_GameBoard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombSearch_GameBoard.ColumnCount = 7
        Me.BombSearch_GameBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.9505!))
        Me.BombSearch_GameBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0495!))
        Me.BombSearch_GameBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.BombSearch_GameBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.BombSearch_GameBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.BombSearch_GameBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.BombSearch_GameBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell1, 1, 0)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell2, 2, 0)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell3, 3, 0)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell4, 4, 0)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell5, 5, 0)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell6, 1, 1)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell7, 2, 1)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell8, 3, 1)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell9, 4, 1)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell10, 5, 1)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell11, 1, 2)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell12, 2, 2)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell15, 5, 2)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell16, 1, 3)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell17, 2, 3)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell18, 3, 3)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell19, 4, 3)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell20, 5, 3)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell21, 1, 4)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell22, 2, 4)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell23, 3, 4)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell24, 4, 4)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell25, 5, 4)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell14, 4, 2)
        Me.BombSearch_GameBoard.Controls.Add(Me.BombCell13, 3, 2)
        Me.BombSearch_GameBoard.Location = New System.Drawing.Point(3, 95)
        Me.BombSearch_GameBoard.Name = "BombSearch_GameBoard"
        Me.BombSearch_GameBoard.RowCount = 5
        Me.BombSearch_GameBoard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BombSearch_GameBoard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BombSearch_GameBoard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.BombSearch_GameBoard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.BombSearch_GameBoard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.BombSearch_GameBoard.Size = New System.Drawing.Size(1005, 460)
        Me.BombSearch_GameBoard.TabIndex = 1
        '
        'BombCell1
        '
        Me.BombCell1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell1.Location = New System.Drawing.Point(159, 3)
        Me.BombCell1.Name = "BombCell1"
        Me.BombCell1.Size = New System.Drawing.Size(121, 83)
        Me.BombCell1.TabIndex = 0
        Me.BombCell1.TabStop = False
        '
        'BombCell2
        '
        Me.BombCell2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell2.Location = New System.Drawing.Point(286, 3)
        Me.BombCell2.Name = "BombCell2"
        Me.BombCell2.Size = New System.Drawing.Size(130, 83)
        Me.BombCell2.TabIndex = 1
        Me.BombCell2.TabStop = False
        '
        'BombCell3
        '
        Me.BombCell3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell3.Location = New System.Drawing.Point(422, 3)
        Me.BombCell3.Name = "BombCell3"
        Me.BombCell3.Size = New System.Drawing.Size(138, 83)
        Me.BombCell3.TabIndex = 2
        Me.BombCell3.TabStop = False
        '
        'BombCell4
        '
        Me.BombCell4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell4.Location = New System.Drawing.Point(566, 3)
        Me.BombCell4.Name = "BombCell4"
        Me.BombCell4.Size = New System.Drawing.Size(131, 83)
        Me.BombCell4.TabIndex = 3
        Me.BombCell4.TabStop = False
        '
        'BombCell5
        '
        Me.BombCell5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell5.Location = New System.Drawing.Point(703, 3)
        Me.BombCell5.Name = "BombCell5"
        Me.BombCell5.Size = New System.Drawing.Size(136, 83)
        Me.BombCell5.TabIndex = 4
        Me.BombCell5.TabStop = False
        '
        'BombCell6
        '
        Me.BombCell6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell6.Location = New System.Drawing.Point(159, 92)
        Me.BombCell6.Name = "BombCell6"
        Me.BombCell6.Size = New System.Drawing.Size(121, 83)
        Me.BombCell6.TabIndex = 5
        Me.BombCell6.TabStop = False
        '
        'BombCell7
        '
        Me.BombCell7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell7.Location = New System.Drawing.Point(286, 92)
        Me.BombCell7.Name = "BombCell7"
        Me.BombCell7.Size = New System.Drawing.Size(130, 83)
        Me.BombCell7.TabIndex = 6
        Me.BombCell7.TabStop = False
        '
        'BombCell8
        '
        Me.BombCell8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell8.Location = New System.Drawing.Point(422, 92)
        Me.BombCell8.Name = "BombCell8"
        Me.BombCell8.Size = New System.Drawing.Size(138, 83)
        Me.BombCell8.TabIndex = 7
        Me.BombCell8.TabStop = False
        '
        'BombCell9
        '
        Me.BombCell9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell9.Location = New System.Drawing.Point(566, 92)
        Me.BombCell9.Name = "BombCell9"
        Me.BombCell9.Size = New System.Drawing.Size(131, 83)
        Me.BombCell9.TabIndex = 8
        Me.BombCell9.TabStop = False
        '
        'BombCell10
        '
        Me.BombCell10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell10.Location = New System.Drawing.Point(703, 92)
        Me.BombCell10.Name = "BombCell10"
        Me.BombCell10.Size = New System.Drawing.Size(136, 83)
        Me.BombCell10.TabIndex = 9
        Me.BombCell10.TabStop = False
        '
        'BombCell11
        '
        Me.BombCell11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell11.Location = New System.Drawing.Point(159, 181)
        Me.BombCell11.Name = "BombCell11"
        Me.BombCell11.Size = New System.Drawing.Size(121, 83)
        Me.BombCell11.TabIndex = 10
        Me.BombCell11.TabStop = False
        '
        'BombCell12
        '
        Me.BombCell12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell12.Location = New System.Drawing.Point(286, 181)
        Me.BombCell12.Name = "BombCell12"
        Me.BombCell12.Size = New System.Drawing.Size(130, 83)
        Me.BombCell12.TabIndex = 11
        Me.BombCell12.TabStop = False
        '
        'BombCell15
        '
        Me.BombCell15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell15.Location = New System.Drawing.Point(703, 181)
        Me.BombCell15.Name = "BombCell15"
        Me.BombCell15.Size = New System.Drawing.Size(136, 83)
        Me.BombCell15.TabIndex = 14
        Me.BombCell15.TabStop = False
        '
        'BombCell16
        '
        Me.BombCell16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell16.Location = New System.Drawing.Point(159, 275)
        Me.BombCell16.Name = "BombCell16"
        Me.BombCell16.Size = New System.Drawing.Size(121, 83)
        Me.BombCell16.TabIndex = 15
        Me.BombCell16.TabStop = False
        '
        'BombCell17
        '
        Me.BombCell17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell17.Location = New System.Drawing.Point(286, 275)
        Me.BombCell17.Name = "BombCell17"
        Me.BombCell17.Size = New System.Drawing.Size(130, 83)
        Me.BombCell17.TabIndex = 16
        Me.BombCell17.TabStop = False
        '
        'BombCell18
        '
        Me.BombCell18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell18.Location = New System.Drawing.Point(422, 275)
        Me.BombCell18.Name = "BombCell18"
        Me.BombCell18.Size = New System.Drawing.Size(138, 83)
        Me.BombCell18.TabIndex = 17
        Me.BombCell18.TabStop = False
        '
        'BombCell19
        '
        Me.BombCell19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell19.Location = New System.Drawing.Point(566, 275)
        Me.BombCell19.Name = "BombCell19"
        Me.BombCell19.Size = New System.Drawing.Size(131, 83)
        Me.BombCell19.TabIndex = 18
        Me.BombCell19.TabStop = False
        '
        'BombCell20
        '
        Me.BombCell20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell20.Location = New System.Drawing.Point(703, 275)
        Me.BombCell20.Name = "BombCell20"
        Me.BombCell20.Size = New System.Drawing.Size(136, 83)
        Me.BombCell20.TabIndex = 19
        Me.BombCell20.TabStop = False
        '
        'BombCell21
        '
        Me.BombCell21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell21.Location = New System.Drawing.Point(159, 369)
        Me.BombCell21.Name = "BombCell21"
        Me.BombCell21.Size = New System.Drawing.Size(121, 83)
        Me.BombCell21.TabIndex = 20
        Me.BombCell21.TabStop = False
        '
        'BombCell22
        '
        Me.BombCell22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell22.Location = New System.Drawing.Point(286, 369)
        Me.BombCell22.Name = "BombCell22"
        Me.BombCell22.Size = New System.Drawing.Size(130, 83)
        Me.BombCell22.TabIndex = 21
        Me.BombCell22.TabStop = False
        '
        'BombCell23
        '
        Me.BombCell23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell23.Location = New System.Drawing.Point(422, 369)
        Me.BombCell23.Name = "BombCell23"
        Me.BombCell23.Size = New System.Drawing.Size(138, 83)
        Me.BombCell23.TabIndex = 22
        Me.BombCell23.TabStop = False
        '
        'BombCell24
        '
        Me.BombCell24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell24.Location = New System.Drawing.Point(566, 369)
        Me.BombCell24.Name = "BombCell24"
        Me.BombCell24.Size = New System.Drawing.Size(131, 83)
        Me.BombCell24.TabIndex = 23
        Me.BombCell24.TabStop = False
        '
        'BombCell25
        '
        Me.BombCell25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell25.Location = New System.Drawing.Point(703, 369)
        Me.BombCell25.Name = "BombCell25"
        Me.BombCell25.Size = New System.Drawing.Size(136, 83)
        Me.BombCell25.TabIndex = 24
        Me.BombCell25.TabStop = False
        '
        'BombCell14
        '
        Me.BombCell14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell14.Location = New System.Drawing.Point(566, 181)
        Me.BombCell14.Name = "BombCell14"
        Me.BombCell14.Size = New System.Drawing.Size(131, 83)
        Me.BombCell14.TabIndex = 13
        Me.BombCell14.TabStop = False
        '
        'BombCell13
        '
        Me.BombCell13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombCell13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BombCell13.Location = New System.Drawing.Point(422, 181)
        Me.BombCell13.Name = "BombCell13"
        Me.BombCell13.Size = New System.Drawing.Size(138, 83)
        Me.BombCell13.TabIndex = 12
        Me.BombCell13.TabStop = False
        '
        'BombSearchStats
        '
        Me.BombSearchStats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombSearchStats.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.dark_overlay
        Me.BombSearchStats.ColumnCount = 6
        Me.BombSearchStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.597122!))
        Me.BombSearchStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.40288!))
        Me.BombSearchStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204.0!))
        Me.BombSearchStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286.0!))
        Me.BombSearchStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277.0!))
        Me.BombSearchStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.BombSearchStats.Controls.Add(Me.BombSearch_BetSize, 1, 0)
        Me.BombSearchStats.Controls.Add(Me.BombSearch_CurrentMultiplier, 2, 0)
        Me.BombSearchStats.Controls.Add(Me.BombSearch_CurrentProfit, 3, 0)
        Me.BombSearchStats.Controls.Add(Me.BombSearch_PossibleProfit, 4, 0)
        Me.BombSearchStats.Location = New System.Drawing.Point(3, 50)
        Me.BombSearchStats.Name = "BombSearchStats"
        Me.BombSearchStats.RowCount = 1
        Me.BombSearchStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BombSearchStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BombSearchStats.Size = New System.Drawing.Size(1005, 39)
        Me.BombSearchStats.TabIndex = 2
        '
        'BombSearch_BetSize
        '
        Me.BombSearch_BetSize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombSearch_BetSize.AutoSize = True
        Me.BombSearch_BetSize.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BombSearch_BetSize.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BombSearch_BetSize.Location = New System.Drawing.Point(10, 0)
        Me.BombSearch_BetSize.Name = "BombSearch_BetSize"
        Me.BombSearch_BetSize.Size = New System.Drawing.Size(200, 39)
        Me.BombSearch_BetSize.TabIndex = 0
        Me.BombSearch_BetSize.Text = "Bet Size:"
        Me.BombSearch_BetSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BombSearch_CurrentMultiplier
        '
        Me.BombSearch_CurrentMultiplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombSearch_CurrentMultiplier.AutoSize = True
        Me.BombSearch_CurrentMultiplier.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BombSearch_CurrentMultiplier.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BombSearch_CurrentMultiplier.Location = New System.Drawing.Point(216, 0)
        Me.BombSearch_CurrentMultiplier.Name = "BombSearch_CurrentMultiplier"
        Me.BombSearch_CurrentMultiplier.Size = New System.Drawing.Size(198, 39)
        Me.BombSearch_CurrentMultiplier.TabIndex = 1
        Me.BombSearch_CurrentMultiplier.Text = "Current Multiplier: "
        Me.BombSearch_CurrentMultiplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BombSearch_CurrentProfit
        '
        Me.BombSearch_CurrentProfit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombSearch_CurrentProfit.AutoSize = True
        Me.BombSearch_CurrentProfit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BombSearch_CurrentProfit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BombSearch_CurrentProfit.Location = New System.Drawing.Point(420, 0)
        Me.BombSearch_CurrentProfit.Name = "BombSearch_CurrentProfit"
        Me.BombSearch_CurrentProfit.Size = New System.Drawing.Size(280, 39)
        Me.BombSearch_CurrentProfit.TabIndex = 2
        Me.BombSearch_CurrentProfit.Text = "Current  Profit:"
        Me.BombSearch_CurrentProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BombSearch_PossibleProfit
        '
        Me.BombSearch_PossibleProfit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombSearch_PossibleProfit.AutoSize = True
        Me.BombSearch_PossibleProfit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BombSearch_PossibleProfit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BombSearch_PossibleProfit.Location = New System.Drawing.Point(706, 0)
        Me.BombSearch_PossibleProfit.Name = "BombSearch_PossibleProfit"
        Me.BombSearch_PossibleProfit.Size = New System.Drawing.Size(271, 39)
        Me.BombSearch_PossibleProfit.TabIndex = 3
        Me.BombSearch_PossibleProfit.Text = "Possible Payout:"
        Me.BombSearch_PossibleProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameLayout_Nav
        '
        Me.GameLayout_Nav.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameLayout_Nav.BackColor = System.Drawing.Color.Transparent
        Me.GameLayout_Nav.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.dark_overlay
        Me.GameLayout_Nav.ColumnCount = 5
        Me.GameLayout_Nav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.08252!))
        Me.GameLayout_Nav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.91748!))
        Me.GameLayout_Nav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.GameLayout_Nav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.GameLayout_Nav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.GameLayout_Nav.Controls.Add(Me.Label5, 3, 0)
        Me.GameLayout_Nav.Controls.Add(Me.GameLayout_BalanceLbl_BombSearch, 4, 0)
        Me.GameLayout_Nav.Controls.Add(Me.GameLayout_UsernameLbl_BombSearch, 0, 0)
        Me.GameLayout_Nav.Controls.Add(Me.Label8, 1, 0)
        Me.GameLayout_Nav.Location = New System.Drawing.Point(247, -3)
        Me.GameLayout_Nav.Margin = New System.Windows.Forms.Padding(0)
        Me.GameLayout_Nav.Name = "GameLayout_Nav"
        Me.GameLayout_Nav.RowCount = 1
        Me.GameLayout_Nav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.GameLayout_Nav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.GameLayout_Nav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.GameLayout_Nav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.GameLayout_Nav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.GameLayout_Nav.Size = New System.Drawing.Size(1021, 50)
        Me.GameLayout_Nav.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(771, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 50)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Balance:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GameLayout_BalanceLbl_BombSearch
        '
        Me.GameLayout_BalanceLbl_BombSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GameLayout_BalanceLbl_BombSearch.AutoSize = True
        Me.GameLayout_BalanceLbl_BombSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_BalanceLbl_BombSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_BalanceLbl_BombSearch.Location = New System.Drawing.Point(871, 0)
        Me.GameLayout_BalanceLbl_BombSearch.Name = "GameLayout_BalanceLbl_BombSearch"
        Me.GameLayout_BalanceLbl_BombSearch.Size = New System.Drawing.Size(66, 50)
        Me.GameLayout_BalanceLbl_BombSearch.TabIndex = 1
        Me.GameLayout_BalanceLbl_BombSearch.Text = "0.00$"
        Me.GameLayout_BalanceLbl_BombSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GameLayout_UsernameLbl_BombSearch
        '
        Me.GameLayout_UsernameLbl_BombSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GameLayout_UsernameLbl_BombSearch.AutoSize = True
        Me.GameLayout_UsernameLbl_BombSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_UsernameLbl_BombSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_UsernameLbl_BombSearch.Location = New System.Drawing.Point(3, 0)
        Me.GameLayout_UsernameLbl_BombSearch.Name = "GameLayout_UsernameLbl_BombSearch"
        Me.GameLayout_UsernameLbl_BombSearch.Size = New System.Drawing.Size(183, 50)
        Me.GameLayout_UsernameLbl_BombSearch.TabIndex = 3
        Me.GameLayout_UsernameLbl_BombSearch.Text = "%username%"
        Me.GameLayout_UsernameLbl_BombSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(382, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 50)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Bomb Search"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameLayout_Panel
        '
        Me.GameLayout_Panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GameLayout_Panel.BackColor = System.Drawing.Color.Transparent
        Me.GameLayout_Panel.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.dark_overlay
        Me.GameLayout_Panel.ColumnCount = 3
        Me.GameLayout_Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.625669!))
        Me.GameLayout_Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.37433!))
        Me.GameLayout_Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GameLayout_Panel.Controls.Add(Me.PictureBox2, 1, 1)
        Me.GameLayout_Panel.Controls.Add(Me.GameSelector_BombSearch, 1, 2)
        Me.GameLayout_Panel.Controls.Add(Me.BombSearchHelpBtn, 1, 4)
        Me.GameLayout_Panel.Controls.Add(Me.LogoutBtn_BombSearch, 1, 5)
        Me.GameLayout_Panel.Controls.Add(Me.PlayBombSearchBtn, 1, 3)
        Me.GameLayout_Panel.Location = New System.Drawing.Point(4, -3)
        Me.GameLayout_Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.GameLayout_Panel.Name = "GameLayout_Panel"
        Me.GameLayout_Panel.RowCount = 7
        Me.GameLayout_Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.774799!))
        Me.GameLayout_Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.2252!))
        Me.GameLayout_Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202.0!))
        Me.GameLayout_Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256.0!))
        Me.GameLayout_Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.GameLayout_Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.GameLayout_Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.GameLayout_Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GameLayout_Panel.Size = New System.Drawing.Size(243, 687)
        Me.GameLayout_Panel.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.image_removebg_preview
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(38, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 85)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GameSelector_BombSearch
        '
        Me.GameSelector_BombSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameSelector_BombSearch.BackColor = System.Drawing.Color.Transparent
        Me.GameSelector_BombSearch.Controls.Add(Me.GameLayout_Selector_Slots)
        Me.GameSelector_BombSearch.Controls.Add(Me.GameLayout_Selector_BlackJack)
        Me.GameSelector_BombSearch.Controls.Add(Me.Label3)
        Me.GameSelector_BombSearch.Controls.Add(Me.GameLayout_Selector_Self_BombSearch)
        Me.GameSelector_BombSearch.Location = New System.Drawing.Point(24, 101)
        Me.GameSelector_BombSearch.Name = "GameSelector_BombSearch"
        Me.GameSelector_BombSearch.Size = New System.Drawing.Size(195, 194)
        Me.GameSelector_BombSearch.TabIndex = 2
        Me.GameSelector_BombSearch.TabStop = False
        '
        'GameLayout_Selector_Slots
        '
        Me.GameLayout_Selector_Slots.AutoSize = True
        Me.GameLayout_Selector_Slots.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_Selector_Slots.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_Selector_Slots.Location = New System.Drawing.Point(6, 138)
        Me.GameLayout_Selector_Slots.Name = "GameLayout_Selector_Slots"
        Me.GameLayout_Selector_Slots.Size = New System.Drawing.Size(154, 34)
        Me.GameLayout_Selector_Slots.TabIndex = 3
        Me.GameLayout_Selector_Slots.TabStop = True
        Me.GameLayout_Selector_Slots.Text = "Slot Machine"
        Me.GameLayout_Selector_Slots.UseVisualStyleBackColor = True
        '
        'GameLayout_Selector_BlackJack
        '
        Me.GameLayout_Selector_BlackJack.AutoSize = True
        Me.GameLayout_Selector_BlackJack.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_Selector_BlackJack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_Selector_BlackJack.Location = New System.Drawing.Point(6, 98)
        Me.GameLayout_Selector_BlackJack.Name = "GameLayout_Selector_BlackJack"
        Me.GameLayout_Selector_BlackJack.Size = New System.Drawing.Size(127, 34)
        Me.GameLayout_Selector_BlackJack.TabIndex = 2
        Me.GameLayout_Selector_BlackJack.TabStop = True
        Me.GameLayout_Selector_BlackJack.Text = "Black Jack"
        Me.GameLayout_Selector_BlackJack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(5, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Game Selector"
        '
        'GameLayout_Selector_Self_BombSearch
        '
        Me.GameLayout_Selector_Self_BombSearch.AutoSize = True
        Me.GameLayout_Selector_Self_BombSearch.Checked = True
        Me.GameLayout_Selector_Self_BombSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_Selector_Self_BombSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_Selector_Self_BombSearch.Location = New System.Drawing.Point(6, 58)
        Me.GameLayout_Selector_Self_BombSearch.Name = "GameLayout_Selector_Self_BombSearch"
        Me.GameLayout_Selector_Self_BombSearch.Size = New System.Drawing.Size(158, 34)
        Me.GameLayout_Selector_Self_BombSearch.TabIndex = 1
        Me.GameLayout_Selector_Self_BombSearch.TabStop = True
        Me.GameLayout_Selector_Self_BombSearch.Text = "Bomb Search"
        Me.GameLayout_Selector_Self_BombSearch.UseVisualStyleBackColor = True
        '
        'BombSearchHelpBtn
        '
        Me.BombSearchHelpBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BombSearchHelpBtn.BackgroundImage = CType(resources.GetObject("BombSearchHelpBtn.BackgroundImage"), System.Drawing.Image)
        Me.BombSearchHelpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BombSearchHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BombSearchHelpBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BombSearchHelpBtn.ForeColor = System.Drawing.Color.Transparent
        Me.BombSearchHelpBtn.Location = New System.Drawing.Point(24, 560)
        Me.BombSearchHelpBtn.Name = "BombSearchHelpBtn"
        Me.BombSearchHelpBtn.Size = New System.Drawing.Size(195, 43)
        Me.BombSearchHelpBtn.TabIndex = 4
        Me.BombSearchHelpBtn.Text = "Help"
        Me.BombSearchHelpBtn.UseVisualStyleBackColor = True
        '
        'LogoutBtn_BombSearch
        '
        Me.LogoutBtn_BombSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutBtn_BombSearch.BackgroundImage = CType(resources.GetObject("LogoutBtn_BombSearch.BackgroundImage"), System.Drawing.Image)
        Me.LogoutBtn_BombSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoutBtn_BombSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogoutBtn_BombSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn_BombSearch.ForeColor = System.Drawing.Color.Transparent
        Me.LogoutBtn_BombSearch.Location = New System.Drawing.Point(24, 609)
        Me.LogoutBtn_BombSearch.Name = "LogoutBtn_BombSearch"
        Me.LogoutBtn_BombSearch.Size = New System.Drawing.Size(195, 44)
        Me.LogoutBtn_BombSearch.TabIndex = 3
        Me.LogoutBtn_BombSearch.Text = "Logout"
        Me.LogoutBtn_BombSearch.UseVisualStyleBackColor = True
        '
        'PlayBombSearchBtn
        '
        Me.PlayBombSearchBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayBombSearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.PlayBombSearchBtn.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.button
        Me.PlayBombSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayBombSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PlayBombSearchBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayBombSearchBtn.ForeColor = System.Drawing.Color.Transparent
        Me.PlayBombSearchBtn.Location = New System.Drawing.Point(24, 391)
        Me.PlayBombSearchBtn.Name = "PlayBombSearchBtn"
        Me.PlayBombSearchBtn.Size = New System.Drawing.Size(195, 74)
        Me.PlayBombSearchBtn.TabIndex = 25
        Me.PlayBombSearchBtn.Text = "Play Bomb Search"
        Me.PlayBombSearchBtn.UseVisualStyleBackColor = False
        '
        'BlackJackPage
        '
        Me.BlackJackPage.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.casino_bg
        Me.BlackJackPage.Controls.Add(Me.TableLayoutPanel4)
        Me.BlackJackPage.Controls.Add(Me.TableLayoutPanel5)
        Me.BlackJackPage.Location = New System.Drawing.Point(4, 22)
        Me.BlackJackPage.Name = "BlackJackPage"
        Me.BlackJackPage.Size = New System.Drawing.Size(1272, 680)
        Me.BlackJackPage.TabIndex = 2
        Me.BlackJackPage.Text = "TabPage3"
        Me.BlackJackPage.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.dark_overlay
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.45776!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.54224!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GameLayout_BalanceLbl_BlackJack, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GameLayout_UsernameLbl_BlackJack, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(247, -3)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1021, 50)
        Me.TableLayoutPanel4.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(771, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 50)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Balance:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GameLayout_BalanceLbl_BlackJack
        '
        Me.GameLayout_BalanceLbl_BlackJack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GameLayout_BalanceLbl_BlackJack.AutoSize = True
        Me.GameLayout_BalanceLbl_BlackJack.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_BalanceLbl_BlackJack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_BalanceLbl_BlackJack.Location = New System.Drawing.Point(871, 0)
        Me.GameLayout_BalanceLbl_BlackJack.Name = "GameLayout_BalanceLbl_BlackJack"
        Me.GameLayout_BalanceLbl_BlackJack.Size = New System.Drawing.Size(66, 50)
        Me.GameLayout_BalanceLbl_BlackJack.TabIndex = 1
        Me.GameLayout_BalanceLbl_BlackJack.Text = "0.00$"
        Me.GameLayout_BalanceLbl_BlackJack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GameLayout_UsernameLbl_BlackJack
        '
        Me.GameLayout_UsernameLbl_BlackJack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GameLayout_UsernameLbl_BlackJack.AutoSize = True
        Me.GameLayout_UsernameLbl_BlackJack.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_UsernameLbl_BlackJack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_UsernameLbl_BlackJack.Location = New System.Drawing.Point(3, 0)
        Me.GameLayout_UsernameLbl_BlackJack.Name = "GameLayout_UsernameLbl_BlackJack"
        Me.GameLayout_UsernameLbl_BlackJack.Size = New System.Drawing.Size(183, 50)
        Me.GameLayout_UsernameLbl_BlackJack.TabIndex = 3
        Me.GameLayout_UsernameLbl_BlackJack.Text = "%username%"
        Me.GameLayout_UsernameLbl_BlackJack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(387, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(215, 50)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Black Jack"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel5.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.dark_overlay
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.625669!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.37433!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox4, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.GameSelector_BlackJack, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.LogoutBtn_BlackJack, 1, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.PlayBlackJackBtn, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.BlackJackHelpBtn, 1, 4)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(4, -3)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 6
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.774799!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.2252!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(243, 687)
        Me.TableLayoutPanel5.TabIndex = 8
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox4.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.image_removebg_preview
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(38, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(166, 117)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'GameSelector_BlackJack
        '
        Me.GameSelector_BlackJack.BackColor = System.Drawing.Color.Transparent
        Me.GameSelector_BlackJack.Controls.Add(Me.GameLayout_Selector_SlotMachines_BlackJack)
        Me.GameSelector_BlackJack.Controls.Add(Me.GameLayout_Selector_Self_BlackJack)
        Me.GameSelector_BlackJack.Controls.Add(Me.Label13)
        Me.GameSelector_BlackJack.Controls.Add(Me.GameLayout_Selector_BombSearch_BlackJack)
        Me.GameSelector_BlackJack.Location = New System.Drawing.Point(24, 152)
        Me.GameSelector_BlackJack.Name = "GameSelector_BlackJack"
        Me.GameSelector_BlackJack.Size = New System.Drawing.Size(175, 194)
        Me.GameSelector_BlackJack.TabIndex = 2
        Me.GameSelector_BlackJack.TabStop = False
        '
        'GameLayout_Selector_SlotMachines_BlackJack
        '
        Me.GameLayout_Selector_SlotMachines_BlackJack.AutoSize = True
        Me.GameLayout_Selector_SlotMachines_BlackJack.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_Selector_SlotMachines_BlackJack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_Selector_SlotMachines_BlackJack.Location = New System.Drawing.Point(6, 138)
        Me.GameLayout_Selector_SlotMachines_BlackJack.Name = "GameLayout_Selector_SlotMachines_BlackJack"
        Me.GameLayout_Selector_SlotMachines_BlackJack.Size = New System.Drawing.Size(154, 34)
        Me.GameLayout_Selector_SlotMachines_BlackJack.TabIndex = 3
        Me.GameLayout_Selector_SlotMachines_BlackJack.TabStop = True
        Me.GameLayout_Selector_SlotMachines_BlackJack.Text = "Slot Machine"
        Me.GameLayout_Selector_SlotMachines_BlackJack.UseVisualStyleBackColor = True
        '
        'GameLayout_Selector_Self_BlackJack
        '
        Me.GameLayout_Selector_Self_BlackJack.AutoSize = True
        Me.GameLayout_Selector_Self_BlackJack.Checked = True
        Me.GameLayout_Selector_Self_BlackJack.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_Selector_Self_BlackJack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_Selector_Self_BlackJack.Location = New System.Drawing.Point(6, 98)
        Me.GameLayout_Selector_Self_BlackJack.Name = "GameLayout_Selector_Self_BlackJack"
        Me.GameLayout_Selector_Self_BlackJack.Size = New System.Drawing.Size(127, 34)
        Me.GameLayout_Selector_Self_BlackJack.TabIndex = 2
        Me.GameLayout_Selector_Self_BlackJack.TabStop = True
        Me.GameLayout_Selector_Self_BlackJack.Text = "Black Jack"
        Me.GameLayout_Selector_Self_BlackJack.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(5, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 32)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Game Selector"
        '
        'GameLayout_Selector_BombSearch_BlackJack
        '
        Me.GameLayout_Selector_BombSearch_BlackJack.AutoSize = True
        Me.GameLayout_Selector_BombSearch_BlackJack.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_Selector_BombSearch_BlackJack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_Selector_BombSearch_BlackJack.Location = New System.Drawing.Point(6, 58)
        Me.GameLayout_Selector_BombSearch_BlackJack.Name = "GameLayout_Selector_BombSearch_BlackJack"
        Me.GameLayout_Selector_BombSearch_BlackJack.Size = New System.Drawing.Size(158, 34)
        Me.GameLayout_Selector_BombSearch_BlackJack.TabIndex = 1
        Me.GameLayout_Selector_BombSearch_BlackJack.Text = "Bomb Search"
        Me.GameLayout_Selector_BombSearch_BlackJack.UseVisualStyleBackColor = True
        '
        'LogoutBtn_BlackJack
        '
        Me.LogoutBtn_BlackJack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutBtn_BlackJack.BackgroundImage = CType(resources.GetObject("LogoutBtn_BlackJack.BackgroundImage"), System.Drawing.Image)
        Me.LogoutBtn_BlackJack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoutBtn_BlackJack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogoutBtn_BlackJack.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn_BlackJack.ForeColor = System.Drawing.Color.Transparent
        Me.LogoutBtn_BlackJack.Location = New System.Drawing.Point(24, 615)
        Me.LogoutBtn_BlackJack.Name = "LogoutBtn_BlackJack"
        Me.LogoutBtn_BlackJack.Size = New System.Drawing.Size(194, 44)
        Me.LogoutBtn_BlackJack.TabIndex = 3
        Me.LogoutBtn_BlackJack.Text = "Logout"
        Me.LogoutBtn_BlackJack.UseVisualStyleBackColor = True
        '
        'PlayBlackJackBtn
        '
        Me.PlayBlackJackBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayBlackJackBtn.BackColor = System.Drawing.Color.Transparent
        Me.PlayBlackJackBtn.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.button
        Me.PlayBlackJackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayBlackJackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PlayBlackJackBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayBlackJackBtn.ForeColor = System.Drawing.Color.Transparent
        Me.PlayBlackJackBtn.Location = New System.Drawing.Point(24, 419)
        Me.PlayBlackJackBtn.Name = "PlayBlackJackBtn"
        Me.PlayBlackJackBtn.Size = New System.Drawing.Size(194, 74)
        Me.PlayBlackJackBtn.TabIndex = 26
        Me.PlayBlackJackBtn.Text = "Play Black Jack"
        Me.PlayBlackJackBtn.UseVisualStyleBackColor = False
        '
        'BlackJackHelpBtn
        '
        Me.BlackJackHelpBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BlackJackHelpBtn.BackgroundImage = CType(resources.GetObject("BlackJackHelpBtn.BackgroundImage"), System.Drawing.Image)
        Me.BlackJackHelpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BlackJackHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BlackJackHelpBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlackJackHelpBtn.ForeColor = System.Drawing.Color.Transparent
        Me.BlackJackHelpBtn.Location = New System.Drawing.Point(24, 565)
        Me.BlackJackHelpBtn.Name = "BlackJackHelpBtn"
        Me.BlackJackHelpBtn.Size = New System.Drawing.Size(194, 43)
        Me.BlackJackHelpBtn.TabIndex = 4
        Me.BlackJackHelpBtn.Text = "Help"
        Me.BlackJackHelpBtn.UseVisualStyleBackColor = True
        '
        'SlotMachinesPage
        '
        Me.SlotMachinesPage.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.casino_bg
        Me.SlotMachinesPage.Controls.Add(Me.TableLayoutPanel2)
        Me.SlotMachinesPage.Controls.Add(Me.TableLayoutPanel3)
        Me.SlotMachinesPage.Location = New System.Drawing.Point(4, 22)
        Me.SlotMachinesPage.Name = "SlotMachinesPage"
        Me.SlotMachinesPage.Size = New System.Drawing.Size(1272, 680)
        Me.SlotMachinesPage.TabIndex = 3
        Me.SlotMachinesPage.Text = "TabPage3"
        Me.SlotMachinesPage.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.dark_overlay
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.63574!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.36426!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GameLayout_BalanceLbl_SlotMachines, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GameLayout_UsernameLbl_SlotMachines, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(247, -3)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1021, 50)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(771, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 50)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Balance:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GameLayout_BalanceLbl_SlotMachines
        '
        Me.GameLayout_BalanceLbl_SlotMachines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GameLayout_BalanceLbl_SlotMachines.AutoSize = True
        Me.GameLayout_BalanceLbl_SlotMachines.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_BalanceLbl_SlotMachines.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_BalanceLbl_SlotMachines.Location = New System.Drawing.Point(871, 0)
        Me.GameLayout_BalanceLbl_SlotMachines.Name = "GameLayout_BalanceLbl_SlotMachines"
        Me.GameLayout_BalanceLbl_SlotMachines.Size = New System.Drawing.Size(66, 50)
        Me.GameLayout_BalanceLbl_SlotMachines.TabIndex = 1
        Me.GameLayout_BalanceLbl_SlotMachines.Text = "0.00$"
        Me.GameLayout_BalanceLbl_SlotMachines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GameLayout_UsernameLbl_SlotMachines
        '
        Me.GameLayout_UsernameLbl_SlotMachines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GameLayout_UsernameLbl_SlotMachines.AutoSize = True
        Me.GameLayout_UsernameLbl_SlotMachines.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_UsernameLbl_SlotMachines.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_UsernameLbl_SlotMachines.Location = New System.Drawing.Point(3, 0)
        Me.GameLayout_UsernameLbl_SlotMachines.Name = "GameLayout_UsernameLbl_SlotMachines"
        Me.GameLayout_UsernameLbl_SlotMachines.Size = New System.Drawing.Size(183, 50)
        Me.GameLayout_UsernameLbl_SlotMachines.TabIndex = 3
        Me.GameLayout_UsernameLbl_SlotMachines.Text = "%username%"
        Me.GameLayout_UsernameLbl_SlotMachines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(394, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 50)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Slot Machine"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.dark_overlay
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.625669!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.37433!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.PlaySlotMachinesBtn, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox3, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.GameSelector_SlotMachines, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.LogoutBtn_SlotMachines, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.SlotMachinesHelpBtn, 1, 4)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, -3)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.774799!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.2252!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 221.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(243, 687)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'PlaySlotMachinesBtn
        '
        Me.PlaySlotMachinesBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlaySlotMachinesBtn.BackColor = System.Drawing.Color.Transparent
        Me.PlaySlotMachinesBtn.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.button
        Me.PlaySlotMachinesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaySlotMachinesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PlaySlotMachinesBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaySlotMachinesBtn.ForeColor = System.Drawing.Color.Transparent
        Me.PlaySlotMachinesBtn.Location = New System.Drawing.Point(24, 424)
        Me.PlaySlotMachinesBtn.Name = "PlaySlotMachinesBtn"
        Me.PlaySlotMachinesBtn.Size = New System.Drawing.Size(194, 74)
        Me.PlaySlotMachinesBtn.TabIndex = 27
        Me.PlaySlotMachinesBtn.Text = "Play Slot Machines"
        Me.PlaySlotMachinesBtn.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.BackgroundImage = Global.CashClubCasino.My.Resources.Resources.image_removebg_preview
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(38, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(166, 117)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'GameSelector_SlotMachines
        '
        Me.GameSelector_SlotMachines.BackColor = System.Drawing.Color.Transparent
        Me.GameSelector_SlotMachines.Controls.Add(Me.GameLayout_Selector_Self_SlotMachines)
        Me.GameSelector_SlotMachines.Controls.Add(Me.GameLayout_Selector_BlackJack_SlotMachines)
        Me.GameSelector_SlotMachines.Controls.Add(Me.Label9)
        Me.GameSelector_SlotMachines.Controls.Add(Me.GameLayout_Selector_BombSearch_SlotMachines)
        Me.GameSelector_SlotMachines.Location = New System.Drawing.Point(24, 152)
        Me.GameSelector_SlotMachines.Name = "GameSelector_SlotMachines"
        Me.GameSelector_SlotMachines.Size = New System.Drawing.Size(184, 194)
        Me.GameSelector_SlotMachines.TabIndex = 2
        Me.GameSelector_SlotMachines.TabStop = False
        '
        'GameLayout_Selector_Self_SlotMachines
        '
        Me.GameLayout_Selector_Self_SlotMachines.AutoSize = True
        Me.GameLayout_Selector_Self_SlotMachines.Checked = True
        Me.GameLayout_Selector_Self_SlotMachines.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_Selector_Self_SlotMachines.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_Selector_Self_SlotMachines.Location = New System.Drawing.Point(6, 138)
        Me.GameLayout_Selector_Self_SlotMachines.Name = "GameLayout_Selector_Self_SlotMachines"
        Me.GameLayout_Selector_Self_SlotMachines.Size = New System.Drawing.Size(154, 34)
        Me.GameLayout_Selector_Self_SlotMachines.TabIndex = 3
        Me.GameLayout_Selector_Self_SlotMachines.TabStop = True
        Me.GameLayout_Selector_Self_SlotMachines.Text = "Slot Machine"
        Me.GameLayout_Selector_Self_SlotMachines.UseVisualStyleBackColor = True
        '
        'GameLayout_Selector_BlackJack_SlotMachines
        '
        Me.GameLayout_Selector_BlackJack_SlotMachines.AutoSize = True
        Me.GameLayout_Selector_BlackJack_SlotMachines.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_Selector_BlackJack_SlotMachines.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_Selector_BlackJack_SlotMachines.Location = New System.Drawing.Point(6, 98)
        Me.GameLayout_Selector_BlackJack_SlotMachines.Name = "GameLayout_Selector_BlackJack_SlotMachines"
        Me.GameLayout_Selector_BlackJack_SlotMachines.Size = New System.Drawing.Size(127, 34)
        Me.GameLayout_Selector_BlackJack_SlotMachines.TabIndex = 2
        Me.GameLayout_Selector_BlackJack_SlotMachines.Text = "Black Jack"
        Me.GameLayout_Selector_BlackJack_SlotMachines.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(5, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 32)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Game Selector"
        '
        'GameLayout_Selector_BombSearch_SlotMachines
        '
        Me.GameLayout_Selector_BombSearch_SlotMachines.AutoSize = True
        Me.GameLayout_Selector_BombSearch_SlotMachines.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLayout_Selector_BombSearch_SlotMachines.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameLayout_Selector_BombSearch_SlotMachines.Location = New System.Drawing.Point(6, 58)
        Me.GameLayout_Selector_BombSearch_SlotMachines.Name = "GameLayout_Selector_BombSearch_SlotMachines"
        Me.GameLayout_Selector_BombSearch_SlotMachines.Size = New System.Drawing.Size(158, 34)
        Me.GameLayout_Selector_BombSearch_SlotMachines.TabIndex = 1
        Me.GameLayout_Selector_BombSearch_SlotMachines.Text = "Bomb Search"
        Me.GameLayout_Selector_BombSearch_SlotMachines.UseVisualStyleBackColor = True
        '
        'LogoutBtn_SlotMachines
        '
        Me.LogoutBtn_SlotMachines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutBtn_SlotMachines.BackgroundImage = CType(resources.GetObject("LogoutBtn_SlotMachines.BackgroundImage"), System.Drawing.Image)
        Me.LogoutBtn_SlotMachines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoutBtn_SlotMachines.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogoutBtn_SlotMachines.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn_SlotMachines.ForeColor = System.Drawing.Color.Transparent
        Me.LogoutBtn_SlotMachines.Location = New System.Drawing.Point(24, 622)
        Me.LogoutBtn_SlotMachines.Name = "LogoutBtn_SlotMachines"
        Me.LogoutBtn_SlotMachines.Size = New System.Drawing.Size(194, 44)
        Me.LogoutBtn_SlotMachines.TabIndex = 3
        Me.LogoutBtn_SlotMachines.Text = "Logout"
        Me.LogoutBtn_SlotMachines.UseVisualStyleBackColor = True
        '
        'SlotMachinesHelpBtn
        '
        Me.SlotMachinesHelpBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SlotMachinesHelpBtn.BackgroundImage = CType(resources.GetObject("SlotMachinesHelpBtn.BackgroundImage"), System.Drawing.Image)
        Me.SlotMachinesHelpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlotMachinesHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SlotMachinesHelpBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlotMachinesHelpBtn.ForeColor = System.Drawing.Color.Transparent
        Me.SlotMachinesHelpBtn.Location = New System.Drawing.Point(24, 575)
        Me.SlotMachinesHelpBtn.Name = "SlotMachinesHelpBtn"
        Me.SlotMachinesHelpBtn.Size = New System.Drawing.Size(194, 41)
        Me.SlotMachinesHelpBtn.TabIndex = 4
        Me.SlotMachinesHelpBtn.Text = "Help"
        Me.SlotMachinesHelpBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Controller)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Controller.ResumeLayout(False)
        Me.StartPage.ResumeLayout(False)
        Me.LoginMenuPanel.ResumeLayout(False)
        Me.LoginMenuPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginMenu_AgeNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.BombSearchPage.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.BombSearch_GameBoard.ResumeLayout(False)
        CType(Me.BombCell1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BombCell13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BombSearchStats.ResumeLayout(False)
        Me.BombSearchStats.PerformLayout()
        Me.GameLayout_Nav.ResumeLayout(False)
        Me.GameLayout_Nav.PerformLayout()
        Me.GameLayout_Panel.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GameSelector_BombSearch.ResumeLayout(False)
        Me.GameSelector_BombSearch.PerformLayout()
        Me.BlackJackPage.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GameSelector_BlackJack.ResumeLayout(False)
        Me.GameSelector_BlackJack.PerformLayout()
        Me.SlotMachinesPage.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GameSelector_SlotMachines.ResumeLayout(False)
        Me.GameSelector_SlotMachines.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Controller As TabControl
    Friend WithEvents StartPage As TabPage
    Friend WithEvents BombSearchPage As TabPage
    Friend WithEvents BlackJackPage As TabPage
    Friend WithEvents SlotMachinesPage As TabPage
    Friend WithEvents GameLayout_Nav As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents GameLayout_BalanceLbl_BombSearch As Label
    Friend WithEvents GameLayout_UsernameLbl_BombSearch As Label
    Friend WithEvents GameLayout_Panel As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GameSelector_BombSearch As GroupBox
    Friend WithEvents GameLayout_Selector_Slots As RadioButton
    Friend WithEvents GameLayout_Selector_BlackJack As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents GameLayout_Selector_Self_BombSearch As RadioButton
    Friend WithEvents BombSearchHelpBtn As Button
    Friend WithEvents LogoutBtn_BombSearch As Button
    Friend WithEvents LoginMenuPanel As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoginMenu_QuitBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginMenu_NameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginMenu_AgeNum As NumericUpDown
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LoginMenu_plus1000Btn As Button
    Friend WithEvents LoginMenu_plus100Btn As Button
    Friend WithEvents LoginMenu_min100Btn As Button
    Friend WithEvents LoginMenu_min1000Btn As Button
    Friend WithEvents LoginMenu_CapitalLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LoginMenu_LoginBtn As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents GameLayout_BalanceLbl_SlotMachines As Label
    Friend WithEvents GameLayout_UsernameLbl_SlotMachines As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GameSelector_SlotMachines As GroupBox
    Friend WithEvents GameLayout_Selector_Self_SlotMachines As RadioButton
    Friend WithEvents GameLayout_Selector_BlackJack_SlotMachines As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents GameLayout_Selector_BombSearch_SlotMachines As RadioButton
    Friend WithEvents SlotMachinesHelpBtn As Button
    Friend WithEvents LogoutBtn_SlotMachines As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents GameLayout_BalanceLbl_BlackJack As Label
    Friend WithEvents GameLayout_UsernameLbl_BlackJack As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GameSelector_BlackJack As GroupBox
    Friend WithEvents GameLayout_Selector_SlotMachines_BlackJack As RadioButton
    Friend WithEvents GameLayout_Selector_Self_BlackJack As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents GameLayout_Selector_BombSearch_BlackJack As RadioButton
    Friend WithEvents BlackJackHelpBtn As Button
    Friend WithEvents LogoutBtn_BlackJack As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents BombSearch_CashOutBtn As Button
    Friend WithEvents BombSearch_GameBoard As TableLayoutPanel
    Friend WithEvents BombCell1 As PictureBox
    Friend WithEvents BombCell2 As PictureBox
    Friend WithEvents BombCell3 As PictureBox
    Friend WithEvents BombCell4 As PictureBox
    Friend WithEvents BombCell5 As PictureBox
    Friend WithEvents BombCell6 As PictureBox
    Friend WithEvents BombCell7 As PictureBox
    Friend WithEvents BombCell8 As PictureBox
    Friend WithEvents BombCell9 As PictureBox
    Friend WithEvents BombCell10 As PictureBox
    Friend WithEvents BombCell11 As PictureBox
    Friend WithEvents BombCell12 As PictureBox
    Friend WithEvents BombCell13 As PictureBox
    Friend WithEvents BombCell14 As PictureBox
    Friend WithEvents BombCell15 As PictureBox
    Friend WithEvents BombCell16 As PictureBox
    Friend WithEvents BombCell17 As PictureBox
    Friend WithEvents BombCell18 As PictureBox
    Friend WithEvents BombCell19 As PictureBox
    Friend WithEvents BombCell20 As PictureBox
    Friend WithEvents BombCell21 As PictureBox
    Friend WithEvents BombCell22 As PictureBox
    Friend WithEvents BombCell23 As PictureBox
    Friend WithEvents BombCell24 As PictureBox
    Friend WithEvents BombCell25 As PictureBox
    Friend WithEvents BombSearchStats As TableLayoutPanel
    Friend WithEvents BombSearch_BetSize As Label
    Friend WithEvents BombSearch_CurrentMultiplier As Label
    Friend WithEvents BombSearch_CurrentProfit As Label
    Friend WithEvents BombSearch_PossibleProfit As Label
    Friend WithEvents PlayBombSearchBtn As Button
    Friend WithEvents PlayBlackJackBtn As Button
    Friend WithEvents PlaySlotMachinesBtn As Button
End Class
