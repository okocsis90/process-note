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
            this.processGrid.Size = new System.Drawing.Size(260, 200);
            this.processGrid.TabIndex = 1;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.processGrid);
            this.Name = "MainWindow";
            this.Text = "ProcessNote 2000";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView processGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn procId;
        private System.Windows.Forms.DataGridViewTextBoxColumn procName;
    }
}

