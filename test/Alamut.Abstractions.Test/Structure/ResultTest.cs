﻿using System;
using Alamut.Abstractions.Structure;
using Xunit;

namespace Alamut.Abstractions.Test.Structure
{
    public class ResultTest
    {
       [Fact]
       public void Result_OkayMethodDefault_ReturnSuccess()
       {
        //Given
            var actual = new Result
            {
                Succeed = true,
                Message = "",
                StatusCode = 200
            };
        
        //When
            var expected = Result.Okay();

        //Then
            Assert.Equal(expected, actual);
       }

       [Fact]
       public void Result_ErrorMethodDefault_ReturnUnsuccess()
       {
        //Given
            var actual = new Result
            {
                Succeed = false,
                Message = "",
                StatusCode = 500
            };

       //When
            var expected = Result.Error();

       //Then
            Assert.Equal(expected, actual);
       }

       [Fact]
       public void Result_ExceptionMethodDefault_ReturnUnsuccess()
       {
       //Given
            var exception = new Exception("Result_ExceptionMethodDefault_ReturnUnsuccess");
            var actual = new Result
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

       [Fact]
       public void Result_BoolOperatorOnSuccess_ReturnTrue()
       {
       //Given
            var actual = new Result
            {
                Succeed = true,
                Message = "",
                StatusCode = 200
            };

       //When
            var expected = Result.Okay();

        //Then
            Assert.True(actual);
            Assert.True(expected);
       }

       [Fact]
       public void Result_BoolOperatorOnUnsuccess_ReturnFalse()
       {
       //Given
            var actual = new Result
            {
                Succeed = false,
                Message = "",
                StatusCode = 500
            };

       //When
            var error = Result.Error();
            var exception = Result.Exception(new Exception());

        //Then
            Assert.False(actual);
            Assert.False(error);
            Assert.False(exception);
       }
    }
}
