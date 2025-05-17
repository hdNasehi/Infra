using Hesabo.Foundation.Commands;
using MediatR;

namespace Hesabo.Foundation.CommandHandlers;

public abstract class CommandHandler<TCommand, TResponse> :
    IRequestHandler<TCommand, TResponse>,
    ICommandHandler<TCommand, TResponse>
    where TCommand : Command<TResponse>
{
    public async Task<TResponse> Handle(TCommand request, CancellationToken cancellationToken)
    {
        return await HandleAsync(request, cancellationToken);
    }

    public abstract Task<TResponse> HandleAsync(TCommand command, CancellationToken cancellationToken);
}

public abstract class CommandHandler<TCommand> :
    IRequestHandler<TCommand, Unit>,
    ICommandHandler<TCommand>
    where TCommand : Command
{
    public async Task<Unit> Handle(TCommand request, CancellationToken cancellationToken)
    {
        await HandleAsync(request, cancellationToken);
        return Unit.Value;
    }

    public abstract Task HandleAsync(TCommand command, CancellationToken cancellationToken);
}