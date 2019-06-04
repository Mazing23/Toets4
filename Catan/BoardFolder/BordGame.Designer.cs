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
            this.lblClothesEquipped = new System.Windows.Forms.Label();
            this.lblEquippedWeapon = new System.Windows.Forms.Label();
            this.lblHealthPoints = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblResources = new System.Windows.Forms.Label();
            this.lblClothes = new System.Windows.Forms.Label();
            this.lblWeapons = new System.Windows.Forms.Label();
            this.listBoxResources = new System.Windows.Forms.ListBox();
            this.listBoxClothes = new System.Windows.Forms.ListBox();
            this.listBoxWeapons = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBoxTileInfo = new System.Windows.Forms.GroupBox();
            this.lblNumberOfCitizens = new System.Windows.Forms.Label();
            this.lblHomeHealth = new System.Windows.Forms.Label();
            this.lblResourcesOnThisTile = new System.Windows.Forms.Label();
            this.lblItemOnThisLand = new System.Windows.Forms.Label();
            this.lblResourcesHome = new System.Windows.Forms.Label();
            this.lblResourcesOnThisLand = new System.Windows.Forms.Label();
            this.lblPosx = new System.Windows.Forms.Label();
            this.lblPosy = new System.Windows.Forms.Label();
            this.lblEquippedClothing.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxMap.SuspendLayout();
            this.groupBoxTileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEquippedClothing
            // 
            this.lblEquippedClothing.Controls.Add(this.butEquipClothes);
            this.lblEquippedClothing.Controls.Add(this.butEquipWeapons);
            this.lblEquippedClothing.Controls.Add(this.lblClothesEquipped);
            this.lblEquippedClothing.Controls.Add(this.lblEquippedWeapon);
            this.lblEquippedClothing.Controls.Add(this.lblHealthPoints);
            this.lblEquippedClothing.Controls.Add(this.lblPlayerName);
            this.lblEquippedClothing.Controls.Add(this.lblResources);
            this.lblEquippedClothing.Controls.Add(this.lblClothes);
            this.lblEquippedClothing.Controls.Add(this.lblWeapons);
            this.lblEquippedClothing.Controls.Add(this.listBoxResources);
            this.lblEquippedClothing.Controls.Add(this.listBoxClothes);
            this.lblEquippedClothing.Controls.Add(this.listBoxWeapons);
            this.lblEquippedClothing.Location = new System.Drawing.Point(11, 593);
            this.lblEquippedClothing.Name = "lblEquippedClothing";
            this.lblEquippedClothing.Size = new System.Drawing.Size(702, 621);
            this.lblEquippedClothing.TabIndex = 0;
            this.lblEquippedClothing.TabStop = false;
            this.lblEquippedClothing.Text = "Inventory";
            // 
            // butEquipClothes
            // 
            this.butEquipClothes.Location = new System.Drawing.Point(325, 248);
            this.butEquipClothes.Name = "butEquipClothes";
            this.butEquipClothes.Size = new System.Drawing.Size(117, 54);
            this.butEquipClothes.TabIndex = 11;
            this.butEquipClothes.Text = "Equip";
            this.butEquipClothes.UseVisualStyleBackColor = true;
            this.butEquipClothes.Click += new System.EventHandler(this.butEquipClothes_Click);
            // 
            // butEquipWeapons
            // 
            this.butEquipWeapons.Location = new System.Drawing.Point(325, 62);
            this.butEquipWeapons.Name = "butEquipWeapons";
            this.butEquipWeapons.Size = new System.Drawing.Size(117, 54);
            this.butEquipWeapons.TabIndex = 10;
            this.butEquipWeapons.Text = "Equip";
            this.butEquipWeapons.UseVisualStyleBackColor = true;
            this.butEquipWeapons.Click += new System.EventHandler(this.butEquipWeapons_Click);
            // 
            // lblClothesEquipped
            // 
            this.lblClothesEquipped.AutoSize = true;
            this.lblClothesEquipped.Location = new System.Drawing.Point(430, 544);
            this.lblClothesEquipped.Name = "lblClothesEquipped";
            this.lblClothesEquipped.Size = new System.Drawing.Size(79, 29);
            this.lblClothesEquipped.TabIndex = 9;
            this.lblClothesEquipped.Text = "label4";
            // 
            // lblEquippedWeapon
            // 
            this.lblEquippedWeapon.AutoSize = true;
            this.lblEquippedWeapon.Location = new System.Drawing.Point(430, 480);
            this.lblEquippedWeapon.Name = "lblEquippedWeapon";
            this.lblEquippedWeapon.Size = new System.Drawing.Size(79, 29);
            this.lblEquippedWeapon.TabIndex = 8;
            this.lblEquippedWeapon.Text = "label3";
            // 
            // lblHealthPoints
            // 
            this.lblHealthPoints.AutoSize = true;
            this.lblHealthPoints.Location = new System.Drawing.Point(430, 419);
            this.lblHealthPoints.Name = "lblHealthPoints";
            this.lblHealthPoints.Size = new System.Drawing.Size(79, 29);
            this.lblHealthPoints.TabIndex = 7;
            this.lblHealthPoints.Text = "label2";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPlayerName.Location = new System.Drawing.Point(428, 360);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(129, 40);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "Player:";
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.Location = new System.Drawing.Point(6, 400);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(135, 29);
            this.lblResources.TabIndex = 5;
            this.lblResources.Text = "Resources:";
            // 
            // lblClothes
            // 
            this.lblClothes.AutoSize = true;
            this.lblClothes.Location = new System.Drawing.Point(6, 216);
            this.lblClothes.Name = "lblClothes";
            this.lblClothes.Size = new System.Drawing.Size(101, 29);
            this.lblClothes.TabIndex = 4;
            this.lblClothes.Text = "Clothes:";
            // 
            // lblWeapons
            // 
            this.lblWeapons.AutoSize = true;
            this.lblWeapons.Location = new System.Drawing.Point(6, 30);
            this.lblWeapons.Name = "lblWeapons";
            this.lblWeapons.Size = new System.Drawing.Size(121, 29);
            this.lblWeapons.TabIndex = 3;
            this.lblWeapons.Text = "Weapons:";
            // 
            // listBoxResources
            // 
            this.listBoxResources.FormattingEnabled = true;
            this.listBoxResources.ItemHeight = 29;
            this.listBoxResources.Location = new System.Drawing.Point(6, 435);
            this.listBoxResources.Name = "listBoxResources";
            this.listBoxResources.Size = new System.Drawing.Size(313, 149);
            this.listBoxResources.TabIndex = 2;
            // 
            // listBoxClothes
            // 
            this.listBoxClothes.FormattingEnabled = true;
            this.listBoxClothes.ItemHeight = 29;
            this.listBoxClothes.Location = new System.Drawing.Point(6, 248);
            this.listBoxClothes.Name = "listBoxClothes";
            this.listBoxClothes.Size = new System.Drawing.Size(313, 149);
            this.listBoxClothes.TabIndex = 1;
            // 
            // listBoxWeapons
            // 
            this.listBoxWeapons.FormattingEnabled = true;
            this.listBoxWeapons.ItemHeight = 29;
            this.listBoxWeapons.Location = new System.Drawing.Point(6, 62);
            this.listBoxWeapons.Name = "listBoxWeapons";
            this.listBoxWeapons.Size = new System.Drawing.Size(313, 149);
            this.listBoxWeapons.TabIndex = 0;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(719, 593);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 621);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moves";
            // 
            // lblTurnsLeft
            // 
            this.lblTurnsLeft.AutoSize = true;
            this.lblTurnsLeft.Location = new System.Drawing.Point(26, 453);
            this.lblTurnsLeft.Name = "lblTurnsLeft";
            this.lblTurnsLeft.Size = new System.Drawing.Size(79, 29);
            this.lblTurnsLeft.TabIndex = 10;
            this.lblTurnsLeft.Text = "label1";
            // 
            // lblMovesLeft
            // 
            this.lblMovesLeft.AutoSize = true;
            this.lblMovesLeft.Location = new System.Drawing.Point(26, 414);
            this.lblMovesLeft.Name = "lblMovesLeft";
            this.lblMovesLeft.Size = new System.Drawing.Size(79, 29);
            this.lblMovesLeft.TabIndex = 9;
            this.lblMovesLeft.Text = "label1";
            // 
            // butNextTurn
            // 
            this.butNextTurn.Location = new System.Drawing.Point(26, 345);
            this.butNextTurn.Name = "butNextTurn";
            this.butNextTurn.Size = new System.Drawing.Size(140, 50);
            this.butNextTurn.TabIndex = 8;
            this.butNextTurn.Text = "Next Turn";
            this.butNextTurn.UseVisualStyleBackColor = true;
            this.butNextTurn.Click += new System.EventHandler(this.butNextTurn_Click);
            // 
            // butHarvest
            // 
            this.butHarvest.Location = new System.Drawing.Point(274, 345);
            this.butHarvest.Name = "butHarvest";
            this.butHarvest.Size = new System.Drawing.Size(83, 79);
            this.butHarvest.TabIndex = 7;
            this.butHarvest.Text = "Harvest";
            this.butHarvest.UseVisualStyleBackColor = true;
            this.butHarvest.Click += new System.EventHandler(this.butHarvest_Click);
            // 
            // butLeft
            // 
            this.butLeft.Location = new System.Drawing.Point(185, 345);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(83, 79);
            this.butLeft.TabIndex = 6;
            this.butLeft.Text = "Left";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // butDown
            // 
            this.butDown.Location = new System.Drawing.Point(274, 430);
            this.butDown.Name = "butDown";
            this.butDown.Size = new System.Drawing.Size(83, 79);
            this.butDown.TabIndex = 5;
            this.butDown.Text = "Down";
            this.butDown.UseVisualStyleBackColor = true;
            this.butDown.Click += new System.EventHandler(this.butDown_Click);
            // 
            // butRight
            // 
            this.butRight.Location = new System.Drawing.Point(366, 345);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(83, 79);
            this.butRight.TabIndex = 4;
            this.butRight.Text = "Right";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // butUp
            // 
            this.butUp.Location = new System.Drawing.Point(274, 260);
            this.butUp.Name = "butUp";
            this.butUp.Size = new System.Drawing.Size(83, 79);
            this.butUp.TabIndex = 3;
            this.butUp.Text = "Up";
            this.butUp.UseVisualStyleBackColor = true;
            this.butUp.Click += new System.EventHandler(this.butUp_Click);
            // 
            // butLoadGame
            // 
            this.butLoadGame.Location = new System.Drawing.Point(31, 156);
            this.butLoadGame.Name = "butLoadGame";
            this.butLoadGame.Size = new System.Drawing.Size(149, 55);
            this.butLoadGame.TabIndex = 2;
            this.butLoadGame.Text = "Load Game";
            this.butLoadGame.UseVisualStyleBackColor = true;
            this.butLoadGame.Click += new System.EventHandler(this.butLoadGame_Click);
            // 
            // butSaveGame
            // 
            this.butSaveGame.Location = new System.Drawing.Point(31, 95);
            this.butSaveGame.Name = "butSaveGame";
            this.butSaveGame.Size = new System.Drawing.Size(149, 55);
            this.butSaveGame.TabIndex = 1;
            this.butSaveGame.Text = "Save Game";
            this.butSaveGame.UseVisualStyleBackColor = true;
            this.butSaveGame.Click += new System.EventHandler(this.butSaveGame_Click);
            // 
            // butNewGame
            // 
            this.butNewGame.Location = new System.Drawing.Point(31, 34);
            this.butNewGame.Name = "butNewGame";
            this.butNewGame.Size = new System.Drawing.Size(149, 55);
            this.butNewGame.TabIndex = 0;
            this.butNewGame.Text = "New Game";
            this.butNewGame.UseVisualStyleBackColor = true;
            this.butNewGame.Click += new System.EventHandler(this.butNewGame_Click);
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Controls.Add(this.lblPosy);
            this.groupBoxMap.Controls.Add(this.lblPosx);
            this.groupBoxMap.Location = new System.Drawing.Point(11, 11);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(702, 589);
            this.groupBoxMap.TabIndex = 2;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Map";
            // 
            // groupBoxTileInfo
            // 
            this.groupBoxTileInfo.Controls.Add(this.lblNumberOfCitizens);
            this.groupBoxTileInfo.Controls.Add(this.lblHomeHealth);
            this.groupBoxTileInfo.Controls.Add(this.lblResourcesOnThisTile);
            this.groupBoxTileInfo.Controls.Add(this.lblItemOnThisLand);
            this.groupBoxTileInfo.Controls.Add(this.lblResourcesHome);
            this.groupBoxTileInfo.Controls.Add(this.lblResourcesOnThisLand);
            this.groupBoxTileInfo.Location = new System.Drawing.Point(719, 13);
            this.groupBoxTileInfo.Name = "groupBoxTileInfo";
            this.groupBoxTileInfo.Size = new System.Drawing.Size(475, 586);
            this.groupBoxTileInfo.TabIndex = 3;
            this.groupBoxTileInfo.TabStop = false;
            this.groupBoxTileInfo.Text = "Tile info";
            // 
            // lblNumberOfCitizens
            // 
            this.lblNumberOfCitizens.AutoSize = true;
            this.lblNumberOfCitizens.Location = new System.Drawing.Point(32, 402);
            this.lblNumberOfCitizens.Name = "lblNumberOfCitizens";
            this.lblNumberOfCitizens.Size = new System.Drawing.Size(79, 29);
            this.lblNumberOfCitizens.TabIndex = 15;
            this.lblNumberOfCitizens.Text = "label6";
            // 
            // lblHomeHealth
            // 
            this.lblHomeHealth.AutoSize = true;
            this.lblHomeHealth.Location = new System.Drawing.Point(32, 363);
            this.lblHomeHealth.Name = "lblHomeHealth";
            this.lblHomeHealth.Size = new System.Drawing.Size(79, 29);
            this.lblHomeHealth.TabIndex = 14;
            this.lblHomeHealth.Text = "label5";
            // 
            // lblResourcesOnThisTile
            // 
            this.lblResourcesOnThisTile.AutoSize = true;
            this.lblResourcesOnThisTile.Location = new System.Drawing.Point(32, 146);
            this.lblResourcesOnThisTile.Name = "lblResourcesOnThisTile";
            this.lblResourcesOnThisTile.Size = new System.Drawing.Size(79, 29);
            this.lblResourcesOnThisTile.TabIndex = 13;
            this.lblResourcesOnThisTile.Text = "label3";
            // 
            // lblItemOnThisLand
            // 
            this.lblItemOnThisLand.AutoSize = true;
            this.lblItemOnThisLand.Location = new System.Drawing.Point(32, 108);
            this.lblItemOnThisLand.Name = "lblItemOnThisLand";
            this.lblItemOnThisLand.Size = new System.Drawing.Size(79, 29);
            this.lblItemOnThisLand.TabIndex = 12;
            this.lblItemOnThisLand.Text = "label2";
            // 
            // lblResourcesHome
            // 
            this.lblResourcesHome.AutoSize = true;
            this.lblResourcesHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResourcesHome.Location = new System.Drawing.Point(19, 306);
            this.lblResourcesHome.Name = "lblResourcesHome";
            this.lblResourcesHome.Size = new System.Drawing.Size(247, 36);
            this.lblResourcesHome.TabIndex = 11;
            this.lblResourcesHome.Text = "Resources home:";
            // 
            // lblResourcesOnThisLand
            // 
            this.lblResourcesOnThisLand.AutoSize = true;
            this.lblResourcesOnThisLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResourcesOnThisLand.Location = new System.Drawing.Point(19, 51);
            this.lblResourcesOnThisLand.Name = "lblResourcesOnThisLand";
            this.lblResourcesOnThisLand.Size = new System.Drawing.Size(328, 36);
            this.lblResourcesOnThisLand.TabIndex = 10;
            this.lblResourcesOnThisLand.Text = "Resources on this land:";
            // 
            // lblPosx
            // 
            this.lblPosx.AutoSize = true;
            this.lblPosx.Location = new System.Drawing.Point(72, 501);
            this.lblPosx.Name = "lblPosx";
            this.lblPosx.Size = new System.Drawing.Size(79, 29);
            this.lblPosx.TabIndex = 0;
            this.lblPosx.Text = "label1";
            // 
            // lblPosy
            // 
            this.lblPosy.AutoSize = true;
            this.lblPosy.Location = new System.Drawing.Point(196, 501);
            this.lblPosy.Name = "lblPosy";
            this.lblPosy.Size = new System.Drawing.Size(79, 29);
            this.lblPosy.TabIndex = 1;
            this.lblPosy.Text = "label1";
            // 
            // BordGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 1216);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxTileInfo);
            this.Controls.Add(this.groupBoxMap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblEquippedClothing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Label lblClothesEquipped;
        private System.Windows.Forms.Label lblEquippedWeapon;
        private System.Windows.Forms.Label lblHealthPoints;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.GroupBox groupBoxTileInfo;
        private System.Windows.Forms.Label lblNumberOfCitizens;
        private System.Windows.Forms.Label lblHomeHealth;
        private System.Windows.Forms.Label lblResourcesOnThisTile;
        private System.Windows.Forms.Label lblItemOnThisLand;
        private System.Windows.Forms.Label lblResourcesHome;
        private System.Windows.Forms.Label lblResourcesOnThisLand;
        private System.Windows.Forms.Button butEquipClothes;
        private System.Windows.Forms.Button butEquipWeapons;
        private System.Windows.Forms.Label lblPosy;
        private System.Windows.Forms.Label lblPosx;
    }
}

