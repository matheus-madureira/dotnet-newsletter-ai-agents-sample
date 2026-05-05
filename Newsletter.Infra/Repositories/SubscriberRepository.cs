using Newsletter.Core.Models;
using Newsletter.Core.Repositories.Abstractions;

namespace Newsletter.Infra.Repositories;

public class SubscriberRepository : ISubscriberRepository
{
    public async Task<IEnumerable<Subscriber>> GetAllAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(100, cancellationToken);

        return
        [
            new Subscriber("John Doe", "johndoe@example.com"),
            new Subscriber("Jane Smith", "janesmith@gmail.com"),
            new Subscriber("Bob Johnson", "bobjohnson@outlook.com"),
            new Subscriber("Alice Williams", "alice.williams@hotmail.com"),
            new Subscriber("Michael Brown", "brownmichael@icloud.com")
        ];
    }
}
