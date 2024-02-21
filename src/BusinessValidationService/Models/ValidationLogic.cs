using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BusinessValidationService.Models
{
    public class ValidationLogic
    {
        [JsonProperty("operator")]
        public string? Operator { get; set; }
        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}