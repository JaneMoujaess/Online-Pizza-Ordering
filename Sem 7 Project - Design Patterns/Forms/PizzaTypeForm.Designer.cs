
namespace Sem_7_Project___Design_Patterns.Forms
{
    partial class PizzaTypeForm
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
            this.pnlNYStylePizza = new Guna.UI2.WinForms.Guna2Panel();
            this.btnContinueNY = new Guna.UI2.WinForms.Guna2Button();
            this.lblNYDesc = new System.Windows.Forms.Label();
            this.lblNYStyleSlice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlChicagoStylePizza = new Guna.UI2.WinForms.Guna2Panel();
            this.btnContinueChicago = new Guna.UI2.WinForms.Guna2Button();
            this.lblChicagoDesc = new System.Windows.Forms.Label();
            this.lblChicagoStyleSlice = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgCart = new System.Windows.Forms.PictureBox();
            this.btnCart = new Guna.UI2.WinForms.Guna2Shapes();
            this.pnlNYStylePizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlChicagoStylePizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNYStylePizza
            // 
            this.pnlNYStylePizza.BackColor = System.Drawing.Color.Transparent;
            this.pnlNYStylePizza.BorderColor = System.Drawing.Color.Transparent;
            this.pnlNYStylePizza.BorderRadius = 20;
            this.pnlNYStylePizza.Controls.Add(this.btnContinueNY);
            this.pnlNYStylePizza.Controls.Add(this.lblNYDesc);
            this.pnlNYStylePizza.Controls.Add(this.lblNYStyleSlice);
            this.pnlNYStylePizza.Controls.Add(this.pictureBox1);
            this.pnlNYStylePizza.FillColor = System.Drawing.Color.SeaShell;
            this.pnlNYStylePizza.Location = new System.Drawing.Point(156, 126);
            this.pnlNYStylePizza.Name = "pnlNYStylePizza";
            this.pnlNYStylePizza.ShadowDecoration.Parent = this.pnlNYStylePizza;
            this.pnlNYStylePizza.Size = new System.Drawing.Size(388, 578);
            this.pnlNYStylePizza.TabIndex = 0;
            // 
            // btnContinueNY
            // 
            this.btnContinueNY.BorderColor = System.Drawing.Color.Tomato;
            this.btnContinueNY.BorderRadius = 10;
            this.btnContinueNY.BorderThickness = 3;
            this.btnContinueNY.CheckedState.Parent = this.btnContinueNY;
            this.btnContinueNY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueNY.CustomImages.Parent = this.btnContinueNY;
            this.btnContinueNY.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContinueNY.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContinueNY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContinueNY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContinueNY.DisabledState.Parent = this.btnContinueNY;
            this.btnContinueNY.FillColor = System.Drawing.Color.Tomato;
            this.btnContinueNY.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueNY.ForeColor = System.Drawing.Color.SeaShell;
            this.btnContinueNY.HoverState.BorderColor = System.Drawing.Color.Tomato;
            this.btnContinueNY.HoverState.FillColor = System.Drawing.Color.SeaShell;
            this.btnContinueNY.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.btnContinueNY.HoverState.Parent = this.btnContinueNY;
            this.btnContinueNY.Location = new System.Drawing.Point(97, 468);
            this.btnContinueNY.Name = "btnContinueNY";
            this.btnContinueNY.ShadowDecoration.Parent = this.btnContinueNY;
            this.btnContinueNY.Size = new System.Drawing.Size(199, 70);
            this.btnContinueNY.TabIndex = 3;
            this.btnContinueNY.Text = "Continue";
            this.btnContinueNY.Click += new System.EventHandler(this.btnContinueNY_Click);
            // 
            // lblNYDesc
            // 
            this.lblNYDesc.AutoSize = true;
            this.lblNYDesc.Font = new System.Drawing.Font("Eras Medium ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNYDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNYDesc.Location = new System.Drawing.Point(92, 327);
            this.lblNYDesc.MaximumSize = new System.Drawing.Size(230, 100);
            this.lblNYDesc.Name = "lblNYDesc";
            this.lblNYDesc.Size = new System.Drawing.Size(214, 81);
            this.lblNYDesc.TabIndex = 2;
            this.lblNYDesc.Text = "The signature NY slice. Thin and light crust.";
            this.lblNYDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNYStyleSlice
            // 
            this.lblNYStyleSlice.AutoSize = true;
            this.lblNYStyleSlice.Font = new System.Drawing.Font("Eras Bold ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNYStyleSlice.Location = new System.Drawing.Point(70, 274);
            this.lblNYStyleSlice.Name = "lblNYStyleSlice";
            this.lblNYStyleSlice.Size = new System.Drawing.Size(238, 38);
            this.lblNYStyleSlice.TabIndex = 1;
            this.lblNYStyleSlice.Text = "NY Style Slice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Sem_7_Project___Design_Patterns.Properties.Resources.NYStylePizza_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(45, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlChicagoStylePizza
            // 
            this.pnlChicagoStylePizza.BackColor = System.Drawing.Color.Transparent;
            this.pnlChicagoStylePizza.BorderColor = System.Drawing.Color.Transparent;
            this.pnlChicagoStylePizza.BorderRadius = 20;
            this.pnlChicagoStylePizza.Controls.Add(this.btnContinueChicago);
            this.pnlChicagoStylePizza.Controls.Add(this.lblChicagoDesc);
            this.pnlChicagoStylePizza.Controls.Add(this.lblChicagoStyleSlice);
            this.pnlChicagoStylePizza.Controls.Add(this.pictureBox2);
            this.pnlChicagoStylePizza.FillColor = System.Drawing.Color.SeaShell;
            this.pnlChicagoStylePizza.Location = new System.Drawing.Point(628, 126);
            this.pnlChicagoStylePizza.Name = "pnlChicagoStylePizza";
            this.pnlChicagoStylePizza.ShadowDecoration.Parent = this.pnlChicagoStylePizza;
            this.pnlChicagoStylePizza.Size = new System.Drawing.Size(388, 578);
            this.pnlChicagoStylePizza.TabIndex = 1;
            // 
            // btnContinueChicago
            // 
            this.btnContinueChicago.BorderColor = System.Drawing.Color.Tomato;
            this.btnContinueChicago.BorderRadius = 10;
            this.btnContinueChicago.BorderThickness = 3;
            this.btnContinueChicago.CheckedState.Parent = this.btnContinueChicago;
            this.btnContinueChicago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueChicago.CustomImages.Parent = this.btnContinueChicago;
            this.btnContinueChicago.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContinueChicago.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContinueChicago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContinueChicago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContinueChicago.DisabledState.Parent = this.btnContinueChicago;
            this.btnContinueChicago.FillColor = System.Drawing.Color.Tomato;
            this.btnContinueChicago.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueChicago.ForeColor = System.Drawing.Color.SeaShell;
            this.btnContinueChicago.HoverState.BorderColor = System.Drawing.Color.Tomato;
            this.btnContinueChicago.HoverState.FillColor = System.Drawing.Color.SeaShell;
            this.btnContinueChicago.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.btnContinueChicago.HoverState.Parent = this.btnContinueChicago;
            this.btnContinueChicago.Location = new System.Drawing.Point(93, 468);
            this.btnContinueChicago.Name = "btnContinueChicago";
            this.btnContinueChicago.ShadowDecoration.Parent = this.btnContinueChicago;
            this.btnContinueChicago.Size = new System.Drawing.Size(199, 70);
            this.btnContinueChicago.TabIndex = 4;
            this.btnContinueChicago.Text = "Continue";
            this.btnContinueChicago.Click += new System.EventHandler(this.btnContinueChicago_Click);
            // 
            // lblChicagoDesc
            // 
            this.lblChicagoDesc.AutoSize = true;
            this.lblChicagoDesc.Font = new System.Drawing.Font("Eras Medium ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChicagoDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblChicagoDesc.Location = new System.Drawing.Point(88, 327);
            this.lblChicagoDesc.MaximumSize = new System.Drawing.Size(250, 100);
            this.lblChicagoDesc.Name = "lblChicagoDesc";
            this.lblChicagoDesc.Size = new System.Drawing.Size(229, 81);
            this.lblChicagoDesc.TabIndex = 3;
            this.lblChicagoDesc.Text = "The iconic deep-dish Chicago slice. Thick and hearty.";
            this.lblChicagoDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChicagoStyleSlice
            // 
            this.lblChicagoStyleSlice.AutoSize = true;
            this.lblChicagoStyleSlice.Font = new System.Drawing.Font("Eras Bold ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChicagoStyleSlice.Location = new System.Drawing.Point(30, 274);
            this.lblChicagoStyleSlice.Name = "lblChicagoStyleSlice";
            this.lblChicagoStyleSlice.Size = new System.Drawing.Size(324, 38);
            this.lblChicagoStyleSlice.TabIndex = 2;
            this.lblChicagoStyleSlice.Text = "Chicago Style Slice";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Sem_7_Project___Design_Patterns.Properties.Resources.ChicagoStylePizza;
            this.pictureBox2.Location = new System.Drawing.Point(66, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // imgCart
            // 
            this.imgCart.BackColor = System.Drawing.Color.SeaShell;
            this.imgCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCart.Image = global::Sem_7_Project___Design_Patterns.Properties.Resources.cart1;
            this.imgCart.Location = new System.Drawing.Point(43, 40);
            this.imgCart.Name = "imgCart";
            this.imgCart.Size = new System.Drawing.Size(89, 84);
            this.imgCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCart.TabIndex = 2;
            this.imgCart.TabStop = false;
            this.imgCart.Click += new System.EventHandler(this.imgCart_Click);
            this.imgCart.MouseEnter += new System.EventHandler(this.imgCart_MouseEnter);
            this.imgCart.MouseLeave += new System.EventHandler(this.imgCart_MouseLeave);
            // 
            // btnCart
            // 
            this.btnCart.BorderColor = System.Drawing.Color.Tomato;
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.FillColor = System.Drawing.Color.SeaShell;
            this.btnCart.Location = new System.Drawing.Point(3, -3);
            this.btnCart.Name = "btnCart";
            this.btnCart.PolygonSkip = 1;
            this.btnCart.Rotate = 0F;
            this.btnCart.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.btnCart.Size = new System.Drawing.Size(171, 167);
            this.btnCart.TabIndex = 3;
            this.btnCart.Zoom = 80;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            this.btnCart.MouseEnter += new System.EventHandler(this.btnCart_MouseEnter);
            this.btnCart.MouseLeave += new System.EventHandler(this.btnCart_MouseLeave);
            // 
            // PizzaTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1121, 754);
            this.Controls.Add(this.imgCart);
            this.Controls.Add(this.pnlChicagoStylePizza);
            this.Controls.Add(this.pnlNYStylePizza);
            this.Controls.Add(this.btnCart);
            this.Name = "PizzaTypeForm";
            this.Text = "Pizza Type";
            this.pnlNYStylePizza.ResumeLayout(false);
            this.pnlNYStylePizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChicagoStylePizza.ResumeLayout(false);
            this.pnlChicagoStylePizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlNYStylePizza;
        private Guna.UI2.WinForms.Guna2Panel pnlChicagoStylePizza;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNYStyleSlice;
        private System.Windows.Forms.Label lblChicagoStyleSlice;
        private System.Windows.Forms.Label lblNYDesc;
        private System.Windows.Forms.Label lblChicagoDesc;
        private Guna.UI2.WinForms.Guna2Button btnContinueNY;
        private Guna.UI2.WinForms.Guna2Button btnContinueChicago;
        private System.Windows.Forms.PictureBox imgCart;
        private Guna.UI2.WinForms.Guna2Shapes btnCart;
    }
}