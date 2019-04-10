namespace FrontEnd
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.beginDialogButton = new System.Windows.Forms.Button();
            this.endDialogButton = new System.Windows.Forms.Button();
            this.saveLogButton = new System.Windows.Forms.Button();
            this.loadLogButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(12, 12);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(473, 246);
            this.chatBox.TabIndex = 0;
            this.chatBox.Text = "";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(12, 265);
            this.userInput.Multiline = true;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(473, 32);
            this.userInput.TabIndex = 1;
            // 
            // beginDialogButton
            // 
            this.beginDialogButton.Location = new System.Drawing.Point(508, 12);
            this.beginDialogButton.Name = "beginDialogButton";
            this.beginDialogButton.Size = new System.Drawing.Size(94, 36);
            this.beginDialogButton.TabIndex = 2;
            this.beginDialogButton.Text = "beginDialog";
            this.beginDialogButton.UseVisualStyleBackColor = true;
            this.beginDialogButton.Click += new System.EventHandler(this.beginDialogButton_Click);
            // 
            // endDialogButton
            // 
            this.endDialogButton.Location = new System.Drawing.Point(508, 54);
            this.endDialogButton.Name = "endDialogButton";
            this.endDialogButton.Size = new System.Drawing.Size(94, 36);
            this.endDialogButton.TabIndex = 3;
            this.endDialogButton.Text = "endDialog";
            this.endDialogButton.UseVisualStyleBackColor = true;
            this.endDialogButton.Click += new System.EventHandler(this.endDialogButton_Click);
            // 
            // saveLogButton
            // 
            this.saveLogButton.Location = new System.Drawing.Point(508, 96);
            this.saveLogButton.Name = "saveLogButton";
            this.saveLogButton.Size = new System.Drawing.Size(94, 36);
            this.saveLogButton.TabIndex = 5;
            this.saveLogButton.Text = "saveLog";
            this.saveLogButton.UseVisualStyleBackColor = true;
            this.saveLogButton.Click += new System.EventHandler(this.saveLogButton_Click);
            // 
            // loadLogButton
            // 
            this.loadLogButton.Location = new System.Drawing.Point(508, 138);
            this.loadLogButton.Name = "loadLogButton";
            this.loadLogButton.Size = new System.Drawing.Size(94, 36);
            this.loadLogButton.TabIndex = 6;
            this.loadLogButton.Text = "loadLog";
            this.loadLogButton.UseVisualStyleBackColor = true;
            this.loadLogButton.Click += new System.EventHandler(this.loadLogButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(508, 265);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(94, 32);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.Location = new System.Drawing.Point(508, 180);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(94, 36);
            this.StatisticsButton.TabIndex = 8;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = true;
            this.StatisticsButton.Click += new System.EventHandler(this.statistics_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 326);
            this.Controls.Add(this.StatisticsButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.loadLogButton);
            this.Controls.Add(this.saveLogButton);
            this.Controls.Add(this.endDialogButton);
            this.Controls.Add(this.beginDialogButton);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.chatBox);
            this.Name = "MainForm";
            this.Text = "Asistente Virtual Vo\'Confia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button beginDialogButton;
        private System.Windows.Forms.Button endDialogButton;
        private System.Windows.Forms.Button saveLogButton;
        private System.Windows.Forms.Button loadLogButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button StatisticsButton;
    }
}

