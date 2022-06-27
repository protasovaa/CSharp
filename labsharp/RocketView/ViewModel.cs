using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using RocketModel;

namespace RocketView
{
    class ViewModel : ViewObject
    {
        public Model Model { get; }

        public override float X { get => Model.X; }
        public override float Y { get => Model.Y; }

        public ViewModel(Model model, Image image)
            : base(image)
        {
            this.Model = model;
        }
    }
}
