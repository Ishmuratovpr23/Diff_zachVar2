namespace WinFormsApp1
{
    partial class Form1
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
            button1 = new Button();
            txtData1 = new TextBox();
            txtData2 = new TextBox();
            cmbGrouping = new ComboBox();
            dgvResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(256, 103);
            button1.Name = "button1";
            button1.Size = new Size(236, 31);
            button1.TabIndex = 0;
            button1.Text = "Выполнить групппировку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtData1
            // 
            txtData1.Location = new Point(50, 33);
            txtData1.Name = "txtData1";
            txtData1.Size = new Size(125, 27);
            txtData1.TabIndex = 1;
            // 
            // txtData2
            // 
            txtData2.Location = new Point(50, 103);
            txtData2.Name = "txtData2";
            txtData2.Size = new Size(125, 27);
            txtData2.TabIndex = 2;
            // 
            // cmbGrouping
            // 
            cmbGrouping.FormattingEnabled = true;
            cmbGrouping.Location = new Point(256, 33);
            cmbGrouping.Name = "cmbGrouping";
            cmbGrouping.Size = new Size(151, 28);
            cmbGrouping.TabIndex = 3;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(28, 180);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.RowTemplate.Height = 29;
            dgvResult.Size = new Size(718, 222);
            dgvResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResult);
            Controls.Add(cmbGrouping);
            Controls.Add(txtData2);
            Controls.Add(txtData1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtData1;
        private TextBox txtData2;
        private ComboBox cmbGrouping;
        private DataGridView dgvResult;
    }
}