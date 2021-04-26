namespace geometricfigures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Figures = new System.Windows.Forms.GroupBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.line = new System.Windows.Forms.RadioButton();
            this.rectangle = new System.Windows.Forms.RadioButton();
            this.triangle = new System.Windows.Forms.RadioButton();
            this.circle = new System.Windows.Forms.RadioButton();
            this.Cordinates = new System.Windows.Forms.GroupBox();
            this.Figures.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.Cordinates.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DrawPanel.Location = new System.Drawing.Point(283, 84);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(408, 320);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(37, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Point (XY)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Point (XY)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radius";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(37, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Figures
            // 
            this.Figures.Controls.Add(this.circle);
            this.Figures.Controls.Add(this.triangle);
            this.Figures.Controls.Add(this.rectangle);
            this.Figures.Controls.Add(this.line);
            this.Figures.Location = new System.Drawing.Point(21, 3);
            this.Figures.Name = "Figures";
            this.Figures.Size = new System.Drawing.Size(120, 110);
            this.Figures.TabIndex = 9;
            this.Figures.TabStop = false;
            this.Figures.Text = "Figures";
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControlPanel.BackgroundImage")));
            this.ControlPanel.Controls.Add(this.Cordinates);
            this.ControlPanel.Controls.Add(this.button2);
            this.ControlPanel.Controls.Add(this.Figures);
            this.ControlPanel.Controls.Add(this.button1);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(170, 450);
            this.ControlPanel.TabIndex = 10;
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Checked = true;
            this.line.Location = new System.Drawing.Point(24, 12);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(45, 17);
            this.line.TabIndex = 0;
            this.line.TabStop = true;
            this.line.Text = "Line";
            this.line.UseVisualStyleBackColor = true;
            this.line.CheckedChanged += new System.EventHandler(this.line_CheckedChanged);
            // 
            // rectangle
            // 
            this.rectangle.AutoSize = true;
            this.rectangle.Location = new System.Drawing.Point(24, 35);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(74, 17);
            this.rectangle.TabIndex = 1;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            // 
            // triangle
            // 
            this.triangle.AutoSize = true;
            this.triangle.Location = new System.Drawing.Point(24, 58);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(63, 17);
            this.triangle.TabIndex = 2;
            this.triangle.Text = "Triangle";
            this.triangle.UseVisualStyleBackColor = true;
            // 
            // circle
            // 
            this.circle.AutoSize = true;
            this.circle.Location = new System.Drawing.Point(24, 81);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(51, 17);
            this.circle.TabIndex = 3;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            // 
            // Cordinates
            // 
            this.Cordinates.Controls.Add(this.label2);
            this.Cordinates.Controls.Add(this.textBox1);
            this.Cordinates.Controls.Add(this.label1);
            this.Cordinates.Controls.Add(this.textBox2);
            this.Cordinates.Controls.Add(this.textBox3);
            this.Cordinates.Controls.Add(this.label3);
            this.Cordinates.Location = new System.Drawing.Point(21, 119);
            this.Cordinates.Name = "Cordinates";
            this.Cordinates.Size = new System.Drawing.Size(120, 141);
            this.Cordinates.TabIndex = 10;
            this.Cordinates.TabStop = false;
            this.Cordinates.Text = "Cordinates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.DrawPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Figures.ResumeLayout(false);
            this.Figures.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.Cordinates.ResumeLayout(false);
            this.Cordinates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Figures;
        private System.Windows.Forms.RadioButton circle;
        private System.Windows.Forms.RadioButton triangle;
        private System.Windows.Forms.RadioButton rectangle;
        private System.Windows.Forms.RadioButton line;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.GroupBox Cordinates;
    }
}

