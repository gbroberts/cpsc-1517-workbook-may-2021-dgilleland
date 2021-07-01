using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class FormTagsModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty] // Allows the two-way binding
        public string BuddyName {get; set;}
        [BindProperty]
        public string Flavour { get; set; }


        public void OnPost()
        {
            // I could manually extract the data from the Request.Form collection...
            // BuddyName = Request.Form["buddy"]; // "buddy" is the key for the dictionary; name attribute value on my <input> element
            // The better approach is to use Razor's Model Binding mechanism to capture
            // information sent from the browser.
        }
    }
}
