using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeterReading.WebAPI.Models
{
    public class MeterReadFileRecord
    {
        public int AccountId { get; set; }
        public string MeterReadValue { get; set; }
        public string MeterReadingDateTime { get; set; }
    }
}
