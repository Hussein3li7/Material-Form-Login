using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace material_Login
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager msr = MaterialSkin.MaterialSkinManager.Instance;
            msr.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            msr.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue900, MaterialSkin.Primary.LightBlue900, MaterialSkin.Primary.Amber700, MaterialSkin.Accent.Teal400, MaterialSkin.TextShade.WHITE);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }
    }
}
