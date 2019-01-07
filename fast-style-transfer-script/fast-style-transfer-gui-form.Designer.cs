namespace fast_style_transfer_script
{
    partial class fast_style_transfer_gui_form
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
            this.pythonExecutableTextbox = new System.Windows.Forms.TextBox();
            this.fileDialogPythonBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileDialogRunSequenceBtn = new System.Windows.Forms.Button();
            this.run_sequenceTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputFolderDialogBtn = new System.Windows.Forms.Button();
            this.inputFolderTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.styleModelBtn = new System.Windows.Forms.Button();
            this.styleModelTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outputFolderDialogBtn = new System.Windows.Forms.Button();
            this.outputFolderTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.renderBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.jpegSequenceFilename = new System.Windows.Forms.TextBox();
            this.import2ProjectMediaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pythonExecutableTextbox
            // 
            this.pythonExecutableTextbox.Location = new System.Drawing.Point(130, 76);
            this.pythonExecutableTextbox.Name = "pythonExecutableTextbox";
            this.pythonExecutableTextbox.Size = new System.Drawing.Size(229, 20);
            this.pythonExecutableTextbox.TabIndex = 0;
            this.pythonExecutableTextbox.TextChanged += new System.EventHandler(this.pythonExecutableTextbox_TextChanged);
            // 
            // fileDialogPythonBtn
            // 
            this.fileDialogPythonBtn.Location = new System.Drawing.Point(365, 77);
            this.fileDialogPythonBtn.Name = "fileDialogPythonBtn";
            this.fileDialogPythonBtn.Size = new System.Drawing.Size(24, 19);
            this.fileDialogPythonBtn.TabIndex = 1;
            this.fileDialogPythonBtn.Text = "...";
            this.fileDialogPythonBtn.UseVisualStyleBackColor = true;
            this.fileDialogPythonBtn.Click += new System.EventHandler(this.fileDialogPythonBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Python 3 Executable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "run_sequence.py:";
            // 
            // fileDialogRunSequenceBtn
            // 
            this.fileDialogRunSequenceBtn.Location = new System.Drawing.Point(365, 103);
            this.fileDialogRunSequenceBtn.Name = "fileDialogRunSequenceBtn";
            this.fileDialogRunSequenceBtn.Size = new System.Drawing.Size(24, 19);
            this.fileDialogRunSequenceBtn.TabIndex = 4;
            this.fileDialogRunSequenceBtn.Text = "...";
            this.fileDialogRunSequenceBtn.UseVisualStyleBackColor = true;
            this.fileDialogRunSequenceBtn.Click += new System.EventHandler(this.fileDialogRunSequenceBtn_Click);
            // 
            // run_sequenceTextbox
            // 
            this.run_sequenceTextbox.Location = new System.Drawing.Point(130, 102);
            this.run_sequenceTextbox.Name = "run_sequenceTextbox";
            this.run_sequenceTextbox.Size = new System.Drawing.Size(229, 20);
            this.run_sequenceTextbox.TabIndex = 3;
            this.run_sequenceTextbox.TextChanged += new System.EventHandler(this.run_sequenceTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input folder:";
            // 
            // inputFolderDialogBtn
            // 
            this.inputFolderDialogBtn.Location = new System.Drawing.Point(365, 129);
            this.inputFolderDialogBtn.Name = "inputFolderDialogBtn";
            this.inputFolderDialogBtn.Size = new System.Drawing.Size(24, 19);
            this.inputFolderDialogBtn.TabIndex = 7;
            this.inputFolderDialogBtn.Text = "...";
            this.inputFolderDialogBtn.UseVisualStyleBackColor = true;
            this.inputFolderDialogBtn.Click += new System.EventHandler(this.inputFolderDialogBtn_Click);
            // 
            // inputFolderTextbox
            // 
            this.inputFolderTextbox.Location = new System.Drawing.Point(130, 128);
            this.inputFolderTextbox.Name = "inputFolderTextbox";
            this.inputFolderTextbox.Size = new System.Drawing.Size(229, 20);
            this.inputFolderTextbox.TabIndex = 6;
            this.inputFolderTextbox.TextChanged += new System.EventHandler(this.inputFolderTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Style model:";
            // 
            // styleModelBtn
            // 
            this.styleModelBtn.Location = new System.Drawing.Point(365, 155);
            this.styleModelBtn.Name = "styleModelBtn";
            this.styleModelBtn.Size = new System.Drawing.Size(24, 19);
            this.styleModelBtn.TabIndex = 10;
            this.styleModelBtn.Text = "...";
            this.styleModelBtn.UseVisualStyleBackColor = true;
            this.styleModelBtn.Click += new System.EventHandler(this.styleModelBtn_Click);
            // 
            // styleModelTextbox
            // 
            this.styleModelTextbox.Location = new System.Drawing.Point(130, 154);
            this.styleModelTextbox.Name = "styleModelTextbox";
            this.styleModelTextbox.Size = new System.Drawing.Size(229, 20);
            this.styleModelTextbox.TabIndex = 9;
            this.styleModelTextbox.TextChanged += new System.EventHandler(this.styleModelTextbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Output folder:";
            // 
            // outputFolderDialogBtn
            // 
            this.outputFolderDialogBtn.Location = new System.Drawing.Point(365, 181);
            this.outputFolderDialogBtn.Name = "outputFolderDialogBtn";
            this.outputFolderDialogBtn.Size = new System.Drawing.Size(24, 19);
            this.outputFolderDialogBtn.TabIndex = 13;
            this.outputFolderDialogBtn.Text = "...";
            this.outputFolderDialogBtn.UseVisualStyleBackColor = true;
            this.outputFolderDialogBtn.Click += new System.EventHandler(this.outputFolderDialogBtn_Click);
            // 
            // outputFolderTextbox
            // 
            this.outputFolderTextbox.Location = new System.Drawing.Point(130, 180);
            this.outputFolderTextbox.Name = "outputFolderTextbox";
            this.outputFolderTextbox.Size = new System.Drawing.Size(229, 20);
            this.outputFolderTextbox.TabIndex = 12;
            this.outputFolderTextbox.TextChanged += new System.EventHandler(this.outputFolderTextbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Run style-transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // renderBtn
            // 
            this.renderBtn.Location = new System.Drawing.Point(281, 35);
            this.renderBtn.Name = "renderBtn";
            this.renderBtn.Size = new System.Drawing.Size(108, 26);
            this.renderBtn.TabIndex = 16;
            this.renderBtn.Text = "Render selected";
            this.renderBtn.UseVisualStyleBackColor = true;
            this.renderBtn.Click += new System.EventHandler(this.renderBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "JPEG sequence name:";
            // 
            // jpegSequenceFilename
            // 
            this.jpegSequenceFilename.Location = new System.Drawing.Point(165, 6);
            this.jpegSequenceFilename.Name = "jpegSequenceFilename";
            this.jpegSequenceFilename.Size = new System.Drawing.Size(224, 20);
            this.jpegSequenceFilename.TabIndex = 18;
            // 
            // import2ProjectMediaBtn
            // 
            this.import2ProjectMediaBtn.Location = new System.Drawing.Point(130, 223);
            this.import2ProjectMediaBtn.Name = "import2ProjectMediaBtn";
            this.import2ProjectMediaBtn.Size = new System.Drawing.Size(259, 26);
            this.import2ProjectMediaBtn.TabIndex = 19;
            this.import2ProjectMediaBtn.Text = "Import output sequence to Project Media";
            this.import2ProjectMediaBtn.UseVisualStyleBackColor = true;
            this.import2ProjectMediaBtn.Click += new System.EventHandler(this.import2ProjectMediaBtn_Click);
            // 
            // fast_style_transfer_gui_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 308);
            this.Controls.Add(this.import2ProjectMediaBtn);
            this.Controls.Add(this.jpegSequenceFilename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.renderBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputFolderDialogBtn);
            this.Controls.Add(this.outputFolderTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.styleModelBtn);
            this.Controls.Add(this.styleModelTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputFolderDialogBtn);
            this.Controls.Add(this.inputFolderTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileDialogRunSequenceBtn);
            this.Controls.Add(this.run_sequenceTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileDialogPythonBtn);
            this.Controls.Add(this.pythonExecutableTextbox);
            this.Name = "fast_style_transfer_gui_form";
            this.Text = "fast-style-transfer GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pythonExecutableTextbox;
        private System.Windows.Forms.Button fileDialogPythonBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fileDialogRunSequenceBtn;
        private System.Windows.Forms.TextBox run_sequenceTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inputFolderDialogBtn;
        private System.Windows.Forms.TextBox inputFolderTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button styleModelBtn;
        private System.Windows.Forms.TextBox styleModelTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button outputFolderDialogBtn;
        private System.Windows.Forms.TextBox outputFolderTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button renderBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox jpegSequenceFilename;
        private System.Windows.Forms.Button import2ProjectMediaBtn;
    }
}