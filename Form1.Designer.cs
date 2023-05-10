
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
            this.errorTextbox = new System.Windows.Forms.TextBox();
            this.outputSelectLBL = new System.Windows.Forms.Label();
            this.inputSelectLBL = new System.Windows.Forms.Label();
            this.outputLBL = new System.Windows.Forms.Label();
            this.inputLBL = new System.Windows.Forms.Label();
            this.titleLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputEntry
            // 
            this.inputEntry.Location = new System.Drawing.Point(48, 166);
            this.inputEntry.Multiline = true;
            this.inputEntry.Name = "inputEntry";
            this.inputEntry.Size = new System.Drawing.Size(459, 259);
            this.inputEntry.TabIndex = 0;
            this.inputEntry.TextChanged += new System.EventHandler(this.inputEntry_TextChanged);
            // 
            // outputEntry
            // 
            this.outputEntry.BackColor = System.Drawing.SystemColors.Window;
            this.outputEntry.ForeColor = System.Drawing.Color.Black;
            this.outputEntry.Location = new System.Drawing.Point(779, 166);
            this.outputEntry.Multiline = true;
            this.outputEntry.Name = "outputEntry";
            this.outputEntry.ReadOnly = true;
            this.outputEntry.Size = new System.Drawing.Size(459, 259);
            this.outputEntry.TabIndex = 1;
            // 
            // inputSelect
            // 
            this.inputSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSelect.FormattingEnabled = true;
            this.inputSelect.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Octal",
            "Hexadecimal",
            "ASCII",
            "RGB"});
            this.inputSelect.Location = new System.Drawing.Point(85, 93);
            this.inputSelect.Name = "inputSelect";
            this.inputSelect.Size = new System.Drawing.Size(367, 24);
            this.inputSelect.TabIndex = 2;
            this.inputSelect.SelectedIndexChanged += new System.EventHandler(this.inputSelect_SelectedIndexChanged);
            // 
            // outputSelect
            // 
            this.outputSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputSelect.FormattingEnabled = true;
            this.outputSelect.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Octal",
            "Hexadecimal",
            "ASCII"});
            this.outputSelect.Location = new System.Drawing.Point(824, 93);
            this.outputSelect.Name = "outputSelect";
            this.outputSelect.Size = new System.Drawing.Size(367, 24);
            this.outputSelect.TabIndex = 3;
            this.outputSelect.SelectedIndexChanged += new System.EventHandler(this.outputSelect_SelectedIndexChanged);
            // 
            // errorTextbox
            // 
            this.errorTextbox.BackColor = System.Drawing.SystemColors.Menu;
            this.errorTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTextbox.Location = new System.Drawing.Point(48, 431);
            this.errorTextbox.Name = "errorTextbox";
            this.errorTextbox.ReadOnly = true;
            this.errorTextbox.Size = new System.Drawing.Size(1190, 38);
            this.errorTextbox.TabIndex = 4;
            this.errorTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputSelectLBL
            // 
            this.outputSelectLBL.AutoSize = true;
            this.outputSelectLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputSelectLBL.Location = new System.Drawing.Point(869, 56);
            this.outputSelectLBL.Name = "outputSelectLBL";
            this.outputSelectLBL.Size = new System.Drawing.Size(291, 29);
            this.outputSelectLBL.TabIndex = 5;
            this.outputSelectLBL.Text = "Select conversion output";
            // 
            // inputSelectLBL
            // 
            this.inputSelectLBL.AutoSize = true;
            this.inputSelectLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSelectLBL.Location = new System.Drawing.Point(141, 59);
            this.inputSelectLBL.Name = "inputSelectLBL";
            this.inputSelectLBL.Size = new System.Drawing.Size(276, 29);
            this.inputSelectLBL.TabIndex = 5;
            this.inputSelectLBL.Text = "Select conversion input";
            // 
            // outputLBL
            // 
            this.outputLBL.AutoSize = true;
            this.outputLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLBL.Location = new System.Drawing.Point(969, 130);
            this.outputLBL.Name = "outputLBL";
            this.outputLBL.Size = new System.Drawing.Size(95, 29);
            this.outputLBL.TabIndex = 6;
            this.outputLBL.Text = "Output:";
            // 
            // inputLBL
            // 
            this.inputLBL.AutoSize = true;
            this.inputLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLBL.Location = new System.Drawing.Point(163, 130);
            this.inputLBL.Name = "inputLBL";
            this.inputLBL.Size = new System.Drawing.Size(189, 29);
            this.inputLBL.TabIndex = 7;
            this.inputLBL.Text = "Type text below";
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.Location = new System.Drawing.Point(423, 9);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(459, 39);
            this.titleLBL.TabIndex = 8;
            this.titleLBL.Text = "Number Systems Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1334, 478);
            this.Controls.Add(this.titleLBL);
            this.Controls.Add(this.inputLBL);
            this.Controls.Add(this.outputLBL);
            this.Controls.Add(this.inputSelectLBL);
            this.Controls.Add(this.outputSelectLBL);
            this.Controls.Add(this.errorTextbox);
            this.Controls.Add(this.outputSelect);
            this.Controls.Add(this.inputSelect);
            this.Controls.Add(this.outputEntry);
            this.Controls.Add(this.inputEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputEntry;
        private System.Windows.Forms.TextBox outputEntry;
        private System.Windows.Forms.ComboBox inputSelect;
        private System.Windows.Forms.ComboBox outputSelect;
        private System.Windows.Forms.TextBox errorTextbox;
        private System.Windows.Forms.Label outputSelectLBL;
        private System.Windows.Forms.Label inputSelectLBL;
        private System.Windows.Forms.Label outputLBL;
        private System.Windows.Forms.Label inputLBL;
        private System.Windows.Forms.Label titleLBL;
    }
}

