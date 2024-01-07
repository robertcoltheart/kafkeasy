namespace Kafkeasy.Events;

public class KafkaEvents
{
    public Func<MessgeStartedContext, Task> OnMessageConsumeStarted { get; set; } = _ => Task.CompletedTask;

    public Func<MessageCompletedContext, Task> OnMessageConsumeCompleted { get; set; } = _ => Task.CompletedTask;

    public Func<MessagedFailedContext, Task> OnMessageConsumeFailed { get; set; } = _ => Task.CompletedTask;

    public Func<MessgeStartedContext, Task> OnMessageProduceStarted { get; set; } = _ => Task.CompletedTask;

    public Func<MessageCompletedContext, Task> OnMessageProduceCompleted { get; set; } = _ => Task.CompletedTask;

    public Func<MessagedFailedContext, Task> OnMessageProduceFailed { get; set; } = _ => Task.CompletedTask;

    public virtual Task MessageConsumeStarted(MessgeStartedContext context)
    {
        return OnMessageConsumeStarted(context);
    }

    public virtual Task MessageConsumeCompleted(MessageCompletedContext context)
    {
        return OnMessageConsumeCompleted(context);
    }

    public virtual Task MessageConsumeFailed(MessagedFailedContext context)
    {
        return OnMessageConsumeFailed(context);
    }

    public virtual Task MessageProduceStarted(MessgeStartedContext context)
    {
        return OnMessageProduceStarted(context);
    }

    public virtual Task MessageProduceCompleted(MessageCompletedContext context)
    {
        return OnMessageProduceCompleted(context);
    }

    public virtual Task MessageProduceFailed(MessagedFailedContext context)
    {
        return OnMessageProduceFailed(context);
    }
}
