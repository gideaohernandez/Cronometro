namespace Cronometro
{
    partial class Cronometro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cronometro));
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.Btn_Iniciar = new Guna.UI.WinForms.GunaButton();
            this.ElipseCronometro = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Btn_Parar = new Guna.UI.WinForms.GunaButton();
            this.Btn_Zerar = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(15, 167);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(269, 55);
            this.label.TabIndex = 0;
            this.label.Text = "11:11:11.111";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cronómetro";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::Cronometro.Properties.Resources.power_off;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaButton1.Location = new System.Drawing.Point(278, 12);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(32, 29);
            this.gunaButton1.TabIndex = 11;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Btn_Iniciar
            // 
            this.Btn_Iniciar.AnimationHoverSpeed = 0.07F;
            this.Btn_Iniciar.AnimationSpeed = 0.03F;
            this.Btn_Iniciar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Iniciar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_Iniciar.BorderColor = System.Drawing.Color.Black;
            this.Btn_Iniciar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Iniciar.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Iniciar.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Iniciar.ForeColor = System.Drawing.Color.White;
            this.Btn_Iniciar.Image = null;
            this.Btn_Iniciar.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Iniciar.Location = new System.Drawing.Point(12, 267);
            this.Btn_Iniciar.Name = "Btn_Iniciar";
            this.Btn_Iniciar.OnHoverBaseColor = System.Drawing.Color.White;
            this.Btn_Iniciar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Iniciar.OnHoverForeColor = System.Drawing.Color.Black;
            this.Btn_Iniciar.OnHoverImage = null;
            this.Btn_Iniciar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Iniciar.Radius = 2;
            this.Btn_Iniciar.Size = new System.Drawing.Size(79, 38);
            this.Btn_Iniciar.TabIndex = 12;
            this.Btn_Iniciar.Text = "Iniciar";
            this.Btn_Iniciar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Iniciar.Click += new System.EventHandler(this.Btn_Iniciar_Click);
            // 
            // ElipseCronometro
            // 
            this.ElipseCronometro.Radius = 5;
            this.ElipseCronometro.TargetControl = this;
            // 
            // Btn_Parar
            // 
            this.Btn_Parar.AnimationHoverSpeed = 0.07F;
            this.Btn_Parar.AnimationSpeed = 0.03F;
            this.Btn_Parar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Parar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_Parar.BorderColor = System.Drawing.Color.Black;
            this.Btn_Parar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Parar.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Parar.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Parar.ForeColor = System.Drawing.Color.White;
            this.Btn_Parar.Image = null;
            this.Btn_Parar.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Parar.Location = new System.Drawing.Point(119, 267);
            this.Btn_Parar.Name = "Btn_Parar";
            this.Btn_Parar.OnHoverBaseColor = System.Drawing.Color.White;
            this.Btn_Parar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Parar.OnHoverForeColor = System.Drawing.Color.Black;
            this.Btn_Parar.OnHoverImage = null;
            this.Btn_Parar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Parar.Radius = 2;
            this.Btn_Parar.Size = new System.Drawing.Size(79, 38);
            this.Btn_Parar.TabIndex = 13;
            this.Btn_Parar.Text = "Parar";
            this.Btn_Parar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Parar.Click += new System.EventHandler(this.Btn_Parar_Click);
            // 
            // Btn_Zerar
            // 
            this.Btn_Zerar.AnimationHoverSpeed = 0.07F;
            this.Btn_Zerar.AnimationSpeed = 0.03F;
            this.Btn_Zerar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Zerar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_Zerar.BorderColor = System.Drawing.Color.Black;
            this.Btn_Zerar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Zerar.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Zerar.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Zerar.ForeColor = System.Drawing.Color.White;
            this.Btn_Zerar.Image = null;
            this.Btn_Zerar.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Zerar.Location = new System.Drawing.Point(222, 267);
            this.Btn_Zerar.Name = "Btn_Zerar";
            this.Btn_Zerar.OnHoverBaseColor = System.Drawing.Color.White;
            this.Btn_Zerar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Zerar.OnHoverForeColor = System.Drawing.Color.Black;
            this.Btn_Zerar.OnHoverImage = null;
            this.Btn_Zerar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Zerar.Radius = 2;
            this.Btn_Zerar.Size = new System.Drawing.Size(79, 38);
            this.Btn_Zerar.TabIndex = 14;
            this.Btn_Zerar.Text = "Zerar";
            this.Btn_Zerar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Zerar.Click += new System.EventHandler(this.Btn_Zerar_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(236, 12);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(36, 29);
            this.gunaControlBox1.TabIndex = 15;
            // 
            // Cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(317, 427);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.Btn_Zerar);
            this.Controls.Add(this.Btn_Parar);
            this.Controls.Add(this.Btn_Iniciar);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cronometro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Cronometro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton Btn_Iniciar;
        private Guna.UI.WinForms.GunaElipse ElipseCronometro;
        private Guna.UI.WinForms.GunaButton Btn_Parar;
        private Guna.UI.WinForms.GunaButton Btn_Zerar;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}

