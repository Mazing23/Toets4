namespace Catan
{
    partial class BordGame
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
            this.lblEquippedClothing = new System.Windows.Forms.GroupBox();
            this.butEquipClothes = new System.Windows.Forms.Button();
            this.butEquipWeapons = new System.Windows.Forms.Button();
            this.lblResources = new System.Windows.Forms.Label();
            this.lblClothes = new System.Windows.Forms.Label();
            this.lblWeapons = new System.Windows.Forms.Label();
            this.listBoxResources = new System.Windows.Forms.ListBox();
            this.listBoxClothes = new System.Windows.Forms.ListBox();
            this.listBoxWeapons = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.lblTurnsLeft = new System.Windows.Forms.Label();
            this.lblMovesLeft = new System.Windows.Forms.Label();
            this.butNextTurn = new System.Windows.Forms.Button();
            this.butHarvest = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.butDown = new System.Windows.Forms.Button();
            this.butRight = new System.Windows.Forms.Button();
            this.butUp = new System.Windows.Forms.Button();
            this.butLoadGame = new System.Windows.Forms.Button();
            this.butSaveGame = new System.Windows.Forms.Button();
            this.butNewGame = new System.Windows.Forms.Button();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.lblPosy = new System.Windows.Forms.Label();
            this.lblPosx = new System.Windows.Forms.Label();
            this.groupBoxTileInfo = new System.Windows.Forms.GroupBox();
            this.lblNumberOfCitizens = new System.Windows.Forms.Label();
            this.lblHomeHealth = new System.Windows.Forms.Label();
            this.lblResourcesOnThisTile = new System.Windows.Forms.Label();
            this.lblItemOnThisLand = new System.Windows.Forms.Label();
            this.lblResourcesHome = new System.Windows.Forms.Label();
            this.lblResourcesOnThisLand = new System.Windows.Forms.Label();
            this.buCitizens = new System.Windows.Forms.Button();
            this.butDefence = new System.Windows.Forms.Button();
            this.lblEquippedClothing.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxMap.SuspendLayout();
            this.groupBoxTileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEquippedClothing
            // 
            this.lblEquippedClothing.Controls.Add(this.butDefence);
            this.lblEquippedClothing.Controls.Add(this.buCitizens);
            this.lblEquippedClothing.Controls.Add(this.butEquipClothes);
            this.lblEquippedClothing.Controls.Add(this.butEquipWeapons);
            this.lblEquippedClothing.Controls.Add(this.lblResources);
            this.lblEquippedClothing.Controls.Add(this.lblClothes);
            this.lblEquippedClothing.Controls.Add(this.lblWeapons);
            this.lblEquippedClothing.Controls.Add(this.listBoxResources);
            this.lblEquippedClothing.Controls.Add(this.listBoxClothes);
            this.lblEquippedClothing.Controls.Add(this.listBoxWeapons);
            this.lblEquippedClothing.Location = new System.Drawing.Point(6, 327);
            this.lblEquippedClothing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblEquippedClothing.Name = "lblEquippedClothing";
            this.lblEquippedClothing.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblEquippedClothing.Size = new System.Drawing.Size(401, 343);
            this.lblEquippedClothing.TabIndex = 0;
            this.lblEquippedClothing.TabStop = false;
            this.lblEquippedClothing.Text = "Inventory";
            // 
            // butEquipClothes
            // 
            this.butEquipClothes.Location = new System.Drawing.Point(331, 137);
            this.butEquipClothes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butEquipClothes.Name = "butEquipClothes";
            this.butEquipClothes.Size = new System.Drawing.Size(67, 30);
            this.butEquipClothes.TabIndex = 11;
            this.butEquipClothes.Text = "Equip";
            this.butEquipClothes.UseVisualStyleBackColor = true;
            this.butEquipClothes.Click += new System.EventHandler(this.butEquipClothes_Click);
            // 
            // butEquipWeapons
            // 
            this.butEquipWeapons.Location = new System.Drawing.Point(331, 34);
            this.butEquipWeapons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butEquipWeapons.Name = "butEquipWeapons";
            this.butEquipWeapons.Size = new System.Drawing.Size(67, 30);
            this.butEquipWeapons.TabIndex = 10;
            this.butEquipWeapons.Text = "Equip";
            this.butEquipWeapons.UseVisualStyleBackColor = true;
            this.butEquipWeapons.Click += new System.EventHandler(this.butEquipWeapons_Click);
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.Location = new System.Drawing.Point(3, 221);
            this.lblResources.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(80, 17);
            this.lblResources.TabIndex = 5;
            this.lblResources.Text = "Resources:";
            // 
            // lblClothes
            // 
            this.lblClothes.AutoSize = true;
            this.lblClothes.Location = new System.Drawing.Point(3, 119);
            this.lblClothes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClothes.Name = "lblClothes";
            this.lblClothes.Size = new System.Drawing.Size(59, 17);
            this.lblClothes.TabIndex = 4;
            this.lblClothes.Text = "Clothes:";
            // 
            // lblWeapons
            // 
            this.lblWeapons.AutoSize = true;
            this.lblWeapons.Location = new System.Drawing.Point(3, 17);
            this.lblWeapons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeapons.Name = "lblWeapons";
            this.lblWeapons.Size = new System.Drawing.Size(72, 17);
            this.lblWeapons.TabIndex = 3;
            this.lblWeapons.Text = "Weapons:";
            // 
            // listBoxResources
            // 
            this.listBoxResources.FormattingEnabled = true;
            this.listBoxResources.ItemHeight = 16;
            this.listBoxResources.Location = new System.Drawing.Point(3, 240);
            this.listBoxResources.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxResources.Name = "listBoxResources";
            this.listBoxResources.Size = new System.Drawing.Size(317, 84);
            this.listBoxResources.TabIndex = 2;
            // 
            // listBoxClothes
            // 
            this.listBoxClothes.FormattingEnabled = true;
            this.listBoxClothes.ItemHeight = 16;
            this.listBoxClothes.Location = new System.Drawing.Point(3, 137);
            this.listBoxClothes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxClothes.Name = "listBoxClothes";
            this.listBoxClothes.Size = new System.Drawing.Size(317, 84);
            this.listBoxClothes.TabIndex = 1;
            // 
            // listBoxWeapons
            // 
            this.listBoxWeapons.FormattingEnabled = true;
            this.listBoxWeapons.ItemHeight = 16;
            this.listBoxWeapons.Location = new System.Drawing.Point(3, 34);
            this.listBoxWeapons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxWeapons.Name = "listBoxWeapons";
            this.listBoxWeapons.Size = new System.Drawing.Size(317, 84);
            this.listBoxWeapons.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.progressBarHealth);
            this.groupBox2.Controls.Add(this.lblTurnsLeft);
            this.groupBox2.Controls.Add(this.lblMovesLeft);
            this.groupBox2.Controls.Add(this.butNextTurn);
            this.groupBox2.Controls.Add(this.butHarvest);
            this.groupBox2.Controls.Add(this.butLeft);
            this.groupBox2.Controls.Add(this.butDown);
            this.groupBox2.Controls.Add(this.butRight);
            this.groupBox2.Controls.Add(this.butUp);
            this.groupBox2.Controls.Add(this.butLoadGame);
            this.groupBox2.Controls.Add(this.butSaveGame);
            this.groupBox2.Controls.Add(this.butNewGame);
            this.groupBox2.Location = new System.Drawing.Point(411, 327);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(272, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moves";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(168, 46);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "label1";
            // 
            // progressBarHealth
            // 
            this.progressBarHealth.Location = new System.Drawing.Point(21, 296);
            this.progressBarHealth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarHealth.Name = "progressBarHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(235, 25);
            this.progressBarHealth.TabIndex = 11;
            // 
            // lblTurnsLeft
            // 
            this.lblTurnsLeft.AutoSize = true;
            this.lblTurnsLeft.Location = new System.Drawing.Point(15, 273);
            this.lblTurnsLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurnsLeft.Name = "lblTurnsLeft";
            this.lblTurnsLeft.Size = new System.Drawing.Size(46, 17);
            this.lblTurnsLeft.TabIndex = 10;
            this.lblTurnsLeft.Text = "label1";
            // 
            // lblMovesLeft
            // 
            this.lblMovesLeft.AutoSize = true;
            this.lblMovesLeft.Location = new System.Drawing.Point(15, 251);
            this.lblMovesLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovesLeft.Name = "lblMovesLeft";
            this.lblMovesLeft.Size = new System.Drawing.Size(46, 17);
            this.lblMovesLeft.TabIndex = 9;
            this.lblMovesLeft.Text = "label1";
            // 
            // butNextTurn
            // 
            this.butNextTurn.Location = new System.Drawing.Point(15, 190);
            this.butNextTurn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butNextTurn.Name = "butNextTurn";
            this.butNextTurn.Size = new System.Drawing.Size(80, 28);
            this.butNextTurn.TabIndex = 8;
            this.butNextTurn.Text = "Next Turn";
            this.butNextTurn.UseVisualStyleBackColor = true;
            this.butNextTurn.Click += new System.EventHandler(this.butNextTurn_Click);
            // 
            // butHarvest
            // 
            this.butHarvest.Location = new System.Drawing.Point(157, 190);
            this.butHarvest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butHarvest.Name = "butHarvest";
            this.butHarvest.Size = new System.Drawing.Size(47, 44);
            this.butHarvest.TabIndex = 7;
            this.butHarvest.Text = "Harvest";
            this.butHarvest.UseVisualStyleBackColor = true;
            this.butHarvest.Click += new System.EventHandler(this.butHarvest_Click);
            // 
            // butLeft
            // 
            this.butLeft.Location = new System.Drawing.Point(106, 190);
            this.butLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(47, 44);
            this.butLeft.TabIndex = 6;
            this.butLeft.Text = "Left";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // butDown
            // 
            this.butDown.Location = new System.Drawing.Point(157, 237);
            this.butDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butDown.Name = "butDown";
            this.butDown.Size = new System.Drawing.Size(47, 44);
            this.butDown.TabIndex = 5;
            this.butDown.Text = "Down";
            this.butDown.UseVisualStyleBackColor = true;
            this.butDown.Click += new System.EventHandler(this.butDown_Click);
            // 
            // butRight
            // 
            this.butRight.Location = new System.Drawing.Point(209, 190);
            this.butRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(47, 44);
            this.butRight.TabIndex = 4;
            this.butRight.Text = "Right";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // butUp
            // 
            this.butUp.Location = new System.Drawing.Point(157, 143);
            this.butUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butUp.Name = "butUp";
            this.butUp.Size = new System.Drawing.Size(47, 44);
            this.butUp.TabIndex = 3;
            this.butUp.Text = "Up";
            this.butUp.UseVisualStyleBackColor = true;
            this.butUp.Click += new System.EventHandler(this.butUp_Click);
            // 
            // butLoadGame
            // 
            this.butLoadGame.Location = new System.Drawing.Point(18, 86);
            this.butLoadGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butLoadGame.Name = "butLoadGame";
            this.butLoadGame.Size = new System.Drawing.Size(85, 30);
            this.butLoadGame.TabIndex = 2;
            this.butLoadGame.Text = "Load Game";
            this.butLoadGame.UseVisualStyleBackColor = true;
            this.butLoadGame.Click += new System.EventHandler(this.butLoadGame_Click);
            // 
            // butSaveGame
            // 
            this.butSaveGame.Location = new System.Drawing.Point(18, 52);
            this.butSaveGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butSaveGame.Name = "butSaveGame";
            this.butSaveGame.Size = new System.Drawing.Size(85, 30);
            this.butSaveGame.TabIndex = 1;
            this.butSaveGame.Text = "Save Game";
            this.butSaveGame.UseVisualStyleBackColor = true;
            this.butSaveGame.Click += new System.EventHandler(this.butSaveGame_Click);
            // 
            // butNewGame
            // 
            this.butNewGame.Location = new System.Drawing.Point(18, 19);
            this.butNewGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butNewGame.Name = "butNewGame";
            this.butNewGame.Size = new System.Drawing.Size(85, 30);
            this.butNewGame.TabIndex = 0;
            this.butNewGame.Text = "New Game";
            this.butNewGame.UseVisualStyleBackColor = true;
            this.butNewGame.Click += new System.EventHandler(this.butNewGame_Click);
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Controls.Add(this.lblPosy);
            this.groupBoxMap.Controls.Add(this.lblPosx);
            this.groupBoxMap.Location = new System.Drawing.Point(6, 6);
            this.groupBoxMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMap.Size = new System.Drawing.Size(401, 325);
            this.groupBoxMap.TabIndex = 2;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Map";
            // 
            // lblPosy
            // 
            this.lblPosy.AutoSize = true;
            this.lblPosy.Location = new System.Drawing.Point(310, 303);
            this.lblPosy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosy.Name = "lblPosy";
            this.lblPosy.Size = new System.Drawing.Size(53, 17);
            this.lblPosy.TabIndex = 1;
            this.lblPosy.Text = "lblPosy";
            // 
            // lblPosx
            // 
            this.lblPosx.AutoSize = true;
            this.lblPosx.Location = new System.Drawing.Point(229, 303);
            this.lblPosx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosx.Name = "lblPosx";
            this.lblPosx.Size = new System.Drawing.Size(53, 17);
            this.lblPosx.TabIndex = 0;
            this.lblPosx.Text = "lblPosy";
            // 
            // groupBoxTileInfo
            // 
            this.groupBoxTileInfo.Controls.Add(this.lblNumberOfCitizens);
            this.groupBoxTileInfo.Controls.Add(this.lblHomeHealth);
            this.groupBoxTileInfo.Controls.Add(this.lblResourcesOnThisTile);
            this.groupBoxTileInfo.Controls.Add(this.lblItemOnThisLand);
            this.groupBoxTileInfo.Controls.Add(this.lblResourcesHome);
            this.groupBoxTileInfo.Controls.Add(this.lblResourcesOnThisLand);
            this.groupBoxTileInfo.Location = new System.Drawing.Point(411, 7);
            this.groupBoxTileInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTileInfo.Name = "groupBoxTileInfo";
            this.groupBoxTileInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTileInfo.Size = new System.Drawing.Size(271, 323);
            this.groupBoxTileInfo.TabIndex = 3;
            this.groupBoxTileInfo.TabStop = false;
            this.groupBoxTileInfo.Text = "Tile info";
            // 
            // lblNumberOfCitizens
            // 
            this.lblNumberOfCitizens.AutoSize = true;
            this.lblNumberOfCitizens.Location = new System.Drawing.Point(18, 222);
            this.lblNumberOfCitizens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfCitizens.Name = "lblNumberOfCitizens";
            this.lblNumberOfCitizens.Size = new System.Drawing.Size(46, 17);
            this.lblNumberOfCitizens.TabIndex = 15;
            this.lblNumberOfCitizens.Text = "label6";
            // 
            // lblHomeHealth
            // 
            this.lblHomeHealth.AutoSize = true;
            this.lblHomeHealth.Location = new System.Drawing.Point(18, 200);
            this.lblHomeHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeHealth.Name = "lblHomeHealth";
            this.lblHomeHealth.Size = new System.Drawing.Size(46, 17);
            this.lblHomeHealth.TabIndex = 14;
            this.lblHomeHealth.Text = "label5";
            // 
            // lblResourcesOnThisTile
            // 
            this.lblResourcesOnThisTile.AutoSize = true;
            this.lblResourcesOnThisTile.Location = new System.Drawing.Point(18, 81);
            this.lblResourcesOnThisTile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResourcesOnThisTile.Name = "lblResourcesOnThisTile";
            this.lblResourcesOnThisTile.Size = new System.Drawing.Size(46, 17);
            this.lblResourcesOnThisTile.TabIndex = 13;
            this.lblResourcesOnThisTile.Text = "label3";
            // 
            // lblItemOnThisLand
            // 
            this.lblItemOnThisLand.AutoSize = true;
            this.lblItemOnThisLand.Location = new System.Drawing.Point(18, 60);
            this.lblItemOnThisLand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemOnThisLand.Name = "lblItemOnThisLand";
            this.lblItemOnThisLand.Size = new System.Drawing.Size(46, 17);
            this.lblItemOnThisLand.TabIndex = 12;
            this.lblItemOnThisLand.Text = "label2";
            // 
            // lblResourcesHome
            // 
            this.lblResourcesHome.AutoSize = true;
            this.lblResourcesHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResourcesHome.Location = new System.Drawing.Point(11, 169);
            this.lblResourcesHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResourcesHome.Name = "lblResourcesHome";
            this.lblResourcesHome.Size = new System.Drawing.Size(141, 20);
            this.lblResourcesHome.TabIndex = 11;
            this.lblResourcesHome.Text = "Resources home:";
            // 
            // lblResourcesOnThisLand
            // 
            this.lblResourcesOnThisLand.AutoSize = true;
            this.lblResourcesOnThisLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResourcesOnThisLand.Location = new System.Drawing.Point(11, 28);
            this.lblResourcesOnThisLand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResourcesOnThisLand.Name = "lblResourcesOnThisLand";
            this.lblResourcesOnThisLand.Size = new System.Drawing.Size(186, 20);
            this.lblResourcesOnThisLand.TabIndex = 10;
            this.lblResourcesOnThisLand.Text = "Resources on this land:";
            // 
            // buCitizens
            // 
            this.buCitizens.Location = new System.Drawing.Point(324, 240);
            this.buCitizens.Margin = new System.Windows.Forms.Padding(2);
            this.buCitizens.Name = "buCitizens";
            this.buCitizens.Size = new System.Drawing.Size(77, 30);
            this.buCitizens.TabIndex = 12;
            this.buCitizens.Text = "Citizens";
            this.buCitizens.UseVisualStyleBackColor = true;
            this.buCitizens.Click += new System.EventHandler(this.buCitizens_Click);
            // 
            // butDefence
            // 
            this.butDefence.Location = new System.Drawing.Point(324, 273);
            this.butDefence.Margin = new System.Windows.Forms.Padding(2);
            this.butDefence.Name = "butDefence";
            this.butDefence.Size = new System.Drawing.Size(77, 30);
            this.butDefence.TabIndex = 13;
            this.butDefence.Text = "Defence";
            this.butDefence.UseVisualStyleBackColor = true;
            this.butDefence.Click += new System.EventHandler(this.butDefence_Click);
            // 
            // BordGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 682);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxTileInfo);
            this.Controls.Add(this.groupBoxMap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblEquippedClothing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BordGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.lblEquippedClothing.ResumeLayout(false);
            this.lblEquippedClothing.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxMap.ResumeLayout(false);
            this.groupBoxMap.PerformLayout();
            this.groupBoxTileInfo.ResumeLayout(false);
            this.groupBoxTileInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lblEquippedClothing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butLoadGame;
        private System.Windows.Forms.Button butSaveGame;
        private System.Windows.Forms.Button butNewGame;
        private System.Windows.Forms.Button butHarvest;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Button butDown;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Button butUp;
        private System.Windows.Forms.ListBox listBoxResources;
        private System.Windows.Forms.ListBox listBoxClothes;
        private System.Windows.Forms.ListBox listBoxWeapons;
        private System.Windows.Forms.Label lblWeapons;
        private System.Windows.Forms.Label lblTurnsLeft;
        private System.Windows.Forms.Label lblMovesLeft;
        private System.Windows.Forms.Button butNextTurn;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.Label lblClothes;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.GroupBox groupBoxTileInfo;
        private System.Windows.Forms.Label lblNumberOfCitizens;
        private System.Windows.Forms.Label lblHomeHealth;
        private System.Windows.Forms.Label lblResourcesOnThisTile;
        private System.Windows.Forms.Label lblItemOnThisLand;
        private System.Windows.Forms.Label lblResourcesHome;
        private System.Windows.Forms.Label lblResourcesOnThisLand;
        private System.Windows.Forms.Button butEquipWeapons;
        private System.Windows.Forms.Label lblPosy;
        private System.Windows.Forms.Label lblPosx;
        private System.Windows.Forms.Button butEquipClothes;
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button butDefence;
        private System.Windows.Forms.Button buCitizens;
    }
}

