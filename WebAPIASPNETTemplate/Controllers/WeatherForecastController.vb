Namespace Controllers
    <ApiController>
    <Route("[controller]")>
    Public Class WeatherForecastController
        Inherits ControllerBase

        Private ReadOnly Summaries() As String = New String() {"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"}

        Private ReadOnly _logger As ILogger(Of WeatherForecastController)

        Public Sub New(logger As ILogger(Of WeatherForecastController))
            _logger = logger
        End Sub


        <HttpGet(Name:="GetWeatherForecast")>
        Public Function [Get]() As IEnumerable(Of WeatherForecast)

            Return Enumerable.Range(1, 5).Select(Function(index) New WeatherForecast With {
                   .Date = DateOnly.FromDateTime(Date.Now.AddDays(index)),
                   .TemperatureC = New Random().Next(-20, 55),
                   .Summary = Summaries(New Random().Next(Summaries.Length))
               }).ToArray()

        End Function

    End Class
End Namespace