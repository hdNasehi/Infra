using Hesabo.Domain.Abstractions.Domain.Entities;
using Hesabo.Financing.Domain.Common;
using Hesabo.Financing.Domain.Companies.Enums;

namespace Hesabo.Financing.Domain.Companies;

public class Company : AggregateRoot<Guid>
{
    private Company()
    {
    }

    public Company(string externalReferenceId, Party party)
    {
        ExternalReferenceId = externalReferenceId;
        Party = party;
    }

    public Party Party { get; set; }
    public string ExternalReferenceId { get; set; }

    public CompanyStatus Status { get; set; } = CompanyStatus.Active;
}
