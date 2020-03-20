using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Storly.Models;
namespace Storly.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable <MemberShip> MemberShip { get; set; }
        public Customer Customer { get; set; }
    }
}