namespace FrontEnd
{
    partial class RateFormcs
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
            this.rateButton2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listaRate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rateButton2
            // 
            this.rateButton2.Location = new System.Drawing.Point(89, 35);
            this.rateButton2.Name = "rateButton2";
            this.rateButton2.Size = new System.Drawing.Size(62, 26);
            this.rateButton2.TabIndex = 0;
            this.rateButton2.Text = "RATE";
            this.rateButton2.UseVisualStyleBackColor = true;
            this.rateButton2.Click += new System.EventHandler(this.rateButton2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listaRate
            // 
            this.listaRate.FormattingEnabled = true;
            this.listaRate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listaRate.Location = new System.Drawing.Point(12, 12);
            this.listaRate.Name = "listaRate";
            this.listaRate.Size = new System.Drawing.Size(62, 69);
            this.listaRate.TabIndex = 2;
            this.listaRate.SelectedIndexChanged += new System.EventHandler(this.listaRate_SelectedIndexChanged);
            // 
            // RateFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 89);
            this.Controls.Add(this.listaRate);
            this.Controls.Add(this.rateButton2);
            this.Name = "RateFormcs";
            this.Text = "RateFormcs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rate_Close);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rateButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listaRate;
    }
}