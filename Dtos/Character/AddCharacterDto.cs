using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDotnetApp.Dtos.Character
{
  public class AddCharacterDto
  {
    public String Name { get; set; } = "Frodo"; // Set a default value as Frodo as we do not allow Nullables

    public int HitPoints { get; set; }

    public int Strength { get; set; }

    public int Defense { get; set; }

    public RpgClass Class { get; set; } = RpgClass.Knight;
  }
}