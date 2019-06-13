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
            this.progressBarHealthYou = new System.Windows.Forms.ProgressBar();
            this.lblEquipedWeapon = new System.Windows.Forms.Label();
            this.lblEquipedClothing = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYou = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblYouName = new System.Windows.Forms.Label();
            this.progressBarHealthEnemy = new System.Windows.Forms.ProgressBar();
            this.lblEnemyDamage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(12, 322);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(164, 98);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run like a coward!";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonFight
            // 
            this.buttonFight.Location = new System.Drawing.Point(182, 322);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(162, 98);
            this.buttonFight.TabIndex = 1;
            this.buttonFight.Text = "Fight like a man!";
            this.buttonFight.UseVisualStyleBackColor = true;
            this.buttonFight.Click += new System.EventHandler(this.buttonFight_Click);
            // 
            // progressBarHealthYou
            // 
            this.progressBarHealthYou.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBarHealthYou.Location = new System.Drawing.Point(394, 117);
            this.progressBarHealthYou.Name = "progressBarHealthYou";
            this.progressBarHealthYou.Size = new System.Drawing.Size(256, 33);
            this.progressBarHealthYou.TabIndex = 2;
            // 
            // lblEquipedWeapon
            // 
            this.lblEquipedWeapon.AutoSize = true;
            this.lblEquipedWeapon.Location = new System.Drawing.Point(403, 179);
            this.lblEquipedWeapon.Name = "lblEquipedWeapon";
            this.lblEquipedWeapon.Size = new System.Drawing.Size(79, 29);
            this.lblEquipedWeapon.TabIndex = 3;
            this.lblEquipedWeapon.Text = "label1";
            // 
            // lblEquipedClothing
            // 
            this.lblEquipedClothing.AutoSize = true;
            this.lblEquipedClothing.Location = new System.Drawing.Point(403, 229);
            this.lblEquipedClothing.Name = "lblEquipedClothing";
            this.lblEquipedClothing.Size = new System.Drawing.Size(79, 29);
            this.lblEquipedClothing.TabIndex = 4;
            this.lblEquipedClothing.Text = "label2";
            // 
            // lblEnemy
            // 
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.Location = new System.Drawing.Point(24, 30);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(93, 29);
            this.lblEnemy.TabIndex = 5;
            this.lblEnemy.Text = "Enemy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 6;
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Location = new System.Drawing.Point(403, 30);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(62, 29);
            this.lblYou.TabIndex = 7;
            this.lblYou.Text = "You:";
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Location = new System.Drawing.Point(24, 72);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(79, 29);
            this.lblEnemyName.TabIndex = 8;
            this.lblEnemyName.Text = "label2";
            // 
            // lblYouName
            // 
            this.lblYouName.AutoSize = true;
            this.lblYouName.Location = new System.Drawing.Point(409, 78);
            this.lblYouName.Name = "lblYouName";
            this.lblYouName.Size = new System.Drawing.Size(79, 29);
            this.lblYouName.TabIndex = 9;
            this.lblYouName.Text = "label2";
            // 
            // progressBarHealthEnemy
            // 
            this.progressBarHealthEnemy.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBarHealthEnemy.Location = new System.Drawing.Point(29, 117);
            this.progressBarHealthEnemy.Name = "progressBarHealthEnemy";
            this.progressBarHealthEnemy.Size = new System.Drawing.Size(256, 33);
            this.progressBarHealthEnemy.TabIndex = 10;
            // 
            // lblEnemyDamage
            // 
            this.lblEnemyDamage.AutoSize = true;
            this.lblEnemyDamage.Location = new System.Drawing.Point(24, 169);
            this.lblEnemyDamage.Name = "lblEnemyDamage";
            this.lblEnemyDamage.Size = new System.Drawing.Size(79, 29);
            this.lblEnemyDamage.TabIndex = 11;
            this.lblEnemyDamage.Text = "label2";
            // 
            // SimpleFightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 462);
            this.ControlBox = false;
            this.Controls.Add(this.lblEnemyDamage);
            this.Controls.Add(this.progressBarHealthEnemy);
            this.Controls.Add(this.lblYouName);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnemy);
            this.Controls.Add(this.lblEquipedClothing);
            this.Controls.Add(this.lblEquipedWeapon);
            this.Controls.Add(this.progressBarHealthYou);
            this.Controls.Add(this.buttonFight);
            this.Controls.Add(this.buttonRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.ProgressBar progressBarHealthYou;
        private System.Windows.Forms.Label lblEquipedWeapon;
        private System.Windows.Forms.Label lblEquipedClothing;
        private System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label lblYouName;
        private System.Windows.Forms.ProgressBar progressBarHealthEnemy;
        private System.Windows.Forms.Label lblEnemyDamage;
    }
}