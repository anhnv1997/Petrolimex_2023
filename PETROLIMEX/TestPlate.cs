using PetrolimexTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPGSTools
{
    public partial class frmTestPlate : Form
    {
        public frmTestPlate()
        {
            InitializeComponent();
        }
        private string ImgPath = "";
        private string Plate = "";
        public frmTestPlate(string imgPath, string plate)
        {
            InitializeComponent();
            this.ImgPath = imgPath;
            this.Plate = plate;
        }

        private void frmTestPlate_Load(object sender, EventArgs e)
        {
            if (ImgPath != "")
            {
                pictureBox1.Image = Image.FromFile(ImgPath);

            }
            else
            {
                label2.Text = "Ko tìm thấy path";
            }
            if (Plate != "")
            {
                label1.Text = Plate;
            }
            else
            {
                label1.Text = "Ko tìm thấy plate";
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
