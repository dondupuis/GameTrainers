namespace GameTrainers
{
    partial class Trainers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_trainerlist = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_trainerlist);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available By Process Name";
            // 
            // lb_trainerlist
            // 
            this.lb_trainerlist.FormattingEnabled = true;
            this.lb_trainerlist.ItemHeight = 25;
            this.lb_trainerlist.Location = new System.Drawing.Point(15, 42);
            this.lb_trainerlist.Name = "lb_trainerlist";
            this.lb_trainerlist.Size = new System.Drawing.Size(286, 254);
            this.lb_trainerlist.TabIndex = 0;
            // 
            // Trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "Trainers";
            this.Text = "Trainers";
            this.Load += new System.EventHandler(this.Trainers_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lb_trainerlist;
    }
}