using Hesabo.Financing.Domain.Wallets.Enums;

namespace Hesabo.Financing.Domain.Wallets;

public class WalletTransaction
{
    public Guid Id { get; set; }

    public Guid WalletId { get; set; }
    public Wallet Wallet { get; set; }

    public WalletTransactionType Type { get; set; }
    public decimal Amount { get; set; }

    public string ReferenceId { get; set; } // Links to payment or accounting system
    public DateTime CreatedAt { get; set; }
}