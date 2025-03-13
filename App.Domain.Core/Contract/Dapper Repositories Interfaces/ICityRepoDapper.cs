using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contract.Dapper_Repositories_Interfaces
{
    public interface ICityRepoDapper
    {
        public Task<List<CityDto>> GetCities(CancellationToken cancellationToken);

    }
}
