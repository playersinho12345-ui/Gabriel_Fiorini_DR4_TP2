using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gabriel_Fiorini_DR4_TP2_CityManager_.Pages.CityManager.Exercicio09
{
    public class CityDetails09Model : PageModel
    {
        public List<string> Cities { get; set; } = ["Rio", "São Paulo", "Brasília"];
        public void OnGet()
        {
        }
    }
}
