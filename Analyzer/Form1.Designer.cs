namespace Analyzer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(13, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.button2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(12, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Compile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, -105);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(618, 564);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(711, 94);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(302, 328);
            this.splitContainer2.SplitterDistance = 141;
            this.splitContainer2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(134, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(484, 210);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.ForeColor = System.Drawing.Color.Black;
            this.richTextBox2.Location = new System.Drawing.Point(134, 219);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(484, 238);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 459);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Compiler Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

