using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectFUEN.Models.VM
{
    public class BrandVM
    {
        public int Id { get; set; }
        [Display(Name = "分類名稱")]
        [Required(ErrorMessage = "必填")]
        public string Name { get; set; }

    }
}
