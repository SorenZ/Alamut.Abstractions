using System;
using Alamut.Abstractions.Messaging.MessageContracts;
using Alamut.Abstractions.Messaging.Messages;
using Alamut.Abstractions.Structure;

namespace Alamut.Abstractions.Messaging
{
    /// <summary>
    /// responsible for building variety types of Message 
    /// </summary>
    public static class MessageFactory
    {
        /// <summary>
        /// build a very basic Message provides Id and Body of actual Data
        /// </summary>
        /// <param name="body">The actual data that moves through messaging system</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Message<T> Build<T>(T body) =>
            new Message<T> { Body = body };

        /// <summary>
        /// build a very basic Message provides Id and Body of actual Data
        /// </summary>
        /// <param name="body">The actual data that moves through messaging system</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Message<T> Build<T>(string id, T body) =>
            new Message<T>
            {
                Id = id,
                Body = body
            };

        /// <summary>
        /// build a Message-with-Acknowledge 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="acknowledgeTopic">the topic that supposes the <see cref="AcknowledgeMessage"> will publish into it</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static MessageWithAcknowledge<T> Build<T>(T body, string acknowledgeTopic) =>
            new MessageWithAcknowledge<T>
            {
                Body = body,
                AcknowledgeRequested = true,
                AcknowledgeTopic = acknowledgeTopic
            };

        /// <summary>
        /// build full feature Message
        /// </summary>
        /// <param name="body">The actual data that moves through messaging system</param>
        /// <param name="eventName">indicates Publisher Event Name </param>
        /// <param name="acknowledgeRequested">indicates whether the publisher requests approval</param>
        /// <param name="acknowledgeTopic">the topic that supposes the <see cref="AcknowledgeMessage"> will publish into it</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static FullMessage<T> Build<T>(T body,
            string eventName,
            bool acknowledgeRequested = false,
            string acknowledgeTopic = null)
        {
            if (acknowledgeRequested == true && string.IsNullOrEmpty(acknowledgeTopic))
            { throw new ArgumentNullException("when `acknowledgeRequested` you must provide `acknowledgeTopic`"); }

            return new FullMessage<T>
            {
                Body = body,
                EventName = eventName,
                AcknowledgeRequested = acknowledgeRequested,
                AcknowledgeTopic = acknowledgeTopic
            };
        }

        /// <summary>
        /// build an Acknowledge-Message 
        /// </summary>
        /// <param name="id">the Id - usually the Id of original message</param>
        /// <param name="result">the Result of the operation on the original message</param>
        /// <returns></returns>
        public static AcknowledgeMessage BuildAcknowledge(string id, Result result) =>
            new AcknowledgeMessage
            {
                Id = id,
                Result = result
            };

    }

}