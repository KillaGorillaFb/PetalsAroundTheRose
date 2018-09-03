namespace PetalsAroundTheRoseGame
{
    partial class PetalsApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetalsApp));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGo = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtBxGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBxDie0 = new System.Windows.Forms.PictureBox();
            this.picBxDie1 = new System.Windows.Forms.PictureBox();
            this.picBxDie2 = new System.Windows.Forms.PictureBox();
            this.picBxDie3 = new System.Windows.Forms.PictureBox();
            this.picBxDie4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCorrecct = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblBestRun = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentRun = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalRolls = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie4)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "OneDice.png");
            this.imageList1.Images.SetKeyName(1, "TwoDice.png");
            this.imageList1.Images.SetKeyName(2, "ThreeDice.png");
            this.imageList1.Images.SetKeyName(3, "FourDice.png");
            this.imageList1.Images.SetKeyName(4, "FiveDice.png");
            this.imageList1.Images.SetKeyName(5, "SixDice.png");
            this.imageList1.Images.SetKeyName(6, "Beautiful_Red_Rose_Gif_Animation.gif");
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Red;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(335, 363);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(140, 69);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Play";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Red;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(335, 465);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(140, 69);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Enter";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtBxGuess
            // 
            this.txtBxGuess.BackColor = System.Drawing.Color.Red;
            this.txtBxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxGuess.Location = new System.Drawing.Point(339, 286);
            this.txtBxGuess.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxGuess.Name = "txtBxGuess";
            this.txtBxGuess.Size = new System.Drawing.Size(136, 34);
            this.txtBxGuess.TabIndex = 7;
            this.txtBxGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxGuess.TextChanged += new System.EventHandler(this.txtBxGuess_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(190, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Your Guess, Then Click Enter";
            // 
            // picBxDie0
            // 
            this.picBxDie0.BackColor = System.Drawing.Color.White;
            this.picBxDie0.Image = global::PetalsAroundTheRoseGame.Properties.Resources.OneDice;
            this.picBxDie0.Location = new System.Drawing.Point(74, 130);
            this.picBxDie0.Margin = new System.Windows.Forms.Padding(4);
            this.picBxDie0.Name = "picBxDie0";
            this.picBxDie0.Size = new System.Drawing.Size(80, 62);
            this.picBxDie0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxDie0.TabIndex = 0;
            this.picBxDie0.TabStop = false;
            // 
            // picBxDie1
            // 
            this.picBxDie1.BackColor = System.Drawing.Color.White;
            this.picBxDie1.Image = global::PetalsAroundTheRoseGame.Properties.Resources.TwoDice;
            this.picBxDie1.Location = new System.Drawing.Point(206, 130);
            this.picBxDie1.Margin = new System.Windows.Forms.Padding(4);
            this.picBxDie1.Name = "picBxDie1";
            this.picBxDie1.Size = new System.Drawing.Size(80, 62);
            this.picBxDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxDie1.TabIndex = 1;
            this.picBxDie1.TabStop = false;
            // 
            // picBxDie2
            // 
            this.picBxDie2.BackColor = System.Drawing.Color.White;
            this.picBxDie2.Image = global::PetalsAroundTheRoseGame.Properties.Resources.ThreeDice;
            this.picBxDie2.Location = new System.Drawing.Point(349, 130);
            this.picBxDie2.Margin = new System.Windows.Forms.Padding(4);
            this.picBxDie2.Name = "picBxDie2";
            this.picBxDie2.Size = new System.Drawing.Size(80, 62);
            this.picBxDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxDie2.TabIndex = 2;
            this.picBxDie2.TabStop = false;
            // 
            // picBxDie3
            // 
            this.picBxDie3.BackColor = System.Drawing.Color.White;
            this.picBxDie3.Image = global::PetalsAroundTheRoseGame.Properties.Resources.FourDice;
            this.picBxDie3.Location = new System.Drawing.Point(488, 130);
            this.picBxDie3.Margin = new System.Windows.Forms.Padding(4);
            this.picBxDie3.Name = "picBxDie3";
            this.picBxDie3.Size = new System.Drawing.Size(80, 62);
            this.picBxDie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxDie3.TabIndex = 3;
            this.picBxDie3.TabStop = false;
            // 
            // picBxDie4
            // 
            this.picBxDie4.BackColor = System.Drawing.Color.White;
            this.picBxDie4.Image = global::PetalsAroundTheRoseGame.Properties.Resources.FiveDice;
            this.picBxDie4.Location = new System.Drawing.Point(621, 130);
            this.picBxDie4.Margin = new System.Windows.Forms.Padding(4);
            this.picBxDie4.Name = "picBxDie4";
            this.picBxDie4.Size = new System.Drawing.Size(80, 62);
            this.picBxDie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxDie4.TabIndex = 4;
            this.picBxDie4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(549, 408);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Correct Guesses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(536, 449);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Incorrect Guesses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(629, 489);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Best Run:";
            // 
            // lblCorrecct
            // 
            this.lblCorrecct.AutoSize = true;
            this.lblCorrecct.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrecct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrecct.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCorrecct.Location = new System.Drawing.Point(741, 408);
            this.lblCorrecct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorrecct.Name = "lblCorrecct";
            this.lblCorrecct.Size = new System.Drawing.Size(21, 24);
            this.lblCorrecct.TabIndex = 12;
            this.lblCorrecct.Text = "0";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIncorrect.Location = new System.Drawing.Point(741, 446);
            this.lblIncorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(21, 24);
            this.lblIncorrect.TabIndex = 13;
            this.lblIncorrect.Text = "0";
            // 
            // lblBestRun
            // 
            this.lblBestRun.AutoSize = true;
            this.lblBestRun.BackColor = System.Drawing.Color.Transparent;
            this.lblBestRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestRun.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBestRun.Location = new System.Drawing.Point(741, 489);
            this.lblBestRun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBestRun.Name = "lblBestRun";
            this.lblBestRun.Size = new System.Drawing.Size(21, 24);
            this.lblBestRun.TabIndex = 14;
            this.lblBestRun.Text = "0";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMessage.Location = new System.Drawing.Point(234, 45);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(352, 31);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "Press play to roll the dice!";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(600, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current Run:";
            // 
            // lblCurrentRun
            // 
            this.lblCurrentRun.AutoSize = true;
            this.lblCurrentRun.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRun.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCurrentRun.Location = new System.Drawing.Point(741, 372);
            this.lblCurrentRun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentRun.Name = "lblCurrentRun";
            this.lblCurrentRun.Size = new System.Drawing.Size(21, 24);
            this.lblCurrentRun.TabIndex = 17;
            this.lblCurrentRun.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(612, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total Rolls:";
            // 
            // lblTotalRolls
            // 
            this.lblTotalRolls.AutoSize = true;
            this.lblTotalRolls.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRolls.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalRolls.Location = new System.Drawing.Point(741, 338);
            this.lblTotalRolls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRolls.Name = "lblTotalRolls";
            this.lblTotalRolls.Size = new System.Drawing.Size(19, 20);
            this.lblTotalRolls.TabIndex = 19;
            this.lblTotalRolls.Text = "0";
            // 
            // PetalsApp
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::PetalsAroundTheRoseGame.Properties.Resources.min1;
            this.ClientSize = new System.Drawing.Size(793, 581);
            this.Controls.Add(this.lblTotalRolls);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCurrentRun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblBestRun);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrecct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxGuess);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.picBxDie4);
            this.Controls.Add(this.picBxDie3);
            this.Controls.Add(this.picBxDie2);
            this.Controls.Add(this.picBxDie1);
            this.Controls.Add(this.picBxDie0);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PetalsApp";
            this.Text = "Petals around the Rose";
            this.Load += new System.EventHandler(this.PetalsApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtBxGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBxDie0;
        private System.Windows.Forms.PictureBox picBxDie1;
        private System.Windows.Forms.PictureBox picBxDie2;
        private System.Windows.Forms.PictureBox picBxDie3;
        private System.Windows.Forms.PictureBox picBxDie4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCorrecct;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblBestRun;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentRun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalRolls;
    }
}

