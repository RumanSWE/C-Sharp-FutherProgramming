namespace Wk5GraphTaskB
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
            this.AddAirportBtn = new System.Windows.Forms.Button();
            this.AddAirport = new System.Windows.Forms.TextBox();
            this.addConnectionBtn = new System.Windows.Forms.Button();
            this.reachableTxt = new System.Windows.Forms.TextBox();
            this.lookupBtn = new System.Windows.Forms.Button();
            this.allAirports = new System.Windows.Forms.RichTextBox();
            this.connectFromTxt = new System.Windows.Forms.TextBox();
            this.connectToTxt = new System.Windows.Forms.TextBox();
            this.searchTxt = new System.Windows.Forms.RichTextBox();
            this.txtConnection = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AddAirportBtn
            // 
            this.AddAirportBtn.Location = new System.Drawing.Point(220, 25);
            this.AddAirportBtn.Name = "AddAirportBtn";
            this.AddAirportBtn.Size = new System.Drawing.Size(75, 23);
            this.AddAirportBtn.TabIndex = 0;
            this.AddAirportBtn.Text = "Add";
            this.AddAirportBtn.UseVisualStyleBackColor = true;
            this.AddAirportBtn.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddAirport
            // 
            this.AddAirport.Location = new System.Drawing.Point(107, 28);
            this.AddAirport.Name = "AddAirport";
            this.AddAirport.Size = new System.Drawing.Size(100, 20);
            this.AddAirport.TabIndex = 1;
            this.AddAirport.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addConnectionBtn
            // 
            this.addConnectionBtn.Location = new System.Drawing.Point(499, 28);
            this.addConnectionBtn.Name = "addConnectionBtn";
            this.addConnectionBtn.Size = new System.Drawing.Size(154, 23);
            this.addConnectionBtn.TabIndex = 3;
            this.addConnectionBtn.Text = "Add Connection";
            this.addConnectionBtn.UseVisualStyleBackColor = true;
            this.addConnectionBtn.Click += new System.EventHandler(this.addConnectionBtn_Click);
            // 
            // reachableTxt
            // 
            this.reachableTxt.Location = new System.Drawing.Point(107, 185);
            this.reachableTxt.Name = "reachableTxt";
            this.reachableTxt.Size = new System.Drawing.Size(100, 20);
            this.reachableTxt.TabIndex = 6;
            // 
            // lookupBtn
            // 
            this.lookupBtn.Location = new System.Drawing.Point(220, 185);
            this.lookupBtn.Name = "lookupBtn";
            this.lookupBtn.Size = new System.Drawing.Size(75, 23);
            this.lookupBtn.TabIndex = 7;
            this.lookupBtn.Text = "Lookup";
            this.lookupBtn.UseVisualStyleBackColor = true;
            this.lookupBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // allAirports
            // 
            this.allAirports.Location = new System.Drawing.Point(107, 56);
            this.allAirports.Name = "allAirports";
            this.allAirports.Size = new System.Drawing.Size(100, 96);
            this.allAirports.TabIndex = 9;
            this.allAirports.Text = "";
            // 
            // connectFromTxt
            // 
            this.connectFromTxt.Location = new System.Drawing.Point(380, 28);
            this.connectFromTxt.Name = "connectFromTxt";
            this.connectFromTxt.Size = new System.Drawing.Size(100, 20);
            this.connectFromTxt.TabIndex = 2;
            // 
            // connectToTxt
            // 
            this.connectToTxt.Location = new System.Drawing.Point(380, 54);
            this.connectToTxt.Name = "connectToTxt";
            this.connectToTxt.Size = new System.Drawing.Size(100, 20);
            this.connectToTxt.TabIndex = 10;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(107, 211);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(100, 96);
            this.searchTxt.TabIndex = 11;
            this.searchTxt.Text = "";
            // 
            // txtConnection
            // 
            this.txtConnection.Location = new System.Drawing.Point(380, 80);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(100, 96);
            this.txtConnection.TabIndex = 12;
            this.txtConnection.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConnection);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.connectToTxt);
            this.Controls.Add(this.allAirports);
            this.Controls.Add(this.lookupBtn);
            this.Controls.Add(this.reachableTxt);
            this.Controls.Add(this.addConnectionBtn);
            this.Controls.Add(this.connectFromTxt);
            this.Controls.Add(this.AddAirport);
            this.Controls.Add(this.AddAirportBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAirportBtn;
        private System.Windows.Forms.TextBox AddAirport;
        private System.Windows.Forms.Button addConnectionBtn;
        private System.Windows.Forms.TextBox reachableTxt;
        private System.Windows.Forms.Button lookupBtn;
        private System.Windows.Forms.RichTextBox allAirports;
        private System.Windows.Forms.TextBox connectFromTxt;
        private System.Windows.Forms.TextBox connectToTxt;
        private System.Windows.Forms.RichTextBox searchTxt;
        private System.Windows.Forms.RichTextBox txtConnection;
    }
}

