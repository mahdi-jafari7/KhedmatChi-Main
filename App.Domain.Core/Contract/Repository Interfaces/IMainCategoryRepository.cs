using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contract.Repository_Interfaces
{
    public interface IMainCategoryRepository
    {
        public Task<MainCategory> CreateMainCategory(MainCategory createdMainCategory, CancellationToken cancellationToken);
        public Task<MainCategoryDTO> UpdateMainCategory(MainCategory updatedMainCategory, CancellationToken cancellationToken);
        public Task<MainCategorySoftDeleteDTO> SoftDeleteCategory(int MaincategoryId, CancellationToken cancellationToken);
        //public Task<Expert.Entities.Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken);
        public Task<MainCategoryDTO> GetMainCategoryById(int MaincategoryId, CancellationToken cancellationToken);
        public Task<List<MainCategoryDTO>> GetMainCategories(CancellationToken cancellationToken);
        public Task<List<MainCategoryDTO>> GetMainCategoriesWithCategories(CancellationToken cancellationToken);

        public Task<bool> RestoreDeletedMainCategory(int MaincategoryId, CancellationToken cancellationToken);

    }
}
