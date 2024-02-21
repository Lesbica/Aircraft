using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft.Classes
{
    class Wing : AircraftComponent
    {
        public override void Add(AircraftComponent component)
        {
        }

        public override void Remove(AircraftComponent component)
        {
        }

        public override void Draw(Graphics graphics, Point position)
        {
            Image wingImage1 = Image.FromFile("img\\Wing.png");
            Image wingImage2 = Image.FromFile("img\\Wing2.png");
            graphics.DrawImage(wingImage1, position);
            graphics.DrawImage(wingImage2, position);
        }
    }
}
