using Microsoft.AspNetCore.Mvc;
using protex.Models;
using System.Text.Json;

namespace protex.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index(int? id)
        {
            string pathFolder = "DataJSON/articls";
            IEnumerable<String> nameArticlFilesJSON = Directory.EnumerateFiles(pathFolder, "*.json", SearchOption.TopDirectoryOnly);

            foreach (string file in nameArticlFilesJSON)
            {
                if (file.Contains(id + ".json"))
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Article? article = JsonSerializer.Deserialize<Article>(fs);
                        return View(article);
                    }
                }
            }

            return NotFound();
        }
    }
}
