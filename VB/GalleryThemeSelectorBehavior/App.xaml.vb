Imports DevExpress.Xpf.Core
Imports System.Linq
Imports System.Windows

Namespace GalleryThemeSelectorBehavior

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Public Sub New()
            For Each theme As Theme In Theme.Themes.ToList()
                Select Case theme.Category
                    Case Theme.Office2007Category
                        theme.ShowInThemeSelector = False
                    Case Theme.MetropolisCategory
                        theme.ShowInThemeSelector = False
                    Case Else
                End Select

                If Equals(theme.Name, "DeepBlue") Then
                    theme.ShowInThemeSelector = False
                End If
            Next
        End Sub
    End Class
End Namespace
