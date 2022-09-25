using System.ComponentModel.DataAnnotations;

namespace Core
{
    internal class DateRangeAttribute : ValidationAttribute
    {
        private readonly DateTime toDate;
        private readonly DateTime fromDate;

        public DateRangeAttribute(string to = null, string from = null)
        {
            toDate = to == null ? DateTime.UtcNow : DateTime.Parse(to);
            fromDate = from == null ? DateTime.MinValue : DateTime.Parse(from);
        }

        public override bool IsValid(object? value)
        {
            if (value == null) return false;
            if (value is DateTime == false) return false;
            var date = (DateTime)value;
            return fromDate <= date && date <= toDate;
        }
    }
}
