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
    public class MainCategoryRepoDapper:IMainCategoryRepoDapper
    {
        private readonly IMemoryCache _memoryCache;
        private readonly SiteSettings _siteSettings;


        public MainCategoryRepoDapper(IMemoryCache memoryCache, SiteSettings siteSettings)

        {
            _siteSettings = siteSettings;
            _memoryCache = memoryCache;

        }
        public async Task<List<MainCategoryDTO>> GetMainCategories(CancellationToken cancellationToken)
        {
            var maincategories = _memoryCache.Get<List<MainCategoryDTO>>("MaincategoryDtos");

            if (maincategories is null)
            {
                using (var connection = new SqlConnection(_siteSettings.SqlConfiguration.ConnectionsString))
                {
                    const string query = @"
                SELECT Id, Title, Description, IsDeleted, Image 
                FROM MainCategories 
                WHERE IsDeleted = 0";

                    maincategories = (await connection.QueryAsync<MainCategoryDTO>(query)).ToList();

                    if (maincategories is null)
                    {
                       
                        throw new Exception("Something went wrong! Please try again.");
                    }
                    else
                    {
                        _memoryCache.Set("MaincategoryDtos", maincategories, new MemoryCacheEntryOptions()
                        {
                            SlidingExpiration = TimeSpan.FromSeconds(120)
                        });

                        
                        return maincategories;
                    }
                }
            }

            
            return maincategories;
        }


    }
}
