Public Class Synchronizer

    Dim Controls As New ArrayList()
    Dim Text As Object

    'Public Delegate Sub SyncDelegate(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event ObjectChanged(ByVal newObject As Object, ByVal oldObject As Object)
    Public Event ObjectAdded(ByRef addedControl As Object)

    Public ReadOnly Property SyncText() As String
        Get
            Return Text
        End Get
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByRef c1 As Object, ByRef c2 As Object)
        AddNewControl(c1)
        AddNewControl(c2)
    End Sub

    ''' <summary>
    ''' Adds a new control to be synchronized.
    ''' </summary>
    ''' <param name="newControl">A ByRef of the control you want to add to the collection.</param>
    ''' <remarks></remarks>
    Public Sub AddNewControl(ByRef newControl As Object, Optional ByVal ConstrainControlType As Boolean = True)
        Dim ControlType As String = ""

        If ConstrainControlType AndAlso Controls.Count > 0 Then
            ControlType = Controls(0).GetType.ToString
        End If

        If ControlType = "" OrElse newControl.GetType.ToString = ControlType Then
            '**********************************************************************
            '* What event to listen for in the passed object to fire the updates. *
            '**********************************************************************
            Select Case newControl.GetType.ToString
                Case "System.Windows.Forms.TextBox"
                    Dim c As TextBox = newControl
                    Text = c.Text
                    AddHandler c.TextChanged, AddressOf Me.AutoSync
                Case "System.Windows.Forms.DateTimePicker"
                    Dim c As DateTimePicker = newControl
                    Text = c.Value
                    AddHandler c.ValueChanged, AddressOf Me.AutoSync
                Case "System.Windows.Forms.CheckBox"
                    Dim c As CheckBox = newControl
                    Text = c.Checked
                    AddHandler c.CheckStateChanged, AddressOf Me.AutoSync
                Case "System.Windows.Forms.ComboBox"
                    Dim c As ComboBox = newControl
                    Text = c.SelectedIndex
                    AddHandler c.SelectedIndexChanged, AddressOf Me.AutoSync
                Case "System.Windows.Forms.CheckedListBox"
                    Dim c As CheckedListBox = newControl
                    Text = c.CheckedIndices
                    AddHandler c.ItemCheck, AddressOf Me.AutoSync
            End Select

            Controls.Add(newControl)

            RaiseEvent ObjectAdded(newControl)
        End If
    End Sub

    ''' <summary>
    ''' Sets the new value for the Synchronizer and distributes it to the associated controls.
    ''' </summary>
    ''' <param name="newText">String value of the new text.</param>
    ''' <remarks></remarks>
    Public Sub SetText(ByVal newText As Object)
        Dim go As Boolean = True
        Try
            go = newText <> Text
        Catch ex As Exception
            go = newText Is Text
        End Try

        If go Then
            Dim ot As Object = Text
            Text = newText
            '***********************************************************************
            '* Where to put the value when it gets distributed across the objects. *
            '***********************************************************************
            For Each c As Object In Controls
                Select Case c.GetType.ToString
                    Case "System.Windows.Forms.TextBox"
                        c.Text = newText
                    Case "System.Windows.Forms.DateTimePicker"
                        c.value = newText
                    Case "System.Windows.Forms.CheckBox"
                        c.checked = newText
                    Case "System.Windows.Forms.ComboBox"
                        c.selectedIndex = newText
                    Case "System.Windows.Forms.CheckedListBox"
                        Dim i As Integer = 0
                        'While i < c.items.count
                        '    c.SetItemChecked(i, False)
                        '    i += 1
                        'End While

                        For Each i In newText
                            c.SetItemChecked(i, True)
                        Next
                End Select
            Next

            RaiseEvent ObjectChanged(newText, ot)
        End If
    End Sub

    Private Sub AutoSync(ByVal sender As Object)
        Dim newText As Object = ""

        '*******************************************************
        '* Where to get the new value from in the sent object. *
        '*******************************************************
        Select Case sender.GetType.ToString
            Case "System.Windows.Forms.TextBox"
                newText = sender.text
            Case "System.Windows.Forms.DateTimePicker"
                newText = sender.value
            Case "System.Windows.Forms.CheckBox"
                newText = sender.checked
            Case "System.Windows.Forms.ComboBox"
                newText = sender.selectedIndex
            Case "System.Windows.Forms.CheckedListBox"
                newText = sender.CheckedIndices
        End Select

        SetText(newText)
    End Sub
    Private Sub AutoSync(ByVal sender As Object, ByVal e As System.EventArgs)
        AutoSync(sender)
    End Sub

    Private Sub AutoSync(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        AutoSync(sender)
    End Sub


End Class
