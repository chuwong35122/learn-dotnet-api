using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDotnetApp.Dtos.Character
{
  public class GetCharacterDto
  {
    public int Id { get; set; }
    public String Name { get; set; } = "Frodo";

    public int HitPoints { get; set; }

    public int Strength { get; set; }

    public int Defense { get; set; }

    public RpgClass Class { get; set; } = RpgClass.Knight;
  }
}