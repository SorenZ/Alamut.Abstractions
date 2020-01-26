using System;

namespace Alamut.Abstractions.Messaging
{
    /// <summary>
    /// binds a MessageHandler to specific topic(s)
    /// </summary>
    [Obsolete("use IMessageHandler.Topics[] to adjust topics", true)]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class TopicsAttribute : Attribute
    {
        public string[] Topics { get; }

        public TopicsAttribute(params string[] topics)
        {
            Topics = topics;
        }
    }
}