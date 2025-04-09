using App.Domain.Core.Other_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contract.Repository_Interfaces
{
    public interface IPaymentRepository
    {
        Task AddAsync(Payment payment);
        Task<List<Payment>> GetAllAsync();
        //Task<Payment> GetByIdAsync(int id);
    }
}
