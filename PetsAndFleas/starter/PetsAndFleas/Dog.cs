using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsAndFleas;
public class Dog : Pet
{
    private readonly static TimeSpan huntingWaitInterval;
    private DateTimeProvider _dateTimeProvider;
}