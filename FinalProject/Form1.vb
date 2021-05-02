Public Class Form1
    'insert a black screen on top of everything.
    Dim strPassword As String = "asdfjkl;" 'my not so secure password

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        blackscreen.Visible = False 'the screen turns on when you click the home button

        Do While blackscreen.Visible = True 'if the screen appears to be off even when the home button is pressed it loops the black screen turning off, preventing the black screen of death.
            blackscreen.Visible = False 'this serves as double checking
        Loop
        If txtPasswordReciever.Text = strPassword Then 'the steps that will occur if the user logs in correctly
            txtPasswordReciever.Visible = False
            lblEnterYourPassword.Visible = False
            lblPressToUnlock.Visible = False
            btnNotesAppIcon.Visible = True
            btnDoWhileAppIcon.Visible = True
            btnReallyBadGame.Visible = True
            btnForNextAppIcon.Visible = True
            btnSmartAssistant.Visible = True
            btnArrayAppIcon.Visible = True
            btnYouTubeAppIcon.Visible = True
            homescreen.Visible = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click 'when the power button is clicked and the wallpaper is not visible, it becomes visible as well as the prompts for logging in are also visible
        If thewallpaper.Visible = False Then
            thewallpaper.Visible = True
            txtPasswordReciever.Visible = True
            lblEnterYourPassword.Visible = True
            lblPressToUnlock.Visible = True
        End If
        blackscreen.Visible = True
    End Sub

    Private Sub btnHome_MouseHover(sender As Object, e As EventArgs) Handles btnHome.MouseHover 'door icon appears when the player first hovers over the home button
        btnHome.Text = "🚪 "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSyncInNotesApp.Click 'adds arrows in the noets app icon
        lstNotesApp.Items.Add("➡️" & txtNotesApp.Text)
        txtNotesApp.Text = Nothing
    End Sub

    'Clicking Apps To Show App Screen Below and hiding those of other apps

    Private Sub btnNotesAppIcon_Click(sender As Object, e As EventArgs) Handles btnNotesAppIcon.Click
        Call showNotesApp()
        Call hideFartNiteApp()
        Call hideArrayApp()
        Call hideDoWhileApp()
        Call hideSmartAssistantApp()
        Call hideForNextApp()
        Call hideYouTubeApp()
        Call hideAppIcons()
    End Sub

    Private Sub btnSmartAssistant_Click(sender As Object, e As EventArgs) Handles btnSmartAssistant.Click
        Call hideNotesApp()
        Call hideFartNiteApp()
        Call hideArrayApp()
        Call showSmartAssistantApp()
        Call hideDoWhileApp()
        Call hideForNextApp()
        Call hideYouTubeApp()
        Call hideAppIcons()
    End Sub

    Private Sub btnForNextAppIcon_Click(sender As Object, e As EventArgs) Handles btnForNextAppIcon.Click
        Call hideNotesApp()
        Call hideFartNiteApp()
        Call hideArrayApp()
        Call hideDoWhileApp()
        Call showForNextApp()
        Call hideYouTubeApp()
        Call hideSmartAssistantApp()
        Call hideAppIcons()
    End Sub

    Private Sub btnDoWhileAppIcon_Click(sender As Object, e As EventArgs) Handles btnDoWhileAppIcon.Click
        Call hideNotesApp()
        Call hideFartNiteApp()
        Call hideArrayApp()
        Call showDoWhileApp()
        Call hideForNextApp()
        Call hideSmartAssistantApp()
        Call hideYouTubeApp()
        Call hideAppIcons()
    End Sub

    Private Sub btnArrayAppIcon_Click(sender As Object, e As EventArgs) Handles btnArrayAppIcon.Click
        Call hideNotesApp()
        Call hideFartNiteApp()
        Call showArrayApp()
        Call hideDoWhileApp()
        Call hideForNextApp()
        Call hideSmartAssistantApp()
        Call hideYouTubeApp()
        Call hideAppIcons()
    End Sub

    Private Sub btnReallyBadGame_Click(sender As Object, e As EventArgs) Handles btnReallyBadGame.Click
        Call hideNotesApp()
        Call showFartNiteApp()
        Call hideArrayApp()
        Call hideDoWhileApp()
        Call hideForNextApp()
        Call hideYouTubeApp()
        Call hideAppIcons()
    End Sub

    Private Sub btnYouTubeAppIcon_Click(sender As Object, e As EventArgs) Handles btnYouTubeAppIcon.Click
        Call hideNotesApp()
        Call hideFartNiteApp()
        Call hideArrayApp()
        Call hideDoWhileApp()
        Call hideForNextApp()
        Call showYouTubeApp()
        Call hideAppIcons()
    End Sub
    '-------------------------------------------------Reptitions Below----------------------------------------------------------------------------
    Private Sub hideAppIcons() 'hides all apps

        btnArrayAppIcon.Visible = False

        btnYouTubeAppIcon.Visible = False
        btnSmartAssistant.Visible = False
        btnDoWhileAppIcon.Visible = False
        btnForNextAppIcon.Visible = False
        btnReallyBadGame.Visible = False
        btnNotesAppIcon.Visible = False
    End Sub

    Private Sub showNotesApp() 'shows notes app
        homescreen.Visible = False
        btnNotesAppIcon.Visible = False
        txtNotesApp.Visible = True
        lstNotesApp.Visible = True
        lblNotesApp.Visible = True
        btnSyncInNotesApp.Visible = True
        notesAppBackground.Visible = True
    End Sub


    Private Sub showYouTubeApp() 'shows youtube app
        picCommentAwards.Visible = True
        picDefaultDance.Visible = True
        picFortniteGameplay.Visible = True
        picSurgeryOnAGrape.Visible = True
        picYouTubeLogo.Visible = True
        lblCommentAwards.Visible = True
        lblDefaultDance.Visible = True
        lblFortniteGameplay.Visible = True
        lblSurgeryOnAGrape.Visible = True
        YouTubeScreen.Visible = True
        homescreen.Visible = False
        hideAppIcons()
    End Sub

    Private Sub showFartNiteApp() 'shows fortnite app
        homescreen.Visible = False
        FartNite.Visible = True
        FartNite2.Visible = True
        FartNite3.Visible = True
    End Sub

    Private Sub showArrayApp() 'shows the array app
        homescreen.Visible = False
        lblArrayAppIcon1.Visible = True
        lblArrayAppIcon2.Visible = True
        txtArrayAppIcon3.Visible = True
        lblArrayAppIcon5.Visible = True
        btnArrayApp4.Visible = True
    End Sub

    Private Sub showDoWhileApp()
        'i once again serve no purpose
    End Sub

    Private Sub showForNextApp() 'shows the for next app
        homescreen.Visible = False
        lblForTheSakeOfTime.Visible = True
        lblNumbersShowerThingy.Visible = True
        btnAnotherForNextNOT.Visible = True
        btnForNextFakeLOL.Visible = True
    End Sub

    Private Sub showSmartAssistantApp() 'shows the web browser
        homescreen.Visible = False
        webBrowser.Visible = True
    End Sub
    Private Sub hideNotesApp() 'shows notes app
        btnSyncInNotesApp.Visible = False
        lstNotesApp.Visible = False
        lblNotesApp.Visible = False
        txtNotesApp.Visible = False
        notesAppBackground.Visible = False
    End Sub

    Private Sub hideYouTubeApp() 'hides youtube app
        btnYouTubeAppIcon.Visible = True
        YouTubeScreen.Visible = False
        picCommentAwards.Visible = False
        picDefaultDance.Visible = False
        picFortniteGameplay.Visible = False
        picSurgeryOnAGrape.Visible = False
        picYouTubeLogo.Visible = False
        lblCommentAwards.Visible = False
        lblDefaultDance.Visible = False
        lblFortniteGameplay.Visible = False
        lblSurgeryOnAGrape.Visible = False
    End Sub

    Private Sub hideFartNiteApp() 'hides fortnite app
        btnReallyBadGame.Visible = True
        FartNite.Visible = False
        FartNite2.Visible = False
        FartNite3.Visible = False
    End Sub

    Private Sub hideArrayApp() 'hides array app
        lblArrayAppIcon1.Visible = False
        lblArrayAppIcon2.Visible = False
        txtArrayAppIcon3.Visible = False
        lblArrayAppIcon5.Visible = False
        btnArrayApp4.Visible = False
    End Sub

    Private Sub hideDoWhileApp()
        'lol i serve no purpose but im too lazy to be removed
    End Sub

    Private Sub hideForNextApp() 'hides for next app
        lblForTheSakeOfTime.Visible = False
        lblNumbersShowerThingy.Visible = False
        btnAnotherForNextNOT.Visible = False
        btnForNextFakeLOL.Visible = False
    End Sub

    Private Sub hideSmartAssistantApp() 'hides the web browser
        webBrowser.Visible = False
    End Sub


    Private Sub homescreen_MouseHover(sender As Object, e As EventArgs) Handles homescreen.MouseHover 'if the player hovers over the wallaper, the the names of the apps will be hidden. 
        btnNotesAppIcon.Text = ""
        btnYouTubeAppIcon.Text = ""
        btnReallyBadGame.Text = ""
        btnSmartAssistant.Text = ""
        btnArrayAppIcon.Text = ""
        btnDoWhileAppIcon.Text = ""
        btnForNextAppIcon.Text = ""
    End Sub
    'For the sub procedures below, if the player hovers over a particular app icon, it shows them the name of it and hides the names of the other apps

    Private Sub btnReallyBadGame_MouseHover(sender As Object, e As EventArgs) Handles btnReallyBadGame.MouseHover
        btnReallyBadGame.Text = "Really Bad Game"
        btnSmartAssistant.Text = ""
        btnYouTubeAppIcon.Text = ""
        btnArrayAppIcon.Text = ""
        btnDoWhileAppIcon.Text = ""
        btnNotesAppIcon.Text = ""
        btnForNextAppIcon.Text = ""
    End Sub

    Private Sub btnSmartAssistant_MouseHover(sender As Object, e As EventArgs) Handles btnSmartAssistant.MouseHover
        btnReallyBadGame.Text = ""
        btnSmartAssistant.Text = "Smart Assistant"
        btnYouTubeAppIcon.Text = ""
        btnArrayAppIcon.Text = ""
        btnNotesAppIcon.Text = ""
        btnDoWhileAppIcon.Text = ""
        btnForNextAppIcon.Text = ""
    End Sub

    Private Sub btnNotesAppIcon_MouseHover(sender As Object, e As EventArgs) Handles btnNotesAppIcon.MouseHover
        btnNotesAppIcon.Text = " N O T E   P A D"
        btnYouTubeAppIcon.Text = ""
        btnReallyBadGame.Text = ""
        btnSmartAssistant.Text = ""
        btnArrayAppIcon.Text = ""
        btnDoWhileAppIcon.Text = ""
        btnForNextAppIcon.Text = ""
    End Sub

    Private Sub btnYouTubeAppIcon_MouseHover(sender As Object, e As EventArgs) Handles btnYouTubeAppIcon.MouseHover
        btnNotesAppIcon.Text = ""
        btnYouTubeAppIcon.Text = "YouTube"
        btnReallyBadGame.Text = ""
        btnSmartAssistant.Text = ""
        btnArrayAppIcon.Text = ""
        btnDoWhileAppIcon.Text = ""
        btnForNextAppIcon.Text = ""
    End Sub

    Private Sub btnArrayAppIcon_MouseHover(sender As Object, e As EventArgs) Handles btnArrayAppIcon.MouseHover
        btnReallyBadGame.Text = ""
        btnSmartAssistant.Text = ""
        btnYouTubeAppIcon.Text = ""
        btnArrayAppIcon.Text = "For Next Demonstration"
        btnNotesAppIcon.Text = ""
        btnDoWhileAppIcon.Text = ""
        btnForNextAppIcon.Text = ""
    End Sub

    Private Sub btnDoWhileAppIcon_MouseHover(sender As Object, e As EventArgs) Handles btnDoWhileAppIcon.MouseHover
        btnReallyBadGame.Text = ""
        btnSmartAssistant.Text = ""
        btnYouTubeAppIcon.Text = ""
        btnArrayAppIcon.Text = ""
        btnNotesAppIcon.Text = ""
        btnDoWhileAppIcon.Text = "Do While Demonstration"
        btnForNextAppIcon.Text = ""
    End Sub

    Private Sub btnForNextAppIcon_MouseHover(sender As Object, e As EventArgs) Handles btnForNextAppIcon.MouseHover
        btnReallyBadGame.Text = ""
        btnSmartAssistant.Text = ""
        btnYouTubeAppIcon.Text = ""
        btnArrayAppIcon.Text = ""
        btnNotesAppIcon.Text = ""
        btnDoWhileAppIcon.Text = ""
        btnForNextAppIcon.Text = "Array Demonstration"
    End Sub

    Private Sub btnArrayApp4_Click(sender As Object, e As EventArgs) Handles btnArrayApp4.Click
        Dim i As Integer = Convert.ToInt16(txtArrayAppIcon3.Text) 'converts the text to an integer
        If i < 6 AndAlso i > 0 Then 'shows text in the label based on the number you entered
            lblArrayAppIcon5.Text = "Thank You!"
        Else
            lblArrayAppIcon5.Text = "Off The Charts."
        End If
        For i = 1 To i 'displays a message box based on the number you entered in the text box
            MessageBox.Show("This message displays based on your input. ", "For Next Demonstration", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Next i
    End Sub

    Private Sub btnForNextFakeLOL_Click(sender As Object, e As EventArgs) Handles btnForNextFakeLOL.Click
        Dim strArray() As String = {4, 1, 5, 6, 2, 8, 9, 13} 'declaring an array with the values
        Array.Sort(strArray) 'sorts the numbers in ascending order
        lblForTheSakeOfTime.Text = strArray(0) 'gives the lowest number since the first number will be in the "0" place
    End Sub

    Private Sub btnAnotherForNextNOT_Click(sender As Object, e As EventArgs) Handles btnAnotherForNextNOT.Click
        Dim strArray() As String = {4, 1, 5, 6, 2, 8, 9, 13} 'declaring an array with the values
        Array.Reverse(strArray) 'sorts the numbers in descending order
        lblForTheSakeOfTime.Text = strArray(0) 'gives the highest number since the first number will be in the "0" place
    End Sub
End Class
