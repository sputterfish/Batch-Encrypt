Option Strict Off
Option Explicit On
Friend Class frmMain
	Inherits System.Windows.Forms.Form
	Dim used(27) As String 'this needs to be global ;)
	Dim chars(27) As Short 'initialize the array...
	
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
		Dim i As Object
		txtDefs.Text = "[Definitions]" 'just clear the text boxes and put initial text there
		txtBatch.Text = "[Paste Code Here]"
		txtEncrypted.Text = "[Encrypted Code]"
		For i = 1 To 27
			chars(i) = 0
			used(i) = ""
		Next 
		txtBatch.Enabled = True
	End Sub
	
	Private Sub cmdCopy_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCopy.Click
		My.Computer.Clipboard.SetText(txtEncrypted.Text) 'copy the code to the text box
	End Sub
	
	Private Sub cmdEncrypt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEncrypt.Click
		Dim j As Object
		Dim checkifwritten As Object
		Dim i As Object
		'add definitions to final text
		txtEncrypted.Text = txtDefs.Text & Chr(13) & Chr(10) & Chr(13) & Chr(10)
		'encrypt it
		For i = 1 To Len(txtBatch.Text)
			checkifwritten = 1
			For j = 1 To 27
				If Mid(txtBatch.Text, i, 1) = Chr(chars(j)) Then
					txtEncrypted.Text = txtEncrypted.Text & "%" & used(j) & "%"
					checkifwritten = 0
				End If
			Next 
			If checkifwritten = 1 Then
				'this makes it so if it's not a lowercase letter then it will leave it alone
				txtEncrypted.Text = txtEncrypted.Text & Mid(txtBatch.Text, i, 1)
			End If
		Next i
		txtBatch.Enabled = False
	End Sub
	
	Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
		End
	End Sub
	
	Private Sub cmdgenkey_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdgenkey.Click
		Dim trasha As Object
		Dim sette As Object
		Dim defchrand As Object
		Dim j As Object
		Dim ender As Object
		Dim defrand As Object
		Dim rando As Object
		Dim randchecker As Object
		Dim rand As Object
		Dim i As Object
		If txtBatch.Text = "[Paste Code Here]" & Chr(13) & Chr(10) Then
			MsgBox("Please first include your code to encrypt.")
			Exit Sub
		End If
		Dim Setter(3) As String
		'clear out the text
		txtDefs.Text = ""
		
		'Encrypt 's','e' and 't' for better encryption in definitions! (Thank SPTH for the idea)
		For i = 1 To 3
			rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
			'save the variable for later use
			randchecker = Int(Rnd() * 5) + 1
			If randchecker = 1 Then
				rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
			ElseIf randchecker = 2 Then 
				rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
			ElseIf randchecker = 3 Then 
				rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
			ElseIf randchecker = 4 Then 
				rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
			Else
				rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
			End If
			Setter(i) = rand
			With txtDefs
				'for the random-variable-size
				
				Select Case i
					Case 1
						.Text = .Text & "set " & rand & "=s" & Chr(13) & Chr(10) 'The true statment
					Case 2
						.Text = .Text & "set " & rand & "=e" & Chr(13) & Chr(10) 'The true statment
					Case 3
						.Text = .Text & "set " & rand & "=t" & Chr(13) & Chr(10) 'The true statment
				End Select
				.Text = .Text & "goto " & rand & Chr(13) & Chr(10)
				.Text = .Text & "set " & rand & "=" & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(13) & Chr(10)
				.Text = .Text & ":" & rand & Chr(13) & Chr(10)
			End With
		Next i
		
		'call the sub, which tells the letters, that are used in the code to encrypt.
		'to don't use vars, which we don't need
		'and to avoid Win95|98|ME 21-vars-maximum error
		Call findletters()
		
		randchecker = Int(Rnd() * 5) + 1
		If randchecker = 1 Then
			rando = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
		ElseIf randchecker = 2 Then 
			rando = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
		ElseIf randchecker = 3 Then 
			rando = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
		ElseIf randchecker = 4 Then 
			rando = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
		Else
			rando = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
		End If
		defrand = rando
		txtDefs.Text = txtDefs.Text & "%" & Setter(1) & "%" & "%" & Setter(2) & "%" & "%" & Setter(3) & "% " & defrand & "=%" & Setter(1) & "%" & "%" & Setter(2) & "%" & "%" & Setter(3) & "%" & Chr(13) & Chr(10)
		For i = 1 To 27
			If chars(i) <> 0 Then
				Do 
					ender = 1
					'for the random-var-size
					randchecker = Int(Rnd() * 5) + 1
					If randchecker = 1 Then
						rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
					ElseIf randchecker = 2 Then 
						rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
					ElseIf randchecker = 3 Then 
						rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
					ElseIf randchecker = 4 Then 
						rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
					Else
						rand = Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97))
					End If
					For j = 1 To 27
						'make sure we havn't used that variable
						If used(j) = rand Then
							ender = 0
						End If
					Next j
				Loop Until (ender = 1)
				'make that variable used
				used(i) = rand
				With txtDefs
					'write the definitions
					defchrand = Int(Rnd() * 2) + 1
					If defchrand = 1 Then
						sette = "%" & Setter(1) & "%" & "%" & Setter(2) & "%" & "%" & Setter(3) & "%"
					Else
						sette = "%" & defrand & "%"
					End If
					.Text = .Text & sette & " " & rand & "=" & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(13) & Chr(10)
					trasha = Int(Rnd() * 4) + 1
					If trasha = 1 Then Call trash()
					.Text = .Text & sette & " " & rand & "=" & Chr(chars(i)) & Chr(13) & Chr(10) 'The true statment
					trasha = Int(Rnd() * 4) + 1
					If trasha = 1 Then Call trash()
					.Text = .Text & "goto " & rand & Chr(13) & Chr(10)
					trasha = Int(Rnd() * 4) + 1
					If trasha = 1 Then Call trash()
					.Text = .Text & sette & " " & " " & rand & "=" & Chr(Int(Rnd() * 26 + 97)) & Chr(Int(Rnd() * 26 + 97)) & Chr(13) & Chr(10)
					trasha = Int(Rnd() * 4) + 1
					If trasha = 1 Then Call trash()
					.Text = .Text & ":" & rand & Chr(13) & Chr(10)
				End With
			End If
		Next i
		'definitions made; now we can encrypt
		cmdEncrypt.Enabled = True
	End Sub
	
	Sub trash()
		Dim c As Object
		Dim b As Object
		Dim a As Object
		Dim Number As Object
		With txtDefs
			Number = Int(Rnd() * 40) + 10
			Do While a < Number
				b = Int(Rnd() * 26) + 97
				c = c + Chr(b)
				a = a + 1
			Loop 
			.Text = .Text + c + Chr(13) & Chr(10)
		End With
	End Sub
	
	Sub findletters()
		Dim j As Object
		Dim i As Object
		Dim checkvar As Object
		Dim charscount As Object
		With txtBatch
			charscount = 1
			checkvar = 1
			For i = 1 To Len(.Text)
				If Asc(Mid(.Text, i, 1)) < 123 And Asc(Mid(.Text, i, 1)) > 96 Then
					For j = 1 To 27
						If Asc(Mid(.Text, i, 1)) = chars(j) Then checkvar = 0
					Next 
					If checkvar = 1 Then
						chars(charscount) = Asc(Mid(.Text, i, 1))
						charscount = charscount + 1
					End If
				End If
			Next 
		End With
	End Sub
	
	Private Sub cmdHelp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelp.Click
		'just a msgbox... interesting? eh?
        MsgBox("Batch Encrpyt - Version 3.0" & Chr(13) & Chr(10) & "Coded By Sputterfish & Tim Strazzere & SPTH." & Chr(10) & Chr(13) & Chr(10) & Chr(13) & "How do you use it?" & Chr(13) & Chr(10) & "First off, load your batch file using the 'Load' button, or paste it into the text box deemed for it. " & Chr(13) & Chr(10) & "Next, generate the definitions for the letters, do this by pressing the 'Generate Defs.' button," & Chr(13) & Chr(10) & "if you deem these definitions acceptable then continue, otherwise reclick until your satisfied." & Chr(13) & Chr(10) & "Then click the 'Encrypt .bat' button. This will then generated the encrypted batch file in the" & Chr(13) & Chr(10) & "third text box, which is clearly marked. Now you can copy the code using the Copy Code button " & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "*NOTE: ONLY LOWERCASE CHARACTERS WILL BE CONVERTED, SYMBOLS AND UPPERCASE" & Chr(13) & Chr(10) & "SHOULD BE RESERVED FOR VARIABLE NAMES! (i.e. - %WINPATH% will not be" & Chr(13) & Chr(10) & "though in %winpath%, winpath would be converted - creating an error)" & Chr(10) & Chr(13) & Chr(10) & Chr(13) & "For more indepth information and help consult ReadMe.txt.")
	End Sub
	
	Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Randomize() 'must be for random numbers
		txtDefs.ReadOnly = True 'disable the editing of the text box
		txtEncrypted.ReadOnly = True 'disable the editing of the text box
		cmdEncrypt.Enabled = False 'You'll get an error if the user encrypt's without definitions
	End Sub
End Class