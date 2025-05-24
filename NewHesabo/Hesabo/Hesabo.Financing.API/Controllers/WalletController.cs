using Hesabo.Foundation.Dispatching;
using Hesabo.Foundation.WebApi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hesabo.Financing.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class WalletController : BaseApiController
{
    public WalletController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(
        commandDispatcher, queryDispatcher)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetWallets(Guid PartyId, CancellationToken cancellationToken)
    {
        // var query = new GetWalletQuery(userId);
        // var result = await _queryDispatcher.QueryAsync(query, cancellationToken);
        return Ok();
    }
}