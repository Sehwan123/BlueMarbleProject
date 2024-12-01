namespace BlueMarbleProject
{
    partial class Building
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Building";
        }

        #endregion
        private System.Windows.Forms.Label areaName;
        private System.Windows.Forms.RadioButton Villa;
        private System.Windows.Forms.RadioButton Apart;
        private System.Windows.Forms.RadioButton Randmark;
        private System.Windows.Forms.RadioButton Hotel;
        private System.Windows.Forms.PictureBox Build;
        private System.Windows.Forms.PictureBox Build1;
        private System.Windows.Forms.PictureBox Build2;
        private System.Windows.Forms.PictureBox Build3;
        private System.Windows.Forms.PictureBox Build4;
    }
}