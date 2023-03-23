using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The engineer's name can't be empty!")]
    public string Name { get; set; }
    public bool isBusy { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}