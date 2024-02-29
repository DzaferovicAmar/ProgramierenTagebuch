using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsAndFleas;
public class Cat : Pet
{
    private bool _isOnTree;
    public int TreesClimbed { get; private set; }
    public Cat() :base() 
    {
              
    }
    public bool ClimbOnTree()
    {
        _isOnTree = true;
        TreesClimbed++;
        return _isOnTree;
    }
    public bool ClimbDown()
    {
        _isOnTree = false;
        return _isOnTree;
    }
    public override string ToString()
    {
        return "";
    }
}
