using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [Remote("CheckUserName", "Account")]
        public string UserName { get; set; }
        [Required]
        [StringLength(160, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(160)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [RegularExpression(@"^\w + ([-+.]\w +)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "邮件格式不正确")]
        public string Email { get; set; }
        public decimal Total { get; set; }
    }
}