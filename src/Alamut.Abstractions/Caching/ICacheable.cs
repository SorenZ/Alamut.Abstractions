namespace Alamut.Abstractions.Caching
{
    /// <summary>
    /// apply to a Request in a Messaging systems like MediatR
    /// and cache the Response of the that Request by provided information 
    /// </summary>
    public interface ICacheable
    {
        string Key { get; }
        ExpirationOptions Options { get; }
    }
}
