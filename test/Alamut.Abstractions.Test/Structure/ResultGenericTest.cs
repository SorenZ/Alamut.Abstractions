using System;
using Alamut.Abstractions.Structure;
using Alamut.Abstractions.Test.Helpers;
using Xunit;

namespace Alamut.Abstractions.Test.Structure
{
    public class ResultGenericTest
    {
        [Fact]
        public void GenericResult_OkayMethorDefault_ReturnDataAndSuccess()
        {
        //Given
            var foo = new Foo("GenericResult_OkayMethorDefault_ReturnDataAndSuccess");
            var actual = new Result<Foo>
            {
                Data = foo,
                Succeed = true,
                Message = "",
                StatusCode = 200
            };

        //When
            var expected = Result<Foo>.Okay(foo);

        //Then
            Assert.Equal(expected, actual);
            
        }

        [Fact]
        public void GenericResult_ErrorMethodDefault_ReturnUnsuccess()
        {
        //Given
            var actual = new Result<Foo>
            {
                Succeed = false,
                Message = "",
                StatusCode = 500
            };
        //When
            var expected = Result<Foo>.Error();
        
        //Then
            Assert.Equal(expected, actual);

        }

        [Fact]
       public void GenericResult_ExceptionMethodDefault_ReturnUnsuccess()
       {
       //Given
            var exception = new Exception("Result_ExceptionMethodDefault_ReturnUnsuccess");
            var actual = new Result<Foo>
            {
                Succeed = false,
                Message = exception.ToString(),
                StatusCode = 500
            };

       //When
            var expected = Result<Foo>.Exception(exception);

       //Then
            Assert.Equal(expected, actual);
       }

       [Fact]
       public void Result_BoolOperatorOnSuccess_ReturnTrue()
       {
       //Given
            var actual = new Result<Foo>
            {
                Succeed = true,
                Message = "",
                StatusCode = 200
            };

       //When
            var expected = Result<Foo>.Okay();

        //Then
            Assert.True(actual);
            Assert.True(expected);
       }

       [Fact]
       public void Result_BoolOperatorOnUnsuccess_ReturnFalse()
       {
       //Given
            var actual = new Result<Foo>
            {
                Succeed = false,
                Message = "",
                StatusCode = 500
            };

       //When
            var error = Result<Foo>.Error();
            var exception = Result<Foo>.Exception(new Exception());

        //Then
            Assert.False(actual);
            Assert.False(error);
            Assert.False(exception);
       }

    //    public Foo Demo1()
    //    {
    //        var result = ExternalService();
    //        if(result)
    //         { return result.Data; }
    //         else
    //         {
    //             _logger.LogError(result.Message);
    //             return NotFound();
    //         }
    //    }

    //    private Result<Foo> ExternalService()
    //    {
    //         // do some network comunication and return value
    //         var value = new Foo("bar");

    //         return Result<Foo>.Okay(value);
    //         return Result<Foo>.Exception(new TimeoutException());
    //         return Result<Foo>.Error("something bad happend");
    //    }
    }


}