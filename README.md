### hello-aspx

#### run with runtime compilation
dotnet watch run

#### short cuts
##### format source code 
press down `ctrl` + `k` then press `f`
##### open terminal in vs
`ctrl` + *`*

#### view current running web app
View => Other Windows => Browser Link Dashboard

#### log configuration
```
/appsettings.json
/appsettings.Development.json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```

follow this tutorial: https://docs.microsoft.com/en-gb/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-5.0