namespace GameTrainers.trainers.FarmingSimulator2019Game
{
    partial class FarmingSimulator2019Game
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_unlmoney = new System.Windows.Forms.CheckBox();
            this.lbl_process = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bgworker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_process);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SETTINGS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_unlmoney);
            this.groupBox2.Location = new System.Drawing.Point(17, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLAYER OPTIONS";
            // 
            // cb_unlmoney
            // 
            this.cb_unlmoney.AutoSize = true;
            this.cb_unlmoney.Location = new System.Drawing.Point(30, 51);
            this.cb_unlmoney.Name = "cb_unlmoney";
            this.cb_unlmoney.Size = new System.Drawing.Size(174, 29);
            this.cb_unlmoney.TabIndex = 0;
            this.cb_unlmoney.Text = "Unlimited Money";
            this.cb_unlmoney.UseVisualStyleBackColor = true;
            // 
            // lbl_process
            // 
            this.lbl_process.AutoSize = true;
            this.lbl_process.Location = new System.Drawing.Point(99, 41);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(44, 25);
            this.lbl_process.TabIndex = 1;
            this.lbl_process.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // bgworker
            // 
            this.bgworker.WorkerReportsProgress = true;
            this.bgworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgworker_DoWork);
            this.bgworker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgworker_ProgressChanged);
            this.bgworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgworker_RunWorkerCompleted);
            // 
            // FarmingSimulator2019Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 469);
            this.Controls.Add(this.groupBox1);
            this.Name = "FarmingSimulator2019Game";
            this.Text = "FarmingSimulator2019Game";
            this.Load += new System.EventHandler(this.FarmingSimulator2019Game_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox cb_unlmoney;
        private Label lbl_process;
        private Label label1;
        private System.ComponentModel.BackgroundWorker bgworker;
    }
}