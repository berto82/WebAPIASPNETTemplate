Module Program
    Sub Main(args As String())

        Dim builder = WebApplication.CreateBuilder(args)

        'Add services to the container.

        builder.Services.AddControllers()
        'Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer()
        builder.Services.AddSwaggerGen()

        Dim app = builder.Build()

        'Configure the HTTP request pipeline.
        If app.Environment.IsDevelopment() Then
            app.UseSwagger()
            app.UseSwaggerUI()
        End If

        app.UseHttpsRedirection()

        app.UseAuthorization()

        app.MapControllers()

        app.Run()

    End Sub
End Module
