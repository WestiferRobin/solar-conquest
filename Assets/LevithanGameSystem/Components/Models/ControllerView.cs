﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{

    public class ControllerModel: IModel
    {
        public ViewModel ModelView => throw new NotImplementedException();

        public ModelController ModelController => throw new NotImplementedException();

        public ControllerModel() { }
    
    }


    public class ControllerView: ViewModel, IController
    {
        public ControllerView(): base(new ControllerModel()) 
        {
        }
    }
}
