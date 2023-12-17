
using System.Collections.Generic;

namespace SolarConquestGameModels
{
    public abstract class ViewModel : IModel, IView
    {
        public ViewModel ModelView { get => this; }
        public IModel Model { get; private set; }
        public IView View { get; private set; }

        public ModelController ModelController => throw new System.NotImplementedException();

        public List<ViewModel> ViewModels => throw new System.NotImplementedException();

        public List<ViewController> ViewControllers => throw new System.NotImplementedException();

        public ViewModel(IView view, IModel model) { 
            this.View = view;
            this.Model = model;
        }
        public ViewModel(IView view) {
            this.View = view;
            this.Model = this.View.ModelView.Model;
        }
        public ViewModel(IModel model)
        {
            this.Model = model;
            this.View = this.Model.ModelView.View;
        }

        public ViewModel GetViewModel()
        {
            throw new System.NotImplementedException();
        }
    }
}
