namespace appRollDieImageList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PicDie1 = new System.Windows.Forms.PictureBox();
            this.BtnRollDie = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnExit = new System.Windows.Forms.Button();
            this.PicDie2 = new System.Windows.Forms.PictureBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // PicDie1
            // 
            this.PicDie1.Location = new System.Drawing.Point(46, 35);
            this.PicDie1.Name = "PicDie1";
            this.PicDie1.Size = new System.Drawing.Size(131, 120);
            this.PicDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDie1.TabIndex = 0;
            this.PicDie1.TabStop = false;
            // 
            // BtnRollDie
            // 
            this.BtnRollDie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRollDie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRollDie.Location = new System.Drawing.Point(323, 242);
            this.BtnRollDie.Name = "BtnRollDie";
            this.BtnRollDie.Size = new System.Drawing.Size(131, 44);
            this.BtnRollDie.TabIndex = 1;
            this.BtnRollDie.Text = "Roll";
            this.BtnRollDie.UseVisualStyleBackColor = false;
            this.BtnRollDie.Click += new System.EventHandler(this.BtnRollDie_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dice1.JPG");
            this.imageList1.Images.SetKeyName(1, "dice2.JPG");
            this.imageList1.Images.SetKeyName(2, "dice3.JPG");
            this.imageList1.Images.SetKeyName(3, "dice4.JPG");
            this.imageList1.Images.SetKeyName(4, "dice5.JPG");
            this.imageList1.Images.SetKeyName(5, "dice6.JPG");
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(323, 323);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(131, 44);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PicDie2
            // 
            this.PicDie2.Location = new System.Drawing.Point(243, 35);
            this.PicDie2.Name = "PicDie2";
            this.PicDie2.Size = new System.Drawing.Size(131, 120);
            this.PicDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDie2.TabIndex = 3;
            this.PicDie2.TabStop = false;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(330, 189);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(0, 29);
            this.LblTotal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(488, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.PicDie2);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRollDie);
            this.Controls.Add(this.PicDie1);
            this.Name = "Form1";
            this.Text = "A roll of the Dice";
            ((System.ComponentModel.ISupportInitialize)(this.PicDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicDie1;
        private System.Windows.Forms.Button BtnRollDie;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox PicDie2;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label1;
    }
}

