using Hesabo.Domain.Abstractions.Domain.Entities;
using Hesabo.Financing.Domain.Wallets.Enums;

namespace Hesabo.Financing.Domain.Wallets;

public class Wallet : AggregateRoot<Guid>
{
    public Guid PartyId { get; private set; }  // Link to Company or Employee via Party
    public WalletType Type { get; private set; }
    public decimal Balance { get; private set; }
    public WalletStatus Status { get; private set; }

    private readonly List<WalletTransaction> _transactions = new();
    public IReadOnlyCollection<WalletTransaction> Transactions => _transactions.AsReadOnly();

    // Behavior like AddFunds, Reserve, Spend, etc. here
}
