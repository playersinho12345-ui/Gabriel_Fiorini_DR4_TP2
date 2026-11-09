using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gabriel_Fiorini_DR4_TP2_CountryManager_.Pages.CountryManager.Exercicio06

{
    public class CreateCountry06Model : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new();

        public Country? CreatedCountry { get; set; }

        public class Country
        {
            public string? CountryName { get; set; }
            public string? CountryCode { get; set; }
        }

        public class InputModel
        {
            [Required(ErrorMessage = "Informe o nome do país.")]
            public string? CountryName { get; set; }

            [Required(ErrorMessage = "Informe o código do país.")]
            [StringLength(2, MinimumLength = 2, ErrorMessage = "O código deve ter exatamente 2 caracteres.")]
            public string? CountryCode { get; set; }
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            CreatedCountry = new Country
            {
                CountryName = Input.CountryName,
                CountryCode = Input.CountryCode
            };
        }
    }
}
