using App.Domain.Core.Contract.Repository_Interfaces;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Expert
{
    public class MainCategoryRepository : IMainCategoryRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<MainCategoryRepository> _logger;
        #endregion

        #region Ctors
        public MainCategoryRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<MainCategoryRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<MainCategory> CreateMainCategory(MainCategory createdMainCategory, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.MainCategories.AddAsync(createdMainCategory, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            _memoryCache.Remove("MaincategoryDtos");

            _logger.LogInformation("دسته بندی اصلی با موفقییت به دیتابیس اضافه شد");
            return createdMainCategory;
        }
        
        //public async Task<List<MainCategoryDTO>> GetMainCategories(CancellationToken cancellationToken)
        //{
        //    var maincategories = _memoryCache.Get<List<MainCategoryDTO>>("MaincategoryDtos");

        //    if (maincategories is null)
        //    {
        //        maincategories = await _homeServiceDbContext.MainCategories
        //            .Where(c => c.IsDeleted == false)
        //        .Select(a => new MainCategoryDTO()
        //        {
        //            Id = a.Id,
        //            Title = a.Title,
        //            Description = a.Description,
        //            IsDeleted = a.IsDeleted,
        //            Image = a.Image
        //        }).ToListAsync(cancellationToken);

        //        if (maincategories is null)
        //        {
        //            _logger.LogError("We expected the AdminProfileDtos to return from the database, but it returned null.");
        //            throw new Exception("Something wents wrong!, please try again.");
        //        }
        //        else
        //        {
        //            _memoryCache.Set("categoryDtos", maincategories, new MemoryCacheEntryOptions()
        //            {
        //                SlidingExpiration = TimeSpan.FromSeconds(120)
        //            });
        //            _logger.LogInformation("categoryDtos returned from database, and cached in memory successfully.");
        //            return maincategories;
        //        }
        //    }
        //    _logger.LogInformation("categoryDtos returned from InMemoryCache.");
        //    return maincategories;
        //}

        public async Task<List<MainCategoryDTO>> GetMainCategoriesWithCategories(CancellationToken cancellationToken)
        {
            var MaincategoriesWithServices = await _homeServiceDbContext.MainCategories
                .Include(c => c.Categories)
                .Select(c => new MainCategoryDTO()
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    IsDeleted = c.IsDeleted,
                    Categories = c.Categories.Select(s => new CategoryDto()
                    {
                        Id = s.Id,
                        Title = s.Title,
                        Description = s.Description,
                        IsDeleted = s.IsDeleted,
                        Image = s.Image,
                    })
                    .ToList(),
                })
                .ToListAsync(cancellationToken);

            return MaincategoriesWithServices;
        }

 

        public async Task<MainCategoryDTO> GetMainCategoryById(int MaincategoryId, CancellationToken cancellationToken)
        {
            //var category = _memoryCache.Get<CategoryDto>("categoryDto");
            //if (category is null)
            //{
            var Maincategory = await _homeServiceDbContext.MainCategories
            .Select(a => new Domain.Core.Expert.DTOs.MainCategoryDTO()
            {
                Id = a.Id,
                Title = a.Title,
                Description = a.Description,
                Image = a.Image,
                IsDeleted = a.IsDeleted
            }).FirstOrDefaultAsync(a => a.Id == MaincategoryId, cancellationToken);

            if (Maincategory != null)
            {
                //_memoryCache.Set("categoryDto", category, new MemoryCacheEntryOptions()
                //{
                //    SlidingExpiration = TimeSpan.FromSeconds(120)
                //});
                //_logger.LogInformation("categoryDto returned from database, and cached in memory successfully.");
                _logger.LogInformation("MaincategoryDto returned from database.");
                return Maincategory;
            }
            else
            {
                _logger.LogError("We expected the MaincategoryDto to return from the database, but it returned null.");
                throw new Exception("Something wents wrong!, please try again.");
            }
            //}
            //_logger.LogInformation("categoryDto returned from InMemoryCache.");
            //return category;
        }

        public async Task<bool> RestoreDeletedMainCategory(int MaincategoryId, CancellationToken cancellationToken)
        {
            var restoringMainCategory = await GetMainCategoryDto(MaincategoryId, cancellationToken);
            restoringMainCategory.IsDeleted = false;
            try
            {
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                _memoryCache.Remove("MaincategoryDtos");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public async Task<Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken)
        //{
        //    var deletedCategory = await GetCategory(categoryId, cancellationToken);
        //    if (deletedCategory != null)
        //    {
        //        deletedCategory.IsDeleted = true;
        //        _homeServiceDbContext.Categories.Remove(deletedCategory);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedCategory;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<MainCategorySoftDeleteDTO> SoftDeleteCategory(int MaincategoryId, CancellationToken cancellationToken)
        {
            var deletedMainCategory = await GetCategorySoftDeleteDto(MaincategoryId, cancellationToken);
            deletedMainCategory.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            _memoryCache.Remove("MaincategoryDtos");

            var deletedMainCategoryDto = new MainCategorySoftDeleteDTO();
            deletedMainCategoryDto.Id = deletedMainCategory.Id;
            deletedMainCategoryDto.IsDeleted = deletedMainCategory.IsDeleted;

            return deletedMainCategoryDto;
        }

        public async Task<MainCategoryDTO> UpdateMainCategory(MainCategory updatedMainCategory, CancellationToken cancellationToken)
        {
            var updatingMainCategory = await GetMainCategoryDto(updatedMainCategory.Id, cancellationToken);

            updatingMainCategory.Title = updatedMainCategory.Title;
            updatingMainCategory.Description = updatedMainCategory.Description;
            updatingMainCategory.Image = updatedMainCategory.Image;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            var updatingMainCategoryDto = new MainCategoryDTO();
            updatingMainCategoryDto.Title = updatingMainCategory.Title;
            updatingMainCategoryDto.Description = updatingMainCategory.Description;
            updatingMainCategoryDto.Image = updatingMainCategory.Image;
            _memoryCache.Remove("MaincategoryDtos");

            return updatingMainCategoryDto;
        }
        #endregion

        #region PrivateMethods
        private async Task<MainCategory> GetMainCategoryDto(int MaincategoryId, CancellationToken cancellationToken)
        {
            var Maincategory = await _homeServiceDbContext.MainCategories
                   .FirstOrDefaultAsync(c => c.Id == MaincategoryId, cancellationToken);
            if (Maincategory == null)
            {
                _logger.LogError($"Category with id {MaincategoryId} returned null");
                throw new Exception($"Category with id {MaincategoryId} returned null");
            }
            return Maincategory;
        }

        private async Task<MainCategory> GetCategorySoftDeleteDto(int MaincategoryId, CancellationToken cancellationToken)
        {
            var Maincategory = _memoryCache.Get<MainCategory>("MaincategorySoftDelete");
            if (Maincategory is null)
            {
                Maincategory = await _homeServiceDbContext.MainCategories
                .FirstOrDefaultAsync(a => a.Id == MaincategoryId, cancellationToken);

                if (Maincategory != null)
                {
                    _memoryCache.Set("categorySoftDelete", Maincategory, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("categorySoftDelete has been returned form database and cached in memory successfully.");
                    return Maincategory;
                }
                _logger.LogError($"category with id {MaincategoryId} not found in GetCategorySoftDelete method.");
                throw new Exception($"category with id {MaincategoryId} not found.");
            }
            _logger.LogInformation("categorySoftDelete returned from InMemeoryCache in GetCategorySoftDelete method.");
            return Maincategory;

        }
        #endregion
    }
}
