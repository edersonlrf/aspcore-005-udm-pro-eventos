# aspcore-005-udm-pro-eventos

## urls

- http://localhost:5000/swagger/index.html
- https://localhost:5001/swagger/index.html

## comands

```
cd Back/src
dotnet new webapi -n ProEventos.API
```

```
cd Back/src/ProEventos.API
dotnet run
dotnet watch run
```

```
dotnet new gitignore --force
```

```
cd Back/src
dotnet tool install --global dotnet-ef --version 5
```

```
cd Back/src/ProEventos.API
dotnet ef migrations add Initial -o Data/Migrations
dotnet ef database update
```

```
cd Front
ng new ProEventos-App
cd Front/ProEventos-App
npm start
```

```
cd Front/ProEventos-App
ng g c eventos
```

```
cd Back/src/
dotnet new sln -n ProEventos
dotnet new classlib -n ProEventos.Persistence
dotnet new classlib -n ProEventos.Domain
dotnet new classlib -n ProEventos.Application
dotnet new classlib -n ProEventos.API
dotnet sln ProEventos.sln add ProEventos.Application
dotnet add ProEventos.API/ProEventos.API.csproj reference ProEventos.Application/ProEventos.Application.csproj
```

```
dotnet ef migrations add Initial -p ProEventos.Persistence -s ProEventos.API
dotnet ef database update -s ProEventos.API
```
