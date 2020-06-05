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
    public partial class RasselenieForm : Form
    {
        public RasselenieForm()
        {
            InitializeComponent();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.общежитие1DataSet);

        }

        private void RasselenieForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитие1DataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.общежитие1DataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитие1DataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.общежитие1DataSet.Rooms);

        }

        private void CorrectChange_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                roomsBindingSource.EndEdit();
                roomsTableAdapter.Update(общежитие1DataSet);
                studentsTableAdapter.Update(общежитие1DataSet);
            }
        }
    }
}
