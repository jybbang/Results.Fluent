using System;
using System.Collections.Generic;
using System.Linq;

namespace Results.Fluent
{
    public class Result
    {
        public bool Succeeded { get; internal set; }

        public string[] Errors { get; } = Array.Empty<string>();

        public string Message { get; internal set; } = string.Empty;

        public ResultResponse Response { get; internal set; } = ResultResponse.None;

        public bool IsSucceeded => Succeeded;

        public bool IsFailed => !Succeeded;

        public bool HasMessage => !string.IsNullOrEmpty(Message);

        public bool HasError => Errors.Any();

        public bool HasResponse => Response != ResultResponse.None;

        public bool IsBadRequest => Response == ResultResponse.BadRequest;

        public bool IsUnauthorized => Response == ResultResponse.Unauthorized;

        public bool IsForbidden => Response == ResultResponse.Forbidden;

        public bool IsNotFound => Response == ResultResponse.NotFound;

        public bool IsNotAllowed => Response == ResultResponse.NotAllowed;

        public bool IsConflict => Response == ResultResponse.Conflict;

        public bool IsInvalid => Response == ResultResponse.Invalid;

        internal Result(bool succeeded, IEnumerable<string> errors)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        internal Result(bool succeeded)
        {
            Succeeded = succeeded;
        }

        public static Result Success()
        {
            return new Result(true);
        }

        public static Result Failure()
        {
            return new Result(false);
        }

        public static Result Failure(IEnumerable<string> errors)
        {
            return new Result(false, errors);
        }

        public static Result Failure(params string[] errors)
        {
            return new Result(false, errors);
        }
    }

    public class ValueResult<TContainer> : Result where TContainer : notnull
    {
        public TContainer Container { get; } = default!;

        internal ValueResult(bool succeeded, IEnumerable<string> errors, TContainer container)
            : base(succeeded, errors)
        {
            Container = container;
        }

        internal ValueResult(bool succeeded, IEnumerable<string> errors)
            : base(succeeded, errors)
        {
        }

        public static ValueResult<TContainer> Success(TContainer container)
        {
            return new ValueResult<TContainer>(true, Array.Empty<string>(), container);
        }

        public static new ValueResult<TContainer> Failure()
        {
            return new ValueResult<TContainer>(false, Array.Empty<string>());
        }

        public static new ValueResult<TContainer> Failure(IEnumerable<string> errors)
        {
            return new ValueResult<TContainer>(false, errors);
        }

        public static new ValueResult<TContainer> Failure(params string[] errors)
        {
            return new ValueResult<TContainer>(false, errors);
        }
    }

    public class Result<TContainer> : Result where TContainer : class
    {
        public TContainer? Container { get; }

        internal Result(bool succeeded, IEnumerable<string> errors, TContainer? container = null)
            : base(succeeded, errors)
        {
            Container = container;
        }

        public static Result<TContainer> Success(TContainer container)
        {
            return new Result<TContainer>(true, Array.Empty<string>(), container);
        }

        public static new Result<TContainer> Failure()
        {
            return new Result<TContainer>(false, Array.Empty<string>());
        }

        public static new Result<TContainer> Failure(IEnumerable<string> errors)
        {
            return new Result<TContainer>(false, errors);
        }

        public static new Result<TContainer> Failure(params string[] errors)
        {
            return new Result<TContainer>(false, errors);
        }
    }
}
