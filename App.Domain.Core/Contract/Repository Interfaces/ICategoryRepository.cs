﻿using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Data
{
    public interface ICategoryRepository
    {
        public Task<Expert.Entities.Category> CreateCategory(Expert.Entities.Category createdCategory, CancellationToken cancellationToken);
        public Task<CategoryDto> UpdateCategory(Expert.Entities.Category updatedCategory, CancellationToken cancellationToken);
        public Task<CategorySoftDeleteDto> SoftDeleteCategory(int categoryId, CancellationToken cancellationToken);
        //public Task<Expert.Entities.Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken);
        public Task<CategoryDto> GetCategoryById(int categoryId, CancellationToken cancellationToken);
        //public Task<List<CategoryDto>> GetCategories(CancellationToken cancellationToken);
        public Task<List<CategoryDto>> GetCategoriesWithServices(CancellationToken cancellationToken);
        public Task<bool> RestoreDeletedCategory(int categoryId, CancellationToken cancellationToken);
    }
}
