Imports System.Runtime.InteropServices
Imports System.Speech

Public Class frmFinal

    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine

    Dim destructCounter As Single = -1

    Dim endCounter As Single

    Dim volTime As Single

    Dim vol As Single

    Dim Muted As Boolean = False

    <DllImport("user32.dll")>
    Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Hide()

        reco.SetInputToDefaultAudioDevice()

        Dim gram As New Recognition.SrgsGrammar.SrgsDocument

        Dim grammerRule As New Recognition.SrgsGrammar.SrgsRule("command")

        Dim commandList As New Recognition.SrgsGrammar.SrgsOneOf("hacking", "yes", "computer, end presentation")

        grammerRule.Add(commandList)

        gram.Rules.Add(grammerRule)

        gram.Root = grammerRule

        reco.LoadGrammar(New Recognition.Grammar(gram))

        reco.RecognizeAsync()

        endCounter = -1

        volTime = -1

        vol = 0

    End Sub

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsync()

    End Sub

    Private Sub timSelfDestruct_Tick(sender As Object, e As EventArgs) Handles timSelfDestruct.Tick

        Dim synth As New Synthesis.SpeechSynthesizer

        destructCounter += 1

        If destructCounter = 6 Then

            timEndCounter.Stop()

            destructCounter = -1

        End If

        If destructCounter = -1 Then

            timSelfDestruct.Stop()

            synth.SpeakAsync("Blake, that was terrible acting, my scans show that nobody thought I was actually going to explode.")

        ElseIf destructCounter = 1 Then

            synth.SpeakAsync("five")

        ElseIf destructCounter = 2 Then

            synth.SpeakAsync("four")

        ElseIf destructCounter = 3 Then

            synth.SpeakAsync("three")

        ElseIf destructCounter = 4 Then

            synth.SpeakAsync("two")

        ElseIf destructCounter = 5 Then

            synth.SpeakAsync("one")

        End If

    End Sub

    Private Sub timEndCounter_Tick(sender As Object, e As EventArgs) Handles timEndCounter.Tick

        Dim synth As New Synthesis.SpeechSynthesizer

        endCounter += 1

        If endCounter = 6 Then

            timEndCounter.Stop()

            endCounter = -1

        End If

        If endCounter = -1 Then

            synth.SpeakAsync("Okay, nevermind")

        ElseIf endCounter = 1 Then

            synth.SpeakAsync("five")

        ElseIf endCounter = 2 Then

            synth.SpeakAsync("four")

        ElseIf endCounter = 3 Then

            synth.SpeakAsync("three")

        ElseIf endCounter = 4 Then

            synth.SpeakAsync("two")

        ElseIf endCounter = 5 Then

            synth.SpeakAsync("one")

        End If

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        Dim synth As New Synthesis.SpeechSynthesizer

        Dim chrome() As Process

        chrome = Process.GetProcessesByName("chrome")

        If e.Result.Text = "yes" And timEndCounter.Enabled = True And endCounter <= 5 And endCounter <> -1 Then

            timEndCounter.Stop()

            For i As Integer = 0 To chrome.Count - 1

                chrome(i).CloseMainWindow()

            Next i

            Application.Exit()

        End If

        Select Case e.Result.Text

            Case "hacking"

                synth.SpeakAsync("self destruct initiated")

                timSelfDestruct.Start()

            Case "computer, end presentation"

                synth.SpeakAsync("are you sure?")

                timEndCounter.Start()

        End Select

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        Dim synth As New Synthesis.SpeechSynthesizer

        synth.SpeakAsync("Testing")

    End Sub
End Class