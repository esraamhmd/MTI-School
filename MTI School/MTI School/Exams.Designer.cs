﻿namespace MTI_School
{
    partial class Exams
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mtiSchoolDataSet = new MTI_School.mtiSchoolDataSet();
            this.examsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examsTableAdapter = new MTI_School.mtiSchoolDataSetTableAdapters.ExamsTableAdapter();
            this.examIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtiSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.examNameDataGridViewTextBoxColumn,
            this.examDateDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.examsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mtiSchoolDataSet
            // 
            this.mtiSchoolDataSet.DataSetName = "mtiSchoolDataSet";
            this.mtiSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examsBindingSource
            // 
            this.examsBindingSource.DataMember = "Exams";
            this.examsBindingSource.DataSource = this.mtiSchoolDataSet;
            // 
            // examsTableAdapter
            // 
            this.examsTableAdapter.ClearBeforeFill = true;
            // 
            // examIDDataGridViewTextBoxColumn
            // 
            this.examIDDataGridViewTextBoxColumn.DataPropertyName = "ExamID";
            this.examIDDataGridViewTextBoxColumn.HeaderText = "ExamID";
            this.examIDDataGridViewTextBoxColumn.Name = "examIDDataGridViewTextBoxColumn";
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // examNameDataGridViewTextBoxColumn
            // 
            this.examNameDataGridViewTextBoxColumn.DataPropertyName = "ExamName";
            this.examNameDataGridViewTextBoxColumn.HeaderText = "ExamName";
            this.examNameDataGridViewTextBoxColumn.Name = "examNameDataGridViewTextBoxColumn";
            // 
            // examDateDataGridViewTextBoxColumn
            // 
            this.examDateDataGridViewTextBoxColumn.DataPropertyName = "ExamDate";
            this.examDateDataGridViewTextBoxColumn.HeaderText = "ExamDate";
            this.examDateDataGridViewTextBoxColumn.Name = "examDateDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Exams";
            this.Text = "Exams";
            this.Load += new System.EventHandler(this.Exams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtiSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private mtiSchoolDataSet mtiSchoolDataSet;
        private System.Windows.Forms.BindingSource examsBindingSource;
        private mtiSchoolDataSetTableAdapters.ExamsTableAdapter examsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn examIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}