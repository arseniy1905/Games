using Games.Common.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class SKUClassificationGeneral
    {
        public SKUClassificationGeneral()
        {
            Divisors = new List<DivisorTypeVieModel>();
        }
        [Required(ErrorMessageResourceType = typeof(CommonResources), ErrorMessageResourceName = "EnterName")]
        public string Name { get; set; }
        [Required(ErrorMessageResourceType = typeof(CommonResources), ErrorMessageResourceName = "EnterDescription")]
        public string Description { get; set; }
        public string DevisorType { get; set; }
        [Required(ErrorMessageResourceType = typeof(CommonResources), ErrorMessageResourceName = "EnterDivisorType")]
        public int DivisorTypeID { get; set; }
        public List<DivisorTypeVieModel> Divisors { get; set; }
        [Required(ErrorMessageResourceType = typeof(CommonResources), ErrorMessageResourceName = "EnterDivisor")]
        public string Divisor { get; set; }
        public bool IsDefault { get; set; }

    }
}
