﻿namespace CDental
{
    partial class frmHistorial
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
            this.SP_RPT_HISTORIAL_DENTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CDentalRPTHistorialDental = new CDental.CDentalRPTHistorialDental();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_RPT_HISTORIAL_DENTALTableAdapter = new CDental.CDentalRPTHistorialDentalTableAdapters.SP_RPT_HISTORIAL_DENTALTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RPT_HISTORIAL_DENTALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDentalRPTHistorialDental)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_RPT_HISTORIAL_DENTALBindingSource
            // 
            this.SP_RPT_HISTORIAL_DENTALBindingSource.DataMember = "SP_RPT_HISTORIAL_DENTAL";
            this.SP_RPT_HISTORIAL_DENTALBindingSource.DataSource = this.CDentalRPTHistorialDental;
            // 
            // CDentalRPTHistorialDental
            // 
            this.CDentalRPTHistorialDental.DataSetName = "CDentalRPTHistorialDental";
            this.CDentalRPTHistorialDental.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsHistorialDental";
            reportDataSource1.Value = this.SP_RPT_HISTORIAL_DENTALBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CDental.Reportes.rptHistorialDental.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(853, 565);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_RPT_HISTORIAL_DENTALTableAdapter
            // 
            this.SP_RPT_HISTORIAL_DENTALTableAdapter.ClearBeforeFill = true;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 565);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmHistorial";
            this.Text = "Historial Dental";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_RPT_HISTORIAL_DENTALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDentalRPTHistorialDental)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_RPT_HISTORIAL_DENTALBindingSource;
        private CDentalRPTHistorialDental CDentalRPTHistorialDental;
        private CDentalRPTHistorialDentalTableAdapters.SP_RPT_HISTORIAL_DENTALTableAdapter SP_RPT_HISTORIAL_DENTALTableAdapter;
    }
}