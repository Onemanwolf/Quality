using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using BusinessValidationService.Models;
using Newtonsoft.Json;


namespace BusinessValidationService.Services
{
    public class BusinessSpecification
    {

        private List<BusinessValidationConfig>? _config;
        private TemplateConfig _templateConfig;
        private string _errorMessage;
        private ValidationLogic _validationLogic;
        private string _ruleName;

        public BusinessSpecification()
        {


        }

        public void LoadBusinessValidationConfig(string jsonFilePath)
        {

            var json = File.ReadAllText(jsonFilePath);


            _config = JsonConvert.DeserializeObject<List<BusinessValidationConfig>>(json);

            foreach (var spec in _config)
            {
                if (spec != null)
                {
                    _ruleName = spec.RuleName;
                    _errorMessage = spec.ErrorMessage;
                    _validationLogic = spec.ValidationLogic;
                }
            }
        }

        private bool IsValid(BusinessValidationConfig businessValidaion, BusinessData data)
        {
            var currentValue = 5;
            // var operatorValue = businessValidaion.RuleName == "Equals";
            //  var value = businessValidaion.ValidationLogic.Value == "10";
            if (businessValidaion.ValidationLogic.Operator == "Equals")
            {

                if (currentValue == Convert.ToInt32(businessValidaion.ValidationLogic.Value))
                {
                    Console.WriteLine($"Equals {businessValidaion.ValidationLogic.Value},");
                    return false;
                }
                return true;
            }
            else if (businessValidaion.ValidationLogic.Operator == "GreaterThan")
            {
                return currentValue > Convert.ToInt32(businessValidaion.ValidationLogic.Value);
            }
            else if (businessValidaion.ValidationLogic.Operator == "LessThan")
            {
                if (currentValue > Convert.ToInt32(businessValidaion.ValidationLogic.Value))
                {
                    Console.WriteLine($"Is Less than {businessValidaion.ValidationLogic.Value},");
                    return false;
                }
                return currentValue < Convert.ToInt32(businessValidaion.ValidationLogic.Value);
            }
            else if (businessValidaion.ValidationLogic.Operator == "NotEquals")
            {
                return currentValue != Convert.ToInt32(businessValidaion.ValidationLogic.Value);
            }
            else
            {
                return false;
            }

        }
    }

    internal class BusinessData
    {
    }
}