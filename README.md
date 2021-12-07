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

```
