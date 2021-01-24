### hello-aspx

#### run with runtime compilation
dotnet watch run

#### short cuts
##### format source code 
all document: press down `ctrl` + `k` then press `d`  
for selection: press down `ctrl` + `k` then press `f`
##### open terminal in vs
`ctrl` + *`*
##### commets/cancel comments
`ctrl` + `k` + `c`/`ctrl` + `k` + `u`
##### upper case/lower case
`ctrl` + `shift` + `u`/`ctrl` + `u`

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