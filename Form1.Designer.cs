namespace OCR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generate_knowledge_base_btn = new System.Windows.Forms.Button();
            this.recognition_btn = new System.Windows.Forms.Button();
            this.path_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fh_tvb = new System.Windows.Forms.TextBox();
            this.fv_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.charv_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.charh_tbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vdiff_tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hdiff_tbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // generate_knowledge_base_btn
            // 
            this.generate_knowledge_base_btn.Location = new System.Drawing.Point(114, 65);
            this.generate_knowledge_base_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generate_knowledge_base_btn.Name = "generate_knowledge_base_btn";
            this.generate_knowledge_base_btn.Size = new System.Drawing.Size(439, 43);
            this.generate_knowledge_base_btn.TabIndex = 0;
            this.generate_knowledge_base_btn.Text = "Generate Knowledge Base";
            this.generate_knowledge_base_btn.UseVisualStyleBackColor = true;
            this.generate_knowledge_base_btn.Click += new System.EventHandler(this.generate_knowledge_base_btn_Click);
            // 
            // recognition_btn
            // 
            this.recognition_btn.Location = new System.Drawing.Point(114, 139);
            this.recognition_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recognition_btn.Name = "recognition_btn";
            this.recognition_btn.Size = new System.Drawing.Size(141, 43);
            this.recognition_btn.TabIndex = 1;
            this.recognition_btn.Text = "Recognition";
            this.recognition_btn.UseVisualStyleBackColor = true;
            this.recognition_btn.Click += new System.EventHandler(this.recognition_btn_Click);
            // 
            // path_txb
            // 
            this.path_txb.Location = new System.Drawing.Point(280, 162);
            this.path_txb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.path_txb.Name = "path_txb";
            this.path_txb.Size = new System.Drawing.Size(273, 20);
            this.path_txb.TabIndex = 2;
            this.path_txb.Text = "C:\\NGSoftware\\Image Processing\\App-2\\Image\\char1.bmp";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path";
       
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "F H_Proj";
           
            // 
            // fh_tvb
            // 
            this.fh_tvb.Location = new System.Drawing.Point(196, 200);
            this.fh_tvb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fh_tvb.Name = "fh_tvb";
            this.fh_tvb.Size = new System.Drawing.Size(357, 20);
            this.fh_tvb.TabIndex = 5;
           
            // 
            // fv_tbx
            // 
            this.fv_tbx.Location = new System.Drawing.Point(196, 225);
            this.fv_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fv_tbx.Name = "fv_tbx";
            this.fv_tbx.Size = new System.Drawing.Size(357, 20);
            this.fv_tbx.TabIndex = 7;
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "F V_Proj";
            
            // 
            // charv_tbx
            // 
            this.charv_tbx.Location = new System.Drawing.Point(196, 308);
            this.charv_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.charv_tbx.Name = "charv_tbx";
            this.charv_tbx.Size = new System.Drawing.Size(357, 20);
            this.charv_tbx.TabIndex = 11;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Char V_Proj";
            
            // 
            // charh_tbx
            // 
            this.charh_tbx.Location = new System.Drawing.Point(196, 281);
            this.charh_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.charh_tbx.Name = "charh_tbx";
            this.charh_tbx.Size = new System.Drawing.Size(357, 20);
            this.charh_tbx.TabIndex = 9;
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Char H_Proj";
            
            // 
            // vdiff_tbx
            // 
            this.vdiff_tbx.Location = new System.Drawing.Point(196, 403);
            this.vdiff_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vdiff_tbx.Name = "vdiff_tbx";
            this.vdiff_tbx.Size = new System.Drawing.Size(357, 20);
            this.vdiff_tbx.TabIndex = 15;
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 410);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "V Diff";
            
            // 
            // hdiff_tbx
            // 
            this.hdiff_tbx.Location = new System.Drawing.Point(196, 381);
            this.hdiff_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hdiff_tbx.Name = "hdiff_tbx";
            this.hdiff_tbx.Size = new System.Drawing.Size(357, 20);
            this.hdiff_tbx.TabIndex = 13;
            
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "H Diff";
            
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(597, 350);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 252);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(597, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nurullah GUGUK - 180201030";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 613);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.vdiff_tbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hdiff_tbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.charv_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.charh_tbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fv_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fh_tvb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path_txb);
            this.Controls.Add(this.recognition_btn);
            this.Controls.Add(this.generate_knowledge_base_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_knowledge_base_btn;
        private System.Windows.Forms.Button recognition_btn;
        private System.Windows.Forms.TextBox path_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fh_tvb;
        private System.Windows.Forms.TextBox fv_tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox charv_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox charh_tbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vdiff_tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hdiff_tbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}

