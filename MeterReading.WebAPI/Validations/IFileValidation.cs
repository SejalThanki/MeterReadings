using MeterReading.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeterReading.WebAPI.Validations
{
    public interface IFileValidation
    {
        Task<bool> ValidateMeterReadingRecord(MeterReadFileRecord record, List<int> readAccountIds);
    }
}
