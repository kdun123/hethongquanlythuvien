namespace bansach
{
    partial class FormThongke
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Thongke = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bansachDataSet5 = new bansach.bansachDataSet5();
            this.sach2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sach2TableAdapter = new bansach.bansachDataSet5TableAdapters.sach2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sach2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Thongke
            // 
            this.Thongke.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Thongke";
            reportDataSource1.Value = this.sach2BindingSource;
            this.Thongke.LocalReport.DataSources.Add(reportDataSource1);
            this.Thongke.LocalReport.ReportEmbeddedResource = "bansach.thongke.rdlc";
            this.Thongke.Location = new System.Drawing.Point(0, 0);
            this.Thongke.Name = "Thongke";
            this.Thongke.ServerReport.BearerToken = null;
            this.Thongke.Size = new System.Drawing.Size(800, 450);
            this.Thongke.TabIndex = 0;
            this.Thongke.Load += new System.EventHandler(this.Thongke_Load);
            // 
            // bansachDataSet5
            // 
            this.bansachDataSet5.DataSetName = "bansachDataSet5";
            this.bansachDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sach2BindingSource
            // 
            this.sach2BindingSource.DataMember = "sach2";
            this.sach2BindingSource.DataSource = this.bansachDataSet5;
            // 
            // sach2TableAdapter
            // 
            this.sach2TableAdapter.ClearBeforeFill = true;
            // 
            // FormThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Thongke);
            this.Name = "FormThongke";
            this.Text = "FormThongke";
            this.Load += new System.EventHandler(this.FormThongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sach2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Thongke;
        private bansachDataSet5 bansachDataSet5;
        private System.Windows.Forms.BindingSource sach2BindingSource;
        private bansachDataSet5TableAdapters.sach2TableAdapter sach2TableAdapter;
    }
}