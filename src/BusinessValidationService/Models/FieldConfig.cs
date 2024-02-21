using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessValidationService.Models
{
    public class FieldConfig
    {

           /*  "Type": "String",
                    "Required": true,
                    "MinLength": 5,
                    "MaxLength": 10,
                    "Value": "{$Binding}",
                    "Xpath": "{$Xpath}",
                    "Ypath": "{$Ypath}", */


        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string Value { get; set; }
        public bool Required { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public string Xpath { get; set; }
        public string Ypath { get; set; }

    }
}