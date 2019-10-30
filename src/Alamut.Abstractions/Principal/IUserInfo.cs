namespace Alamut.Abstractions.Principal
{
    public interface IUserInfo
    {
        /// <summary>
        /// gets current user Username
        /// </summary>
        string UserName { get; }

        /// <summary>
        /// gets current user full name (first name + family)
        /// </summary>
        string Name { get; }

        /// <summary>
        /// gets current user friendly name (fore name)
        /// if it doesn't represented return userName
        /// </summary>
        string GivenName { get; }

        /// <summary>
        /// gets current user UserId
        /// </summary>
        string UserId { get; }

        /// <summary>
        /// gets current user Ip Address
        /// </summary>
        string GetClientIpAddress(bool tryUseXForwardHeader = true);

        /// <summary>
        /// get current user browser information
        /// </summary>
        string UserAgent { get; }

        /// <summary>
        /// path of current request
        /// </summary>
        string RequestPath { get; }
        
        /// <summary>
        /// give current request query string
        /// </summary>
        string RequestQueryString { get; }

        /// <summary>
        /// give current method of request
        /// </summary>
        string RequestMethod { get; }
    }
}