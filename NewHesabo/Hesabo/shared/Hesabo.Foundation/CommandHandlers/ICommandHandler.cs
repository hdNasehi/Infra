using Hesabo.Foundation.Commands;
using MediatR;

namespace Hesabo.Foundation.CommandHandlers
{
    public interface ICommandHandler<TCommand, TResponse>
        where TCommand : Command<TResponse>
    {
        Task<TResponse> HandleAsync(TCommand command, CancellationToken cancellationToken);
    }

    public interface ICommandHandler<TCommand>
        where TCommand : Command
    {
        Task HandleAsync(TCommand command, CancellationToken cancellationToken);
    }
}

