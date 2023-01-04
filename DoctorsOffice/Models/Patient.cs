using System.Collections.Generic;

namespace DoctorsOffice.Models{



public class Patient{

  public int PatientId { get; set; }
  
  public string Name { get; set; }

  public DateTime? BirthDate { get; set; }

  public List<DoctorPatient> JoinEntites { get; }
  }
  }