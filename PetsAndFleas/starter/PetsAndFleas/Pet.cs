using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsAndFleas;
public class Pet
{
    public static int NextPetId { get; private set;}
    public int PetId { get; }
    public int RemainingBites { get; private set; }
    public Pet()
    {
        NextPetId = PetId++;
        RemainingBites = 100;
    }
    int GetBitten(int bites)
    {
        RemainingBites -= bites;
        return RemainingBites;
    }
}