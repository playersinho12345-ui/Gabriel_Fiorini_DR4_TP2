using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gabriel_Fiorini_DR4_TP2_SaveNote_.Pages
{
    public class SaveNotesModel : PageModel
    {
        private readonly IWebHostEnvironment _env;

        public SaveNotesModel(IWebHostEnvironment env)
        {
            _env = env;
        }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public string? Message { get; set; }
        public string? DownloadUrl { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Escreva alguma coisa.")]
            public string? Content { get; set; }
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

            var fileName = $"note-{DateTime.Now:yyyyMMddHHmmss}.txt";
            var folder = Path.Combine(_env.WebRootPath, "files");
            Directory.CreateDirectory(folder);

            var fullPath = Path.Combine(folder, fileName);
            System.IO.File.WriteAllText(fullPath, Input.Content);

            if (System.IO.File.Exists(fullPath))
            {
                Message = "Anotação salva com sucesso!";
                DownloadUrl = "/files/" + fileName;
            }
        }
    }
}
