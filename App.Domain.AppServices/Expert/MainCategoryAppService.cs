using App.Domain.Core.Contract.AppService_Interfaces;
using App.Domain.Core.Contract.Service_Interfaces;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
    public class MainCategoryAppService : IMainCategoryAppService
    {

        #region Fields
        private readonly IMainCategoryService _MaincategoryService;
        #endregion

        #region Ctors
        public MainCategoryAppService(IMainCategoryService MaincategoryService)
        {
            _MaincategoryService = MaincategoryService;
        }
        #endregion

        #region Implementations
        public async Task<MainCategory> CreateMainCategory(MainCategoryDTO MaincategoryDto, CancellationToken cancellationToken)
            => await _MaincategoryService.CreateMainCategory(MaincategoryDto, cancellationToken);

        public async Task<List<MainCategoryDTO>> GetMainCategories(CancellationToken cancellationToken)
            => await _MaincategoryService.GetMainCategories(cancellationToken);

        public async Task<List<MainCategoryDTO>> GetMainCategoriesWithCategories(CancellationToken cancellationToken)
            => await _MaincategoryService.GetMainCategoriesWithCategories(cancellationToken);

        public async Task<MainCategoryDTO> GetMainCategoryById(int MaincategoryId, CancellationToken cancellationToken)
            => await _MaincategoryService.GetMainCategoryById(MaincategoryId, cancellationToken);

        public async Task<bool> RestoreDeletedMainCategory(int MaincategoryId, CancellationToken cancellationToken)
            => await _MaincategoryService.RestoreDeletedMainCategory(MaincategoryId, cancellationToken);

        //public async Task<Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken)
        //    => await _categoryService.HardDeleteCategory(categoryId, cancellationToken);

        public async Task<MainCategorySoftDeleteDTO> SoftDeleteMainCategory(int MaincategoryId, CancellationToken cancellationToken)
            => await _MaincategoryService.SoftDeleteMainCategory(MaincategoryId, cancellationToken);

        public async Task<MainCategoryDTO> UpdateMainCategory(MainCategoryDTO MaincategoryDto, CancellationToken cancellationToken)
            => await _MaincategoryService.UpdateMainCategory(MaincategoryDto, cancellationToken);

        #endregion
    }
}
