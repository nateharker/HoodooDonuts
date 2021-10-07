using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HoodooDonuts.Models.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Donut> Donuts { get; set; }
        public string Type { get; set; }
    }
}
