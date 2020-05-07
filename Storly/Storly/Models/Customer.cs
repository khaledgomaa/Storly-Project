using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Storly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public bool IsSubscribedByMemberShip { get; set; }

        [Display(Name = "Date of Birth")]
<<<<<<< HEAD
=======
        [Min18YearsOld]
>>>>>>> Adding dataTables and using ajax to call web api
        public DateTime? BirthDate { get; set; }

        public MemberShip MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        [Required]
        public byte MemberShipTypeId { get; set; }
<<<<<<< HEAD

        public string MyProperty { get; set; }
=======
>>>>>>> Adding dataTables and using ajax to call web api
    }
}