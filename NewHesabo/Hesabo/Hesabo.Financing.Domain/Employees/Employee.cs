using Hesabo.Domain.Abstractions.Domain.Entities;
using Hesabo.Financing.Domain.Common;
using Hesabo.Financing.Domain.Employees.Enums;

namespace Hesabo.Financing.Domain.Employees;

public class Employee : AggregateRoot<Guid>
{

    public Employee(Guid id, string externalId, Party party, Guid companyId) 
    {
        ExternalId = externalId;
        Party = party;
        CompanyId = companyId;
        Status = EmployeeStatus.Active;
    }

    public string ExternalId { get; private set; }

    public Party Party { get; private set; }

    public Guid CompanyId { get; private set; }

    public EmployeeStatus Status { get; private set; }

    // private readonly List<EmployeeWalletConfiguration> _walletConfigurations = new();
    // public IReadOnlyCollection<EmployeeWalletConfiguration> WalletConfigurations => _walletConfigurations.AsReadOnly();
    //
    // private readonly List<PaymentRequest> _paymentRequests = new();
    // public IReadOnlyCollection<PaymentRequest> PaymentRequests => _paymentRequests.AsReadOnly();
    //
    // // Domain Behavior
    // public void AddWalletConfiguration(EmployeeWalletConfiguration config)
    // {
    //     _walletConfigurations.Add(config);
    // }
    //
    // public void AddPaymentRequest(PaymentRequest request)
    // {
    //     _paymentRequests.Add(request);
    // }
    //
    // public void Deactivate()
    // {
    //     Status = EmployeeStatus.Inactive;
    // }
    //
    // public void Reactivate()
    // {
    //     Status = EmployeeStatus.Active;
    // }
}