﻿using System.Threading;
using System.Threading.Tasks;

namespace Alamut.Abstractions.Messaging.Handlers
{
    /// <summary>
    /// string Message Handler base interface
    /// </summary>
    public interface IStringMessageHandler
    {
        Task Handle(string message, CancellationToken token);
    }
}