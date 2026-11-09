using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gabriel_Fiorini_DR4_TP2_SaveNote_.Pages
{
    public class SaveNotes11Model : PageModel
    {
        private readonly IWebHostEnvironment _env;

        public SaveNotes11Model(IWebHostEnvironment env)
        {
            _env = env;
        }

        public List<string> Files { get; set; } = new();
        public string? SelectedFile { get; set; }
        public string? Content { get; set; }

        public void OnGet(string? fileName)
        {
            var folder = Path.Combine(_env.WebRootPath, "files");

            if (Directory.Exists(folder))
            {
                Files = Directory.GetFiles(folder, "*.txt")
                                 .Select(f => Path.GetFileName(f))
                                 .OrderByDescending(n => n)
                                 .ToList();
            }

            if (!string.IsNullOrEmpty(fileName))
            {
                var safeName = Path.GetFileName(fileName);
                var fullPath = Path.Combine(folder, safeName);

                if (System.IO.File.Exists(fullPath))
                {
                    SelectedFile = safeName;
                    Content = System.IO.File.ReadAllText(fullPath);
                }
                else
                {
                    Content = "Arquivo não encontrado.";
                }
            }
        }
    }
}
