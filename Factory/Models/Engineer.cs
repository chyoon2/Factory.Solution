using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<MachineEngineer>();
    }

    public int EngineerId {get; set;} 
    public string EngineerName {get; set;}
    public string EngineerDetails {get; set;}
    public virtual ICollection<MachineEngineer> Machines {get; set;}
  }
}