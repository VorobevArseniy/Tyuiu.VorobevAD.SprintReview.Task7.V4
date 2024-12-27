namespace Tyuiu.VorobevAD.SprintReview.Task7.V4.App
{
    partial class ReadersForm
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
            buttonReturnMain_VAD = new Button();
            label1 = new Label();
            textBoxResult_VAD = new TextBox();
            buttonSumAmount_VAD = new Button();
            textBoxFindValue_VAD = new TextBox();
            buttonFind_VAD = new Button();
            buttonSave_VAD = new Button();
            buttonDelete_VAD = new Button();
            buttonAdd_VAD = new Button();
            dataGridViewBooks_VAD = new DataGridView();
            buttonImportCSV_VAD = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks_VAD).BeginInit();
            SuspendLayout();
            // 
            // buttonReturnMain_VAD
            // 
            buttonReturnMain_VAD.Location = new Point(12, 12);
            buttonReturnMain_VAD.Name = "buttonReturnMain_VAD";
            buttonReturnMain_VAD.Size = new Size(45, 45);
            buttonReturnMain_VAD.TabIndex = 0;
            buttonReturnMain_VAD.Text = "<--";
            buttonReturnMain_VAD.UseVisualStyleBackColor = true;
            buttonReturnMain_VAD.Click += buttonReturnMain_VAD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 453);
            label1.Name = "label1";
            label1.Size = new Size(327, 20);
            label1.TabIndex = 25;
            label1.Text = "_____________________________________________________";
            // 
            // textBoxResult_VAD
            // 
            textBoxResult_VAD.Location = new Point(865, 497);
            textBoxResult_VAD.Name = "textBoxResult_VAD";
            textBoxResult_VAD.ReadOnly = true;
            textBoxResult_VAD.Size = new Size(213, 27);
            textBoxResult_VAD.TabIndex = 24;
            // 
            // buttonSumAmount_VAD
            // 
            buttonSumAmount_VAD.Location = new Point(865, 409);
            buttonSumAmount_VAD.Name = "buttonSumAmount_VAD";
            buttonSumAmount_VAD.Size = new Size(213, 29);
            buttonSumAmount_VAD.TabIndex = 23;
            buttonSumAmount_VAD.Text = "Кол-во";
            buttonSumAmount_VAD.UseVisualStyleBackColor = true;
            buttonSumAmount_VAD.Click += buttonSumAmount_VAD_Click;
            // 
            // textBoxFindValue_VAD
            // 
            textBoxFindValue_VAD.Location = new Point(89, 497);
            textBoxFindValue_VAD.Name = "textBoxFindValue_VAD";
            textBoxFindValue_VAD.Size = new Size(224, 27);
            textBoxFindValue_VAD.TabIndex = 19;
            // 
            // buttonFind_VAD
            // 
            buttonFind_VAD.Location = new Point(319, 496);
            buttonFind_VAD.Name = "buttonFind_VAD";
            buttonFind_VAD.Size = new Size(94, 29);
            buttonFind_VAD.TabIndex = 18;
            buttonFind_VAD.Text = "Найти";
            buttonFind_VAD.UseVisualStyleBackColor = true;
            buttonFind_VAD.Click += buttonFind_VAD_Click;
            // 
            // buttonSave_VAD
            // 
            buttonSave_VAD.Location = new Point(319, 409);
            buttonSave_VAD.Name = "buttonSave_VAD";
            buttonSave_VAD.Size = new Size(94, 29);
            buttonSave_VAD.TabIndex = 17;
            buttonSave_VAD.Text = "Сохранить";
            buttonSave_VAD.UseVisualStyleBackColor = true;
            buttonSave_VAD.Click += buttonSave_VAD_Click;
            // 
            // buttonDelete_VAD
            // 
            buttonDelete_VAD.Location = new Point(219, 409);
            buttonDelete_VAD.Name = "buttonDelete_VAD";
            buttonDelete_VAD.Size = new Size(94, 29);
            buttonDelete_VAD.TabIndex = 16;
            buttonDelete_VAD.Text = "Удалить стр.";
            buttonDelete_VAD.UseVisualStyleBackColor = true;
            buttonDelete_VAD.Click += buttonDelete_VAD_Click;
            // 
            // buttonAdd_VAD
            // 
            buttonAdd_VAD.Location = new Point(89, 409);
            buttonAdd_VAD.Name = "buttonAdd_VAD";
            buttonAdd_VAD.Size = new Size(124, 29);
            buttonAdd_VAD.TabIndex = 15;
            buttonAdd_VAD.Text = "Добавить";
            buttonAdd_VAD.UseVisualStyleBackColor = true;
            buttonAdd_VAD.Click += buttonAdd_VAD_Click;
            // 
            // dataGridViewBooks_VAD
            // 
            dataGridViewBooks_VAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks_VAD.Location = new Point(89, 12);
            dataGridViewBooks_VAD.Name = "dataGridViewBooks_VAD";
            dataGridViewBooks_VAD.RowHeadersWidth = 51;
            dataGridViewBooks_VAD.Size = new Size(989, 356);
            dataGridViewBooks_VAD.TabIndex = 14;
            // 
            // buttonImportCSV_VAD
            // 
            buttonImportCSV_VAD.Location = new Point(12, 605);
            buttonImportCSV_VAD.Name = "buttonImportCSV_VAD";
            buttonImportCSV_VAD.Size = new Size(124, 29);
            buttonImportCSV_VAD.TabIndex = 26;
            buttonImportCSV_VAD.Text = "Добавить";
            buttonImportCSV_VAD.UseVisualStyleBackColor = true;
            buttonImportCSV_VAD.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(865, 453);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 27;
            label2.Text = "__________________________________";
            // 
            // ReadersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 699);
            Controls.Add(label2);
            Controls.Add(buttonImportCSV_VAD);
            Controls.Add(label1);
            Controls.Add(textBoxResult_VAD);
            Controls.Add(buttonSumAmount_VAD);
            Controls.Add(textBoxFindValue_VAD);
            Controls.Add(buttonFind_VAD);
            Controls.Add(buttonSave_VAD);
            Controls.Add(buttonDelete_VAD);
            Controls.Add(buttonAdd_VAD);
            Controls.Add(dataGridViewBooks_VAD);
            Controls.Add(buttonReturnMain_VAD);
            Name = "ReadersForm";
            Text = "ReadersForm";
            Load += ReadersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks_VAD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturnMain_VAD;
        private Label label1;
        private TextBox textBoxResult_VAD;
        private Button buttonSumAmount_VAD;
        private TextBox textBoxFindValue_VAD;
        private Button buttonFind_VAD;
        private Button buttonSave_VAD;
        private Button buttonDelete_VAD;
        private Button buttonAdd_VAD;
        private DataGridView dataGridViewBooks_VAD;
        private Button buttonImportCSV_VAD;
        private Label label2;
    }
}