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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.filePathControl = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.selectTaskLabel = new System.Windows.Forms.Label();
            this.activeTasks = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.addEditTask.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.selectCreateTaskGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.addEditTask);
            this.tabControl.Controls.Add(this.activeTasks);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(848, 522);
            this.tabControl.TabIndex = 0;
            // 
            // addEditTask
            // 
            this.addEditTask.Controls.Add(this.tableLayoutPanel1);
            this.addEditTask.Location = new System.Drawing.Point(4, 29);
            this.addEditTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEditTask.Name = "addEditTask";
            this.addEditTask.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEditTask.Size = new System.Drawing.Size(840, 489);
            this.addEditTask.TabIndex = 0;
            this.addEditTask.Text = "Add/Edit Task";
            this.addEditTask.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.selectCreateTaskGroup, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.10187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.89813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectCreateTaskGroup
            // 
            this.selectCreateTaskGroup.Controls.Add(this.tableLayoutPanel2);
            this.selectCreateTaskGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectCreateTaskGroup.Location = new System.Drawing.Point(3, 4);
            this.selectCreateTaskGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectCreateTaskGroup.Name = "selectCreateTaskGroup";
            this.selectCreateTaskGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectCreateTaskGroup.Size = new System.Drawing.Size(828, 333);
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
            this.tableLayoutPanel2.Controls.Add(this.selectTaskLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(822, 306);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskNameLabel.Location = new System.Drawing.Point(12, 10);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(115, 36);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Task Name";
            this.taskNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taskNameMenu
            // 
            this.taskNameMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskNameMenu.FormattingEnabled = true;
            this.taskNameMenu.Location = new System.Drawing.Point(133, 14);
            this.taskNameMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskNameMenu.Name = "taskNameMenu";
            this.taskNameMenu.Size = new System.Drawing.Size(677, 28);
            this.taskNameMenu.TabIndex = 1;
            // 
            // FileSelectLabel
            // 
            this.FileSelectLabel.AutoSize = true;
            this.FileSelectLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FileSelectLabel.Location = new System.Drawing.Point(44, 46);
            this.FileSelectLabel.Name = "FileSelectLabel";
            this.FileSelectLabel.Size = new System.Drawing.Size(83, 53);
            this.FileSelectLabel.TabIndex = 2;
            this.FileSelectLabel.Text = "File Select";
            this.FileSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.filePathControl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.browseButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(133, 50);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(677, 45);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // filePathControl
            // 
            this.filePathControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathControl.Location = new System.Drawing.Point(3, 10);
            this.filePathControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filePathControl.Name = "filePathControl";
            this.filePathControl.Size = new System.Drawing.Size(501, 26);
            this.filePathControl.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(510, 4);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Padding = new System.Windows.Forms.Padding(1);
            this.browseButton.Size = new System.Drawing.Size(164, 38);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // selectTaskLabel
            // 
            this.selectTaskLabel.AutoSize = true;
            this.selectTaskLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectTaskLabel.Location = new System.Drawing.Point(35, 99);
            this.selectTaskLabel.Name = "selectTaskLabel";
            this.selectTaskLabel.Size = new System.Drawing.Size(92, 51);
            this.selectTaskLabel.TabIndex = 4;
            this.selectTaskLabel.Text = "Select Task";
            this.selectTaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // activeTasks
            // 
            this.activeTasks.Location = new System.Drawing.Point(4, 29);
            this.activeTasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activeTasks.Name = "activeTasks";
            this.activeTasks.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activeTasks.Size = new System.Drawing.Size(840, 489);
            this.activeTasks.TabIndex = 1;
            this.activeTasks.Text = "Active Tasks";
            this.activeTasks.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(501, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(133, 102);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(677, 45);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(510, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Configure";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReportSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 522);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.tableLayoutPanel4.ResumeLayout(false);
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
        private System.Windows.Forms.Label selectTaskLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

