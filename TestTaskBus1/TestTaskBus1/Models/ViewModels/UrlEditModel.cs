using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestTaskBus1.Models.ViewModels
{
    public class UrlEditModel
    {
        public Guid Id { get; set; }

        [DisplayName("LongURL")]
        [Url]
        [Required(ErrorMessage = "URL required")]
        public string LongUrl { get; set; }

        [DisplayName("Publishing Date")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "01/01/1900", "01/01/2100", ErrorMessage = "Date is out of range")]
        public DateTime Date { get; set; }
    }
}