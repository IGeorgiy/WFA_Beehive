namespace WFA_Beehive
{
    partial class FormBeehiveManagmentSystem
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
            this.groupBoxWorkerBeeAssigment = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelJob = new System.Windows.Forms.Label();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.labelShifts = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.buttonAssignThisJobToABee = new System.Windows.Forms.Button();
            this.panelText = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBoxWorkerBeeAssigment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.panelText.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWorkerBeeAssigment
            // 
            this.groupBoxWorkerBeeAssigment.Controls.Add(this.buttonAssignThisJobToABee);
            this.groupBoxWorkerBeeAssigment.Controls.Add(this.shifts);
            this.groupBoxWorkerBeeAssigment.Controls.Add(this.labelShifts);
            this.groupBoxWorkerBeeAssigment.Controls.Add(this.workerBeeJob);
            this.groupBoxWorkerBeeAssigment.Controls.Add(this.labelJob);
            this.groupBoxWorkerBeeAssigment.Location = new System.Drawing.Point(3, 3);
            this.groupBoxWorkerBeeAssigment.Name = "groupBoxWorkerBeeAssigment";
            this.groupBoxWorkerBeeAssigment.Size = new System.Drawing.Size(297, 100);
            this.groupBoxWorkerBeeAssigment.TabIndex = 0;
            this.groupBoxWorkerBeeAssigment.TabStop = false;
            this.groupBoxWorkerBeeAssigment.Text = "Worker Bee Assigment";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(306, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Work the next shift";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Location = new System.Drawing.Point(7, 20);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(24, 13);
            this.labelJob.TabIndex = 0;
            this.labelJob.Text = "Job";
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Nectar collector",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(10, 37);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(175, 21);
            this.workerBeeJob.TabIndex = 1;
            // 
            // labelShifts
            // 
            this.labelShifts.AutoSize = true;
            this.labelShifts.Location = new System.Drawing.Point(193, 20);
            this.labelShifts.Name = "labelShifts";
            this.labelShifts.Size = new System.Drawing.Size(33, 13);
            this.labelShifts.TabIndex = 2;
            this.labelShifts.Text = "Shifts";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(191, 38);
            this.shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(92, 20);
            this.shifts.TabIndex = 3;
            this.shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAssignThisJobToABee
            // 
            this.buttonAssignThisJobToABee.Location = new System.Drawing.Point(7, 65);
            this.buttonAssignThisJobToABee.Name = "buttonAssignThisJobToABee";
            this.buttonAssignThisJobToABee.Size = new System.Drawing.Size(276, 23);
            this.buttonAssignThisJobToABee.TabIndex = 4;
            this.buttonAssignThisJobToABee.Text = "Assign this job to a bee";
            this.buttonAssignThisJobToABee.UseVisualStyleBackColor = true;
            this.buttonAssignThisJobToABee.Click += new System.EventHandler(this.buttonAssignThisJobToABee_Click);
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.report);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelText.Location = new System.Drawing.Point(0, 109);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(504, 332);
            this.panelText.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxWorkerBeeAssigment);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 106);
            this.panel1.TabIndex = 3;
            // 
            // report
            // 
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report.Location = new System.Drawing.Point(0, 0);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(504, 332);
            this.report.TabIndex = 0;
            // 
            // FormBeehiveManagmentSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelText);
            this.MinimumSize = new System.Drawing.Size(520, 480);
            this.Name = "FormBeehiveManagmentSystem";
            this.Text = "Beehive Management System";
            this.groupBoxWorkerBeeAssigment.ResumeLayout(false);
            this.groupBoxWorkerBeeAssigment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWorkerBeeAssigment;
        private System.Windows.Forms.Button buttonAssignThisJobToABee;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label labelShifts;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox report;
    }
}

