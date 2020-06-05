namespace Общежитие
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tables_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rooms_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.общежитие1DataSet = new Общежитие.Общежитие1DataSet();
            this.Lgots_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Students_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Show_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rasselenie_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new Общежитие.Общежитие1DataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new Общежитие.Общежитие1DataSetTableAdapters.TableAdapterManager();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Общежитие.Общежитие1DataSetTableAdapters.StudentsTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитие1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Tables_ToolStripMenuItem,
            this.Show_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.File_ToolStripMenuItem.Text = "Файл";
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Exit_ToolStripMenuItem.Text = "Выход";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // Tables_ToolStripMenuItem
            // 
            this.Tables_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rooms_ToolStripMenuItem,
            this.Lgots_ToolStripMenuItem,
            this.Students_ToolStripMenuItem});
            this.Tables_ToolStripMenuItem.Name = "Tables_ToolStripMenuItem";
            this.Tables_ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.Tables_ToolStripMenuItem.Text = "Таблицы";
            // 
            // Rooms_ToolStripMenuItem
            // 
            this.Rooms_ToolStripMenuItem.Name = "Rooms_ToolStripMenuItem";
            this.Rooms_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Rooms_ToolStripMenuItem.Text = "Комнаты";
            this.Rooms_ToolStripMenuItem.Click += new System.EventHandler(this.комнатыToolStripMenuItem_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.общежитие1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // общежитие1DataSet
            // 
            this.общежитие1DataSet.DataSetName = "Общежитие1DataSet";
            this.общежитие1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Lgots_ToolStripMenuItem
            // 
            this.Lgots_ToolStripMenuItem.Name = "Lgots_ToolStripMenuItem";
            this.Lgots_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Lgots_ToolStripMenuItem.Text = "Льготы";
            this.Lgots_ToolStripMenuItem.Click += new System.EventHandler(this.Lgots_ToolStripMenuItem_Click);
            // 
            // Students_ToolStripMenuItem
            // 
            this.Students_ToolStripMenuItem.Name = "Students_ToolStripMenuItem";
            this.Students_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Students_ToolStripMenuItem.Text = "Студенты";
            this.Students_ToolStripMenuItem.Click += new System.EventHandler(this.Students_ToolStripMenuItem_Click);
            // 
            // Show_ToolStripMenuItem
            // 
            this.Show_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rasselenie_ToolStripMenuItem});
            this.Show_ToolStripMenuItem.Name = "Show_ToolStripMenuItem";
            this.Show_ToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.Show_ToolStripMenuItem.Text = "Просмотр";
            // 
            // Rasselenie_ToolStripMenuItem
            // 
            this.Rasselenie_ToolStripMenuItem.Name = "Rasselenie_ToolStripMenuItem";
            this.Rasselenie_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Rasselenie_ToolStripMenuItem.Text = "Расселение";
            this.Rasselenie_ToolStripMenuItem.Click += new System.EventHandler(this.Rasselenie_ToolStripMenuItem_Click);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.общежитие1DataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LgotaTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Общежитие.Общежитие1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "RoomsStudents";
            this.studentsBindingSource.DataSource = this.roomsBindingSource;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитие1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Общежитие1DataSet общежитие1DataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tables_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rooms_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Lgots_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Students_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Show_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rasselenie_ToolStripMenuItem;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Общежитие1DataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private Общежитие1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Общежитие1DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
    }
}

