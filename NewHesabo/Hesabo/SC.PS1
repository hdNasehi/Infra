# Set base path
$basePath = "src/Framework"
$projectName = "Hesabo.Foundation"
$projectPath = "$basePath/$projectName"

# Create project
dotnet new classlib -n $projectName -o $projectPath

# Create folders
New-Item -ItemType Directory -Path "$projectPath/Domain/Entities" -Force
New-Item -ItemType Directory -Path "$projectPath/Domain/Events" -Force
New-Item -ItemType Directory -Path "$projectPath/Domain/Primitives" -Force
New-Item -ItemType Directory -Path "$projectPath/Domain/Exceptions" -Force
New-Item -ItemType Directory -Path "$projectPath/Common" -Force

# Add classes (empty shell)
Set-Content "$projectPath/Domain/Entities/BaseEntity.cs" 'namespace Hesabo.Foundation.Domain.Entities { public abstract class BaseEntity { } }'
Set-Content "$projectPath/Domain/Entities/AggregateRoot.cs" 'namespace Hesabo.Foundation.Domain.Entities { public abstract class AggregateRoot : BaseEntity { } }'
Set-Content "$projectPath/Domain/Events/IDomainEvent.cs" 'namespace Hesabo.Foundation.Domain.Events { public interface IDomainEvent { DateTime OccurredOn { get; } } }'
Set-Content "$projectPath/Domain/Events/DomainEventDispatcher.cs" 'namespace Hesabo.Foundation.Domain.Events { public interface IDomainEventDispatcher { Task DispatchAsync(IEnumerable<IDomainEvent> domainEvents); } }'
Set-Content "$projectPath/Domain/Primitives/ValueObject.cs" 'namespace Hesabo.Foundation.Domain.Primitives { public abstract class ValueObject { } }'
Set-Content "$projectPath/Domain/Primitives/EntityId.cs" 'namespace Hesabo.Foundation.Domain.Primitives { public record EntityId(Guid Value); }'
Set-Content "$projectPath/Domain/Exceptions/DomainException.cs" 'namespace Hesabo.Foundation.Domain.Exceptions { public class DomainException : Exception { public DomainException(string message) : base(message) { } } }'
Set-Content "$projectPath/Common/Guard.cs" 'namespace Hesabo.Foundation.Common { public static class Guard { } }'
Set-Content "$projectPath/Common/Clock.cs" 'namespace Hesabo.Foundation.Common { public static class Clock { public static DateTime UtcNow => DateTime.UtcNow; } }'
Set-Content "$projectPath/Common/Result.cs" 'namespace Hesabo.Foundation.Common { public class Result { } }'

# Output
Write-Host "✅ Scaffolded $projectName at $projectPath"
