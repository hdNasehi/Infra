using Hesabo.Foundation.Commands;

namespace Hesabo.Foundation.Dispatching;

public interface ICommandDispatcher
{
    Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : Command;

    Task<TResponse> SendAsync<TCommand, TResponse>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : Command<TResponse>;
}