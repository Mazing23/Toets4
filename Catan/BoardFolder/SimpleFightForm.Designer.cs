namespace Catan
{
    partial class SimpleFightForm
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonFight = new System.Windows.Forms.Button();
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.lblEquipedWeapon = new System.Windows.Forms.Label();
            this.lblEquipedClothing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(40, 301);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(126, 98);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run like a coward!";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // buttonFight
            // 
            this.buttonFight.Location = new System.Drawing.Point(172, 301);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(125, 98);
            this.buttonFight.TabIndex = 1;
            this.buttonFight.Text = "Fight like a man!";
            this.buttonFight.UseVisualStyleBackColor = true;
            // 
            // progressBarHealth
            // 
            this.progressBarHealth.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBarHealth.Location = new System.Drawing.Point(41, 262);
            this.progressBarHealth.Name = "progressBarHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(256, 33);
            this.progressBarHealth.TabIndex = 2;
            // 
            // lblEquipedWeapon
            // 
            this.lblEquipedWeapon.AutoSize = true;
            this.lblEquipedWeapon.Location = new System.Drawing.Point(353, 266);
            this.lblEquipedWeapon.Name = "lblEquipedWeapon";
            this.lblEquipedWeapon.Size = new System.Drawing.Size(79, 29);
            this.lblEquipedWeapon.TabIndex = 3;
            this.lblEquipedWeapon.Text = "label1";
            // 
            // lblEquipedClothing
            // 
            this.lblEquipedClothing.AutoSize = true;
            this.lblEquipedClothing.Location = new System.Drawing.Point(353, 336);
            this.lblEquipedClothing.Name = "lblEquipedClothing";
            this.lblEquipedClothing.Size = new System.Drawing.Size(79, 29);
            this.lblEquipedClothing.TabIndex = 4;
            this.lblEquipedClothing.Text = "label2";
            // 
            // SimpleFightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 419);
            this.ControlBox = false;
            this.Controls.Add(this.lblEquipedClothing);
            this.Controls.Add(this.lblEquipedWeapon);
            this.Controls.Add(this.progressBarHealth);
            this.Controls.Add(this.buttonFight);
            this.Controls.Add(this.buttonRun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleFightForm";
            this.ShowIcon = false;
            this.Text = "SimpleFightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.Label lblEquipedWeapon;
        private System.Windows.Forms.Label lblEquipedClothing;
    }
}