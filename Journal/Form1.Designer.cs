namespace Journal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTeacher = new System.Windows.Forms.DataGridView();
            this.dataSubject = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addTich = new System.Windows.Forms.Button();
            this.tich = new System.Windows.Forms.TextBox();
            this.sub = new System.Windows.Forms.TextBox();
            this.addSub = new System.Windows.Forms.Button();
            this.dataGridAll = new System.Windows.Forms.DataGridView();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серилизоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTeacher
            // 
            this.dataTeacher.AllowUserToOrderColumns = true;
            this.dataTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTeacher.Location = new System.Drawing.Point(27, 75);
            this.dataTeacher.Name = "dataTeacher";
            this.dataTeacher.ReadOnly = true;
            this.dataTeacher.RowTemplate.Height = 28;
            this.dataTeacher.Size = new System.Drawing.Size(214, 526);
            this.dataTeacher.TabIndex = 0;
            this.dataTeacher.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataTeacher_UserDeletingRow);
            // 
            // dataSubject
            // 
            this.dataSubject.AllowUserToAddRows = false;
            this.dataSubject.AllowUserToOrderColumns = true;
            this.dataSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSubject.Location = new System.Drawing.Point(295, 75);
            this.dataSubject.Name = "dataSubject";
            this.dataSubject.ReadOnly = true;
            this.dataSubject.RowTemplate.Height = 28;
            this.dataSubject.Size = new System.Drawing.Size(214, 526);
            this.dataSubject.TabIndex = 1;
            this.dataSubject.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataSubject_UserDeletingRow);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(66, 42);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(145, 26);
            this.t.TabIndex = 2;
            this.t.Text = "Преподаватели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Предметы";
          
            // 
            // addTich
            // 
            this.addTich.Location = new System.Drawing.Point(27, 663);
            this.addTich.Name = "addTich";
            this.addTich.Size = new System.Drawing.Size(221, 53);
            this.addTich.TabIndex = 4;
            this.addTich.Text = "Добавить Преподавателя";
            this.addTich.UseVisualStyleBackColor = true;
            this.addTich.Click += new System.EventHandler(this.addTich_Click);
            // 
            // tich
            // 
            this.tich.Location = new System.Drawing.Point(27, 617);
            this.tich.Name = "tich";
            this.tich.Size = new System.Drawing.Size(221, 26);
            this.tich.TabIndex = 5;
            this.tich.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tich_KeyDown);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(295, 617);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(214, 26);
            this.sub.TabIndex = 7;
            this.sub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sub_KeyDown);
            // 
            // addSub
            // 
            this.addSub.Location = new System.Drawing.Point(295, 663);
            this.addSub.Name = "addSub";
            this.addSub.Size = new System.Drawing.Size(214, 53);
            this.addSub.TabIndex = 6;
            this.addSub.Text = "Добавить Предмет";
            this.addSub.UseVisualStyleBackColor = true;
            this.addSub.Click += new System.EventHandler(this.addSub_Click);
            // 
            // dataGridAll
            // 
            this.dataGridAll.AllowUserToAddRows = false;
            this.dataGridAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Teacher,
            this.Subject});
            this.dataGridAll.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridAll.Location = new System.Drawing.Point(563, 75);
            this.dataGridAll.Name = "dataGridAll";
            this.dataGridAll.ReadOnly = true;
            this.dataGridAll.RowTemplate.Height = 33;
            this.dataGridAll.Size = new System.Drawing.Size(368, 528);
            this.dataGridAll.TabIndex = 8;
            this.dataGridAll.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridAll_UserDeletingRow);
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Преподаватель";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // linkButton
            // 
            this.linkButton.Location = new System.Drawing.Point(620, 617);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(243, 56);
            this.linkButton.TabIndex = 9;
            this.linkButton.Text = "Добавить Связь";
            this.linkButton.UseVisualStyleBackColor = true;
            this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(687, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Взаимосвязь";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.серилизоватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // серилизоватьToolStripMenuItem
            // 
            this.серилизоватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem});
            this.серилизоватьToolStripMenuItem.Name = "серилизоватьToolStripMenuItem";
            this.серилизоватьToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.серилизоватьToolStripMenuItem.Text = "Cереализовать";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.binaryToolStripMenuItem.Text = "BINARY";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1068, 849);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkButton);
            this.Controls.Add(this.dataGridAll);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.addSub);
            this.Controls.Add(this.tich);
            this.Controls.Add(this.addTich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t);
            this.Controls.Add(this.dataSubject);
            this.Controls.Add(this.dataTeacher);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTeacher;
        private System.Windows.Forms.DataGridView dataSubject;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTich;
        private System.Windows.Forms.TextBox tich;
        private System.Windows.Forms.TextBox sub;
        private System.Windows.Forms.Button addSub;
        private System.Windows.Forms.DataGridView dataGridAll;
        private System.Windows.Forms.Button linkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серилизоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
    }
}

