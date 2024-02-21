using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft.Classes
{
    class Engine : AircraftComponent
    {
        public override void Add(AircraftComponent component)
        {
        }

        public override void Remove(AircraftComponent component)
        {
        }

        public override void Draw(Graphics graphics, Point position)
        {
            Image engineImage = Image.FromFile("img\\Engane.png");
            graphics.DrawImage(engineImage, position);
        }
    }
}
