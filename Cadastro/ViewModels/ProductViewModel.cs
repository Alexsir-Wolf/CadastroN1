using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }
		public Client Client { get; set; }
		public string Name { get; set; }
		public decimal Value { get; set; }
		public bool Active { get; set; }
		public int IdCategory { get; set; }
		public virtual Category Category { get; set; }
	}
}
