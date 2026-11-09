using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gabriel_Fiorini_DR4_TP2_CityManager_.Pages.CityManager.Exercicio08
{
    public class CityDetailsModel : PageModel
    {

        public string? Message { get; set; }

        public void OnGet(string cityName)
        {
            Message = "Você está vendo detalhes de: " + cityName;
        }
    }
}
