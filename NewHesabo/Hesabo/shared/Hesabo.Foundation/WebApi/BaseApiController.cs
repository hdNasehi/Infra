using Hesabo.Foundation.Commands;
using Hesabo.Foundation.Dispatching;
using Hesabo.Foundation.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Hesabo.Foundation.WebApi;

[ApiController]
public abstract class BaseApiController : ControllerBase
{
    protected readonly ICommandDispatcher CommandDispatcher;
    protected readonly IQueryDispatcher QueryDispatcher;

    protected BaseApiController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
    {
        CommandDispatcher = commandDispatcher;
        QueryDispatcher = queryDispatcher;
    }

    protected Task<TResponse> SendQueryAsync<TResponse>(IQuery<TResponse> query, CancellationToken cancellationToken = default)
        => QueryDispatcher.QueryAsync(query, cancellationToken);

    protected Task SendCommandAsync(Command command, CancellationToken cancellationToken = default)
        => CommandDispatcher.SendAsync(command, cancellationToken);

    protected Task<TResponse> SendCommandAsync<TCommand, TResponse>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : Command<TResponse>
        => CommandDispatcher.SendAsync<TCommand, TResponse>(command, cancellationToken);
}