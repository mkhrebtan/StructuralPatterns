using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralPatterns.Abstraction
{
    public interface IBirdBehavior
    {
        void Activate(Bird bird);
        string GetDescription();
    }
}