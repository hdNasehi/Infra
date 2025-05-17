using Hesabo.Domain.Abstractions.Domain.Entities;
using Hesabo.Financing.Domain.Common.Enums;

namespace Hesabo.Financing.Domain.Common;

public class Party : AggregateRoot<Guid>
{
    public Party(PartyType type)
    {
        Type = type;
    }
    public string Name { get; set; }
    public PartyType Type { get; private set; } 
}