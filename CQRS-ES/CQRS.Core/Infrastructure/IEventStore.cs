using CQRS.Core.Events;

namespace CQRS.Core.Infrastructure;

public interface IEventStore
{
    Task SaveEvetsAsync(Guid aggregateId, IEnumerable<BaseEvent> events, int expectedVersion, CancellationToken cancellationToken = default);
    Task<List<BaseEvent>> GetEventsAsync(Guid aggregateId, CancellationToken cancellationToken = default);
}