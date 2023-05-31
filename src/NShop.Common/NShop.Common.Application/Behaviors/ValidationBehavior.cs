using Mediator;

namespace NShop.Common.Application.Behaviors;

public class ValidationBehavior<TMessage, TResponse> : IPipelineBehavior<TMessage, TResponse> where TMessage : IMessage
{
    public ValueTask<TResponse> Handle(TMessage message, CancellationToken cancellationToken, MessageHandlerDelegate<TMessage, TResponse> next)
    {
        throw new NotImplementedException();
    }
}
