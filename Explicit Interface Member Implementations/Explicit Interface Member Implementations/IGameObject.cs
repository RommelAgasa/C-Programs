using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface_Member_Implementations
{

    public enum GameObjectMedium { Paper, Plastic, Electronic }
    internal interface IGameObject
    {

        int Value
        {
            get;
        }
        GameObjectMedium Medium { get; }
    }
}
