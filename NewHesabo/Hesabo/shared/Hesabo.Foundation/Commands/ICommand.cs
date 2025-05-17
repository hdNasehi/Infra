using MediatR;

namespace Hesabo.Foundation.Commands;

public interface ICommand : IRequest<Unit> { }

public interface ICommand<TResponse>
{
}