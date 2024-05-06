
namespace _15prakt
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.x1Coordinate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.y1Coordinate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.z1Coordinate = new System.Windows.Forms.TextBox();
            this.addVectorA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addVectorB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.z2Coordinate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.y2Coordinate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.x2Coordinate = new System.Windows.Forms.TextBox();
            this.solveVestorC = new System.Windows.Forms.Button();
            this.additional = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // x1Coordinate
            // 
            this.x1Coordinate.Location = new System.Drawing.Point(12, 79);
            this.x1Coordinate.Name = "x1Coordinate";
            this.x1Coordinate.Size = new System.Drawing.Size(134, 20);
            this.x1Coordinate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Координата x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Координата Y";
            // 
            // y1Coordinate
            // 
            this.y1Coordinate.Location = new System.Drawing.Point(12, 128);
            this.y1Coordinate.Name = "y1Coordinate";
            this.y1Coordinate.Size = new System.Drawing.Size(134, 20);
            this.y1Coordinate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Координата Z";
            // 
            // z1Coordinate
            // 
            this.z1Coordinate.Location = new System.Drawing.Point(12, 182);
            this.z1Coordinate.Name = "z1Coordinate";
            this.z1Coordinate.Size = new System.Drawing.Size(134, 20);
            this.z1Coordinate.TabIndex = 4;
            // 
            // addVectorA
            // 
            this.addVectorA.Location = new System.Drawing.Point(12, 219);
            this.addVectorA.Name = "addVectorA";
            this.addVectorA.Size = new System.Drawing.Size(134, 23);
            this.addVectorA.TabIndex = 6;
            this.addVectorA.Text = "Добавить вектор";
            this.addVectorA.UseVisualStyleBackColor = true;
            this.addVectorA.Click += new System.EventHandler(this.addVectorA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вектор А";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Вектор B";
            // 
            // addVectorB
            // 
            this.addVectorB.Location = new System.Drawing.Point(214, 219);
            this.addVectorB.Name = "addVectorB";
            this.addVectorB.Size = new System.Drawing.Size(134, 23);
            this.addVectorB.TabIndex = 15;
            this.addVectorB.Text = "Добавить вектор";
            this.addVectorB.UseVisualStyleBackColor = true;
            this.addVectorB.Click += new System.EventHandler(this.addVectorB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Координата Z";
            // 
            // z2Coordinate
            // 
            this.z2Coordinate.Location = new System.Drawing.Point(214, 182);
            this.z2Coordinate.Name = "z2Coordinate";
            this.z2Coordinate.Size = new System.Drawing.Size(134, 20);
            this.z2Coordinate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Координата Y";
            // 
            // y2Coordinate
            // 
            this.y2Coordinate.Location = new System.Drawing.Point(214, 128);
            this.y2Coordinate.Name = "y2Coordinate";
            this.y2Coordinate.Size = new System.Drawing.Size(134, 20);
            this.y2Coordinate.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Координата x";
            // 
            // x2Coordinate
            // 
            this.x2Coordinate.Location = new System.Drawing.Point(214, 79);
            this.x2Coordinate.Name = "x2Coordinate";
            this.x2Coordinate.Size = new System.Drawing.Size(134, 20);
            this.x2Coordinate.TabIndex = 9;
            // 
            // solveVestorC
            // 
            this.solveVestorC.Location = new System.Drawing.Point(508, 391);
            this.solveVestorC.Name = "solveVestorC";
            this.solveVestorC.Size = new System.Drawing.Size(165, 23);
            this.solveVestorC.TabIndex = 17;
            this.solveVestorC.Text = "Вычислить вектор C";
            this.solveVestorC.UseVisualStyleBackColor = true;
            this.solveVestorC.Click += new System.EventHandler(this.solveVestorC_Click);
            // 
            // additional
            // 
            this.additional.AutoSize = true;
            this.additional.Location = new System.Drawing.Point(425, 395);
            this.additional.Name = "additional";
            this.additional.Size = new System.Drawing.Size(77, 17);
            this.additional.TabIndex = 18;
            this.additional.Text = "Сложение";
            this.additional.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(425, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 251);
            this.listBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.additional);
            this.Controls.Add(this.solveVestorC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addVectorB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.z2Coordinate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.y2Coordinate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.x2Coordinate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addVectorA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.z1Coordinate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.y1Coordinate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x1Coordinate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1Coordinate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox y1Coordinate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox z1Coordinate;
        private System.Windows.Forms.Button addVectorA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addVectorB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox z2Coordinate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox y2Coordinate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox x2Coordinate;
        private System.Windows.Forms.Button solveVestorC;
        private System.Windows.Forms.CheckBox additional;
        private System.Windows.Forms.ListBox listBox1;
    }
}

