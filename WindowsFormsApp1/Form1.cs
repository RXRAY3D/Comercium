using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Button currenButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;

            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Color SelecThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if( currenButton != (Button)btnSender) 
                {
                    DisableButton();
                    Color color = SelecThemeColor();
                    currenButton = (Button)btnSender;
                    currenButton.BackColor = color;
                    currenButton.ForeColor = Color.White;
                    currenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = ThemeColor.ChangeColorBright(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBright(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesk.Controls.Add(childForm);
            this.panelDesk.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProducts(), sender);
            //ActivateButton(sender);
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrders(), sender);
            //ActivateButton(sender);

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormClient(), sender);
            //ActivateButton(sender);

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReport(), sender);
            //ActivateButton(sender);

        }

        private void btnNotifi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNotificacion(), sender);
            //ActivateButton(sender);

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConfig(), sender);
            //ActivateButton(sender);

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panelDesk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else 
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }

        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39 ,39 , 58);
            currenButton = null; 
            
        }
    }
}
