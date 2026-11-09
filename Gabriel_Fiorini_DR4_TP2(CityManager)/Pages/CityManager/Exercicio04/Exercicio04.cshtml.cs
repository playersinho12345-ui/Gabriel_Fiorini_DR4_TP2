using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gabriel_Fiorini_DR4_TP2_CityManager_.Pages.CityManager.Exercicio04
{
    public class Exercicio04Model : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new();

        public string? Message { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            Message = "Cidade cadastrada: " + Input.CityName;
        }

        public class InputModel
        {
            [Required(ErrorMessage = "Informe o nome da cidade.")]
            [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
            public string? CityName { get; set; }
        }
    }
}
