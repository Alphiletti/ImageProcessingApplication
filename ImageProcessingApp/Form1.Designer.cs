
namespace ImageProcessingApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Mean = new System.Windows.Forms.Button();
            this.btn_Gaussian = new System.Windows.Forms.Button();
            this.btn_Edge4 = new System.Windows.Forms.Button();
            this.btn_Edge8 = new System.Windows.Forms.Button();
            this.btn_Sharpen = new System.Windows.Forms.Button();
            this.btn_SharpenMore = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btn_Brightness = new System.Windows.Forms.Button();
            this.btn_Contrast = new System.Windows.Forms.Button();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_DownScale = new System.Windows.Forms.Button();
            this.btn_UpScaleNN = new System.Windows.Forms.Button();
            this.btn_UpScaleLinear = new System.Windows.Forms.Button();
            this.btn_Rot90 = new System.Windows.Forms.Button();
            this.btn_RotInv90 = new System.Windows.Forms.Button();
            this.btn_Rot180 = new System.Windows.Forms.Button();
            this.btn_FlipV = new System.Windows.Forms.Button();
            this.btn_FlipH = new System.Windows.Forms.Button();
            this.btn_RotArr = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Gama = new System.Windows.Forms.Button();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(717, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(475, 366);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(192, 487);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(91, 34);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Mean
            // 
            this.btn_Mean.Location = new System.Drawing.Point(518, 98);
            this.btn_Mean.Name = "btn_Mean";
            this.btn_Mean.Size = new System.Drawing.Size(168, 25);
            this.btn_Mean.TabIndex = 3;
            this.btn_Mean.Text = "Mean Filter 3x3";
            this.btn_Mean.UseVisualStyleBackColor = true;
            this.btn_Mean.Click += new System.EventHandler(this.btn_Mean_Click);
            // 
            // btn_Gaussian
            // 
            this.btn_Gaussian.Location = new System.Drawing.Point(518, 129);
            this.btn_Gaussian.Name = "btn_Gaussian";
            this.btn_Gaussian.Size = new System.Drawing.Size(168, 25);
            this.btn_Gaussian.TabIndex = 4;
            this.btn_Gaussian.Text = "Gaussian Filter";
            this.btn_Gaussian.UseVisualStyleBackColor = true;
            this.btn_Gaussian.Click += new System.EventHandler(this.btn_Gaussian_Click);
            // 
            // btn_Edge4
            // 
            this.btn_Edge4.Location = new System.Drawing.Point(518, 160);
            this.btn_Edge4.Name = "btn_Edge4";
            this.btn_Edge4.Size = new System.Drawing.Size(168, 25);
            this.btn_Edge4.TabIndex = 5;
            this.btn_Edge4.Text = "Edge 4-Connected";
            this.btn_Edge4.UseVisualStyleBackColor = true;
            this.btn_Edge4.Click += new System.EventHandler(this.btn_Edge4_Click);
            // 
            // btn_Edge8
            // 
            this.btn_Edge8.Location = new System.Drawing.Point(518, 191);
            this.btn_Edge8.Name = "btn_Edge8";
            this.btn_Edge8.Size = new System.Drawing.Size(168, 25);
            this.btn_Edge8.TabIndex = 6;
            this.btn_Edge8.Text = "Edge 8-Connected";
            this.btn_Edge8.UseVisualStyleBackColor = true;
            this.btn_Edge8.Click += new System.EventHandler(this.btn_Edge8_Click);
            // 
            // btn_Sharpen
            // 
            this.btn_Sharpen.Location = new System.Drawing.Point(518, 222);
            this.btn_Sharpen.Name = "btn_Sharpen";
            this.btn_Sharpen.Size = new System.Drawing.Size(168, 25);
            this.btn_Sharpen.TabIndex = 7;
            this.btn_Sharpen.Text = "Sharpen";
            this.btn_Sharpen.UseVisualStyleBackColor = true;
            this.btn_Sharpen.Click += new System.EventHandler(this.btn_Sharpen_Click);
            // 
            // btn_SharpenMore
            // 
            this.btn_SharpenMore.Location = new System.Drawing.Point(518, 253);
            this.btn_SharpenMore.Name = "btn_SharpenMore";
            this.btn_SharpenMore.Size = new System.Drawing.Size(168, 25);
            this.btn_SharpenMore.TabIndex = 8;
            this.btn_SharpenMore.Text = "Sharpen More";
            this.btn_SharpenMore.UseVisualStyleBackColor = true;
            this.btn_SharpenMore.Click += new System.EventHandler(this.btn_SharpenMore_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(518, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 9;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(590, 288);
            this.hScrollBar1.Minimum = -100;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(96, 20);
            this.hScrollBar1.TabIndex = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // btn_Brightness
            // 
            this.btn_Brightness.Location = new System.Drawing.Point(518, 314);
            this.btn_Brightness.Name = "btn_Brightness";
            this.btn_Brightness.Size = new System.Drawing.Size(168, 25);
            this.btn_Brightness.TabIndex = 11;
            this.btn_Brightness.Text = "Brightness";
            this.btn_Brightness.UseVisualStyleBackColor = true;
            this.btn_Brightness.Click += new System.EventHandler(this.btn_Brightness_Click);
            // 
            // btn_Contrast
            // 
            this.btn_Contrast.Location = new System.Drawing.Point(518, 380);
            this.btn_Contrast.Name = "btn_Contrast";
            this.btn_Contrast.Size = new System.Drawing.Size(168, 23);
            this.btn_Contrast.TabIndex = 14;
            this.btn_Contrast.Text = "Contrast";
            this.btn_Contrast.UseVisualStyleBackColor = true;
            this.btn_Contrast.Click += new System.EventHandler(this.btn_Contrast_Click);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 1;
            this.hScrollBar2.Location = new System.Drawing.Point(590, 354);
            this.hScrollBar2.Minimum = -100;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(96, 18);
            this.hScrollBar2.TabIndex = 13;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(518, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 12;
            // 
            // btn_DownScale
            // 
            this.btn_DownScale.Location = new System.Drawing.Point(518, 492);
            this.btn_DownScale.Name = "btn_DownScale";
            this.btn_DownScale.Size = new System.Drawing.Size(168, 25);
            this.btn_DownScale.TabIndex = 15;
            this.btn_DownScale.Text = "Down Scale";
            this.btn_DownScale.UseVisualStyleBackColor = true;
            this.btn_DownScale.Click += new System.EventHandler(this.btn_DownScale_Click);
            // 
            // btn_UpScaleNN
            // 
            this.btn_UpScaleNN.Location = new System.Drawing.Point(518, 523);
            this.btn_UpScaleNN.Name = "btn_UpScaleNN";
            this.btn_UpScaleNN.Size = new System.Drawing.Size(168, 25);
            this.btn_UpScaleNN.TabIndex = 16;
            this.btn_UpScaleNN.Text = "Up Scale - NN";
            this.btn_UpScaleNN.UseVisualStyleBackColor = true;
            this.btn_UpScaleNN.Click += new System.EventHandler(this.btn_UpScaleNN_Click);
            // 
            // btn_UpScaleLinear
            // 
            this.btn_UpScaleLinear.Location = new System.Drawing.Point(518, 554);
            this.btn_UpScaleLinear.Name = "btn_UpScaleLinear";
            this.btn_UpScaleLinear.Size = new System.Drawing.Size(168, 25);
            this.btn_UpScaleLinear.TabIndex = 17;
            this.btn_UpScaleLinear.Text = "Up Scale Linear";
            this.btn_UpScaleLinear.UseVisualStyleBackColor = true;
            this.btn_UpScaleLinear.Click += new System.EventHandler(this.btn_UpScaleLinear_Click);
            // 
            // btn_Rot90
            // 
            this.btn_Rot90.Location = new System.Drawing.Point(784, 492);
            this.btn_Rot90.Name = "btn_Rot90";
            this.btn_Rot90.Size = new System.Drawing.Size(70, 25);
            this.btn_Rot90.TabIndex = 18;
            this.btn_Rot90.Text = "Rot 90";
            this.btn_Rot90.UseVisualStyleBackColor = true;
            this.btn_Rot90.Click += new System.EventHandler(this.btn_Rot90_Click);
            // 
            // btn_RotInv90
            // 
            this.btn_RotInv90.Location = new System.Drawing.Point(860, 492);
            this.btn_RotInv90.Name = "btn_RotInv90";
            this.btn_RotInv90.Size = new System.Drawing.Size(70, 25);
            this.btn_RotInv90.TabIndex = 19;
            this.btn_RotInv90.Text = "Rot -90";
            this.btn_RotInv90.UseVisualStyleBackColor = true;
            this.btn_RotInv90.Click += new System.EventHandler(this.btn_RotInv90_Click);
            // 
            // btn_Rot180
            // 
            this.btn_Rot180.Location = new System.Drawing.Point(936, 492);
            this.btn_Rot180.Name = "btn_Rot180";
            this.btn_Rot180.Size = new System.Drawing.Size(70, 25);
            this.btn_Rot180.TabIndex = 20;
            this.btn_Rot180.Text = "Rot 180";
            this.btn_Rot180.UseVisualStyleBackColor = true;
            this.btn_Rot180.Click += new System.EventHandler(this.btn_Rot180_Click);
            // 
            // btn_FlipV
            // 
            this.btn_FlipV.Location = new System.Drawing.Point(815, 523);
            this.btn_FlipV.Name = "btn_FlipV";
            this.btn_FlipV.Size = new System.Drawing.Size(70, 25);
            this.btn_FlipV.TabIndex = 21;
            this.btn_FlipV.Text = "Flip V";
            this.btn_FlipV.UseVisualStyleBackColor = true;
            this.btn_FlipV.Click += new System.EventHandler(this.btn_FlipV_Click);
            // 
            // btn_FlipH
            // 
            this.btn_FlipH.Location = new System.Drawing.Point(891, 523);
            this.btn_FlipH.Name = "btn_FlipH";
            this.btn_FlipH.Size = new System.Drawing.Size(70, 25);
            this.btn_FlipH.TabIndex = 22;
            this.btn_FlipH.Text = "Flip H";
            this.btn_FlipH.UseVisualStyleBackColor = true;
            this.btn_FlipH.Click += new System.EventHandler(this.btn_FlipH_Click);
            // 
            // btn_RotArr
            // 
            this.btn_RotArr.Location = new System.Drawing.Point(825, 554);
            this.btn_RotArr.Name = "btn_RotArr";
            this.btn_RotArr.Size = new System.Drawing.Size(70, 25);
            this.btn_RotArr.TabIndex = 23;
            this.btn_RotArr.Text = "Rot. Ar.";
            this.btn_RotArr.UseVisualStyleBackColor = true;
            this.btn_RotArr.Click += new System.EventHandler(this.btn_RotArr_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(901, 557);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(123, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(756, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 39);
            this.label2.TabIndex = 26;
            this.label2.Text = "After Image Processing";
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(562, 56);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 23);
            this.btn_Copy.TabIndex = 27;
            this.btn_Copy.Text = "<<";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Gama
            // 
            this.btn_Gama.Location = new System.Drawing.Point(518, 444);
            this.btn_Gama.Name = "btn_Gama";
            this.btn_Gama.Size = new System.Drawing.Size(168, 25);
            this.btn_Gama.TabIndex = 30;
            this.btn_Gama.Text = "Gama";
            this.btn_Gama.UseVisualStyleBackColor = true;
            this.btn_Gama.Click += new System.EventHandler(this.btn_Gama_Click);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.LargeChange = 1;
            this.hScrollBar3.Location = new System.Drawing.Point(590, 418);
            this.hScrollBar3.Maximum = 20;
            this.hScrollBar3.Minimum = 1;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(96, 20);
            this.hScrollBar3.TabIndex = 29;
            this.hScrollBar3.Value = 10;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(518, 418);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 20);
            this.textBox4.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 601);
            this.Controls.Add(this.btn_Gama);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_RotArr);
            this.Controls.Add(this.btn_FlipH);
            this.Controls.Add(this.btn_FlipV);
            this.Controls.Add(this.btn_Rot180);
            this.Controls.Add(this.btn_RotInv90);
            this.Controls.Add(this.btn_Rot90);
            this.Controls.Add(this.btn_UpScaleLinear);
            this.Controls.Add(this.btn_UpScaleNN);
            this.Controls.Add(this.btn_DownScale);
            this.Controls.Add(this.btn_Contrast);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_Brightness);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_SharpenMore);
            this.Controls.Add(this.btn_Sharpen);
            this.Controls.Add(this.btn_Edge8);
            this.Controls.Add(this.btn_Edge4);
            this.Controls.Add(this.btn_Gaussian);
            this.Controls.Add(this.btn_Mean);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Mean;
        private System.Windows.Forms.Button btn_Gaussian;
        private System.Windows.Forms.Button btn_Edge4;
        private System.Windows.Forms.Button btn_Edge8;
        private System.Windows.Forms.Button btn_Sharpen;
        private System.Windows.Forms.Button btn_SharpenMore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button btn_Brightness;
        private System.Windows.Forms.Button btn_Contrast;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_DownScale;
        private System.Windows.Forms.Button btn_UpScaleNN;
        private System.Windows.Forms.Button btn_UpScaleLinear;
        private System.Windows.Forms.Button btn_Rot90;
        private System.Windows.Forms.Button btn_RotInv90;
        private System.Windows.Forms.Button btn_Rot180;
        private System.Windows.Forms.Button btn_FlipV;
        private System.Windows.Forms.Button btn_FlipH;
        private System.Windows.Forms.Button btn_RotArr;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Gama;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

