namespace BlackJackV2._0
{
    partial class Blackjack
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
            this.StartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BHit = new System.Windows.Forms.Button();
            this.BStand = new System.Windows.Forms.Button();
            this.BReset = new System.Windows.Forms.Button();
            this.DPicBox1 = new System.Windows.Forms.PictureBox();
            this.PPicBox1 = new System.Windows.Forms.PictureBox();
            this.PPicBox2 = new System.Windows.Forms.PictureBox();
            this.PPicBox3 = new System.Windows.Forms.PictureBox();
            this.DPicBox2 = new System.Windows.Forms.PictureBox();
            this.DPicBox3 = new System.Windows.Forms.PictureBox();
            this.PPicBox4 = new System.Windows.Forms.PictureBox();
            this.DPicBox4 = new System.Windows.Forms.PictureBox();
            this.LResult = new System.Windows.Forms.Label();
            this.PPicBox5 = new System.Windows.Forms.PictureBox();
            this.PPicBox6 = new System.Windows.Forms.PictureBox();
            this.DPicBox5 = new System.Windows.Forms.PictureBox();
            this.DPicBox6 = new System.Windows.Forms.PictureBox();
            this.LDealerWin = new System.Windows.Forms.Label();
            this.LPlayerWin = new System.Windows.Forms.Label();
            this.LCardValueDealer = new System.Windows.Forms.Label();
            this.LCardValuePlayer = new System.Windows.Forms.Label();
            this.BetBar = new System.Windows.Forms.TrackBar();
            this.LBet = new System.Windows.Forms.Label();
            this.LChips = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Brown;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.White;
            this.StartGame.Location = new System.Drawing.Point(16, 227);
            this.StartGame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(82, 32);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(61, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dealer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(61, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player";
            // 
            // BHit
            // 
            this.BHit.BackColor = System.Drawing.Color.Brown;
            this.BHit.Enabled = false;
            this.BHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BHit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BHit.ForeColor = System.Drawing.Color.White;
            this.BHit.Location = new System.Drawing.Point(16, 277);
            this.BHit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BHit.Name = "BHit";
            this.BHit.Size = new System.Drawing.Size(82, 32);
            this.BHit.TabIndex = 7;
            this.BHit.Text = "Hit";
            this.BHit.UseVisualStyleBackColor = false;
            this.BHit.Click += new System.EventHandler(this.BHit_Click);
            // 
            // BStand
            // 
            this.BStand.BackColor = System.Drawing.Color.Brown;
            this.BStand.Enabled = false;
            this.BStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BStand.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BStand.ForeColor = System.Drawing.Color.White;
            this.BStand.Location = new System.Drawing.Point(16, 327);
            this.BStand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BStand.Name = "BStand";
            this.BStand.Size = new System.Drawing.Size(82, 32);
            this.BStand.TabIndex = 8;
            this.BStand.Text = "Stand";
            this.BStand.UseVisualStyleBackColor = false;
            this.BStand.Click += new System.EventHandler(this.BStand_Click);
            // 
            // BReset
            // 
            this.BReset.BackColor = System.Drawing.Color.Brown;
            this.BReset.Enabled = false;
            this.BReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReset.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BReset.ForeColor = System.Drawing.Color.White;
            this.BReset.Location = new System.Drawing.Point(16, 377);
            this.BReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BReset.Name = "BReset";
            this.BReset.Size = new System.Drawing.Size(82, 32);
            this.BReset.TabIndex = 9;
            this.BReset.Text = "Reset";
            this.BReset.UseVisualStyleBackColor = false;
            this.BReset.Click += new System.EventHandler(this.BReset_Click);
            // 
            // DPicBox1
            // 
            this.DPicBox1.BackColor = System.Drawing.Color.Transparent;
            this.DPicBox1.Location = new System.Drawing.Point(191, 73);
            this.DPicBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DPicBox1.Name = "DPicBox1";
            this.DPicBox1.Size = new System.Drawing.Size(102, 138);
            this.DPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DPicBox1.TabIndex = 11;
            this.DPicBox1.TabStop = false;
            // 
            // PPicBox1
            // 
            this.PPicBox1.BackColor = System.Drawing.Color.Transparent;
            this.PPicBox1.Location = new System.Drawing.Point(191, 416);
            this.PPicBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PPicBox1.Name = "PPicBox1";
            this.PPicBox1.Size = new System.Drawing.Size(102, 138);
            this.PPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PPicBox1.TabIndex = 12;
            this.PPicBox1.TabStop = false;
            // 
            // PPicBox2
            // 
            this.PPicBox2.BackColor = System.Drawing.Color.Transparent;
            this.PPicBox2.Location = new System.Drawing.Point(330, 416);
            this.PPicBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PPicBox2.Name = "PPicBox2";
            this.PPicBox2.Size = new System.Drawing.Size(102, 138);
            this.PPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PPicBox2.TabIndex = 13;
            this.PPicBox2.TabStop = false;
            // 
            // PPicBox3
            // 
            this.PPicBox3.BackColor = System.Drawing.Color.Transparent;
            this.PPicBox3.Location = new System.Drawing.Point(472, 416);
            this.PPicBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PPicBox3.Name = "PPicBox3";
            this.PPicBox3.Size = new System.Drawing.Size(102, 138);
            this.PPicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PPicBox3.TabIndex = 14;
            this.PPicBox3.TabStop = false;
            // 
            // DPicBox2
            // 
            this.DPicBox2.BackColor = System.Drawing.Color.Transparent;
            this.DPicBox2.Location = new System.Drawing.Point(330, 73);
            this.DPicBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DPicBox2.Name = "DPicBox2";
            this.DPicBox2.Size = new System.Drawing.Size(102, 138);
            this.DPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DPicBox2.TabIndex = 15;
            this.DPicBox2.TabStop = false;
            // 
            // DPicBox3
            // 
            this.DPicBox3.BackColor = System.Drawing.Color.Transparent;
            this.DPicBox3.Location = new System.Drawing.Point(472, 73);
            this.DPicBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DPicBox3.Name = "DPicBox3";
            this.DPicBox3.Size = new System.Drawing.Size(102, 138);
            this.DPicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DPicBox3.TabIndex = 16;
            this.DPicBox3.TabStop = false;
            // 
            // PPicBox4
            // 
            this.PPicBox4.BackColor = System.Drawing.Color.Transparent;
            this.PPicBox4.Location = new System.Drawing.Point(609, 416);
            this.PPicBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PPicBox4.Name = "PPicBox4";
            this.PPicBox4.Size = new System.Drawing.Size(102, 138);
            this.PPicBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PPicBox4.TabIndex = 17;
            this.PPicBox4.TabStop = false;
            // 
            // DPicBox4
            // 
            this.DPicBox4.BackColor = System.Drawing.Color.Transparent;
            this.DPicBox4.Location = new System.Drawing.Point(609, 73);
            this.DPicBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DPicBox4.Name = "DPicBox4";
            this.DPicBox4.Size = new System.Drawing.Size(102, 138);
            this.DPicBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DPicBox4.TabIndex = 18;
            this.DPicBox4.TabStop = false;
            // 
            // LResult
            // 
            this.LResult.AutoSize = true;
            this.LResult.BackColor = System.Drawing.Color.Transparent;
            this.LResult.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LResult.ForeColor = System.Drawing.Color.White;
            this.LResult.Location = new System.Drawing.Point(418, 277);
            this.LResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LResult.Name = "LResult";
            this.LResult.Size = new System.Drawing.Size(172, 54);
            this.LResult.TabIndex = 19;
            this.LResult.Text = "Result";
            // 
            // PPicBox5
            // 
            this.PPicBox5.BackColor = System.Drawing.Color.Transparent;
            this.PPicBox5.Location = new System.Drawing.Point(744, 416);
            this.PPicBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PPicBox5.Name = "PPicBox5";
            this.PPicBox5.Size = new System.Drawing.Size(102, 138);
            this.PPicBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PPicBox5.TabIndex = 20;
            this.PPicBox5.TabStop = false;
            // 
            // PPicBox6
            // 
            this.PPicBox6.BackColor = System.Drawing.Color.Transparent;
            this.PPicBox6.Location = new System.Drawing.Point(883, 416);
            this.PPicBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PPicBox6.Name = "PPicBox6";
            this.PPicBox6.Size = new System.Drawing.Size(102, 138);
            this.PPicBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PPicBox6.TabIndex = 21;
            this.PPicBox6.TabStop = false;
            // 
            // DPicBox5
            // 
            this.DPicBox5.BackColor = System.Drawing.Color.Transparent;
            this.DPicBox5.Location = new System.Drawing.Point(744, 73);
            this.DPicBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DPicBox5.Name = "DPicBox5";
            this.DPicBox5.Size = new System.Drawing.Size(102, 138);
            this.DPicBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DPicBox5.TabIndex = 22;
            this.DPicBox5.TabStop = false;
            // 
            // DPicBox6
            // 
            this.DPicBox6.BackColor = System.Drawing.Color.Transparent;
            this.DPicBox6.Location = new System.Drawing.Point(883, 73);
            this.DPicBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DPicBox6.Name = "DPicBox6";
            this.DPicBox6.Size = new System.Drawing.Size(102, 138);
            this.DPicBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DPicBox6.TabIndex = 23;
            this.DPicBox6.TabStop = false;
            // 
            // LDealerWin
            // 
            this.LDealerWin.AutoSize = true;
            this.LDealerWin.BackColor = System.Drawing.Color.Transparent;
            this.LDealerWin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDealerWin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LDealerWin.Location = new System.Drawing.Point(6, 8);
            this.LDealerWin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDealerWin.Name = "LDealerWin";
            this.LDealerWin.Size = new System.Drawing.Size(159, 25);
            this.LDealerWin.TabIndex = 24;
            this.LDealerWin.Text = "Dealer wins: 0";
            // 
            // LPlayerWin
            // 
            this.LPlayerWin.AutoSize = true;
            this.LPlayerWin.BackColor = System.Drawing.Color.Transparent;
            this.LPlayerWin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPlayerWin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LPlayerWin.Location = new System.Drawing.Point(6, 30);
            this.LPlayerWin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPlayerWin.Name = "LPlayerWin";
            this.LPlayerWin.Size = new System.Drawing.Size(156, 25);
            this.LPlayerWin.TabIndex = 25;
            this.LPlayerWin.Text = "Player wins: 0";
            this.LPlayerWin.Click += new System.EventHandler(this.LPlayerWin_Click);
            // 
            // LCardValueDealer
            // 
            this.LCardValueDealer.AutoSize = true;
            this.LCardValueDealer.BackColor = System.Drawing.Color.Transparent;
            this.LCardValueDealer.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCardValueDealer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LCardValueDealer.Location = new System.Drawing.Point(63, 138);
            this.LCardValueDealer.Name = "LCardValueDealer";
            this.LCardValueDealer.Size = new System.Drawing.Size(140, 23);
            this.LCardValueDealer.TabIndex = 26;
            this.LCardValueDealer.Text = "Card value: 0";
            // 
            // LCardValuePlayer
            // 
            this.LCardValuePlayer.AutoSize = true;
            this.LCardValuePlayer.BackColor = System.Drawing.Color.Transparent;
            this.LCardValuePlayer.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCardValuePlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LCardValuePlayer.Location = new System.Drawing.Point(63, 487);
            this.LCardValuePlayer.Name = "LCardValuePlayer";
            this.LCardValuePlayer.Size = new System.Drawing.Size(140, 23);
            this.LCardValuePlayer.TabIndex = 27;
            this.LCardValuePlayer.Text = "Card value: 0";
            // 
            // BetBar
            // 
            this.BetBar.BackColor = System.Drawing.Color.Maroon;
            this.BetBar.Location = new System.Drawing.Point(660, 568);
            this.BetBar.Name = "BetBar";
            this.BetBar.Size = new System.Drawing.Size(233, 56);
            this.BetBar.TabIndex = 28;
            this.BetBar.Value = 1;
            this.BetBar.Scroll += new System.EventHandler(this.BetBar_Scroll);
            // 
            // LBet
            // 
            this.LBet.AutoSize = true;
            this.LBet.BackColor = System.Drawing.Color.Transparent;
            this.LBet.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBet.Location = new System.Drawing.Point(899, 568);
            this.LBet.Name = "LBet";
            this.LBet.Size = new System.Drawing.Size(69, 23);
            this.LBet.TabIndex = 29;
            this.LBet.Text = "Bet: 1";
            // 
            // LChips
            // 
            this.LChips.AutoSize = true;
            this.LChips.BackColor = System.Drawing.Color.Transparent;
            this.LChips.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LChips.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LChips.Location = new System.Drawing.Point(899, 591);
            this.LChips.Name = "LChips";
            this.LChips.Size = new System.Drawing.Size(91, 23);
            this.LChips.TabIndex = 30;
            this.LChips.Text = "Chips: 0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::BlackJackV2._0.Properties.Resources.zuyd_rgb_3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::BlackJackV2._0.Properties.Resources.zuyd_rgb_3;
            this.pictureBox3.Location = new System.Drawing.Point(885, 262);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackV2._0.Properties.Resources.zuyd_achtergrond1;
            this.ClientSize = new System.Drawing.Size(1043, 625);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LChips);
            this.Controls.Add(this.LBet);
            this.Controls.Add(this.BetBar);
            this.Controls.Add(this.LCardValuePlayer);
            this.Controls.Add(this.LCardValueDealer);
            this.Controls.Add(this.LPlayerWin);
            this.Controls.Add(this.LDealerWin);
            this.Controls.Add(this.DPicBox6);
            this.Controls.Add(this.DPicBox5);
            this.Controls.Add(this.PPicBox6);
            this.Controls.Add(this.PPicBox5);
            this.Controls.Add(this.LResult);
            this.Controls.Add(this.DPicBox4);
            this.Controls.Add(this.PPicBox4);
            this.Controls.Add(this.DPicBox3);
            this.Controls.Add(this.DPicBox2);
            this.Controls.Add(this.PPicBox3);
            this.Controls.Add(this.PPicBox2);
            this.Controls.Add(this.PPicBox1);
            this.Controls.Add(this.DPicBox1);
            this.Controls.Add(this.BReset);
            this.Controls.Add(this.BStand);
            this.Controls.Add(this.BHit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartGame);
            this.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPicBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPicBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BHit;
        private System.Windows.Forms.Button BStand;
        private System.Windows.Forms.Button BReset;
        private System.Windows.Forms.PictureBox DPicBox1;
        private System.Windows.Forms.PictureBox PPicBox1;
        private System.Windows.Forms.PictureBox PPicBox2;
        private System.Windows.Forms.PictureBox PPicBox3;
        private System.Windows.Forms.PictureBox DPicBox2;
        private System.Windows.Forms.PictureBox DPicBox3;
        private System.Windows.Forms.PictureBox PPicBox4;
        private System.Windows.Forms.PictureBox DPicBox4;
        private System.Windows.Forms.Label LResult;
        private System.Windows.Forms.PictureBox PPicBox5;
        private System.Windows.Forms.PictureBox PPicBox6;
        private System.Windows.Forms.PictureBox DPicBox5;
        private System.Windows.Forms.PictureBox DPicBox6;
        private System.Windows.Forms.Label LDealerWin;
        private System.Windows.Forms.Label LPlayerWin;
        private System.Windows.Forms.Label LCardValueDealer;
        private System.Windows.Forms.Label LCardValuePlayer;
        private System.Windows.Forms.TrackBar BetBar;
        private System.Windows.Forms.Label LBet;
        private System.Windows.Forms.Label LChips;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

