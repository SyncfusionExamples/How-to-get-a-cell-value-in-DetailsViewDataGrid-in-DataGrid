#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace DetailsView
{
    partial class Form1
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
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnGetCellValue = new System.Windows.Forms.Button();
            this.txtGetCellValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.Location = new System.Drawing.Point(12, 12);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.RowHeight = 21;
            this.sfDataGrid1.Size = new System.Drawing.Size(601, 496);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // btnGetCellValue
            // 
            this.btnGetCellValue.Location = new System.Drawing.Point(621, 115);
            this.btnGetCellValue.Name = "btnGetCellValue";
            this.btnGetCellValue.Size = new System.Drawing.Size(75, 23);
            this.btnGetCellValue.TabIndex = 4;
            this.btnGetCellValue.Text = "CellValue";
            this.btnGetCellValue.UseVisualStyleBackColor = true;
            // 
            // txtGetCellValue
            // 
            this.txtGetCellValue.Location = new System.Drawing.Point(620, 71);
            this.txtGetCellValue.Name = "txtGetCellValue";
            this.txtGetCellValue.Size = new System.Drawing.Size(100, 20);
            this.txtGetCellValue.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 520);
            this.Controls.Add(this.btnGetCellValue);
            this.Controls.Add(this.txtGetCellValue);
            this.Controls.Add(this.sfDataGrid1);
            this.Name = "Form1";
            this.Text = "Master Details View";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Button btnGetCellValue;
        private System.Windows.Forms.TextBox txtGetCellValue;
    }
}

