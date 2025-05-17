using MediatR;

namespace Hesabo.Foundation.Commands
{
    public abstract class Command<TResponse> : IRequest<TResponse>, ICommand<TResponse>
    {
        public Guid CorrelationId { get; protected set; } = Guid.NewGuid();
    }

    public abstract class Command : IRequest<Unit>, ICommand
    {
        public Guid CorrelationId { get; protected set; } = Guid.NewGuid();
    }
}