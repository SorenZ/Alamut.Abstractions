﻿using System.Threading;
using System.Threading.Tasks;

namespace Alamut.Abstractions.Messaging
{
    /// <summary>
    /// message handler base interface
    /// </summary>
    /// <typeparam name="TMessage"></typeparam>
    /// <remark>inherited class should decorated with TopicsAttribute</remark>
    public interface IMessageHandler<TMessage>
    {
        Task Handle(TMessage message, CancellationToken token);
    }

    /// <summary>
    /// a flag interface to mark Message Handler
    /// </summary>
    public interface IMessageHandler
    {
        
    }
}