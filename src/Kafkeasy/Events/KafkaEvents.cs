namespace Kafkeasy.Events;

public class KafkaEvents
{
    public Func<MessageConsumeStartedContext, Task> OnMessageConsumeStarted { get; set; } = _ => Task.CompletedTask;

    public virtual Task MessageConsumeStarted(MessageConsumeStartedContext context)
    {
        return OnMessageConsumeStarted(context);
    }
}
