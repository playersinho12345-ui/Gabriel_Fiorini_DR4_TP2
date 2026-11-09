using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gabriel_Fiorini_DR4_TP2_CityManager_.Pages.CityManager.Exercicio02
{
    public class Exercicio02Model : PageModel
    {
        public string? Message { get; set; }

        public void OnPost(string cityName)
        {
            Message = "Cidade recebida: " + cityName;
        }
    }
}
