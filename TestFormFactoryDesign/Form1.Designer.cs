namespace TestFormFactoryDesign
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.npccmb = new System.Windows.Forms.ComboBox();
            this.strengthtxt = new System.Windows.Forms.TextBox();
            this.dextxt = new System.Windows.Forms.TextBox();
            this.contxt = new System.Windows.Forms.TextBox();
            this.inttxt = new System.Windows.Forms.TextBox();
            this.wistxt = new System.Windows.Forms.TextBox();
            this.chartxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.npcRacecmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(256, 343);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(349, 84);
            this.txtOutput.TabIndex = 0;
            // 
            // npccmb
            // 
            this.npccmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.npccmb.FormattingEnabled = true;
            this.npccmb.Location = new System.Drawing.Point(33, 15);
            this.npccmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npccmb.Name = "npccmb";
            this.npccmb.Size = new System.Drawing.Size(160, 24);
            this.npccmb.TabIndex = 1;
            // 
            // strengthtxt
            // 
            this.strengthtxt.Location = new System.Drawing.Point(33, 94);
            this.strengthtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.strengthtxt.Name = "strengthtxt";
            this.strengthtxt.Size = new System.Drawing.Size(132, 22);
            this.strengthtxt.TabIndex = 2;
            // 
            // dextxt
            // 
            this.dextxt.Location = new System.Drawing.Point(33, 142);
            this.dextxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dextxt.Name = "dextxt";
            this.dextxt.Size = new System.Drawing.Size(132, 22);
            this.dextxt.TabIndex = 3;
            // 
            // contxt
            // 
            this.contxt.Location = new System.Drawing.Point(33, 190);
            this.contxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contxt.Name = "contxt";
            this.contxt.Size = new System.Drawing.Size(132, 22);
            this.contxt.TabIndex = 4;
            // 
            // inttxt
            // 
            this.inttxt.Location = new System.Drawing.Point(33, 238);
            this.inttxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inttxt.Name = "inttxt";
            this.inttxt.Size = new System.Drawing.Size(132, 22);
            this.inttxt.TabIndex = 5;
            // 
            // wistxt
            // 
            this.wistxt.Location = new System.Drawing.Point(33, 286);
            this.wistxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wistxt.Name = "wistxt";
            this.wistxt.Size = new System.Drawing.Size(132, 22);
            this.wistxt.TabIndex = 6;
            // 
            // chartxt
            // 
            this.chartxt.Location = new System.Drawing.Point(33, 334);
            this.chartxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartxt.Name = "chartxt";
            this.chartxt.Size = new System.Drawing.Size(132, 22);
            this.chartxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dexterity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Intelligence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Constitution";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Charisma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wisdom";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // npcRacecmb
            // 
            this.npcRacecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.npcRacecmb.FormattingEnabled = true;
            this.npcRacecmb.Location = new System.Drawing.Point(33, 46);
            this.npcRacecmb.Name = "npcRacecmb";
            this.npcRacecmb.Size = new System.Drawing.Size(160, 24);
            this.npcRacecmb.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.npcRacecmb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartxt);
            this.Controls.Add(this.wistxt);
            this.Controls.Add(this.inttxt);
            this.Controls.Add(this.contxt);
            this.Controls.Add(this.dextxt);
            this.Controls.Add(this.strengthtxt);
            this.Controls.Add(this.npccmb);
            this.Controls.Add(this.txtOutput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox npccmb;
        private System.Windows.Forms.TextBox strengthtxt;
        private System.Windows.Forms.TextBox dextxt;
        private System.Windows.Forms.TextBox contxt;
        private System.Windows.Forms.TextBox inttxt;
        private System.Windows.Forms.TextBox wistxt;
        private System.Windows.Forms.TextBox chartxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox npcRacecmb;
    }
}

