using App.Domain.Core.Contract.Dapper_Repositories_Interfaces;
using App.Domain.Core.Contract.Repository_Interfaces;
using App.Domain.Core.Contract.Service_Interfaces;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Expert
{
    public class MainCategoryService : IMainCategoryService
    {

        #region Fields
        private readonly IMainCategoryRepository _MaincategoryRepository;
        private readonly IMainCategoryRepoDapper _mainCategoryRepoDapper;
        #endregion

        #region Ctors
        public MainCategoryService(IMainCategoryRepository maincategoryRepository,IMainCategoryRepoDapper mainCategoryRepoDapper)
        {
            _MaincategoryRepository = maincategoryRepository;
            _mainCategoryRepoDapper = mainCategoryRepoDapper;
        }
        #endregion

        #region Implementations
        public async Task<MainCategory> CreateMainCategory(MainCategoryDTO MaincategoryDto, CancellationToken cancellationToken)
        {
            var creatingMainCategory = new MainCategory();
            creatingMainCategory.CreatedAt = DateTime.Now;
            creatingMainCategory.Title = MaincategoryDto.Title;
            creatingMainCategory.Description = MaincategoryDto.Description;
            creatingMainCategory.Image = MaincategoryDto.Image;
            return await _MaincategoryRepository.CreateMainCategory(creatingMainCategory, cancellationToken);
        }

        public async Task<List<MainCategoryDTO>> GetMainCategories(CancellationToken cancellationToken)
            => await _mainCategoryRepoDapper.GetMainCategories(cancellationToken);

        public async Task<List<MainCategoryDTO>> GetMainCategoriesWithCategories(CancellationToken cancellationToken)
            => await _MaincategoryRepository.GetMainCategoriesWithCategories(cancellationToken);

        public async Task<MainCategoryDTO> GetMainCategoryById(int maincategoryId, CancellationToken cancellationToken)
            => await _MaincategoryRepository.GetMainCategoryById(maincategoryId, cancellationToken);

        public async Task<bool> RestoreDeletedMainCategory(int maincategoryId, CancellationToken cancellationToken)
            => await _MaincategoryRepository.RestoreDeletedMainCategory(maincategoryId, cancellationToken);

        //public async Task<Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken)
        //    => await _categoryRepository.HardDeleteCategory(categoryId, cancellationToken);

        public async Task<MainCategorySoftDeleteDTO> SoftDeleteMainCategory(int maincategoryId, CancellationToken cancellationToken)
            => await _MaincategoryRepository.SoftDeleteCategory(maincategoryId, cancellationToken);

        public async Task<MainCategoryDTO> UpdateMainCategory(MainCategoryDTO MaincategoryDto, CancellationToken cancellationToken)
        {
            var updatedMainCategory = new MainCategory();
            updatedMainCategory.Id = MaincategoryDto.Id;
            updatedMainCategory.Title = MaincategoryDto.Title;
            updatedMainCategory.Description = MaincategoryDto.Description;
            updatedMainCategory.Image = MaincategoryDto.Image;
            return await _MaincategoryRepository.UpdateMainCategory(updatedMainCategory, cancellationToken);
        }

        #endregion
    }
}
