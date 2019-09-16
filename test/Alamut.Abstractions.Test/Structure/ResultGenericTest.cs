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
            var expected = Result.Exception(exception);

       //Then
            Assert.Equal(expected, actual);
       }
    }


}