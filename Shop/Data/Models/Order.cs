using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name= "Имя")]
        
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        
        [DataType(DataType.PhoneNumber)]
        
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime{ get; set; }

        public List<OrderDetail> orderDetails { get; set; }

    }
}
