using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProGym.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            Socios Control = new Socios();
            panelBienvenida.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panelBienvenida.Controls.Add(Control);
            
        }
    }
}
