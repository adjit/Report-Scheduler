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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectCreateTaskGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskNameMenu = new System.Windows.Forms.ComboBox();
            this.FileSelectLabel = new System.Windows.Forms.Label();
            this.selectActionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.selectActionComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.fileSelectComboBox = new System.Windows.Forms.ComboBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.addFileToTaskButton = new System.Windows.Forms.Button();
            this.fileManagementGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.fileManagementListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.removeFileButton = new System.Windows.Forms.Button();
            this.ScheduleGroupBox = new System.Windows.Forms.GroupBox();
            this.activeTasks = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.addEditTask.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.selectCreateTaskGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.fileManagementGroupBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(697, 677);
            this.tabControl.TabIndex = 0;
            // 
            // addEditTask
            // 
            this.addEditTask.Controls.Add(this.tableLayoutPanel1);
            this.addEditTask.Location = new System.Drawing.Point(4, 25);
            this.addEditTask.Name = "addEditTask";
            this.addEditTask.Padding = new System.Windows.Forms.Padding(3);
            this.addEditTask.Size = new System.Drawing.Size(689, 648);
            this.addEditTask.TabIndex = 0;
            this.addEditTask.Text = "Add/Edit Task";
            this.addEditTask.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.selectCreateTaskGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileManagementGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ScheduleGroupBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 642);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectCreateTaskGroup
            // 
            this.selectCreateTaskGroup.Controls.Add(this.tableLayoutPanel2);
            this.selectCreateTaskGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectCreateTaskGroup.Location = new System.Drawing.Point(3, 3);
            this.selectCreateTaskGroup.Name = "selectCreateTaskGroup";
            this.selectCreateTaskGroup.Size = new System.Drawing.Size(677, 179);
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
            this.tableLayoutPanel2.Controls.Add(this.FileSelectLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.selectActionLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(671, 158);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskNameLabel.Location = new System.Drawing.Point(11, 8);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(92, 30);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Task Name";
            this.taskNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taskNameMenu
            // 
            this.taskNameMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskNameMenu.FormattingEnabled = true;
            this.taskNameMenu.Location = new System.Drawing.Point(109, 11);
            this.taskNameMenu.Name = "taskNameMenu";
            this.taskNameMenu.Size = new System.Drawing.Size(551, 24);
            this.taskNameMenu.TabIndex = 1;
            // 
            // FileSelectLabel
            // 
            this.FileSelectLabel.AutoSize = true;
            this.FileSelectLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FileSelectLabel.Location = new System.Drawing.Point(30, 78);
            this.FileSelectLabel.Name = "FileSelectLabel";
            this.FileSelectLabel.Size = new System.Drawing.Size(73, 40);
            this.FileSelectLabel.TabIndex = 2;
            this.FileSelectLabel.Text = "File Select";
            this.FileSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectActionLabel
            // 
            this.selectActionLabel.AutoSize = true;
            this.selectActionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectActionLabel.Location = new System.Drawing.Point(13, 38);
            this.selectActionLabel.Name = "selectActionLabel";
            this.selectActionLabel.Size = new System.Drawing.Size(90, 40);
            this.selectActionLabel.TabIndex = 4;
            this.selectActionLabel.Text = "Select Action";
            this.selectActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.selectActionComboBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(109, 40);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(551, 36);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // selectActionComboBox
            // 
            this.selectActionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectActionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectActionComboBox.FormattingEnabled = true;
            this.selectActionComboBox.Location = new System.Drawing.Point(3, 5);
            this.selectActionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectActionComboBox.Name = "selectActionComboBox";
            this.selectActionComboBox.Size = new System.Drawing.Size(407, 24);
            this.selectActionComboBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Configure";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.fileSelectComboBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.browseButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(109, 80);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(551, 36);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // fileSelectComboBox
            // 
            this.fileSelectComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelectComboBox.FormattingEnabled = true;
            this.fileSelectComboBox.Location = new System.Drawing.Point(3, 5);
            this.fileSelectComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileSelectComboBox.Name = "fileSelectComboBox";
            this.fileSelectComboBox.Size = new System.Drawing.Size(407, 24);
            this.fileSelectComboBox.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(416, 2);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(132, 32);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.addFileToTaskButton, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(109, 120);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(551, 36);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // addFileToTaskButton
            // 
            this.addFileToTaskButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addFileToTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFileToTaskButton.Location = new System.Drawing.Point(140, 2);
            this.addFileToTaskButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFileToTaskButton.Name = "addFileToTaskButton";
            this.addFileToTaskButton.Size = new System.Drawing.Size(131, 32);
            this.addFileToTaskButton.TabIndex = 6;
            this.addFileToTaskButton.Text = "Add File to Task";
            this.addFileToTaskButton.UseVisualStyleBackColor = true;
            // 
            // fileManagementGroupBox
            // 
            this.fileManagementGroupBox.Controls.Add(this.tableLayoutPanel5);
            this.fileManagementGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileManagementGroupBox.Location = new System.Drawing.Point(3, 188);
            this.fileManagementGroupBox.Name = "fileManagementGroupBox";
            this.fileManagementGroupBox.Size = new System.Drawing.Size(677, 212);
            this.fileManagementGroupBox.TabIndex = 1;
            this.fileManagementGroupBox.TabStop = false;
            this.fileManagementGroupBox.Text = "File Management";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.26647F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.733524F));
            this.tableLayoutPanel5.Controls.Add(this.fileManagementListBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel5.MinimumSize = new System.Drawing.Size(0, 100);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(671, 191);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // fileManagementListBox
            // 
            this.fileManagementListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileManagementListBox.FormattingEnabled = true;
            this.fileManagementListBox.ItemHeight = 16;
            this.fileManagementListBox.Location = new System.Drawing.Point(3, 3);
            this.fileManagementListBox.Name = "fileManagementListBox";
            this.fileManagementListBox.Size = new System.Drawing.Size(619, 185);
            this.fileManagementListBox.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.removeFileButton, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(628, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.65854F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.34146F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(40, 185);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // removeFileButton
            // 
            this.removeFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeFileButton.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFileButton.ForeColor = System.Drawing.Color.Red;
            this.removeFileButton.Location = new System.Drawing.Point(3, 3);
            this.removeFileButton.Name = "removeFileButton";
            this.removeFileButton.Size = new System.Drawing.Size(34, 93);
            this.removeFileButton.TabIndex = 0;
            this.removeFileButton.Text = "X";
            this.removeFileButton.UseVisualStyleBackColor = true;
            // 
            // ScheduleGroupBox
            // 
            this.ScheduleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleGroupBox.Location = new System.Drawing.Point(3, 406);
            this.ScheduleGroupBox.Name = "ScheduleGroupBox";
            this.ScheduleGroupBox.Size = new System.Drawing.Size(677, 212);
            this.ScheduleGroupBox.TabIndex = 2;
            this.ScheduleGroupBox.TabStop = false;
            this.ScheduleGroupBox.Text = "Schedule";
            // 
            // activeTasks
            // 
            this.activeTasks.Location = new System.Drawing.Point(4, 25);
            this.activeTasks.Name = "activeTasks";
            this.activeTasks.Padding = new System.Windows.Forms.Padding(3);
            this.activeTasks.Size = new System.Drawing.Size(689, 648);
            this.activeTasks.TabIndex = 1;
            this.activeTasks.Text = "Active Tasks";
            this.activeTasks.UseVisualStyleBackColor = true;
            // 
            // ReportSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 677);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(715, 550);
            this.Name = "ReportSchedulerForm";
            this.Text = "Report Scheduler";
            this.tabControl.ResumeLayout(false);
            this.addEditTask.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.selectCreateTaskGroup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.fileManagementGroupBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
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
        private System.Windows.Forms.Label selectActionLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox selectActionComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox fileSelectComboBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button addFileToTaskButton;
        private System.Windows.Forms.GroupBox fileManagementGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListBox fileManagementListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button removeFileButton;
        private System.Windows.Forms.GroupBox ScheduleGroupBox;
    }
}

