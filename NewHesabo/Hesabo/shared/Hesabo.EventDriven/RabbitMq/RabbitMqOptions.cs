using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Hesabo.EventDriven.RabbitMq;

public class RabbitMqOptions
{
    [Required]
    public string Host { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }

    [Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
    public RabbitMqOptions()
    {
    }
}