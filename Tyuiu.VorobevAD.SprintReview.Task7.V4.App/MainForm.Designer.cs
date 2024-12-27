namespace Tyuiu.VorobevAD.SprintReview.Task7.V4.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOpenBooks_VAD = new Button();
            buttonOpenReaders_VAD = new Button();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            buttonOpenInfo_VAD = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenBooks_VAD
            // 
            buttonOpenBooks_VAD.Location = new Point(63, 23);
            buttonOpenBooks_VAD.Name = "buttonOpenBooks_VAD";
            buttonOpenBooks_VAD.Size = new Size(200, 156);
            buttonOpenBooks_VAD.TabIndex = 0;
            buttonOpenBooks_VAD.Text = "Книги";
            buttonOpenBooks_VAD.UseVisualStyleBackColor = true;
            buttonOpenBooks_VAD.Click += buttonOpenBooks_VAD_Click;
            // 
            // buttonOpenReaders_VAD
            // 
            buttonOpenReaders_VAD.Location = new Point(53, 23);
            buttonOpenReaders_VAD.Name = "buttonOpenReaders_VAD";
            buttonOpenReaders_VAD.Size = new Size(200, 156);
            buttonOpenReaders_VAD.TabIndex = 1;
            buttonOpenReaders_VAD.Text = "Читатели";
            buttonOpenReaders_VAD.UseVisualStyleBackColor = true;
            buttonOpenReaders_VAD.Click += buttonOpenReaders_VAD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 119);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 2;
            label1.Text = "Выберете нужный вариант";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(87, 157);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonOpenReaders_VAD);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonOpenBooks_VAD);
            splitContainer1.Size = new Size(638, 210);
            splitContainer1.SplitterDistance = 312;
            splitContainer1.TabIndex = 3;
            // 
            // buttonOpenInfo_VAD
            // 
            buttonOpenInfo_VAD.Location = new Point(12, 409);
            buttonOpenInfo_VAD.Name = "buttonOpenInfo_VAD";
            buttonOpenInfo_VAD.Size = new Size(130, 29);
            buttonOpenInfo_VAD.TabIndex = 4;
            buttonOpenInfo_VAD.Text = "Информация";
            buttonOpenInfo_VAD.UseVisualStyleBackColor = true;
            buttonOpenInfo_VAD.Click += buttonOpenInfo_VAD_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOpenInfo_VAD);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenBooks_VAD;
        private Button buttonOpenReaders_VAD;
        private Label label1;
        private SplitContainer splitContainer1;
        private Button buttonOpenInfo_VAD;
    }
}
