using CQRS.Core.Events;

namespace CQRS.Core.Domain;

public interface IEventStoreRepository
{
    public Task SaveAsync(EventModel eventModel,  CancellationToken cancellationToken = default);
    public Task<List<EventModel>> FindByAggregateIdAsync(Guid aggregateId , CancellationToken cancellationToken = default);
}