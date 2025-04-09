using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Other_Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public int CustomerId { get; set; }
        public Customer.Entities.Customer Customer { get; set; }

        public int ExpertId { get; set; }
        public Expert.Entities.Expert Expert { get; set; }

        public int ServiceId { get; set; }
        public Expert.Entities.Service Service { get; set; }

        public decimal Price { get; set; }
    }

}
