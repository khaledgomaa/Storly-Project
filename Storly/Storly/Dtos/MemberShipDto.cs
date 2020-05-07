using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storly.Dtos
{
    public class MemberShipDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public byte DiscountRate { get; set; }
    }
}