namespace SFTPConnector_1._0.UserControls
{
    partial class TaskTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.taskDataTable = new System.Windows.Forms.DataGridView();
            this.taskListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.taskDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // taskDataTable
            // 
            this.taskDataTable.AutoGenerateColumns = false;
            this.taskDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataTable.DataSource = this.taskListBindingSource;
            this.taskDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDataTable.Location = new System.Drawing.Point(0, 0);
            this.taskDataTable.Name = "taskDataTable";
            this.taskDataTable.RowHeadersWidth = 51;
            this.taskDataTable.RowTemplate.Height = 24;
            this.taskDataTable.Size = new System.Drawing.Size(608, 324);
            this.taskDataTable.TabIndex = 0;
            // 
            // taskListBindingSource
            // 
            this.taskListBindingSource.DataSource = typeof(SFTPConnectorLib.Models.TaskList);
            // 
            // TaskTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskDataTable);
            this.Name = "TaskTable";
            this.Size = new System.Drawing.Size(608, 324);
            ((System.ComponentModel.ISupportInitialize)(this.taskDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView taskDataTable;
        private System.Windows.Forms.BindingSource taskListBindingSource;
    }
}
