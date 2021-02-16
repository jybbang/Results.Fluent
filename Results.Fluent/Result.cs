using System;
using System.Collections.Generic;
using System.Linq;

namespace Results.Fluent
{
    public class Result
    {
        public bool Succeeded { get; internal set; }

        public string[] Errors { get; }

        public string Message { get; internal set; }

        public ResultResponse Response { get; internal set; }

        public bool IsSucceeded => Succeeded;

        public bool IsFailed => !Succeeded;

        public bool HasMessage => !string.IsNullOrEmpty(Message);

        public bool HasError => Errors.Any();

        public bool HasResponse => !(Response is null);

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
            Errors = Array.Empty<string>();
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

    public class Result<TContainer> : Result
    {
        public TContainer Container { get; } = default(TContainer);

        internal Result(bool succeeded, IEnumerable<string> errors, TContainer container = default)
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
