using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Results.Fluent.Tests
{
    [TestClass]
    public class ResultTests
    {
        [TestMethod]
        public void ShouldHasSuccessWithResult()
        {
            // when
            var result = Result.Success();

            // then
            result.Succeeded.Should().BeTrue();
            result.IsSucceeded.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldHAsFailureWithResult()
        {
            // when
            var result = Result.Failure();

            // then
            result.Succeeded.Should().BeFalse();
            result.IsFailed.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldHasErrorsWithResult()
        {
            // given
            var expect = "error";

            // when
            var result = Result.Failure(expect);

            // then
            result.Errors.Contains(expect).Should().BeTrue();
            result.HasError.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldHasMessageWithResult()
        {
            // given
            var expect = "message";

            // when
            var result = Result.Success().WithMessage(expect);

            // then
            result.Message.Should().Be(expect);
        }

        [TestMethod]
        public void ShouldHasResponseWithSuccessResult()
        {
            var result = Result.Success().BadRequest();
            result.Response.Should().Be(ResultResponse.BadRequest);
            result.IsBadRequest.Should().BeTrue();

            result = Result.Success().Unauthorized();
            result.Response.Should().Be(ResultResponse.Unauthorized);
            result.IsUnauthorized.Should().BeTrue();

            result = Result.Success().Forbidden();
            result.Response.Should().Be(ResultResponse.Forbidden);
            result.IsForbidden.Should().BeTrue();

            result = Result.Success().NotFound();
            result.Response.Should().Be(ResultResponse.NotFound);
            result.IsNotFound.Should().BeTrue();

            result = Result.Success().NotAllowed();
            result.Response.Should().Be(ResultResponse.NotAllowed);
            result.IsNotAllowed.Should().BeTrue();

            result = Result.Success().Conflict();
            result.Response.Should().Be(ResultResponse.Conflict);
            result.IsConflict.Should().BeTrue();

            result = Result.Success().Invalid();
            result.Response.Should().Be(ResultResponse.Invalid);
            result.IsInvalid.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldHasSuccessWithContainerResult()
        {
            // given
            var expect = 100;

            // when
            var result = ValueResult<int>.Success(expect);

            // then
            result.Succeeded.Should().BeTrue();
            result.Container.Should().Be(expect);
        }

        [TestMethod]
        public void ShouldHasSuccessWithObjectContainerResult()
        {
            // given
            var expect = new object();

            // when
            var result = Result<object>.Success(expect);

            // then
            result.Succeeded.Should().BeTrue();
            result.Container.Should().Be(expect);
        }

        [TestMethod]
        public void ShouldHasFailureWithContainerResult()
        {
            // when
            var result = ValueResult<int>.Failure();

            // then
            result.Succeeded.Should().BeFalse();
        }

        [TestMethod]
        public void ShouldHasErrorsWithContainerResult()
        {
            // given
            var expect = "error";

            // when
            var result = ValueResult<int>.Failure(expect);

            // then
            result.Errors.Contains(expect).Should().BeTrue();
            result.HasError.Should().BeTrue();
        }

        [TestMethod]
        public void ShouldHasMessageWithContainerResult()
        {
            // given
            var expect = 100;
            var expectMessage = "message";

            // when
            var result = ValueResult<int>.Success(expect).WithMessage(expectMessage);

            // then
            result.Container.Should().Be(expect);
            result.Message.Should().Be(expectMessage);
        }

        [TestMethod]
        public void ShouldHasResponseWithSuccessContainerResult()
        {
            // given
            var expect = 100;

            var result = ValueResult<int>.Success(expect).BadRequest();
            result.Container.Should().Be(expect);
            result.Response.Should().Be(ResultResponse.BadRequest);
            result.IsBadRequest.Should().BeTrue();

            result = ValueResult<int>.Success(expect).Unauthorized();
            result.Container.Should().Be(expect);
            result.Response.Should().Be(ResultResponse.Unauthorized);
            result.IsUnauthorized.Should().BeTrue();

            result = ValueResult<int>.Success(expect).Forbidden();
            result.Container.Should().Be(expect);
            result.Response.Should().Be(ResultResponse.Forbidden);
            result.IsForbidden.Should().BeTrue();

            result = ValueResult<int>.Success(expect).NotFound();
            result.Container.Should().Be(expect);
            result.Response.Should().Be(ResultResponse.NotFound);
            result.IsNotFound.Should().BeTrue();

            result = ValueResult<int>.Success(expect).NotAllowed();
            result.Container.Should().Be(expect);
            result.Response.Should().Be(ResultResponse.NotAllowed);
            result.IsNotAllowed.Should().BeTrue();

            result = ValueResult<int>.Success(expect).Conflict();
            result.Container.Should().Be(expect);
            result.Response.Should().Be(ResultResponse.Conflict);
            result.IsConflict.Should().BeTrue();

            result = ValueResult<int>.Success(expect).Invalid();
            result.Container.Should().Be(expect);
            result.Response.Should().Be(ResultResponse.Invalid);
            result.IsInvalid.Should().BeTrue();
        }
    }
}
