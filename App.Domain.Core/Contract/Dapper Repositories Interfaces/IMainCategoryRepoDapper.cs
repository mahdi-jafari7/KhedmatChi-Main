﻿using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contract.Dapper_Repositories_Interfaces
{
    public interface IMainCategoryRepoDapper
    {
        public Task<List<MainCategoryDTO>> GetMainCategories(CancellationToken cancellationToken);

    }
}
