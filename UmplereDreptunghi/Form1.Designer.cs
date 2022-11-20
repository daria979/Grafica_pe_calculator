namespace UmplereDreptunghi
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.inputX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputY = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputWidth = new System.Windows.Forms.NumericUpDown();
            this.inputHeight = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listFill = new System.Windows.Forms.ComboBox();
            this.listContour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputY)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(870, 630);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // inputX
            // 
            this.inputX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputX.Location = new System.Drawing.Point(7, 84);
            this.inputX.Maximum = new decimal(new int[] {
            870,
            0,
            0,
            0});
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(208, 29);
            this.inputX.TabIndex = 1;
            this.inputX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coordonata X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coordonata Y";
            // 
            // inputY
            // 
            this.inputY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputY.Location = new System.Drawing.Point(7, 152);
            this.inputY.Maximum = new decimal(new int[] {
            630,
            0,
            0,
            0});
            this.inputY.Name = "inputY";
            this.inputY.Size = new System.Drawing.Size(208, 29);
            this.inputY.TabIndex = 3;
            this.inputY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputX);
            this.panel1.Controls.Add(this.inputY);
            this.panel1.Location = new System.Drawing.Point(898, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 192);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Coordonate";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.inputWidth);
            this.panel2.Controls.Add(this.inputHeight);
            this.panel2.Location = new System.Drawing.Point(898, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 144);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lungime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Latime";
            // 
            // inputWidth
            // 
            this.inputWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputWidth.Location = new System.Drawing.Point(7, 35);
            this.inputWidth.Maximum = new decimal(new int[] {
            870,
            0,
            0,
            0});
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(208, 29);
            this.inputWidth.TabIndex = 1;
            this.inputWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // inputHeight
            // 
            this.inputHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputHeight.Location = new System.Drawing.Point(7, 103);
            this.inputHeight.Maximum = new decimal(new int[] {
            630,
            0,
            0,
            0});
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(208, 29);
            this.inputHeight.TabIndex = 3;
            this.inputHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.listFill);
            this.panel3.Controls.Add(this.listContour);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(898, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 192);
            this.panel3.TabIndex = 5;
            // 
            // listFill
            // 
            this.listFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFill.FormattingEnabled = true;
            this.listFill.Location = new System.Drawing.Point(7, 152);
            this.listFill.Name = "listFill";
            this.listFill.Size = new System.Drawing.Size(208, 32);
            this.listFill.TabIndex = 6;
            // 
            // listContour
            // 
            this.listContour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listContour.FormattingEnabled = true;
            this.listContour.Location = new System.Drawing.Point(7, 84);
            this.listContour.Name = "listContour";
            this.listContour.Size = new System.Drawing.Size(208, 32);
            this.listContour.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Culori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Contur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Umplere";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(927, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Deseneaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputY)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.NumericUpDown inputX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown inputWidth;
        private System.Windows.Forms.NumericUpDown inputHeight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox listContour;
        private System.Windows.Forms.ComboBox listFill;
    }
}

