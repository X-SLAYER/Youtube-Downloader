Imports xNet
Imports System.Text.RegularExpressions

Public Class Req

    Private URI As String
    Public TrackID As String
    Public Format As String
    Public Errone As Boolean = False
    Public _id, v_id, ajax, ftype, quality As String


    Public Event ConvertStart(sender As Object, Result As String)
    Public Event RequestComplete(sender As Object, Result As String)

    Public Sub Requ(ByVal name As String)
        Try

            Using request As New HttpRequest
                request.Proxy = Nothing
                request.UserAgent = Http.ChromeUserAgent
                request.KeepAlive = True
                request.Cookies = New CookieDictionary(False)
                request.IgnoreProtocolErrors = True
                request.AllowAutoRedirect = False

                request.AddHeader("X-Requested-With", "XMLHttpRequest")

                request.AddParam("url", name)
                request.AddParam("ajax", "1")

                Dim response As String = ""
                Dim rep As HttpResponse = request.Post(Me.URI)
                If rep.HasRedirect = True Then
                    response = request.Get(rep.RedirectAddress.ToString(), Nothing).ToString()
                Else
                    response = rep.ToString()
                End If

                If response.Contains("Sorry, we can not process this video") Then
                    Errone = True
                End If

                RaiseEvent ConvertStart(Me, response)

                _id = Regex.Match(response, "\\n_id: '(.*?)',").Groups(1).Value
                v_id = Regex.Match(response, "v_id: '(.*?)',").Groups(1).Value  '128

                request.AddHeader("X-Requested-With", "XMLHttpRequest")

                request.AddParam("type", "youtube")
                request.AddParam("_id", _id)
                request.AddParam("v_id", v_id)
                request.AddParam("ajax", ajax)
                request.AddParam("ftype", ftype)
                request.AddParam("fquality", quality)

                Dim R As String = ""
                Dim P As HttpResponse = request.Post("https://y2mate.com/fr/convert")
                If P.HasRedirect = True Then
                    R = request.Get(P.RedirectAddress.ToString(), Nothing).ToString()
                Else
                    R = P.ToString()
                End If


                RaiseEvent RequestComplete(Me, R)

            End Using
        Catch ex As Exception
            RaiseEvent RequestComplete(Me, ex.Message)
        End Try
    End Sub

    Public Sub insert(ByVal e As String)
        Me.TrackID = Regex.Match(e, ",""trackId"":""(.*?)"",").Groups(1).Value
    End Sub

    Public Sub SetURI(ByVal URI As String)
        Me.URI = URI
    End Sub
End Class
