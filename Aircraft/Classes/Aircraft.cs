using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft.Classes
{
    class Aircraft : AircraftComponent
    {
        private List<AircraftComponent> _components = new List<AircraftComponent>();

        public override void Add(AircraftComponent component)
        {
            _components.Add(component);
        }

        public override void Remove(AircraftComponent component)
        {
            _components.Remove(component);
        }

        public override void Draw(Graphics graphics, Point position)
        {
            foreach (var component in _components)
            {
                component.Draw(graphics, position);
            }
        }
    }
}
