using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using Whales.Models;

namespace Whales.ViewModels
{
    public class WhalesListViewModel
    {
        public IEnumerable<Whale> Whales { get; set; }
        public IEnumerable<SelectListItem> Diets { get; }

        public Diet Diet { get; set; }

        public WhalesListViewModel()
        {
            Diets = new List<SelectListItem>
            {
                new SelectListItem { Text = "Krill", Value = "0"},
                new SelectListItem { Text = "Squid", Value = "1"},
                new SelectListItem { Text = "Other", Value = "2"},
            };
        }
    }
}
