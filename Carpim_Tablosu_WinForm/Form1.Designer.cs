namespace Carpim_Tablosu_WinForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvCarpim = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCarpim).BeginInit();
            SuspendLayout();
            // 
            // dgvCarpim
            // 
            dgvCarpim.AllowUserToAddRows = false;
            dgvCarpim.AllowUserToDeleteRows = false;
            dgvCarpim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarpim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarpim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarpim.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvCarpim.Location = new Point(56, 42);
            dgvCarpim.Name = "dgvCarpim";
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCarpim.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarpim.RowTemplate.Height = 50;
            dgvCarpim.Size = new Size(689, 293);
            dgvCarpim.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "5";
            Column5.Name = "Column5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(dgvCarpim);
            Name = "Form1";
            Text = "Carpim Tablosu";
            ((System.ComponentModel.ISupportInitialize)dgvCarpim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCarpim;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}