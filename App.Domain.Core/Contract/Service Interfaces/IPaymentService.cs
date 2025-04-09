using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contract.Service_Interfaces
{
    public interface IPaymentService
    {
        Task<bool> HandlePaymentAsync(ServiceRequest order, decimal amount);
    }
}
