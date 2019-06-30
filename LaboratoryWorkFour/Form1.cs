using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWorkFour
{
    public partial class Form1 : Form
    {

        private List<Student> students = new List<Student>();

        private List<Student> Students { get => students; set => students = value; }

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Внимание: Когда вы нажимаете кнопку очистить массив с данными не удаляеться и вы можете его восстановить нажав на кнопку форматирования");
        }
        struct Student
        {
            public string name;
            public string surname;
            public string patronymic;

            public string floor;
            public string faculty;
            public int course;
            public string group;
            public string city;
            public double srBal;

            public Student(string name, string surname, string patronymic, string floor, string faculty, int course, string group, string city,double srBal)
            {
                this.name = name;
                this.surname = surname;
                this.patronymic = patronymic;
                this.floor = floor;
                this.faculty = faculty;
                this.course = course;
                this.group = group;
                this.city = city;
                this.srBal = srBal;
            }
        }

        struct Subject
        {

            public int mat;
            public int fiz;
            public int bio;
            public int him;
            public int ano;

            public Subject(int mat, int fiz, int bio, int him, int ano)
            {
                this.mat = mat;
                this.fiz = fiz;
                this.bio = bio;
                this.him = him;
                this.ano = ano;
            }

        }

        private double StudStatus(Subject sub)
        {

            double result = (sub.mat + sub.fiz + sub.bio + sub.him + sub.ano) / 5;  
            
            MessageBox.Show("средний балл студента равен - " + result);
            return result;

        }
            
        private List<Student> SortListGood(List<Student> students) {
            int count = 0;

            foreach (Student i in students)
            {
                if (i.floor == "женский" && i.srBal == 5) {
                    count++;
                }
                
            }

            Student[] stud = new Student[count];
            int[] id = new int[count];
            
            count = 0;
            int num = 0;
            int idinc = 0;
            foreach (Student i in students)
            {
                if (i.floor == "женский" && i.srBal == 5)
                {
                    stud[count] = i;
                    id[idinc] = num;
                    idinc++;
                    count++;
                }
                num++;
            }
            //мортировочка подьехала
            var studs = from i in stud
                                 orderby i.name
                                 select i;
            
            idinc = 0;

            foreach (var item in studs)
            {
                int c = id[idinc];
                students.RemoveAt(c);
                students.Insert(c,item);
                idinc++;
            }
            
            return students;
        }
        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void floor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void faculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void course_TextChanged(object sender, EventArgs e)
        {

        }

        private void group_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void mat_TextChanged(object sender, EventArgs e)
        {

        }

        private void fiz_TextChanged(object sender, EventArgs e)
        {

        }

        private void bio_TextChanged(object sender, EventArgs e)
        {

        }

        private void him_TextChanged(object sender, EventArgs e)
        {

        }

        private void ano_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_view_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                Subject subject = new Subject(Convert.ToInt32(mat.Text), Convert.ToInt32(fiz.Text), Convert.ToInt32(bio.Text), Convert.ToInt32(him.Text), Convert.ToInt32(ano.Text));
                double status = StudStatus(subject);

                Student student = new Student(name.Text, surname.Text, textBox3.Text, floor.Text, faculty.Text, Convert.ToInt32(course.Text), group.Text, city.Text,status);

                    Students.Add(student);
               

                results.Text += "Имя : " + student.name + Environment.NewLine + "Фамилия :  " + student.surname + Environment.NewLine + "Курс: " + student.course + Environment.NewLine
                + "Группа :  " + student.group + Environment.NewLine + "Средний балл :  " + status + Environment.NewLine + Environment.NewLine;

                mat.Clear();
                fiz.Clear();
                bio.Clear();
                him.Clear();
                ano.Clear();
                name.Clear();
                city.Clear();
                group.Clear();
                course.Clear();
                faculty.Clear();
                surname.Clear();
                textBox3.Clear();
                floor.SelectedIndex = -1;
                MessageBox.Show("Студент добавлен");

            }

            catch (Exception)
            {
                MessageBox.Show("Вы пытаетесь ввести недопустимые значения или оставили пустые строки, убидесть в том что вы все ввели вверно");
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            results.Clear();
            MessageBox.Show("Успешно очищено");
        }

        private void generate_Click(object sender, EventArgs e)
        {
            results.Clear();
            Students = SortListGood(Students);
            foreach (Student i in Students)
            {
                if (i.floor == "женский" && i.srBal == 5)
                {
                        results.Text += "Имя : " + i.name + Environment.NewLine + "Фамилия :  " + i.surname + Environment.NewLine + "Курс: " + i.course + Environment.NewLine
                    + "Группа :  " + i.group + Environment.NewLine + "Средний балл :  " + i.srBal+ Environment.NewLine + "ВНИМАНИЕ ЭТО ОТЛИЧНИЦА!!!!!!!!!!!!!!!!!!!!!!!!!!!  " 
                    + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    results.Text += "Имя : " + i.name + Environment.NewLine + "Фамилия :  " + i.surname + Environment.NewLine + "Курс: " + i.course + Environment.NewLine
                + "Группа :  " + i.group + Environment.NewLine + "Средний балл :  " + i.srBal + Environment.NewLine + Environment.NewLine;
                }
            }
        }

        private void surname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}