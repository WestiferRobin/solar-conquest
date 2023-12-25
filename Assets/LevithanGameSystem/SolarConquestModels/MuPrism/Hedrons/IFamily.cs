using System;
using SolarConquestGameModels;
using System.Collections.Generic;

namespace SolarConquestGameModels
{
    public interface IFamily
    {
        public static int MaxSize = 4;

        IPrism Father { get; }
        IPrism Mother { get; }
        List<IPrism> Children { get; }

        FamilyName Name { get; }

        public virtual void InitFamily<T>(T father, T mother)
        {

        }
    }
}


