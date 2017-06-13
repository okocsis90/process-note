using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProcessNote
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Process[] allProcess;
        private List<String> comments = new List<string>();

        private void GetAllProcess()
        {
            allProcess = Process.GetProcesses();
            processGrid.Rows.Clear();
            foreach (var p in allProcess)
            {
                processGrid.Rows.Add(p.Id, p.ProcessName);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void SetTimes(Process clickedProcess)
        {
            try
            {
                startTime.Text = clickedProcess.StartTime.ToString();
                elapsedTime.Text = (DateTime.UtcNow - clickedProcess.StartTime.ToUniversalTime()).ToString();
            }
            catch (Win32Exception exception)
            {
                startTime.Text = "N/A";
                elapsedTime.Text = "N/A";
            }
        }

        private void SetCpuInfo(string procName)
        {
            PerformanceCounter currentAppCPU = new PerformanceCounter("Process", "ID Process", procName, true);
            cpu.Text = (currentAppCPU.NextValue() / Environment.ProcessorCount).ToString();
        }


        private void processGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Initialize info for current Process
            DataGridView dataGridView = sender as DataGridView;
            int indexOfCurrentRow = dataGridView.CurrentRow.Index;
            int clickedProcessId = (int) dataGridView.Rows[indexOfCurrentRow].Cells["procId"].Value;
            Process clickedProcess = Process.GetProcessById(clickedProcessId);

            // Change Label fields for every Data
            mem.Text = clickedProcess.WorkingSet64.ToString();
            SetCpuInfo(clickedProcess.ProcessName);
            SetTimes(clickedProcess);
        }

        private void saveComment_Click(object sender, EventArgs e)
        {
            int indexOfCurrentRow = processGrid.CurrentRow.Index;
            int processId = (int) processGrid.Rows[indexOfCurrentRow].Cells["procId"].Value;

            StringBuilder commentStr = new StringBuilder();
            commentStr.Append("Comment: " + textBoxComment.Text);
            commentStr.Append("; Process Id: " + processId);
            comments.Add(commentStr.ToString());
            commentGrid.Rows.Add(processId, textBoxComment.Text);
            textBoxComment.Clear();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBoxComment.Text.Length > 0)
            {
                MessageBox.Show("Please save before Exit!");
                e.Cancel = true;
            }

        }

        private void onTop_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            TopMost = false;
        }
    }
}
