using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MeterReading.API.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string UploadMessage { get; private set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public async Task OnPost()
        {
            using (var multipartFormContent = new MultipartFormDataContent())
            {
                if(Request.Form.Files.Count <= 0)
                {
                    this.UploadMessage = "Please select a file";
                    return;
                }
                
                var file = Request.Form.Files[0];
                if(Path.GetExtension(file.FileName).ToLower() != ".csv")
                {
                    this.UploadMessage = "Please select a csv file";
                    return;
                }
                var fileStreamContent = new StreamContent(file.OpenReadStream());
                fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("text/csv");

                //Add the file
                multipartFormContent.Add(fileStreamContent, name: "file", fileName: file.FileName);
                HttpClient client = new HttpClient();
                var response = await client.PostAsync("http://localhost:5000/api/MeterReadingUpload/meter-reading-uploads", multipartFormContent);
                response.EnsureSuccessStatusCode();
                this.UploadMessage = await response.Content.ReadAsStringAsync();
            }
        }
    }
}

