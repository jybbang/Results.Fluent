# Results.Fluent

[![NuGet](https://img.shields.io/nuget/v/Results.Fluent.svg)](https://www.nuget.org/packages/Results.Fluent/)
![Build And Deploy](https://github.com/jybbang/Results.Fluent/workflows/Build%20And%20Deploy/badge.svg)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/jybbang/Results.Fluent/blob/master/LICENSE)

**Results.Fluent
 is a small library to use well-formed return type in the DDD architecture.**

You can install [Results.Fluent with NuGet](https://www.nuget.org/packages/Results.Fluent/):

```
Install-Package Results.Fluent
```

To use, with an `Result` instance :

```c#
var result = Result.Success();
if(result.IsSucceeded) return true;
```

```c#
var result = Result.Success().WithMessage("Perfect");
if(result.IsSucceeded && result.HasMessage && result.Message == "Perfect") return true;
```

```c#
var result = Result.Failure();
if(result.IsFailed) return false;
```

```c#
var result = Result.Failure("Can Not Open");
if(result.IsFailed && result.HasError) return false;
```

```c#
var result = Result.Failure().NotFound();
if(result.IsFailed && result.IsNotFound) return false;
```

> also try 'BadRequest', 'Unauthorized', 'Forbidden', NotFound', 'NotAllowed', 'Conflict', 'Invalid'

Or, you can contain some object `Result<TContainer>`

```c#
var result = Result<int>.Success(200);
if(result.IsSucceeded && result.Container == 200) return true;
```

```c#
var result = Result<int>.Failure().Unauthorized();
if(result.IsFailed && result.IsUnauthorized) return false;
```

## Copyright

Copyright (c) Jungyoung bang.
