using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenAI_API.Completions;
using OpenAI_API;
using AspNetCoreWebApi.DataContexts;
using OpenAI_API.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using AspNetCoreWebApi.Models;
using System.ComponentModel;

namespace AspNetCoreWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllData()
        {
            var results=_context.TextGenerates.ToList();
            return Ok(results);
        }

        [HttpPost]
        public void SaveResult(TextGenerate text)
        {
            var result = _context.Add(text);
            _context.SaveChanges();
        }



        [HttpPost]
        public async Task<IActionResult> GetAIResults(TextGenerate searchText)
        {
            //string APIKey = "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";
            string answer = string.Empty;

            //var openAi = new OpenAIAPI(APIKey);

            //CompletionRequest completionRequest = new CompletionRequest();
            //completionRequest.Prompt = searchText;
            //completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
            //completionRequest.MaxTokens = 200;

            //var result = openAi.Completions.CreateCompletionAsync(completionRequest);
            //foreach (var item in result.Result.Completions)
            //{
            //    answer = item.Text;
            //}
            answer = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente eveniet nobis blanditiis in, animi quam obcaecati atque veniam aperiam recusandae nesciunt. Consequatur nam debitis nihil obcaecati quae unde rerum reprehenderit minima iusto, aut laudantium fuga cupiditate soluta aperiam ratione consequuntur nulla officiis blanditiis odio et eius tempore, omnis praesentium! Illum laudantium dolores consectetur laborum deserunt molestias, aliquam error. Accusantium, repellendus eveniet facilis optio numquam incidunt. Maxime enim odio similique eius fugiat laudantium, distinctio natus at? Eveniet, laborum enim? Minima odit ut repellat quas fugiat quo recusandae reiciendis? Sequi amet laborum molestiae corporis minima at, eum suscipit facilis quisquam consectetur. Eos quo est deleniti assumenda. Similique, nemo? Repellendus et sint minus corrupti odio temporibus, iusto magnam, at deserunt, blanditiis consectetur sunt quisquam explicabo. Veritatis dicta illo vel consequuntur ipsam aliquid reiciendis quia eaque repellendus eligendi. Quidem sapiente ";
            if(answer != null)
            {
               var strData= new TextGenerate();
                strData.Topic = answer;
                strData.Word = 200;
                SaveResult(strData);
            }
            return Ok(answer);

        }
    }
}
