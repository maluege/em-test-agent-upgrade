using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MySpendings.Models.ViewModels
{
    public class OutlayViewModel
    {
        public required Outlay Outlay { get; set; }

        [ValidateNever]
        public required string MinDate { get; set; }

        [ValidateNever]
        public required string MaxDate { get; set; }

        [ValidateNever]
        public required IEnumerable<SelectListItem> Categories { get; set; }
    }
}
