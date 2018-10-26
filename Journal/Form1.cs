using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Journal
{
    using Controller1 = Controller.Controller;
    [Serializable]
    public partial class Form1 : Form
    {

        static public List<Model.Teacher> teachers;
        static public List<Model.Subject> subjects;
        BindingSource bst = new BindingSource();
        BindingSource bss = new BindingSource();
       

        public Form1()
        {
            InitializeComponent();
          
            bst.DataSource = teachers;
            bss.DataSource = subjects;
            dataTeacher.DataSource = bst;
            dataSubject.DataSource = bss;
            bst.ResetBindings(true);
            bss.ResetBindings(true);

        }

        private void addTich_Click(object sender, EventArgs e)
        {
            if(teachers == null)
                teachers = new List<Model.Teacher>();
            if (Controller1.CorrectEnterance(tich.Text) && !Controller1.IsTeacherExsist(tich.Text , teachers))
            {
                Controller1.AddTeacher(tich.Text, teachers);
                bst.DataSource = teachers;
                bst.ResetBindings(true);
            }
            tich.Text = "";
        }

        private void addSub_Click(object sender, EventArgs e)
        {
            if (subjects == null)
                subjects = new List<Model.Subject>();
            if (Controller1.CorrectEnterance(sub.Text) && !Controller1.IsSubjectExsist(sub.Text, subjects))
            {
                Controller1.AddSubject(sub.Text, subjects);
                bss.DataSource = subjects;
                bss.ResetBindings(true);
            }
            sub.Text = "";
        }

        private void dataTeacher_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            MessageBox.Show("Удаляя преподавателя, он больше не может читать предметы");
            for (int i = 0; i < dataGridAll.RowCount; i++)
            {
                if (dataGridAll.Rows[i].Cells[0].Value.ToString() == dataTeacher.SelectedCells[0].Value.ToString())
                {
                    dataGridAll.Rows.Remove(dataGridAll.Rows[i]);
                    --i;
                }
            }

        }

        private void dataSubject_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            MessageBox.Show("Удаляя прeдмет, его перестает читать преподаватель");
            for (int i = 0; i < dataGridAll.RowCount; i++)
            {
                if (dataGridAll.Rows[i].Cells[1].Value.ToString() == dataSubject.SelectedCells[0].Value.ToString())
                {
                    dataGridAll.Rows.Remove(dataGridAll.Rows[i]);
                    --i;
                }
            }

        }

        private void tich_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addTich_Click(sender, e);
                tich.Text = "";
            }
        }

        private void sub_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addSub_Click(sender, e);
                sub.Text = "";
            }
        }

        private void linkButton_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = dataTeacher.SelectedCells[0].Value.ToString();
                var subject = dataSubject.SelectedCells[0].Value.ToString();

                if (!Controller1.GetTeacher(teacher, teachers).Teaching.Contains(Controller1.GetSubject(subject, subjects)))
                { 
                    Controller1.GetTeacher(teacher, teachers).AddSubject(
                    Controller1.GetSubject(subject, subjects));
                    dataGridAll.Rows.Add(teacher, subject);
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали Преподавателя или Предмет");
            }
        }

        private void dataGridAll_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var teacher = dataGridAll.SelectedCells[0].Value.ToString();
            var subject = dataGridAll.SelectedCells[1].Value.ToString();
            Controller1.GetTeacher(teacher, teachers).DropSubject(Controller1.GetSubject(subject, subjects));
        }


        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("binar.dat", FileMode.OpenOrCreate))
            {
                ArrayList ar = new ArrayList
                {
                    teachers,
                    subjects
                };
                bf.Serialize(fs, ar);
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //teachers.Clear();
            //subjects.Clear();

            using (FileStream fs = new FileStream("binar.dat", FileMode.OpenOrCreate))
            {
            
            BinaryFormatter bf = new BinaryFormatter();
                
                try
                {
                    var s = (ArrayList)bf.Deserialize(fs);
                    teachers = (List<Model.Teacher>)s[0];
                    subjects = (List<Model.Subject>)s[1];
                    
                    bst.DataSource = teachers;
                    bss.DataSource = subjects;
                    dataTeacher.DataSource = bst;
                    dataSubject.DataSource = bss;
                    bst.ResetBindings(true);
                    bss.ResetBindings(true);
                    foreach(var t in teachers)
                    {
                       foreach(var sss in t.Teaching)
                        {
                            dataGridAll.Rows.Add(t.Name, sss.Name );
                        }
                    }

                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }
    }
}
