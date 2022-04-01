using MeterReading.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MeterReading.WebAPI.Validations
{
    public class FileValidation : IFileValidation
    {
        private readonly ApplicationDbContext _dbContext;
        public FileValidation(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> ValidateMeterReadingRecord(MeterReadFileRecord record, List<int> readAccountIds)
        {
            // If account Id not Match "NNNN"
            if(record.AccountId.ToString().Length != 4)
            {
                return false;
            }

            // If a duplicate account
            if (readAccountIds.Contains(record.AccountId))
            {
                return false;
            }

            //If the date is older than the existing one
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime actualDate;
            if (!DateTime.TryParseExact(record.MeterReadingDateTime, "dd/MM/yyyy HH:mm", provider, DateTimeStyles.None, out actualDate))
            {
                return false;
            }

            //If it is unknown account
            var accountDetails = await _dbContext.Accounts.Where(x => x.AccountId == record.AccountId).FirstOrDefaultAsync();
            if(accountDetails == null)
            {
                return false;
            }

            if (actualDate < accountDetails.MeterReadingDateTime)
            {
                return false;
            }

            //Update process if the validations valid
            accountDetails.MeterReadingDateTime = actualDate;
            accountDetails.MeterReadValue = record.MeterReadValue;
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
