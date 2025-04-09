using App.Domain.Core.Contract.Repository_Interfaces;
using App.Domain.Core.Other_Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Admin
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly HomeServiceDbContext _context;
        public PaymentRepository(HomeServiceDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Payment payment)
        {
            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Payment>> GetAllAsync()
        {
            return await _context.Payments.ToListAsync();
        }
    }
}
