using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsAndFleas;
public class Pet
{
    public int PetId { get; }
    public static int NextPetId { get; private set; }
    public int RemainingBites { get; private set; }
    public Pet()
    {
        NextPetId = 0;
        RemainingBites = 100;
    }
    public int GetBitten(int bites)
    {
        RemainingBites -= bites;
        return 0;
    }
    public void PrintCtorInfo(string info)
    {

    }
}