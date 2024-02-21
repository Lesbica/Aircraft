using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft.Classes
{
    abstract class AircraftComponent
    {
        public abstract void Add(AircraftComponent component);
        public abstract void Remove(AircraftComponent component);
        public abstract void Draw(Graphics graphics, Point position);
    }

}
