using Aircraft.Classes;
using AircraftС.Classes;

namespace Aircraft
{
    public partial class Form1 : Form
    {
        private AircraftComponent _aircraft = new Classes.Aircraft();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _aircraft.Draw(e.Graphics, new Point(100, 100));
        }

        private void btnAddWing_Click(object sender, EventArgs e)
        {
            _aircraft.Add(new Wing());
            Refresh();
        }

        private void btnAddEngine_Click(object sender, EventArgs e)
        {
            _aircraft.Add(new Engine());
            Refresh();
        }

        private void btnAddAirframe_Click(object sender, EventArgs e)
        {
            _aircraft.Add(new Airframe());
            Refresh();
        }
    }
}
