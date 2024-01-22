using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDraft
{
    public partial class AddShapeDropDown : Form
    {
        public AddShapeDropDown()
        {
            InitializeComponent();
        }

        public event EventHandler<string> ShapeDrawn;

        private void addCircleBtn_Click(object sender, EventArgs e)
        {
            ShapeDrawn?.Invoke(sender, "circle");
        }

        private void addRectangleBtn_Click(object sender, EventArgs e)
        {
            ShapeDrawn?.Invoke(sender, "rectangle");
        }

        private void addTriangleBtn_Click(object sender, EventArgs e)
        {
            ShapeDrawn?.Invoke(sender, "triangle");
        }

        private void addHexagonBtn_Click(object sender, EventArgs e)
        {
            ShapeDrawn?.Invoke(sender, "hexagon");
        }
    }
}
