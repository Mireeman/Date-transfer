using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Info
{
    public partial class Form1 : Form
    {
        private object textbox1;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                if (textBox1.Text == "")
                {
                    textBox1.BackColor = Color.LightCoral;
                }
                
                if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.LightCoral;
                }

                if (textBox3.Text == "")
                {
                    textBox3.BackColor = Color.LightCoral;
                }

                if (textBox4.Text == "")
                {
                    textBox4.BackColor = Color.LightCoral;
                }
                
                if (textBox5.Text == "")
                {
                    textBox5.BackColor = Color.LightCoral;
                }

                if (textBox6.Text == "")
                {
                    textBox6.BackColor = Color.LightCoral;
                }
                
                if (textBox7.Text == "")
                {
                    textBox7.BackColor = Color.LightCoral;
                }

                if (textBox8.Text == "")
                {
                    textBox8.BackColor = Color.LightCoral;
                }

                if (textBox9.Text == "")
                {
                    textBox9.BackColor = Color.LightCoral;
                }
                MessageBox.Show("Вы не заполнили все поля!");
            }
            else
            {
                Form2 fm2 = new Form2();

                fm2.label1.Text = "Ф.И.О: " + this.textBox2.Text + " " + this.textBox1.Text + " " + this.textBox3.Text;
                fm2.label2.Text = "Пол: " + this.comboBox1.Text;
                fm2.label3.Text = "Дата рождения: " + this.dateTimePicker1.Text;
                fm2.label4.Text = "Место рожения: " + this.comboBox2.Text + ", " + this.textBox4.Text;
                fm2.label5.Text = "E-mail: " + this.textBox5.Text;
                fm2.label6.Text = "Номер телефона: +7" + this.textBox6.Text;

                fm2.Show();


                Form3 fm3 = new Form3();

                fm3.label1.Text = "Место учебы: " + this.textBox7.Text;
                fm3.label2.Text = "Класс/Группа: " + this.textBox8.Text;
                fm3.label3.Text = "Специальность: " + this.textBox9.Text;
                fm3.label4.Text = "Дата поступления: " + this.dateTimePicker2.Text;
                fm3.label5.Text = "Дата окончания: " + this.dateTimePicker3.Text;

                fm3.Show();
            }


            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "Персональные данные.txt");
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Ф.И.О: " + this.textBox2.Text + " " + this.textBox1.Text + " " + this.textBox3.Text );
                    sw.WriteLine("Пол: " + this.comboBox1.Text);
                    sw.WriteLine("Дата рождения: " + this.dateTimePicker1.Text);
                    sw.WriteLine("Место рождения: " + this.comboBox2.Text + ", " + this.textBox4.Text);
                    sw.WriteLine("E-mail: " + this.textBox5.Text);
                    sw.WriteLine("Номер телефона: +7" + this.textBox6.Text);
                }
            }
            string path1 = System.IO.Path.Combine(Environment.CurrentDirectory, "Образование.txt");
            if (!File.Exists(path1))
            {
                using (StreamWriter sw = File.CreateText(path1))
                {
                    sw.WriteLine("Место учебы: " + this.textBox7.Text);
                    sw.WriteLine("Класс/Группа: " + this.textBox8.Text);
                    sw.WriteLine("Специальность: " + this.textBox9.Text);
                    sw.WriteLine("Дата поступления: " + this.dateTimePicker2.Text);
                    sw.WriteLine("Дата окончания: " + this.dateTimePicker3.Text);
                }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
         
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Текст
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            else
                e.Handled = true;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Текст
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Текст
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Текст
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Числа
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.White;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.White;
        }

  
    }
}
