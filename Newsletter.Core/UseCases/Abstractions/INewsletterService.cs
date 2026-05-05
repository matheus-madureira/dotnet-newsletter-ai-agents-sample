namespace Newsletter.Core.UseCases.Abstractions;

public interface INewsletterService
{
    Task SendAsync(CancellationToken cancellationToken);
}
