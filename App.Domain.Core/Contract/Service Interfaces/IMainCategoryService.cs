using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contract.Service_Interfaces
{
    public interface IMainCategoryService
    {

        public Task<MainCategory> CreateMainCategory(MainCategoryDTO MaincategoryDto, CancellationToken cancellationToken);
        public Task<List<MainCategoryDTO>> GetMainCategories(CancellationToken cancellationToken);
        public Task<List<MainCategoryDTO>> GetMainCategoriesWithCategories(CancellationToken cancellationToken);
        public Task<MainCategoryDTO> GetMainCategoryById(int maincategoryId, CancellationToken cancellationToken);
        public Task<bool> RestoreDeletedMainCategory(int maincategoryId, CancellationToken cancellationToken);
        public Task<MainCategorySoftDeleteDTO> SoftDeleteMainCategory(int maincategoryId, CancellationToken cancellationToken);

        public Task<MainCategoryDTO> UpdateMainCategory(MainCategoryDTO MaincategoryDto, CancellationToken cancellationToken);







    }
}
