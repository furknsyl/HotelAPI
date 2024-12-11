using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Lütfen Hizmet Başlığı Giriniz.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
