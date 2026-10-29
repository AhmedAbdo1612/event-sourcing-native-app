using CQRS.Core.Events;

namespace CQRS.Core.Producers;

public interface IEventProducer
{
    Task ProduceAsync<T>(string topic, T message, CancellationToken cancellationToken = default) where T :BaseEvent;
}