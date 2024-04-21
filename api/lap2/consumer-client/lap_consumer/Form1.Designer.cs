namespace lap_consumer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_student = new DataGridView();
            txt_name = new TextBox();
            txt_age = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cb_depts = new ComboBox();
            label4 = new Label();
            add = new Button();
            label3 = new Label();
            txt_super = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
            SuspendLayout();
            // 
            // dgv_student
            // 
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Location = new Point(49, 220);
            dgv_student.Name = "dgv_student";
            dgv_student.RowHeadersWidth = 51;
            dgv_student.Size = new Size(695, 188);
            dgv_student.TabIndex = 1;
            dgv_student.CellContentClick += dataGridView2_CellContentClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(97, 24);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(176, 27);
            txt_name.TabIndex = 2;
            txt_name.TextChanged += textBox1_TextChanged;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(451, 24);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(176, 27);
            txt_age.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 6;
            label1.Text = "name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 27);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 7;
            label2.Text = "age";
            // 
            // cb_depts
            // 
            cb_depts.FormattingEnabled = true;
            cb_depts.Location = new Point(451, 80);
            cb_depts.Name = "cb_depts";
            cb_depts.Size = new Size(176, 28);
            cb_depts.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 83);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 10;
            label4.Text = "department";
            label4.Click += label4_Click;
            // 
            // add
            // 
            add.Location = new Point(293, 167);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 11;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 12;
            label3.Text = "supervisor";
            // 
            // txt_super
            // 
            txt_super.Location = new Point(94, 104);
            txt_super.Name = "txt_super";
            txt_super.Size = new Size(179, 27);
            txt_super.TabIndex = 13;
            txt_super.TextChanged += textBox1_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_super);
            Controls.Add(label3);
            Controls.Add(add);
            Controls.Add(label4);
            Controls.Add(cb_depts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(dgv_student);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_student;
        private TextBox txt_name;
        private TextBox txt_age;
        private Label label1;
        private Label label2;
        private ComboBox cb_depts;
        private Label label4;
        private Button add;
        private Label label3;
        private TextBox txt_super;
    }
}
