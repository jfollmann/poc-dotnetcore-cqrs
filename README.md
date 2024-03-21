# .netCore - CQRS

Create new webapi with controllers:
```sh
dotnet new webapi --use-controllers --framework net8.0 -n poc-dotnet-cqrs
```

## Types of Lifetime (Dependency Injection)
| Type      | Same Request     | Other Request        |
|-----------|------------------|----------------------|
| Singleton | Same instance    | Same instance        |
| Scoped    | Same instance    | New instance         |
| Transient | New instance     | New instance         |

Restore packages
```sh
dotnet restore
```

Clean project
```sh
dotnet clean
```

Build project
```sh
dotnet build
```

Run project
```sh
dotnet run
```

Get customer by uuid
```sh
curl -X GET \
http://localhost:5227/api/Customer?Id=0e60b197-53e8-4cd7-b536-c8a7b137902b | jq
```

Create new customer
```sh
curl --header "Content-Type: application/json" \
  -X POST \
  -d '{"Name": "Customer Sample", "Email": "cs@gmail.com"}' \
 http://localhost:5227/api/Customer | jq
```

References: 
- https://balta.io/blog/aspnet-core-cqrs-mediator
- https://stackoverflow.com/questions/75527541/could-not-load-type-mediatr-servicefactory
- https://pt.stackoverflow.com/a/528207