
namespace Pim
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHospedes = new System.Windows.Forms.Button();
            this.btnQuartos = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnHospedes);
            this.panelMenu.Controls.Add(this.btnQuartos);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelUsuario);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // btnHospedes
            // 
            this.btnHospedes.BackColor = System.Drawing.SystemColors.Control;
            this.btnHospedes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHospedes.FlatAppearance.BorderSize = 0;
            this.btnHospedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospedes.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHospedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospedes.Location = new System.Drawing.Point(0, 221);
            this.btnHospedes.Name = "btnHospedes";
            this.btnHospedes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHospedes.Size = new System.Drawing.Size(220, 60);
            this.btnHospedes.TabIndex = 3;
            this.btnHospedes.Text = "  Hospedes";
            this.btnHospedes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospedes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHospedes.UseVisualStyleBackColor = false;
            this.btnHospedes.Click += new System.EventHandler(this.btnHospedes_Click);
            // 
            // btnQuartos
            // 
            this.btnQuartos.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuartos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuartos.FlatAppearance.BorderSize = 0;
            this.btnQuartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuartos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuartos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuartos.Location = new System.Drawing.Point(0, 161);
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQuartos.Size = new System.Drawing.Size(220, 60);
            this.btnQuartos.TabIndex = 2;
            this.btnQuartos.Text = "  Quartos";
            this.btnQuartos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuartos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuartos.UseVisualStyleBackColor = false;
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 101);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(220, 101);
            this.panelUsuario.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(666, 56);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(281, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelTitle);
            this.panelBody.Location = new System.Drawing.Point(248, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(666, 546);
            this.panelBody.TabIndex = 2;
            this.panelBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBody_Paint);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 581);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Life Hotel";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button btnHospedes;
        private System.Windows.Forms.Button btnQuartos;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblTitle;
    }
}