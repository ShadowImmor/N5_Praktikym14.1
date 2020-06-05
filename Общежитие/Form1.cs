using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Общежитие
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Text = "Комнаты";
            try
            {
                roomsForm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка" , MessageBoxButtons.OK);
            }
        }

        private void Lgots_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LgotaForm lgotaForm = new LgotaForm();
            lgotaForm.Text = "Льготы";
            try
            {
                lgotaForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Students_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Text = "Студенты";
            try
            {
                studentsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Rasselenie_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RasselenieForm rasselenieForm = new RasselenieForm();
            rasselenieForm.Text = "Рассиление";
            try
            {
                rasselenieForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
            }     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитие1DataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.общежитие1DataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитие1DataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.общежитие1DataSet.Rooms);

        }
    }
}
