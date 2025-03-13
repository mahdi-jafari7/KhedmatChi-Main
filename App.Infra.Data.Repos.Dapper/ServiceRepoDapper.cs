using App.Domain.Core.Admin.Entities.Configs;
using App.Domain.Core.Contract.Dapper_Repositories_Interfaces;
using App.Domain.Core.Expert.DTOs;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Dapper
{
    public class ServiceRepoDapper : IServiceRepoDapper
    {

        private readonly IMemoryCache _memoryCache;
        private readonly SiteSettings _siteSettings;


        public ServiceRepoDapper(IMemoryCache memoryCache, SiteSettings siteSettings)

        {
            _siteSettings = siteSettings;
            _memoryCache = memoryCache;

        }
        public async Task<List<ServiceDto>> GetServices(CancellationToken cancellationToken)
        {
            var services = _memoryCache.Get<List<ServiceDto>>("serviceDtos");

            if (services is null)
            {
                using (var connection = new SqlConnection(_siteSettings.SqlConfiguration.ConnectionsString))
                {
                    const string query = @"
                SELECT Id, Title, Description, IsDeleted, Image 
                FROM Services";

                    services = (await connection.QueryAsync<ServiceDto>(query)).ToList();

                    if (services is null)
                    {
                       
                        throw new Exception("Something went wrong! Please try again.");
                    }
                    else
                    {
                        _memoryCache.Set("serviceDtos", services, new MemoryCacheEntryOptions()
                        {
                            SlidingExpiration = TimeSpan.FromSeconds(120)
                        });

                       
                        return services;
                    }
                }
            }

            
            return services;
        }
    }
}
