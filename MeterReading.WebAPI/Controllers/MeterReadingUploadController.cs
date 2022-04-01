using CsvHelper;
using MeterReading.WebAPI.Models;
using MeterReading.WebAPI.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MeterReading.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterReadingUploadController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IFileValidation _fileValidation;
        public MeterReadingUploadController(ApplicationDbContext dbContext, IFileValidation fileValidation)
        {
            _dbContext = dbContext;
            _fileValidation = fileValidation;
        }

        [HttpPost]
        [Route("meter-reading-uploads")]
        public async Task<IActionResult> Post(IFormFile file)
        {
            var fileextension = Path.GetExtension(file.FileName);
            var filename = Guid.NewGuid().ToString() + fileextension;
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", filename);
            int successCount = 0;
            int errorCount = 0;
            List<int> readRecordAccountIds = new List<int>();
            using (FileStream fs = System.IO.File.Create(filepath))
            {
                file.CopyTo(fs);
            }
            if (fileextension == ".csv")
            {
                using (var reader = new StreamReader(filepath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<MeterReadFileRecord>();
                    foreach (var record in records)
                    {
                        if(await _fileValidation.ValidateMeterReadingRecord(record, readRecordAccountIds))
                        {
                            successCount++;
                            readRecordAccountIds.Add(record.AccountId);

                        }
                        else
                        {
                            errorCount++;
                        }
                    }
                }
            }

            return Ok($"File upload done successfully with {successCount} valid rows and {errorCount} error rows");
        }
    }
}
