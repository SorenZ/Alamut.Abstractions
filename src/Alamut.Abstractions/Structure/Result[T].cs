namespace Alamut.Abstractions.Structure
{
    /// <summary>
    /// represents a generic data wrapper for Result 
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
        /// returns a typed ServiceResult with an error
        /// </summary>
        /// <param name="message">error message</param>
        /// <param name="statusCode"></param>
        /// <returns>error ServiceResult</returns>
        public new static Result<T> Error(string message = "",int statusCode = 500)
        {
            return new Result<T>
            {
                Succeed = false,
                Message = message,
                StatusCode = statusCode
            };
        }

    }
}