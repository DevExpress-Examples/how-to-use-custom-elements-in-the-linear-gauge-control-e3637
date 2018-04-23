Imports Microsoft.VisualBasic
Imports System.Windows.Controls

Namespace LinearGaugeControl_CustomElement
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
			If bar.Value < 100 Then
				bar.Value += 10
			End If
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
			If bar.Value > 0 Then
				bar.Value -= 10
			End If
		End Sub
	End Class
End Namespace
