
namespace Sem_7_Project___Design_Patterns
{
    partial class LoadingForm
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
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BorderRadius = 15;
            this.progressBar.BorderThickness = 2;
            this.progressBar.FillColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(124, 480);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.progressBar.ProgressColor = System.Drawing.Color.Tomato;
            this.progressBar.ProgressColor2 = System.Drawing.Color.Tomato;
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.Size = new System.Drawing.Size(326, 43);
            this.progressBar.TabIndex = 0;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sem_7_Project___Design_Patterns.Properties.Resources.vecteezy_pizzeria_vector_emblem_on_blackboard_pizza_logo_template_11157893;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 550);
            this.Controls.Add(this.progressBar);
            this.Name = "LoadingForm";
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}

