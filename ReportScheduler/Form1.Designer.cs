namespace ReportScheduler
{
    partial class ReportSchedulerForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.addEditTask = new System.Windows.Forms.TabPage();
            this.activeTasks = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectCreateTaskGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskNameMenu = new System.Windows.Forms.ComboBox();
            this.FileSelectLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.filePathControl = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.addEditTask.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.selectCreateTaskGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.addEditTask);
            this.tabControl.Controls.Add(this.activeTasks);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(754, 418);
            this.tabControl.TabIndex = 0;
            // 
            // addEditTask
            // 
            this.addEditTask.Controls.Add(this.tableLayoutPanel1);
            this.addEditTask.Location = new System.Drawing.Point(4, 25);
            this.addEditTask.Name = "addEditTask";
            this.addEditTask.Padding = new System.Windows.Forms.Padding(3);
            this.addEditTask.Size = new System.Drawing.Size(746, 389);
            this.addEditTask.TabIndex = 0;
            this.addEditTask.Text = "Add/Edit Task";
            this.addEditTask.UseVisualStyleBackColor = true;
            // 
            // activeTasks
            // 
            this.activeTasks.Location = new System.Drawing.Point(4, 25);
            this.activeTasks.Name = "activeTasks";
            this.activeTasks.Padding = new System.Windows.Forms.Padding(3);
            this.activeTasks.Size = new System.Drawing.Size(651, 360);
            this.activeTasks.TabIndex = 1;
            this.activeTasks.Text = "Active Tasks";
            this.activeTasks.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.selectCreateTaskGroup, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectCreateTaskGroup
            // 
            this.selectCreateTaskGroup.Controls.Add(this.tableLayoutPanel2);
            this.selectCreateTaskGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectCreateTaskGroup.Location = new System.Drawing.Point(3, 3);
            this.selectCreateTaskGroup.Name = "selectCreateTaskGroup";
            this.selectCreateTaskGroup.Size = new System.Drawing.Size(734, 185);
            this.selectCreateTaskGroup.TabIndex = 0;
            this.selectCreateTaskGroup.TabStop = false;
            this.selectCreateTaskGroup.Text = "Select / Create Task";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.05376F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.94624F));
            this.tableLayoutPanel2.Controls.Add(this.taskNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.taskNameMenu, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.FileSelectLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(728, 164);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskNameLabel.Location = new System.Drawing.Point(11, 8);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(101, 30);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Task Name";
            this.taskNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taskNameMenu
            // 
            this.taskNameMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskNameMenu.FormattingEnabled = true;
            this.taskNameMenu.Location = new System.Drawing.Point(118, 11);
            this.taskNameMenu.Name = "taskNameMenu";
            this.taskNameMenu.Size = new System.Drawing.Size(599, 24);
            this.taskNameMenu.TabIndex = 1;
            // 
            // FileSelectLabel
            // 
            this.FileSelectLabel.AutoSize = true;
            this.FileSelectLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FileSelectLabel.Location = new System.Drawing.Point(39, 38);
            this.FileSelectLabel.Name = "FileSelectLabel";
            this.FileSelectLabel.Size = new System.Drawing.Size(73, 42);
            this.FileSelectLabel.TabIndex = 2;
            this.FileSelectLabel.Text = "File Select";
            this.FileSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5F));
            this.tableLayoutPanel3.Controls.Add(this.filePathControl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.browseButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(118, 41);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(599, 36);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // filePathControl
            // 
            this.filePathControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathControl.Location = new System.Drawing.Point(3, 7);
            this.filePathControl.Name = "filePathControl";
            this.filePathControl.Size = new System.Drawing.Size(446, 22);
            this.filePathControl.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(455, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Padding = new System.Windows.Forms.Padding(1);
            this.browseButton.Size = new System.Drawing.Size(141, 30);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // ReportSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 418);
            this.Controls.Add(this.tabControl);
            this.Name = "ReportSchedulerForm";
            this.Text = "Report Scheduler";
            this.tabControl.ResumeLayout(false);
            this.addEditTask.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.selectCreateTaskGroup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage addEditTask;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox selectCreateTaskGroup;
        private System.Windows.Forms.TabPage activeTasks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.ComboBox taskNameMenu;
        private System.Windows.Forms.Label FileSelectLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox filePathControl;
        private System.Windows.Forms.Button browseButton;
    }
}

