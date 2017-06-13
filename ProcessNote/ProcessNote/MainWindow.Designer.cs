namespace ProcessNote
{
    partial class MainWindow
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
            this.processGrid = new System.Windows.Forms.DataGridView();
            this.procId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.saveComment = new System.Windows.Forms.Button();
            this.mem = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.labelMem = new System.Windows.Forms.Label();
            this.labelCpu = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.elapsedTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.processGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // processGrid
            // 
            this.processGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procId,
            this.procName});
            this.processGrid.Location = new System.Drawing.Point(12, 12);
            this.processGrid.Name = "processGrid";
            this.processGrid.Size = new System.Drawing.Size(250, 297);
            this.processGrid.TabIndex = 1;
            this.processGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processGrid_CellClick);
            // 
            // procId
            // 
            this.procId.HeaderText = "Process ID";
            this.procId.Name = "procId";
            // 
            // procName
            // 
            this.procName.HeaderText = "Process Name";
            this.procName.Name = "procName";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(268, 12);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(322, 70);
            this.textBoxComment.TabIndex = 2;
            // 
            // saveComment
            // 
            this.saveComment.Location = new System.Drawing.Point(514, 89);
            this.saveComment.Name = "saveComment";
            this.saveComment.Size = new System.Drawing.Size(75, 23);
            this.saveComment.TabIndex = 3;
            this.saveComment.Text = "Save Comment";
            this.saveComment.UseVisualStyleBackColor = true;
            this.saveComment.Click += new System.EventHandler(this.saveComment_Click);
            // 
            // mem
            // 
            this.mem.AutoSize = true;
            this.mem.Location = new System.Drawing.Point(315, 171);
            this.mem.Name = "mem";
            this.mem.Size = new System.Drawing.Size(35, 13);
            this.mem.TabIndex = 4;
            this.mem.Text = "label1";
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Location = new System.Drawing.Point(412, 171);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(35, 13);
            this.cpu.TabIndex = 5;
            this.cpu.Text = "label2";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(511, 171);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(35, 13);
            this.startTime.TabIndex = 6;
            this.startTime.Text = "label3";
            // 
            // labelMem
            // 
            this.labelMem.AutoSize = true;
            this.labelMem.Location = new System.Drawing.Point(315, 138);
            this.labelMem.Name = "labelMem";
            this.labelMem.Size = new System.Drawing.Size(81, 13);
            this.labelMem.TabIndex = 7;
            this.labelMem.Text = "Memory Usage:";
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.Location = new System.Drawing.Point(412, 138);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(32, 13);
            this.labelCpu.TabIndex = 8;
            this.labelCpu.Text = "CPU:";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(511, 138);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(58, 13);
            this.labelStartTime.TabIndex = 9;
            this.labelStartTime.Text = "Start Time:";
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.AutoSize = true;
            this.labelElapsedTime.Location = new System.Drawing.Point(315, 224);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(74, 13);
            this.labelElapsedTime.TabIndex = 10;
            this.labelElapsedTime.Text = "Elapsed Time:";
            // 
            // elapsedTime
            // 
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.Location = new System.Drawing.Point(315, 264);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(35, 13);
            this.elapsedTime.TabIndex = 11;
            this.elapsedTime.Text = "label2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 321);
            this.Controls.Add(this.elapsedTime);
            this.Controls.Add(this.labelElapsedTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelCpu);
            this.Controls.Add(this.labelMem);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.mem);
            this.Controls.Add(this.saveComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.processGrid);
            this.Name = "MainWindow";
            this.Text = "ProcessNote 2000";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView processGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn procId;
        private System.Windows.Forms.DataGridViewTextBoxColumn procName;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button saveComment;
        private System.Windows.Forms.Label mem;
        private System.Windows.Forms.Label cpu;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label labelMem;
        private System.Windows.Forms.Label labelCpu;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.Label elapsedTime;
    }
}

