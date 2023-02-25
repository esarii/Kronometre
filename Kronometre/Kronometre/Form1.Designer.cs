namespace Kronometre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salisetext = new System.Windows.Forms.Label();
            this.saattext = new System.Windows.Forms.Label();
            this.dakikatext = new System.Windows.Forms.Label();
            this.saniyetext = new System.Windows.Forms.Label();
            this.zamansayaci = new System.Windows.Forms.Timer(this.components);
            this.sdsekran = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Snow;
            this.start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start.ForeColor = System.Drawing.Color.SeaGreen;
            this.start.Location = new System.Drawing.Point(127, 253);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(162, 58);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Snow;
            this.stop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stop.ForeColor = System.Drawing.Color.SeaGreen;
            this.stop.Location = new System.Drawing.Point(339, 253);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(148, 58);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Snow;
            this.reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reset.ForeColor = System.Drawing.Color.SeaGreen;
            this.reset.Location = new System.Drawing.Point(536, 253);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(148, 58);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.salisetext);
            this.panel1.Controls.Add(this.saattext);
            this.panel1.Controls.Add(this.dakikatext);
            this.panel1.Controls.Add(this.saniyetext);
            this.panel1.Location = new System.Drawing.Point(173, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 89);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(383, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 41);
            this.label4.TabIndex = 19;
            this.label4.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(288, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 41);
            this.label3.TabIndex = 18;
            this.label3.Text = "s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(177, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "m";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "h";
            // 
            // salisetext
            // 
            this.salisetext.AutoSize = true;
            this.salisetext.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salisetext.ForeColor = System.Drawing.Color.Black;
            this.salisetext.Location = new System.Drawing.Point(343, 23);
            this.salisetext.Name = "salisetext";
            this.salisetext.Size = new System.Drawing.Size(34, 41);
            this.salisetext.TabIndex = 15;
            this.salisetext.Text = "0";
            // 
            // saattext
            // 
            this.saattext.AutoSize = true;
            this.saattext.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saattext.ForeColor = System.Drawing.Color.Black;
            this.saattext.Location = new System.Drawing.Point(27, 23);
            this.saattext.Name = "saattext";
            this.saattext.Size = new System.Drawing.Size(34, 41);
            this.saattext.TabIndex = 14;
            this.saattext.Text = "0";
            // 
            // dakikatext
            // 
            this.dakikatext.AutoSize = true;
            this.dakikatext.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dakikatext.ForeColor = System.Drawing.Color.Black;
            this.dakikatext.Location = new System.Drawing.Point(137, 23);
            this.dakikatext.Name = "dakikatext";
            this.dakikatext.Size = new System.Drawing.Size(34, 41);
            this.dakikatext.TabIndex = 13;
            this.dakikatext.Text = "0";
            // 
            // saniyetext
            // 
            this.saniyetext.AutoSize = true;
            this.saniyetext.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saniyetext.ForeColor = System.Drawing.Color.Black;
            this.saniyetext.Location = new System.Drawing.Point(248, 23);
            this.saniyetext.Name = "saniyetext";
            this.saniyetext.Size = new System.Drawing.Size(34, 41);
            this.saniyetext.TabIndex = 12;
            this.saniyetext.Text = "0";
            // 
            // zamansayaci
            // 
            this.zamansayaci.Tick += new System.EventHandler(this.zamansayaci_Tick);
            // 
            // sdsekran
            // 
            this.sdsekran.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sdsekran.ForeColor = System.Drawing.Color.Black;
            this.sdsekran.Location = new System.Drawing.Point(163, 347);
            this.sdsekran.Name = "sdsekran";
            this.sdsekran.Size = new System.Drawing.Size(511, 41);
            this.sdsekran.TabIndex = 15;
            this.sdsekran.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sdsekran);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Zaman Sayacı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button start;
        private Button stop;
        private Button reset;
        private Panel panel1;
        private Label saniyetext;
        private System.Windows.Forms.Timer zamansayaci;
        private Label saattext;
        private Label dakikatext;
        private Label salisetext;
        private Label sdsekran;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}