# saltoapis-dotnet

This repository contains the source code for the C# SALTO APIs SDK.

> Some of these APIs are using gRPC. Refer to the [official gRPC documentation](https://docs.microsoft.com/en-us/aspnet/core/grpc/client?view=aspnetcore-5.0) to learn more about gRPC.

## Status (Unofficial)

These packages are **not official** SALTO packages.

- Packages under `src` are rebuilds of the SALTO code.
- Packages under `src-extended` are rebuilds of the original code with refactoring to reduce size and improve performance.


## Authentication Example

The SDK provides a simple gRPC interceptor that will automatically get and refresh valid access tokens and include them in all gRPC requests:
```c#
// create a gRPC channel
GrpcChannel channel = GrpcChannel.ForAddress("https://nebula.saltoapis.com");

// Create a new SaltoapisAuthInterceptor with your user credentials
var authInterceptor = new SaltoapisAuthInterceptor(clientID, clientSecret);

// And add the interceptor to your channel
var invoker = ChannelExtensions.Intercept(channel, authInterceptor);

// Now you can use the resulting invoker to instantiate gRPC services
var service = new UserService.UserServiceClient(invoker);
```

You can find more information about authentication at https://developer.saltosystems.com/nebula/api/authentication/.

## Setup

Les packages NuGet sont publiés directement sur https://www.nuget.org.  
Vous pouvez installer un package avec `dotnet` :

```bash
dotnet add package Community.Saltoapis.Nebula.User.V1
```

Remplacez le nom du package par celui dont vous avez besoin (préfixe `Community.Saltoapis.*` ou `Community.Saltoapis.Extended.*`).
