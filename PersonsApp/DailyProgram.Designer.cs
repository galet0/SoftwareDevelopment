﻿namespace PersonsApp
{
    partial class DailyProgram
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClassStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberInClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassStr,
            this.NumberInClass,
            this.Name,
            this.Grades});
            this.dataGridView1.Location = new System.Drawing.Point(108, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClassStr
            // 
            this.ClassStr.HeaderText = "Class";
            this.ClassStr.MinimumWidth = 6;
            this.ClassStr.Name = "ClassStr";
            this.ClassStr.Width = 125;
            // 
            // NumberInClass
            // 
            this.NumberInClass.HeaderText = "№";
            this.NumberInClass.MinimumWidth = 6;
            this.NumberInClass.Name = "NumberInClass";
            this.NumberInClass.Width = 125;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Grades
            // 
            this.Grades.HeaderText = "Grades";
            this.Grades.MinimumWidth = 6;
            this.Grades.Name = "Grades";
            this.Grades.Width = 125;
            // 
            // DailyProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 604);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DailyProgram";
            this.Text = "DailyProgram";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberInClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grades;
    }
}