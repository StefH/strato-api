# ![Project Icon](resources/blockapps-logo-blue-t_64.png) Strato Client and Strato Bloc Client
Strato BlockApps C# Client which uses [RestEase](https://github.com/canton7/RestEase) to generate an API interface for:

* [Strato API](http://stratodev.blockapps.net/docs/?url=/strato-api/eth/v1.2/swagger.json) version **1.2** (supports 14 from 15 methods)
* [Bloc API](http://stratodev.blockapps.net/docs/?url=/bloc/v2.2/swagger.json) version **2.2** (supports 8 from 26 methods)

### NuGet

| Name | NuGet |
| ---- | ----- |
| Strato.Client | [![NuGet Badge](https://buildstats.info/nuget/Strato.Client)](https://www.nuget.org/packages/Strato.Client) |
| Strato.Bloc.Client | [![NuGet Badge](https://buildstats.info/nuget/Strato.Bloc.Client)](https://www.nuget.org/packages/Strato.Bloc.Client) |

### Frameworks
The following frameworks are supported:
- net 4.5
- net 4.6
- netstandard 1.1
- netstandard 2.0


### Usage example for Strato Client

``` charp
var client = RestClient.For<IStratoApi>("http://stratodev.blockapps.net/strato-api/eth/v1.2/");

var transactions = await client.TransactionsGetAsync("e1fd0d4a52b75a694de8b55528ad48e2e2cf7859");
```

---

### Usage example for Strato Bloc Client

``` charp
var client = RestClient.For<IStratoBlocApi>("http://stratodev.blockapps.net/bloc/v2.2/");

var users = await client.UsersGetAsync();
```
