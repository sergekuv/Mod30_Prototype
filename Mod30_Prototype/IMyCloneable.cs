using Mod30_Prototype.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod30_Prototype
{
    internal interface IMyCloneable<out T> where T : class
    {
        public T CloneMemberWise();

        public T CloneCtor();
    }
}
