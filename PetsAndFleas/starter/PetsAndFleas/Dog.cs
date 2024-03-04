using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsAndFleas;
public class Dog : Pet
{
    private readonly TimeSpan _huntingWaitInterval;
    private readonly DateTimeProvider? _dateTimeProvider;
    private DateTime? _lastHuntedTime;
    public int HuntedAnimals { get; private set; }

    public Dog(DateTimeProvider dateTimeProvider)
    {
        _huntingWaitInterval = TimeSpan.FromMinutes(1);
        _dateTimeProvider = dateTimeProvider;
    }
    public bool HuntAnimal()
    {
        var currentTime = _dateTimeProvider!.Now;
        if (currentTime - _lastHuntedTime < TimeSpan.FromMinutes(1))
        {
            return false;
        }
        _lastHuntedTime = currentTime;
        HuntedAnimals++;
        return true;
    }


    public override string ToString()
    {
        return "I'm a dog";
    }
}