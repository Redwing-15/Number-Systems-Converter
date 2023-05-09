
namespace Number_Systems_Converter
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
            this.inputEntry = new System.Windows.Forms.TextBox();
            this.outputEntry = new System.Windows.Forms.TextBox();
            this.inputSelect = new System.Windows.Forms.ComboBox();
            this.outputSelect = new System.Windows.Forms.ComboBox();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputEntry
            // 
            this.inputEntry.Location = new System.Drawing.Point(49, 95);
            this.inputEntry.Multiline = true;
            this.inputEntry.Name = "inputEntry";
            this.inputEntry.Size = new System.Drawing.Size(459, 259);
            this.inputEntry.TabIndex = 0;
            // 
            // outputEntry
            // 
            this.outputEntry.Location = new System.Drawing.Point(780, 95);
            this.outputEntry.Multiline = true;
            this.outputEntry.Name = "outputEntry";
            this.outputEntry.ReadOnly = true;
            this.outputEntry.Size = new System.Drawing.Size(459, 259);
            this.outputEntry.TabIndex = 1;
            // 
            // inputSelect
            // 
            this.inputSelect.FormattingEnabled = true;
            this.inputSelect.Location = new System.Drawing.Point(85, 47);
            this.inputSelect.Name = "inputSelect";
            this.inputSelect.Size = new System.Drawing.Size(367, 24);
            this.inputSelect.TabIndex = 2;
            // 
            // outputSelect
            // 
            this.outputSelect.FormattingEnabled = true;
            this.outputSelect.Location = new System.Drawing.Point(826, 47);
            this.outputSelect.Name = "outputSelect";
            this.outputSelect.Size = new System.Drawing.Size(367, 24);
            this.outputSelect.TabIndex = 3;
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(570, 386);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(153, 36);
            this.calculateBTN.TabIndex = 5;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 478);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.outputSelect);
            this.Controls.Add(this.inputSelect);
            this.Controls.Add(this.outputEntry);
            this.Controls.Add(this.inputEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputEntry;
        private System.Windows.Forms.TextBox outputEntry;
        private System.Windows.Forms.ComboBox inputSelect;
        private System.Windows.Forms.ComboBox outputSelect;
        private System.Windows.Forms.Button calculateBTN;
    }
}

