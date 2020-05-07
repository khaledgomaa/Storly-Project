using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storly.Models
{
    public class MemberShip
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
<<<<<<< HEAD
=======

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;

>>>>>>> Adding dataTables and using ajax to call web api
    }
}