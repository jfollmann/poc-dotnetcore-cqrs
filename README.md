# .netCore - CQRS

Create new webapi with controllers:
```sh
dotnet new webapi --use-controllers --framework net8.0 -n poc-dotnet-cqrs
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


References: https://balta.io/blog/aspnet-core-cqrs-mediator
