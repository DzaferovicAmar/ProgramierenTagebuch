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

        public Cat() : base()
        {
            _isOnTree = false; // Initialize as not on tree
            TreesClimbed = 0; // Initialize trees climbed
        }

        public bool ClimbOnTree()
        {
            if (!_isOnTree)
            {
                _isOnTree = true;
                TreesClimbed++;
                return true;
            }
            return false;
        }

        public bool ClimbDown()
        {
            if (_isOnTree)
            {
                _isOnTree = false;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "I'm a cat";
        }
    }