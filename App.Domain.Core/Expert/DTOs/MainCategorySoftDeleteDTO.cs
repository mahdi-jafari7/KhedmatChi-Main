using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class MainCategorySoftDeleteDTO
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
