using Newsletter.Core.Models;
using Newsletter.Core.Repositories.Abstractions;

namespace Newsletter.Infra.Repositories;

public class ArticleRepository : IArticleRepository
{
    public async Task<IEnumerable<Article>> GetFromLastWeekAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(150, cancellationToken);

        return
        [
            new Article(
                "Dapper: Mapeando consultas complexas",
                "https://blog.balta.io/dapper-mapeando-consultas-complexas",
                "Learn how to map complex queries using Dapper.",
                DateTime.Now.AddDays(-1)),
            new Article(
                "Dapper: Mapeando consultas complexas",
                "https://blog.balta.io/dapper-mapeando-consultas-complexas",
                "Learn how to map complex queries using Dapper.",
                DateTime.Now.AddDays(-2)),
            new Article(
                "Dapper: Mapeando consultas complexas",
                "https://blog.balta.io/dapper-mapeando-consultas-complexas",
                "Learn how to map complex queries using Dapper.",
                DateTime.Now.AddDays(-3)),
            new Article(
                "Dapper: Mapeando consultas complexas",
                "https://blog.balta.io/dapper-mapeando-consultas-complexas",
                "Learn how to map complex queries using Dapper.",
                DateTime.Now.AddDays(-4)),
            new Article(
                "Dapper: Mapeando consultas complexas",
                "https://blog.balta.io/dapper-mapeando-consultas-complexas",
                "Learn how to map complex queries using Dapper.",
                DateTime.Now.AddDays(-5)),
        ];
    }
}
