namespace Tyuiu.VorobevAD.SprintReview.Task7.V4.App
{
    partial class BooksForm
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
            dataGridViewBooks_VAD = new DataGridView();
            buttonAdd_VAD = new Button();
            buttonDelete_VAD = new Button();
            buttonSave_VAD = new Button();
            buttonFind_VAD = new Button();
            textBoxFindValue_VAD = new TextBox();
            buttonMinPrice = new Button();
            buttonMaxPrice_VAD = new Button();
            buttonSumPrice_VAD = new Button();
            textBoxResult_VAD = new TextBox();
            label1 = new Label();
            buttonImportCSV_VAD = new Button();
            buttonMiddlePrice_VAD = new Button();
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
            // dataGridViewBooks_VAD
            // 
            dataGridViewBooks_VAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks_VAD.Location = new Point(89, 12);
            dataGridViewBooks_VAD.Name = "dataGridViewBooks_VAD";
            dataGridViewBooks_VAD.RowHeadersWidth = 51;
            dataGridViewBooks_VAD.Size = new Size(989, 356);
            dataGridViewBooks_VAD.TabIndex = 1;
            dataGridViewBooks_VAD.CellContentClick += dataGridViewBooks_VAD_CellContentClick;
            // 
            // buttonAdd_VAD
            // 
            buttonAdd_VAD.Location = new Point(89, 409);
            buttonAdd_VAD.Name = "buttonAdd_VAD";
            buttonAdd_VAD.Size = new Size(124, 29);
            buttonAdd_VAD.TabIndex = 2;
            buttonAdd_VAD.Text = "Добавить";
            buttonAdd_VAD.UseVisualStyleBackColor = true;
            buttonAdd_VAD.Click += buttonAdd_VAD_Click;
            // 
            // buttonDelete_VAD
            // 
            buttonDelete_VAD.Location = new Point(219, 409);
            buttonDelete_VAD.Name = "buttonDelete_VAD";
            buttonDelete_VAD.Size = new Size(94, 29);
            buttonDelete_VAD.TabIndex = 3;
            buttonDelete_VAD.Text = "Удалить стр.";
            buttonDelete_VAD.UseVisualStyleBackColor = true;
            buttonDelete_VAD.Click += buttonDelete_VAD_Click;
            // 
            // buttonSave_VAD
            // 
            buttonSave_VAD.Location = new Point(319, 409);
            buttonSave_VAD.Name = "buttonSave_VAD";
            buttonSave_VAD.Size = new Size(94, 29);
            buttonSave_VAD.TabIndex = 4;
            buttonSave_VAD.Text = "Сохранить";
            buttonSave_VAD.UseVisualStyleBackColor = true;
            buttonSave_VAD.Click += buttonSave_VAD_Click;
            // 
            // buttonFind_VAD
            // 
            buttonFind_VAD.Location = new Point(319, 496);
            buttonFind_VAD.Name = "buttonFind_VAD";
            buttonFind_VAD.Size = new Size(94, 29);
            buttonFind_VAD.TabIndex = 5;
            buttonFind_VAD.Text = "Найти";
            buttonFind_VAD.UseVisualStyleBackColor = true;
            buttonFind_VAD.Click += buttonFind_VAD_Click;
            // 
            // textBoxFindValue_VAD
            // 
            textBoxFindValue_VAD.Location = new Point(89, 497);
            textBoxFindValue_VAD.Name = "textBoxFindValue_VAD";
            textBoxFindValue_VAD.Size = new Size(224, 27);
            textBoxFindValue_VAD.TabIndex = 6;
            // 
            // buttonMinPrice
            // 
            buttonMinPrice.Location = new Point(971, 409);
            buttonMinPrice.Name = "buttonMinPrice";
            buttonMinPrice.Size = new Size(107, 29);
            buttonMinPrice.TabIndex = 7;
            buttonMinPrice.Text = "Мин. Цена";
            buttonMinPrice.UseVisualStyleBackColor = true;
            buttonMinPrice.Click += buttonMinPrice_Click;
            // 
            // buttonMaxPrice_VAD
            // 
            buttonMaxPrice_VAD.Location = new Point(871, 453);
            buttonMaxPrice_VAD.Name = "buttonMaxPrice_VAD";
            buttonMaxPrice_VAD.Size = new Size(94, 29);
            buttonMaxPrice_VAD.TabIndex = 9;
            buttonMaxPrice_VAD.Text = "Макс. цена";
            buttonMaxPrice_VAD.UseVisualStyleBackColor = true;
            buttonMaxPrice_VAD.Click += buttonMaxPrice_VAD_Click;
            // 
            // buttonSumPrice_VAD
            // 
            buttonSumPrice_VAD.Location = new Point(971, 453);
            buttonSumPrice_VAD.Name = "buttonSumPrice_VAD";
            buttonSumPrice_VAD.Size = new Size(107, 29);
            buttonSumPrice_VAD.TabIndex = 10;
            buttonSumPrice_VAD.Text = "Общ. сумма";
            buttonSumPrice_VAD.UseVisualStyleBackColor = true;
            buttonSumPrice_VAD.Click += buttonSumPrice_VAD_Click;
            // 
            // textBoxResult_VAD
            // 
            textBoxResult_VAD.Location = new Point(871, 497);
            textBoxResult_VAD.Name = "textBoxResult_VAD";
            textBoxResult_VAD.ReadOnly = true;
            textBoxResult_VAD.Size = new Size(207, 27);
            textBoxResult_VAD.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 453);
            label1.Name = "label1";
            label1.Size = new Size(327, 20);
            label1.TabIndex = 12;
            label1.Text = "_____________________________________________________";
            label1.Click += label1_Click;
            // 
            // buttonImportCSV_VAD
            // 
            buttonImportCSV_VAD.Location = new Point(12, 603);
            buttonImportCSV_VAD.Name = "buttonImportCSV_VAD";
            buttonImportCSV_VAD.Size = new Size(124, 29);
            buttonImportCSV_VAD.TabIndex = 13;
            buttonImportCSV_VAD.Text = "Добавить";
            buttonImportCSV_VAD.UseVisualStyleBackColor = true;
            buttonImportCSV_VAD.Visible = false;
            buttonImportCSV_VAD.Click += buttonImportCSV_VAD_Click;
            // 
            // buttonMiddlePrice_VAD
            // 
            buttonMiddlePrice_VAD.Location = new Point(871, 409);
            buttonMiddlePrice_VAD.Name = "buttonMiddlePrice_VAD";
            buttonMiddlePrice_VAD.Size = new Size(94, 29);
            buttonMiddlePrice_VAD.TabIndex = 8;
            buttonMiddlePrice_VAD.Text = "Сред. Цена";
            buttonMiddlePrice_VAD.UseVisualStyleBackColor = true;
            buttonMiddlePrice_VAD.Click += buttonMiddlePrice_VAD_Click;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(buttonImportCSV_VAD);
            Controls.Add(label1);
            Controls.Add(textBoxResult_VAD);
            Controls.Add(buttonSumPrice_VAD);
            Controls.Add(buttonMaxPrice_VAD);
            Controls.Add(buttonMiddlePrice_VAD);
            Controls.Add(buttonMinPrice);
            Controls.Add(textBoxFindValue_VAD);
            Controls.Add(buttonFind_VAD);
            Controls.Add(buttonSave_VAD);
            Controls.Add(buttonDelete_VAD);
            Controls.Add(buttonAdd_VAD);
            Controls.Add(dataGridViewBooks_VAD);
            Controls.Add(buttonReturnMain_VAD);
            Name = "BooksForm";
            Text = "BooksForm";
            Load += BooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks_VAD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturnMain_VAD;
        private DataGridView dataGridViewBooks_VAD;
        private Button buttonAdd_VAD;
        private Button buttonDelete_VAD;
        private Button buttonSave_VAD;
        private Button buttonFind_VAD;
        private TextBox textBoxFindValue_VAD;
        private Button buttonMinPrice;
        private Button buttonMaxPrice_VAD;
        private Button buttonSumPrice_VAD;
        private TextBox textBoxResult_VAD;
        private Label label1;
        private Button buttonImportCSV_VAD;
        private Button buttonMiddlePrice_VAD;
    }
}