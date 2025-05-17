namespace Hesabo.Financing.Domain.Wallets.Enums;

public enum WalletStatus
{
    /// <summary>
    /// Wallet is active and can be used for operations (credit, debit, freeze).
    /// </summary>
    Active = 1,

    /// <summary>
    /// Wallet is temporarily locked — cannot process any operations.
    /// </summary>
    Suspended = 2,

    /// <summary>
    /// Wallet is closed permanently — no further use allowed.
    /// </summary>
    Closed = 3,

    /// <summary>
    /// Wallet is being initialized — used before activation.
    /// </summary>
    PendingActivation = 4,

    /// <summary>
    /// Wallet is marked for review due to suspicious or policy violations.
    /// </summary>
    UnderReview = 5
}