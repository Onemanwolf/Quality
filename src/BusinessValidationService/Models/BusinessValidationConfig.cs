using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessValidationService.Models;
using Newtonsoft.Json;

namespace BusinessValidationService.Models
{
    public class BusinessValidationConfig
    {
        [JsonProperty("ruleName")]
        public string? RuleName { get; set; }
        [JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }
        [JsonProperty("validationLogic")]
        public ValidationLogic? ValidationLogic { get; set; }
    }
}