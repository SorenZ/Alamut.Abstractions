using System;

namespace Alamut.Abstractions.Structure
{
    /// <summary>
    /// represent result data structure for API services
    /// </summary>
    public class Result
    {
        public bool Succeed { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }

        /// <summary>
        /// provides a successfull result 
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="statusCode"></param>
        /// <returns>successfull result</returns>
        public static Result Okay(string message = "", int statusCode = 200)
        {
            return new Result
            {
                Succeed = true,
                Message = message,
                StatusCode = statusCode
            };
        }

        /// <summary>
        /// provides an unsuccessfull Result
        /// </summary>
        /// <param name="message">error message</param>
        /// <param name="statusCode"></param>
        /// <returns>error (unsuccessfull) result</returns>
        public static Result Error(string message = "", int statusCode = 500)
        {
            return new Result
            {
                Succeed = false,
                Message = message,
                StatusCode = statusCode
            };
        }

        /// <summary>
        /// creates an unsuccessfull Result from an exception
        /// </summary>
        /// <param name="ex">the exception</param>
        /// <param name="statusCode"></param>
        /// <returns>error Result</returns>
        public static Result Exception(Exception ex, int statusCode = 500)
        {
            return new Result
            {
                Succeed = false,
                Message = ex.ToString(),
                StatusCode = statusCode
            };
        }

        public static implicit operator bool(Result result) => result.Succeed;

        #region Object overrides 

        public override bool Equals(object obj)
        {
            var sr = obj as Result;

            if (sr == null)
            { return false; }


            return this.Succeed == sr.Succeed && this.StatusCode == sr.StatusCode;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return Convert.ToInt32(this.Succeed) + this.StatusCode;
            }
        }
        
        #endregion
    }
}