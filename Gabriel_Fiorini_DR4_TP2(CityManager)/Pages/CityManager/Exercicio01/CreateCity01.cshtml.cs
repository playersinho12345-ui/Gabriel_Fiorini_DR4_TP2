using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gabriel_Fiorini_DR4_TP2_CityManager_.Pages.CityManager.Exercicio01
{
    public class CreateCity01Model : PageModel
    {
        [BindProperty]
        public string? CityName { get; set; }

        public void OnGet() { }
        

        public void OnPost() { }
    }
}
