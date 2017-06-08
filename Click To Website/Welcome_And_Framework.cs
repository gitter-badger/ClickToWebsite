using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_To_Website
{
    public partial class Welcome_And_Framework : Form
    {
        public Welcome_And_Framework()
        {
            InitializeComponent();
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            #region Welcome
            if (Welcome_Name.Visible && Welcome_Info.Visible == true)
            {
                this.Size = new Size(215, 351);
                //Make what on the screen not visible
                Welcome_Name.Visible = false;
                Welcome_Info.Visible = false;

                //Make what needs to be visible... well visible
                Framework_Ask.Visible = true;
                Bootstrap_Ask.Visible = true;
                Or_Ask.Visible = true;
                Materialize_Ask.Visible = true;
                Picture_Bootstrap.Visible = true;
                Picture_Materialize.Visible = true;
                Picture_Materialize.Location = new Point(38, 66);
                Background_Materialize.Location = new Point(35, 63);
                Picture_Bootstrap.Location = new Point(38, 189);
                Background_Bootstrap.Location = new Point(35, 186);
                Or_Ask.Location = new Point(91, 144);
                Bootstrap_Ask.Location = new Point(69, 164);
            }
            #endregion
            #region Select Framework
            else if (Background_Bootstrap.Visible == true)
            {
                MessageBox.Show("This is hasn't been started on yet. Use Materialize.", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.Hide();
                //Bootstrap_Setup BSet = new Bootstrap_Setup();
                //BSet.Show();
            }
            else if (Background_Materialize.Visible == true)
            {
                this.Hide();
                Materialize_Setup MSet = new Materialize_Setup();
                MSet.Show();
            }
            else if (Picture_Bootstrap.Visible && Picture_Materialize.Visible == true)
            {
                MessageBox.Show("You need to press what you what to use","Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion
        }

        private void Picture_Materialize_Click(object sender, EventArgs e)
        {
            if (Background_Bootstrap.Visible == true)
            {
                Background_Bootstrap.Visible = false;
            }
            Background_Materialize.Visible = true;
        }

        private void Picture_Bootstrap_Click(object sender, EventArgs e)
        {
            if (Background_Materialize.Visible == true)
            {
                Background_Materialize.Visible = false;
            }
            Background_Bootstrap.Visible = true;
        }

        private void Welcome_And_Framework_SizeChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
