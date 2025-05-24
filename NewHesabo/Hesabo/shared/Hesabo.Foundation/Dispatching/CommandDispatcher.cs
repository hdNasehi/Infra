using Hesabo.Foundation.Commands;
using Hesabo.Foundation.Queries;
using MediatR;

namespace Hesabo.Foundation.Dispatching
{
  
    public class CommandDispatcher : ICommandDispatcher,IQueryDispatcher
    {
        private readonly IMediator _mediator;

        public CommandDispatcher(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
            where TCommand : Command
        {
            await _mediator.Send(command, cancellationToken);
        }

        public async Task<TResponse> SendAsync<TCommand, TResponse>(TCommand command, CancellationToken cancellationToken = default)
            where TCommand : Command<TResponse>
        {
            return await _mediator.Send(command, cancellationToken);
        }

        public async Task<TResponse> QueryAsync<TResponse>(IQuery<TResponse> query, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(query, cancellationToken);
        }
       
    }
}
