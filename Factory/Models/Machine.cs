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
    public List<EngineerMachine> JoinEntities { get; }
  }
}