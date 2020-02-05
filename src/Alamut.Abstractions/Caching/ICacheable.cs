namespace Alamut.Abstractions.Caching
{
    /// <summary>
    /// apply to a Request in a Messaging systems like MediatR
    /// and cache the Response of the that Request by provided information 
    /// </summary>
    public interface ICacheable
    {
        /// <summary>
        /// represents unique caching key
        /// </summary>
        string Key { get; }

        /// <summary>
        /// represent caching expiration option (it could be null and act as default provider) 
        /// </summary>
        ExpirationOptions Options { get; }
    }
}
