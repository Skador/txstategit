Public Class Form1
    Private WithEvents myStation As New WeatherStation

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        myStation.MonitorTheWeather()
    End Sub

    Private Sub myStation_Normal() Handles myStation.Normal
        Label2.Text = "The weather seems normal. Nothing special."
    End Sub

    Private Sub myStation_Lightening() Handles myStation.Lightening
        Label2.Text = "There is Lightening in the area. Kinda scary..."
    End Sub

    Private Sub myStation_Snowing() Handles myStation.Snowing
        Label2.Text = "Snow is currently falling. Time for a snowball fight!"
    End Sub

    Private Sub myStation_Raining() Handles myStation.Raining
        Label2.Text = "It is currently raining. Get the canoes."
    End Sub

End Class
