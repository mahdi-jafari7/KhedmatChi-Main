using App.Domain.Core.Contract.Repository_Interfaces;
using App.Domain.Core.Other_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Admin
{
    public class PaymentService
    {

        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task AddAsync(Payment payment)
        {
            _paymentRepository.AddAsync(payment);
        }

        public async Task<List<Payment>> GetAllAsync()
        {
            return await _paymentRepository.GetAllAsync();
        }
    }
}
