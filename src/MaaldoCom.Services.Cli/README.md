# MaaldoCom.Services.Cli

## CLI Setup

### OpenAPI Document Specification Generation

Run the following command to install the OpenAPI tool globally:

```shell
dotnet tool install -g Microsoft.dotnet-openapi
```

Run the following command to generate or update the OpenAPI document specification:

```shell
dotnet openapi add url https://app-maaldocomapi-tst-cus.azurewebsites.net/openapi/v1.json
```