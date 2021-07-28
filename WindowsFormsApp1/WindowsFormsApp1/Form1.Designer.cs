
namespace WindowsFormsApp1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.IPAddressPLC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rack = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Slot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypePLC = new System.Windows.Forms.ComboBox();
            this.button_Check = new System.Windows.Forms.Button();
            this.buttonWrite01 = new System.Windows.Forms.Button();
            this.VariantW01 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DBW01 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BitW01 = new System.Windows.Forms.TextBox();
            this.FirstAddrW01 = new System.Windows.Forms.TextBox();
            this.valueW01 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(21, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.IPAddressPLC);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.Rack);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Slot);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.TypePLC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.button_Check);
            this.splitContainer1.Size = new System.Drawing.Size(249, 100);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(4, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Config PLC";
            // 
            // IPAddressPLC
            // 
            this.IPAddressPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddressPLC.Location = new System.Drawing.Point(6, 73);
            this.IPAddressPLC.Multiline = true;
            this.IPAddressPLC.Name = "IPAddressPLC";
            this.IPAddressPLC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IPAddressPLC.Size = new System.Drawing.Size(151, 22);
            this.IPAddressPLC.TabIndex = 0;
            this.IPAddressPLC.Text = "192.168.1.200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Slot";
            // 
            // Rack
            // 
            this.Rack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rack.FormattingEnabled = true;
            this.Rack.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Rack.Location = new System.Drawing.Point(77, 46);
            this.Rack.Name = "Rack";
            this.Rack.Size = new System.Drawing.Size(37, 21);
            this.Rack.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rack";
            // 
            // Slot
            // 
            this.Slot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot.FormattingEnabled = true;
            this.Slot.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Slot.Location = new System.Drawing.Point(120, 46);
            this.Slot.Name = "Slot";
            this.Slot.Size = new System.Drawing.Size(36, 21);
            this.Slot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type PLC";
            // 
            // TypePLC
            // 
            this.TypePLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypePLC.FormattingEnabled = true;
            this.TypePLC.Items.AddRange(new object[] {
            "S7200",
            "S7300",
            "S7400",
            "S71200",
            "S71500"});
            this.TypePLC.Location = new System.Drawing.Point(6, 46);
            this.TypePLC.Name = "TypePLC";
            this.TypePLC.Size = new System.Drawing.Size(65, 21);
            this.TypePLC.TabIndex = 3;
            // 
            // button_Check
            // 
            this.button_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Check.Location = new System.Drawing.Point(3, 46);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(75, 49);
            this.button_Check.TabIndex = 7;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // buttonWrite01
            // 
            this.buttonWrite01.Location = new System.Drawing.Point(276, 166);
            this.buttonWrite01.Name = "buttonWrite01";
            this.buttonWrite01.Size = new System.Drawing.Size(78, 23);
            this.buttonWrite01.TabIndex = 88;
            this.buttonWrite01.Text = "Write";
            this.buttonWrite01.UseVisualStyleBackColor = true;
            this.buttonWrite01.Click += new System.EventHandler(this.buttonWrite01_Click);
            // 
            // VariantW01
            // 
            this.VariantW01.FormattingEnabled = true;
            this.VariantW01.Items.AddRange(new object[] {
            "Q",
            "M",
            "Bool",
            "Int",
            "Real"});
            this.VariantW01.Location = new System.Drawing.Point(111, 168);
            this.VariantW01.Name = "VariantW01";
            this.VariantW01.Size = new System.Drawing.Size(49, 21);
            this.VariantW01.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(80, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "DB";
            // 
            // DBW01
            // 
            this.DBW01.Location = new System.Drawing.Point(77, 168);
            this.DBW01.Multiline = true;
            this.DBW01.Name = "DBW01";
            this.DBW01.Size = new System.Drawing.Size(28, 21);
            this.DBW01.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(115, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Variant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(241, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Bit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(171, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "FirstAddr";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(29, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Value";
            // 
            // BitW01
            // 
            this.BitW01.Location = new System.Drawing.Point(230, 168);
            this.BitW01.Multiline = true;
            this.BitW01.Name = "BitW01";
            this.BitW01.Size = new System.Drawing.Size(40, 21);
            this.BitW01.TabIndex = 80;
            // 
            // FirstAddrW01
            // 
            this.FirstAddrW01.Location = new System.Drawing.Point(166, 168);
            this.FirstAddrW01.Multiline = true;
            this.FirstAddrW01.Name = "FirstAddrW01";
            this.FirstAddrW01.Size = new System.Drawing.Size(58, 21);
            this.FirstAddrW01.TabIndex = 79;
            // 
            // valueW01
            // 
            this.valueW01.Location = new System.Drawing.Point(21, 168);
            this.valueW01.Multiline = true;
            this.valueW01.Name = "valueW01";
            this.valueW01.Size = new System.Drawing.Size(50, 21);
            this.valueW01.TabIndex = 78;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWrite01);
            this.Controls.Add(this.VariantW01);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DBW01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BitW01);
            this.Controls.Add(this.FirstAddrW01);
            this.Controls.Add(this.valueW01);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IPAddressPLC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Rack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Slot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypePLC;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Button buttonWrite01;
        public System.Windows.Forms.ComboBox VariantW01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DBW01;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BitW01;
        private System.Windows.Forms.TextBox FirstAddrW01;
        private System.Windows.Forms.TextBox valueW01;
    }
}

