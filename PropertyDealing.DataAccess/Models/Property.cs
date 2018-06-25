using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PropertyDealing.DataAccess.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nagłówek oferty")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Miejscowość")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Ulica")]
        public string Street { get; set; }
        [Required]
        [Display(Name = "Zdjęcie")]
        public byte[] Image { get; set; }
        [Required]
        [Display(Name = "Liczba pokoi")]
        public int RoomsNumber { get; set; }
        [Required]
        [Display(Name = "Powierzchnia")]
        public int PropertyArea { get; set; }
        [Required]
        [Display(Name = "Kondygnacja")]       
        public int Storey { get; set; }
        [Required]
        [Display(Name = "Balkon")]
        public bool IsBalcony { get; set; }
        [Required]
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Cena")]
        public float Price { get; set; }
        [Required]
        public string UserId { get; set; }

        public bool IsSold { get; set; }
    }
}
