using System;
using System.Diagnostics;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;

namespace fast_style_transfer_script
{
    public partial class fast_style_transfer_gui_form : Form
    {
        public fast_style_transfer_gui_form()
        {
            InitializeComponent();
            pythonExecutableTextbox.Text = pythonExecutablePath = Application.UserAppDataRegistry.GetValue("fast_style_transfer_gui_pythonExecutablePath", "").ToString();
            run_sequenceTextbox.Text = runSequencePath = Application.UserAppDataRegistry.GetValue("fast_style_transfer_gui_runSequencePath", "").ToString();
            inputFolderTextbox.Text = inputFolder = Application.UserAppDataRegistry.GetValue("fast_style_transfer_gui_inputFolder", "").ToString();
            styleModelTextbox.Text = styleModelPath = Application.UserAppDataRegistry.GetValue("fast_style_transfer_gui_styleModelPath", "").ToString();
            outputFolderTextbox.Text = outputFolder = Application.UserAppDataRegistry.GetValue("fast_style_transfer_gui_outputFolder", "").ToString();
        }

        string pythonExecutablePath;
        string runSequencePath;
        string inputFolder;
        string styleModelPath;
        string outputFolder;

        private void fileDialogPythonBtn_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "|*.exe";
            string startDir = System.IO.Path.GetDirectoryName(pythonExecutablePath);
            if (System.IO.Directory.Exists(startDir)) ofd.InitialDirectory = startDir;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pythonExecutableTextbox.Text = ofd.FileName;
                pythonExecutablePath = pythonExecutableTextbox.Text;
                Application.UserAppDataRegistry.SetValue("fast_style_transfer_gui_pythonExecutablePath", pythonExecutablePath);
            }
        }

        private void pythonExecutableTextbox_TextChanged(object sender, System.EventArgs e)
        {
            pythonExecutablePath = pythonExecutableTextbox.Text;
            Application.UserAppDataRegistry.SetValue("fast_style_transfer_gui_pythonExecutablePath", pythonExecutablePath);
        }

        private void fileDialogRunSequenceBtn_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "|*.py";
            string startDir = System.IO.Path.GetDirectoryName(runSequencePath);
            if (System.IO.Directory.Exists(startDir)) ofd.InitialDirectory = startDir;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                run_sequenceTextbox.Text = ofd.FileName;
                runSequencePath = run_sequenceTextbox.Text;
                Application.UserAppDataRegistry.SetValue("fast_style_transfer_gui_runSequencePath", runSequencePath);
            }
        }

        private void run_sequenceTextbox_TextChanged(object sender, System.EventArgs e)
        {
            runSequencePath = run_sequenceTextbox.Text;
            Application.UserAppDataRegistry.SetValue("fast_style_transfer_gui_runSequencePath", runSequencePath);
        }

        private void inputFolderDialogBtn_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (System.IO.Directory.Exists(inputFolder)) fbd.SelectedPath = inputFolder;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                inputFolder = inputFolderTextbox.Text = fbd.SelectedPath;
                Application.UserAppDataRegistry.SetValue("fast_style_transfer_gui_inputFolder", inputFolder);
            }
        }

        private void inputFolderTextbox_TextChanged(object sender, System.EventArgs e)
        {
            inputFolder = inputFolderTextbox.Text;
            Application.UserAppDataRegistry.SetValue("fast_style_transfer_gui_inputFolder", inputFolder);
        }

        private void styleModelBtn_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string startDir = System.IO.Path.GetDirectoryName(styleModelPath);
            if (System.IO.Directory.Exists(startDir)) ofd.InitialDirectory = startDir;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                styleModelTextbox.Text = ofd.FileName;
                if (styleModelTextbox.Text.EndsWith(".index"))
                {
                    styleModelTextbox.Text = styleModelTextbox.Text.Remove(styleModelTextbox.Text.Length - 6);
                }
                else if (styleModelTextbox.Text.EndsWith(".data-00000-of-00001"))
                {
                    styleModelTextbox.Text = styleModelTextbox.Text.Remove(styleModelTextbox.Text.Length - 20);
                }
                else if (styleModelTextbox.Text.EndsWith(".meta"))
                {
                    styleModelTextbox.Text = styleModelTextbox.Text.Remove(styleModelTextbox.Text.Length - 5);
                }

                styleModelPath = styleModelTextbox.Text;
                Application.UserAppDataRegistry.SetValue("fast_style_transfer_gui_styleModelPath", styleModelPath);
            }
        }

        private void styleModelTextbox_TextChanged(object sender, System.EventArgs e)
        {
            if (styleModelTextbox.Text.EndsWith(".index"))
            {
                styleModelTextbox.Text = styleModelTextbox.Text.Remove(styleModelTextbox.Text.Length - 6);
            }
            else if (styleModelTextbox.Text.EndsWith(".data-00000-of-00001"))
            {
                styleModelTextbox.Text = styleModelTextbox.Text.Remove(styleModelTextbox.Text.Length - 20);
            }
            else if (styleModelTextbox.Text.EndsWith(".meta"))
            {
                styleModelTextbox.Text = styleModelTextbox.Text.Remove(styleModelTextbox.Text.Length - 5);
            }

            styleModelPath = styleModelTextbox.Text;
            Application.UserAppDataRegistry.SetValue("fast_style_transfer_gui_styleModelPath", styleModelPath);
        }

        private void outputFolderDialogBtn_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (System.IO.Directory.Exists(outputFolder)) fbd.SelectedPath = outputFolder;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                outputFolder = outputFolderTextbox.Text = fbd.SelectedPath;
                Application.UserAppDataRegistry.SetValue("fast_style_transfer_gui_outputFolder", outputFolder);
            }
        }

        private void outputFolderTextbox_TextChanged(object sender, System.EventArgs e)
        {
            outputFolder = outputFolderTextbox.Text;
            Application.UserAppDataRegistry.SetValue("fast_style_transfer_gui_outputFolder", outputFolder);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            executeRunSequence();
        }

        bool executeRunSequence()
        {
            //if (inputFolder == outputFolder)
            //{
            //    MessageBox.Show("Input and output folders must be different!");
            //    return false;
            //}

            Process process = new Process();
            process.StartInfo.FileName = pythonExecutablePath;
            process.StartInfo.Arguments = "\"" + runSequencePath + "\" --content \"" + inputFolder + "\" --style_model \"" + styleModelPath + "\" --output \"" + outputFolder + "\"";
            process.Start();
            return true;
        }
    }
}
