using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessValidationService.Models
{
    public class TemplateConfig
    {
        public string TemplateName { get; set; }
        public List<FieldConfig> Fields { get; set; }
        public List<BusinessValidationConfig> Rules { get; set; }
    }
}