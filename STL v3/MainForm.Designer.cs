namespace STL_v3
{
    partial class MainForm
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_recogition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 212);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(148, 37);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Empezar a Reconocer";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(166, 212);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(106, 37);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Terminar";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lbl_recogition
            // 
            this.lbl_recogition.Location = new System.Drawing.Point(12, 12);
            this.lbl_recogition.Multiline = true;
            this.lbl_recogition.Name = "lbl_recogition";
            this.lbl_recogition.Size = new System.Drawing.Size(260, 194);
            this.lbl_recogition.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_recogition);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Name = "MainForm";
            this.Text = "STL v3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox lbl_recogition;
    }
}

