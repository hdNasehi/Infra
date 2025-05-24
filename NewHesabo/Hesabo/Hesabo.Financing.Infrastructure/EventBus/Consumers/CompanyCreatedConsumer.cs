using Hesabo.EventDriven.Abstractions;
using Hesabo.Foundation.Dispatching;
using Microsoft.Extensions.Logging;
using  Framework.MessageBus.Abstraction.Profile.Company;

namespace Hesabo.Financing.Infrastructure.EventBus.Consumers
{
    public class CompanyCreatedConsumer : IIntegrationEventHandler<CompanyCreatedEvent>
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly ILogger<CompanyCreatedConsumer> _logger;

        public CompanyCreatedConsumer(ICommandDispatcher commandDispatcher, ILogger<CompanyCreatedConsumer> logger)
        {
            _commandDispatcher = commandDispatcher;
            _logger = logger;
        }

        public async Task HandleAsync(CompanyCreatedEvent @event, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CompanyCreatedEvent for CompanyId: {CompanyId}", @event.CompanyId);

            // var command = new SyncCompanyCommand
            // {
            //     CompanyId = @event.CompanyId,
            //     Name = @event.Name,
            //     CreditLimit = @event.CreditLimit,
            //     CreatedAt = @event.CreatedAt
            // };
            //
            // await _commandDispatcher.SendAsync(command, cancellationToken);
        }
    }
}
