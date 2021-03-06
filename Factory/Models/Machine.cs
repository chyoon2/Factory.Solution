using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine ()
    {
      this.Engineers = new HashSet<MachineEngineer>();
    }  

      public int MachineId {get; set;}
      public string MachineName {get; set;}
      public string MachineDetails {get; set;}
      public virtual ICollection<MachineEngineer> Engineers {get; set;}
  }
}