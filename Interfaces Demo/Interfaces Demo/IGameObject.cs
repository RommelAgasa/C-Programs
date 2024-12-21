using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Demo
{

    public enum GameObjectMedium { Paper, Plastic, Electronic}
    internal interface IGameObject
    {
        int GameValue
        {
            get;
        }

        GameObjectMedium Medium { get; }
    }
}
