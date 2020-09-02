using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestTaskBus1.Models.ViewModels
{
    public class UrlAddModel
    {
        [DisplayName("LongURL")]
        [Url]
        [Required(ErrorMessage = "URL required")]
        public string LongUrl { get; set; }
    }
}