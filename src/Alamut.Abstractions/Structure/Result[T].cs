using System;

namespace Alamut.Abstractions.Structure
{
    /// <summary>
    /// represents a generic data container that represent data with Result behavior
    /// </summary>
    /// <typeparam name="T">wrapped data</typeparam>
    public class Result<T> : Result
    {
        public T Data { get; set; }

        /// <summary>
        /// provides data wrapped in successfull result 
        /// </summary>
        /// <param name="data">return data</param>
        /// <param name="message">the result message</param>
        /// <param name="statusCode">the result status code</param>
        /// <returns>successfull result with data</returns>
        public static Result<T> Okay(T data, string message = "", int statusCode = 200)
        {
            return new Result<T>
            {
                Succeed = true,
                Message = message,
                Data = data,
                StatusCode = statusCode
            };
        }

        /// <summary>
        /// provides an unsuccessfull Result
        /// </summary>
        /// <param name="message">error message</param>
        /// <param name="statusCode"></param>
        /// <returns>error (unsuccessfull) result</returns>
        public new static Result<T> Error(string message = "", int statusCode = 500)
        {
            return new Result<T>
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
        /// <returns>error (unsuccessfull) result</returns>
        public new static Result<T> Exception(Exception ex, int statusCode = 500)
        {
            return new Result<T>
            {
                Succeed = false,
                Message = ex.ToString(),
                StatusCode = statusCode
            };
        }

        public static implicit operator bool(Result<T> result) => result.Succeed;

        #region Object overrides 
        public override bool Equals(object obj)
        {
            var sr = obj as Result<T>;

            if (sr == null)
            { return false; }

            if (this.Succeed && this.Data != null)
            {
                return this.Succeed == sr.Succeed
                   && this.StatusCode == sr.StatusCode
                   && this.Data.Equals(sr.Data);
            }

            return this.Succeed == sr.Succeed
                && this.StatusCode == sr.StatusCode;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                if (this.Data == null)
                {
                    return Convert.ToInt32(this.Succeed)
                    + this.StatusCode;
                }
                else
                {
                    return Convert.ToInt32(this.Succeed)
                    + this.StatusCode
                    + this.Data.GetHashCode();
                }
            }
        }
        #endregion
    }
}