using System.ComponentModel;
using Bunifu.Framework.UI;

namespace QLBH_BunifuUI.form
{
    partial class ChildFrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.childFrmAboutElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // childFrmAboutElipse
            // 
            this.childFrmAboutElipse.ElipseRadius = 0;
            this.childFrmAboutElipse.TargetControl = this;
            // 
            // childFrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildFrmAbout";
            this.Text = "childFrmAbout";
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuElipse childFrmAboutElipse;
    }
}