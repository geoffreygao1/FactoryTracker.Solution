using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The machine's name can't be empty!")]
    public string Title { get; set; }
    [Range(0, 2, ErrorMessage = "You are out of the status range")]
    public int Status { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}