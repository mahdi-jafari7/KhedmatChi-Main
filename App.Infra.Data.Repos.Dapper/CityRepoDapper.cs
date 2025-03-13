using App.Domain.Core.Admin.Entities.Configs;
using App.Domain.Core.Contract.Dapper_Repositories_Interfaces;
using App.Domain.Core.Customer.DTOs;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Dapper
{
    public class CityRepoDapper : ICityRepoDapper
    {

        private readonly IMemoryCache _memoryCache;
        private readonly SiteSettings _siteSettings;

       
        public CityRepoDapper(IMemoryCache memoryCache,SiteSettings siteSettings)

        {
            _siteSettings = siteSettings;
            _memoryCache = memoryCache;

        }
        public async Task<List<CityDto>> GetCities(CancellationToken cancellationToken)
        {
            var cities = _memoryCache.Get<List<CityDto>>("Cities");

            if (cities is null)
            {
                using (IDbConnection db = new SqlConnection(_siteSettings.SqlConfiguration.ConnectionsString))
                {
                    cities = (await db.QueryAsync<CityDto>("SELECT Id, Name FROM Cities")).ToList();

                    _memoryCache.Set("Cities", cities, new MemoryCacheEntryOptions
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120) 
                    });

                    return cities;
                }
            }

            return cities;
        }


    }
}