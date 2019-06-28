namespace LaboratoryWorkFour
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
            this.surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.floor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ano = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.him = new System.Windows.Forms.TextBox();
            this.bio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.fiz = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(93, 49);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(154, 20);
            this.surname.TabIndex = 0;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(93, 75);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(154, 20);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // floor
            // 
            this.floor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floor.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.floor.Location = new System.Drawing.Point(93, 127);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(154, 21);
            this.floor.TabIndex = 6;
            this.floor.SelectedIndexChanged += new System.EventHandler(this.floor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Факультет";
            // 
            // faculty
            // 
            this.faculty.Location = new System.Drawing.Point(93, 154);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(154, 20);
            this.faculty.TabIndex = 8;
            this.faculty.TextChanged += new System.EventHandler(this.faculty_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Курс";
            // 
            // course
            // 
            this.course.Location = new System.Drawing.Point(93, 180);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(154, 20);
            this.course.TabIndex = 10;
            this.course.TextChanged += new System.EventHandler(this.course_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Группа";
            // 
            // group
            // 
            this.group.Location = new System.Drawing.Point(93, 206);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(154, 20);
            this.group.TabIndex = 12;
            this.group.TextChanged += new System.EventHandler(this.group_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Данные о студенте";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "отметки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Математика";
            // 
            // mat
            // 
            this.mat.Location = new System.Drawing.Point(412, 52);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(154, 20);
            this.mat.TabIndex = 16;
            this.mat.TextChanged += new System.EventHandler(this.mat_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Биология";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Химия";
            // 
            // ano
            // 
            this.ano.Location = new System.Drawing.Point(412, 156);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(154, 20);
            this.ano.TabIndex = 20;
            this.ano.TextChanged += new System.EventHandler(this.ano_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Анатомия";
            // 
            // him
            // 
            this.him.Location = new System.Drawing.Point(412, 130);
            this.him.Name = "him";
            this.him.Size = new System.Drawing.Size(154, 20);
            this.him.TabIndex = 22;
            this.him.TextChanged += new System.EventHandler(this.him_TextChanged);
            // 
            // bio
            // 
            this.bio.Location = new System.Drawing.Point(412, 104);
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(154, 20);
            this.bio.TabIndex = 24;
            this.bio.TextChanged += new System.EventHandler(this.bio_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(358, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Физика";
            // 
            // fiz
            // 
            this.fiz.Location = new System.Drawing.Point(412, 78);
            this.fiz.Name = "fiz";
            this.fiz.Size = new System.Drawing.Size(154, 20);
            this.fiz.TabIndex = 26;
            this.fiz.TextChanged += new System.EventHandler(this.fiz_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(102, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Город проживания(село)";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(93, 263);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(154, 20);
            this.city.TabIndex = 29;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(93, 345);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(277, 67);
            this.add.TabIndex = 31;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(376, 345);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(277, 67);
            this.delete.TabIndex = 32;
            this.delete.Text = "очистить результаты";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(659, 345);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(277, 67);
            this.generate.TabIndex = 33;
            this.generate.Text = "Офармотировать текст по стандартам";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(798, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "результаты";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(659, 52);
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.Size = new System.Drawing.Size(350, 231);
            this.results.TabIndex = 35;
            this.results.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.fiz);
            this.Controls.Add(this.bio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.him);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ano);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.group);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.course);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox floor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox faculty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox group;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ano;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox him;
        private System.Windows.Forms.TextBox bio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox fiz;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox results;
    }
}

