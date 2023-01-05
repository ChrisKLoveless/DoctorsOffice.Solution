using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorsOffice.Models
{

  public class Doctor
  {
    public int DoctorId { get; set; }
    [Required(ErrorMessage = "The Doctor name field can't be empty!")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Doctor's Specialty can't be empty!")]
    public string Specialty { get; set; }
    public List<DoctorPatient> JoinEntities { get; }
  }
}