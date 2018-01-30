namespace M1HW2_Lee
{
    partial class Form1
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
            this.cardFivePictureBox = new System.Windows.Forms.PictureBox();
            this.cardThreePictureBox = new System.Windows.Forms.PictureBox();
            this.cardFourPictureBox = new System.Windows.Forms.PictureBox();
            this.cardTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.cardOnePictureBox = new System.Windows.Forms.PictureBox();
            this.numberTextLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardFivePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFourPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardOnePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFivePictureBox
            // 
            this.cardFivePictureBox.BackgroundImage = global::M1HW2_Lee.Properties.Resources.Five;
            this.cardFivePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardFivePictureBox.Location = new System.Drawing.Point(370, 54);
            this.cardFivePictureBox.Name = "cardFivePictureBox";
            this.cardFivePictureBox.Size = new System.Drawing.Size(82, 144);
            this.cardFivePictureBox.TabIndex = 4;
            this.cardFivePictureBox.TabStop = false;
            this.cardFivePictureBox.Click += new System.EventHandler(this.cardFivePictureBox_Click);
            // 
            // cardThreePictureBox
            // 
            this.cardThreePictureBox.BackgroundImage = global::M1HW2_Lee.Properties.Resources.Three;
            this.cardThreePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardThreePictureBox.Location = new System.Drawing.Point(194, 54);
            this.cardThreePictureBox.Name = "cardThreePictureBox";
            this.cardThreePictureBox.Size = new System.Drawing.Size(82, 144);
            this.cardThreePictureBox.TabIndex = 3;
            this.cardThreePictureBox.TabStop = false;
            this.cardThreePictureBox.Click += new System.EventHandler(this.cardThreePictureBox_Click);
            // 
            // cardFourPictureBox
            // 
            this.cardFourPictureBox.BackgroundImage = global::M1HW2_Lee.Properties.Resources.Four;
            this.cardFourPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardFourPictureBox.Location = new System.Drawing.Point(282, 54);
            this.cardFourPictureBox.Name = "cardFourPictureBox";
            this.cardFourPictureBox.Size = new System.Drawing.Size(82, 144);
            this.cardFourPictureBox.TabIndex = 2;
            this.cardFourPictureBox.TabStop = false;
            this.cardFourPictureBox.Click += new System.EventHandler(this.cardFourPictureBox_Click);
            // 
            // cardTwoPictureBox
            // 
            this.cardTwoPictureBox.BackgroundImage = global::M1HW2_Lee.Properties.Resources.Two;
            this.cardTwoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardTwoPictureBox.Location = new System.Drawing.Point(106, 54);
            this.cardTwoPictureBox.Name = "cardTwoPictureBox";
            this.cardTwoPictureBox.Size = new System.Drawing.Size(82, 144);
            this.cardTwoPictureBox.TabIndex = 1;
            this.cardTwoPictureBox.TabStop = false;
            this.cardTwoPictureBox.Click += new System.EventHandler(this.cardTwoPictureBox_Click);
            // 
            // cardOnePictureBox
            // 
            this.cardOnePictureBox.BackgroundImage = global::M1HW2_Lee.Properties.Resources.One;
            this.cardOnePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardOnePictureBox.Location = new System.Drawing.Point(18, 54);
            this.cardOnePictureBox.Name = "cardOnePictureBox";
            this.cardOnePictureBox.Size = new System.Drawing.Size(82, 144);
            this.cardOnePictureBox.TabIndex = 0;
            this.cardOnePictureBox.TabStop = false;
            this.cardOnePictureBox.Click += new System.EventHandler(this.cardOnePictureBox_Click);
            // 
            // numberTextLabel
            // 
            this.numberTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextLabel.Location = new System.Drawing.Point(20, 209);
            this.numberTextLabel.Name = "numberTextLabel";
            this.numberTextLabel.Size = new System.Drawing.Size(431, 40);
            this.numberTextLabel.TabIndex = 5;
            this.numberTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(59, 16);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(331, 25);
            this.instructionLabel.TabIndex = 6;
            this.instructionLabel.Text = "Click a number to display text.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 262);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.numberTextLabel);
            this.Controls.Add(this.cardFivePictureBox);
            this.Controls.Add(this.cardThreePictureBox);
            this.Controls.Add(this.cardFourPictureBox);
            this.Controls.Add(this.cardTwoPictureBox);
            this.Controls.Add(this.cardOnePictureBox);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.cardFivePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThreePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFourPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardOnePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardOnePictureBox;
        private System.Windows.Forms.PictureBox cardTwoPictureBox;
        private System.Windows.Forms.PictureBox cardFourPictureBox;
        private System.Windows.Forms.PictureBox cardThreePictureBox;
        private System.Windows.Forms.PictureBox cardFivePictureBox;
        private System.Windows.Forms.Label numberTextLabel;
        private System.Windows.Forms.Label instructionLabel;
    }
}

