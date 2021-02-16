# Results.Fluent

[![NuGet](https://img.shields.io/nuget/v/Results.Fluent.svg)](https://www.nuget.org/packages/Results.Fluent/)
![Build And Deploy](https://github.com/jybbang/Results.Fluent/workflows/Build%20And%20Deploy/badge.svg)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/jybbang/Results.Fluent/blob/master/LICENSE)

**Results.Fluent
 is a small library to use well-formed return type in thr DDD architecture.**

You can install [Results.Fluent with NuGet](https://www.nuget.org/packages/Results.Fluent/):

```
Install-Package Results.Fluent
```

To use, with an `Result` instance :

```c#
var result = Result.Success();
if(result.IsSuccess) return true;

result = Result.Success().WithMessage("Perfect");
if(result.HasMessage && result.Message == "Perfect") return true;

result = Result.Failure();
if(result.IsFailure) return false;

result = Result.Failure("Can Not Open");
if(result.IsFailure && result.HasError) return false;

result = Result.Failure().NotFound();
if(result.IsFailure && result.IsNotFound) return false;
```
Or, you can contain some object `Result<TContainer>`

```c#
result = Result<int>.Success(200);
if(result.IsSuccess && result.Container == 200) return true;

result = Result<int>.Failure().Unauthorized();
if(result.IsFailure && result.IsUnauthorized) return false;
```

## Copyright

Copyright (c) Jungyoung bang.
