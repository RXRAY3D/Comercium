namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnNotifi = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnOrden = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesk = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnNotifi);
            this.panelMenu.Controls.Add(this.btnReporte);
            this.panelMenu.Controls.Add(this.btnClient);
            this.panelMenu.Controls.Add(this.btnOrden);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 380);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnConfig.Size = new System.Drawing.Size(220, 60);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.Text = "   Configuraciones";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnNotifi
            // 
            this.btnNotifi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotifi.FlatAppearance.BorderSize = 0;
            this.btnNotifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNotifi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifi.Location = new System.Drawing.Point(0, 320);
            this.btnNotifi.Name = "btnNotifi";
            this.btnNotifi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNotifi.Size = new System.Drawing.Size(220, 60);
            this.btnNotifi.TabIndex = 5;
            this.btnNotifi.Text = "   Notificaciones";
            this.btnNotifi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifi.UseVisualStyleBackColor = true;
            this.btnNotifi.Click += new System.EventHandler(this.btnNotifi_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 260);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReporte.Size = new System.Drawing.Size(220, 60);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "   Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnClient
            // 
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(0, 200);
            this.btnClient.Name = "btnClient";
            this.btnClient.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClient.Size = new System.Drawing.Size(220, 60);
            this.btnClient.TabIndex = 3;
            this.btnClient.Text = "   Cliente";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrden.FlatAppearance.BorderSize = 0;
            this.btnOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrden.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrden.Location = new System.Drawing.Point(0, 140);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnOrden.Size = new System.Drawing.Size(220, 60);
            this.btnOrden.TabIndex = 2;
            this.btnOrden.Text = "   Ordenes";
            this.btnOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 80);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(220, 60);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "   Productos";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(72, 31);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(52, 20);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Home";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(580, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Orbitron SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(478, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 29);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Orbitron SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(513, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(29, 29);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Orbitron SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(548, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(238, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Caja";
            // 
            // panelDesk
            // 
            this.panelDesk.BackColor = System.Drawing.SystemColors.Window;
            this.panelDesk.Controls.Add(this.pictureBox1);
            this.panelDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesk.Location = new System.Drawing.Point(220, 80);
            this.panelDesk.Name = "panelDesk";
            this.panelDesk.Size = new System.Drawing.Size(580, 370);
            this.panelDesk.TabIndex = 2;
            this.panelDesk.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesk_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesk);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnNotifi;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

