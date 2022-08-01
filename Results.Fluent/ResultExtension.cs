using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Results.Fluent
{
    public static class ResultExtension
    {
        public static Task<Result> AsAsync(this Result result)
        {
            return Task.FromResult(result);
        }

        public static Task<ValueResult<TContainer>> AsAsync<TContainer>(this ValueResult<TContainer> result) where TContainer : notnull
        {
            return Task.FromResult(result);
        }

        public static Task<Result<TContainer>> AsAsync<TContainer>(this Result<TContainer> result) where TContainer : class
        {
            return Task.FromResult(result);
        }

        public static Result WithMessage(this Result result, string message)
        {
            result.Message = message;
            return result;
        }

        public static Result BadRequest(this Result result)
        {
            result.Response = ResultResponse.BadRequest;
            return result;
        }

        public static Result Unauthorized(this Result result)
        {
            result.Response = ResultResponse.Unauthorized;
            return result;
        }

        public static Result Forbidden(this Result result)
        {
            result.Response = ResultResponse.Forbidden;
            return result;
        }

        public static Result NotFound(this Result result)
        {
            result.Response = ResultResponse.NotFound;
            return result;
        }

        public static Result NotAllowed(this Result result)
        {
            result.Response = ResultResponse.NotAllowed;
            return result;
        }

        public static Result Conflict(this Result result)
        {
            result.Response = ResultResponse.Conflict;
            return result;
        }

        public static Result Invalid(this Result result)
        {
            result.Response = ResultResponse.Invalid;
            return result;
        }

        public static ValueResult<TContainer> WithMessage<TContainer>(this ValueResult<TContainer> result, string message) where TContainer : notnull
        {
            result.Message = message;
            return result;
        }

        public static ValueResult<TContainer> BadRequest<TContainer>(this ValueResult<TContainer> result) where TContainer : notnull
        {
            result.Response = ResultResponse.BadRequest;
            return result;
        }

        public static ValueResult<TContainer> Unauthorized<TContainer>(this ValueResult<TContainer> result) where TContainer : notnull
        {
            result.Response = ResultResponse.Unauthorized;
            return result;
        }

        public static ValueResult<TContainer> Forbidden<TContainer>(this ValueResult<TContainer> result) where TContainer : notnull
        {
            result.Response = ResultResponse.Forbidden;
            return result;
        }

        public static ValueResult<TContainer> NotFound<TContainer>(this ValueResult<TContainer> result) where TContainer : notnull
        {
            result.Response = ResultResponse.NotFound;
            return result;
        }

        public static ValueResult<TContainer> NotAllowed<TContainer>(this ValueResult<TContainer> result) where TContainer : notnull
        {
            result.Response = ResultResponse.NotAllowed;
            return result;
        }

        public static ValueResult<TContainer> Conflict<TContainer>(this ValueResult<TContainer> result) where TContainer : notnull
        {
            result.Response = ResultResponse.Conflict;
            return result;
        }

        public static ValueResult<TContainer> Invalid<TContainer>(this ValueResult<TContainer> result) where TContainer : notnull
        {
            result.Response = ResultResponse.Invalid;
            return result;
        }

        public static Result<TContainer> WithMessage<TContainer>(this Result<TContainer> result, string message) where TContainer : class
        {
            result.Message = message;
            return result;
        }

        public static Result<TContainer> BadRequest<TContainer>(this Result<TContainer> result) where TContainer : class
        {
            result.Response = ResultResponse.BadRequest;
            return result;
        }

        public static Result<TContainer> Unauthorized<TContainer>(this Result<TContainer> result) where TContainer : class
        {
            result.Response = ResultResponse.Unauthorized;
            return result;
        }

        public static Result<TContainer> Forbidden<TContainer>(this Result<TContainer> result) where TContainer : class
        {
            result.Response = ResultResponse.Forbidden;
            return result;
        }

        public static Result<TContainer> NotFound<TContainer>(this Result<TContainer> result) where TContainer : class
        {
            result.Response = ResultResponse.NotFound;
            return result;
        }

        public static Result<TContainer> NotAllowed<TContainer>(this Result<TContainer> result) where TContainer : class
        {
            result.Response = ResultResponse.NotAllowed;
            return result;
        }

        public static Result<TContainer> Conflict<TContainer>(this Result<TContainer> result) where TContainer : class
        {
            result.Response = ResultResponse.Conflict;
            return result;
        }

        public static Result<TContainer> Invalid<TContainer>(this Result<TContainer> result) where TContainer : class
        {
            result.Response = ResultResponse.Invalid;
            return result;
        }
    }
}
