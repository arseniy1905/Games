using Games.Common.Extensions;
using Games.Common.Resources;
using Games.ViewModel.MVC;
using System;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.Validation
{
    public class MustBeLaterThanAttribute : ValidationAttribute
    {
        private readonly string _startDateName;

        public MustBeLaterThanAttribute(string startDateName)
        {
            _startDateName = startDateName;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var pi = validationContext.ObjectType.GetProperty(_startDateName);

                if (validationContext.ObjectType == typeof(ConfigureOrderingDaysViewModel))
                {
                    TimeSpan startTimespan, endTimespan;
                    if (!TimeSpan.TryParse((string)value, out endTimespan))
                    {
                        return new ValidationResult(CommonResources.InvalidValue, new string[] { "EndTime" });
                    }
                    if (!TimeSpan.TryParse((string)pi.GetValue(validationContext.ObjectInstance, null), out startTimespan))
                    {
                        return new ValidationResult(CommonResources.InvalidValue, new string[] { "StartTime" });
                    }
                    if (startTimespan >= endTimespan)
                    {
                        return new ValidationResult(CommonResources.EndTimeShouldBeLaterThanStartTime, new string[] { "EndTime" });
                    }
                }

                if (pi.PropertyType.Equals(typeof(DateTime)) || pi.PropertyType.Equals(typeof(DateTime?)))
                {
                    if (validationContext.ObjectType == typeof(DeliveryScheduleRecordViewModel))
                    {
                        if (DateTime.Now.Date.CompareTo(((DateTime)value).Date) > 0)
                        {
                            return new ValidationResult(CommonResources.DeliveryDateShouldNotBeEarlierThanToday);
                        }
                        //if (!((DateTime)value).IsWithinCurrentWeek())
                        //{
                        //    return new ValidationResult(CommonResources.DeliveryShouldBeForRestOfCurrentWeek);
                        //}
                    }

                    var startDt = (DateTime)pi.GetValue(validationContext.ObjectInstance, null);
                    if (startDt.CompareTo(value) >= 0)
                    {
                        return new ValidationResult(CommonResources.EndTimeShouldBeLaterThanStartTime);
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}
