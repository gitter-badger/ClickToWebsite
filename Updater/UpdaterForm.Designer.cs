namespace Updater
{
    partial class UpdaterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdaterForm));
            this.Updating_Label = new System.Windows.Forms.Label();
            this.Done_Label = new System.Windows.Forms.Label();
            this.Open_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Updating_Label
            // 
            this.Updating_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Updating_Label.AutoSize = true;
            this.Updating_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Updating_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Updating_Label.Location = new System.Drawing.Point(107, 9);
            this.Updating_Label.Name = "Updating_Label";
            this.Updating_Label.Size = new System.Drawing.Size(161, 50);
            this.Updating_Label.TabIndex = 0;
            this.Updating_Label.Text = "Updating\r\nClick To Website";
            this.Updating_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Done_Label
            // 
            this.Done_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Done_Label.AutoSize = true;
            this.Done_Label.Location = new System.Drawing.Point(164, 72);
            this.Done_Label.Name = "Done_Label";
            this.Done_Label.Size = new System.Drawing.Size(42, 13);
            this.Done_Label.TabIndex = 1;
            this.Done_Label.Text = "Done :)";
            // 
            // Open_Button
            // 
            this.Open_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Open_Button.Location = new System.Drawing.Point(112, 99);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(134, 23);
            this.Open_Button.TabIndex = 2;
            this.Open_Button.Text = "Open Click To Website";
            this.Open_Button.UseVisualStyleBackColor = true;
            this.Open_Button.Click += new System.EventHandler(this.Open_Button_Click);
            // 
            // UpdaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(373, 134);
            this.Controls.Add(this.Open_Button);
            this.Controls.Add(this.Done_Label);
            this.Controls.Add(this.Updating_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdaterForm";
            this.Text = "Updating Click To Website";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Updating_Label;
        private System.Windows.Forms.Label Done_Label;
        private System.Windows.Forms.Button Open_Button;
    }
}

