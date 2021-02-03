using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Forms
{
    public class AddAddressModel : PageModel
    {
        [BindProperty]
        public AddressModel Address { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            // Save Model to Database.

            return RedirectToPage("/Index", new { FirstName = Address.City });
        }
    }
}
