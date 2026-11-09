using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gabriel_Fiorini_DR4_TP2_CountryManager_.Pages.CountryManager.Exercicio07
{
    public class CreateCountry07Model : PageModel
    {
        [BindProperty]
        public List<InputModel> Inputs { get; set; } = new();

        public List<Country> CreatedCountries { get; set; } = new();

        public class Country
        {
            public string? CountryName { get; set; }
            public string? CountryCode { get; set; }
        }

        public class InputModel
        {
            public string? CountryName { get; set; }

            [StringLength(2, MinimumLength = 2, ErrorMessage = "O código deve ter exatamente 2 caracteres.")]
            public string? CountryCode { get; set; }
        }

        public void OnGet()
        {
            for (int i = 0; i < 5; i++)
            {
                Inputs.Add(new InputModel());
            }
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            foreach (var item in Inputs)
            {
                if (!string.IsNullOrWhiteSpace(item.CountryName) &&
                    !string.IsNullOrWhiteSpace(item.CountryCode))
                {
                    CreatedCountries.Add(new Country
                    {
                        CountryName = item.CountryName,
                        CountryCode = item.CountryCode
                    });
                }
            }
        }
    }
}

