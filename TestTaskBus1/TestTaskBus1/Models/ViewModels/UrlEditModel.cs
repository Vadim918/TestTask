using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestTaskBus1.Models.ViewModels
{
    public class UrlEditModel
    {
        [DisplayName("LongURL")]
        [Required(ErrorMessage = "URL required")]
        public string LongUrl { get; set; }
    }
}