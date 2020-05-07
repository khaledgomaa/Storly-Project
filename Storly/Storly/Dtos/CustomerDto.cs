using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Storly.Models;
using System.ComponentModel.DataAnnotations;

namespace Storly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public bool IsSubscribedByMemberShip { get; set; }

        //[Min18YearsOld]
        public DateTime? BirthDate { get; set; }

        public MemberShipDto MembershipType { get; set; }

        [Required]
        public byte MemberShipTypeId { get; set; }
    }
}