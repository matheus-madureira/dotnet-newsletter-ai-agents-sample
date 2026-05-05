using Newsletter.Core.UseCases.Abstractions;

namespace Newsletter.Infra.Services;

public sealed class NewsletterService : INewsletterService
{
    public async Task SendAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
