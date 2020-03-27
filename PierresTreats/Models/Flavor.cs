using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string FlavorName { get; set; }

    public ICollection<FlavorTreat> Treats { get; }
  }
}