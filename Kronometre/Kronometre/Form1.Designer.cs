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
            this.sayactext = new System.Windows.Forms.Label();
            this.zamansayaci = new System.Windows.Forms.Timer(this.components);
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
            this.panel1.Controls.Add(this.sayactext);
            this.panel1.Location = new System.Drawing.Point(193, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 87);
            this.panel1.TabIndex = 14;
            // 
            // sayactext
            // 
            this.sayactext.AutoSize = true;
            this.sayactext.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sayactext.ForeColor = System.Drawing.Color.Black;
            this.sayactext.Location = new System.Drawing.Point(29, 23);
            this.sayactext.Name = "sayactext";
            this.sayactext.Size = new System.Drawing.Size(34, 41);
            this.sayactext.TabIndex = 12;
            this.sayactext.Text = "0";
            // 
            // zamansayaci
            // 
            this.zamansayaci.Tick += new System.EventHandler(this.zamansayaci_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private Label sayactext;
        private System.Windows.Forms.Timer zamansayaci;
    }
}