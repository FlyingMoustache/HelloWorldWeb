using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldWeb.Pages
{
    public class EmptyModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Nothing to see here";
        }
    }
}