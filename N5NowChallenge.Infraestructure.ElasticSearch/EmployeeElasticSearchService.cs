using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N5Now.Domain.Entity;
using Elasticsearch.Net;
using Nest;
namespace N5NowChallenge.Infraestructure.ElasticSearch
{
    public class EmployeeElasticSearchService
    {
        private readonly IElasticClient _elasticClient;

        public EmployeeElasticSearchService(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public async Task IndexPermissionAsync(Permission permission)
        {
            var indexResponse = await _elasticClient.IndexDocumentAsync(permission);
        }
    }
}
