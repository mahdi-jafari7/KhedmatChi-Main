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
    public class CategoriesRepoDapper : ICategoryRepoDapper
    {
        private readonly IMemoryCache _memoryCache;
        private readonly SiteSettings _siteSettings;


        public CategoriesRepoDapper(IMemoryCache memoryCache, SiteSettings siteSettings)

        {
            _siteSettings = siteSettings;
            _memoryCache = memoryCache;

        }

        public async Task<List<CategoryDto>> GetCategories(CancellationToken cancellationToken)
        {
            var categories = _memoryCache.Get<List<CategoryDto>>("categoryDtos");

            if (categories is null)
            {
                using (var connection = new SqlConnection(_siteSettings.SqlConfiguration.ConnectionsString))
                {
                    const string query = @"
                SELECT Id, Title, Description, IsDeleted, Image 
                FROM Categories 
                WHERE IsDeleted = 0";

                    categories = (await connection.QueryAsync<CategoryDto>(query)).ToList();

                    if (categories is null)
                    {
                       
                        throw new Exception("Something went wrong! Please try again.");
                    }
                    else
                    {
                        _memoryCache.Set("categoryDtos", categories, new MemoryCacheEntryOptions()
                        {
                            SlidingExpiration = TimeSpan.FromSeconds(120)
                        });

                        
                        return categories;
                    }
                }
            }

            
            return categories;
        }

    }
}
