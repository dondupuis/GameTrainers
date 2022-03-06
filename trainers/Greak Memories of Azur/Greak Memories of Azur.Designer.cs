namespace GameTrainers.trainers.Greak_Memories_of_Azur
{
    partial class Greak_Memories_of_Azur
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
            this.cb_onehithill = new System.Windows.Forms.CheckBox();
            this.lbl_process = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bgworker = new System.ComponentModel.BackgroundWorker();
            this.cb_health = new System.Windows.Forms.CheckBox();
            this.cb_mana = new System.Windows.Forms.CheckBox();
            this.cb_arrows = new System.Windows.Forms.CheckBox();
            this.cb_money = new System.Windows.Forms.CheckBox();
            this.cb_jump = new System.Windows.Forms.CheckBox();
            this.cb_invincible = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_process);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 416);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SETTINGS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_invincible);
            this.groupBox2.Controls.Add(this.cb_jump);
            this.groupBox2.Controls.Add(this.cb_money);
            this.groupBox2.Controls.Add(this.cb_arrows);
            this.groupBox2.Controls.Add(this.cb_mana);
            this.groupBox2.Controls.Add(this.cb_health);
            this.groupBox2.Controls.Add(this.cb_onehithill);
            this.groupBox2.Location = new System.Drawing.Point(17, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 296);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AOB SCANS";
            // 
            // cb_onehithill
            // 
            this.cb_onehithill.AutoSize = true;
            this.cb_onehithill.Location = new System.Drawing.Point(15, 48);
            this.cb_onehithill.Name = "cb_onehithill";
            this.cb_onehithill.Size = new System.Drawing.Size(103, 29);
            this.cb_onehithill.TabIndex = 0;
            this.cb_onehithill.Text = "1 Hit Kill";
            this.cb_onehithill.UseVisualStyleBackColor = true;
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
            // cb_health
            // 
            this.cb_health.AutoSize = true;
            this.cb_health.Location = new System.Drawing.Point(15, 83);
            this.cb_health.Name = "cb_health";
            this.cb_health.Size = new System.Drawing.Size(120, 29);
            this.cb_health.TabIndex = 1;
            this.cb_health.Text = "Unl Health";
            this.cb_health.UseVisualStyleBackColor = true;
            // 
            // cb_mana
            // 
            this.cb_mana.AutoSize = true;
            this.cb_mana.Location = new System.Drawing.Point(15, 118);
            this.cb_mana.Name = "cb_mana";
            this.cb_mana.Size = new System.Drawing.Size(113, 29);
            this.cb_mana.TabIndex = 2;
            this.cb_mana.Text = "Unl Mana";
            this.cb_mana.UseVisualStyleBackColor = true;
            // 
            // cb_arrows
            // 
            this.cb_arrows.AutoSize = true;
            this.cb_arrows.Location = new System.Drawing.Point(15, 153);
            this.cb_arrows.Name = "cb_arrows";
            this.cb_arrows.Size = new System.Drawing.Size(125, 29);
            this.cb_arrows.TabIndex = 3;
            this.cb_arrows.Text = "Unl Arrows";
            this.cb_arrows.UseVisualStyleBackColor = true;
            // 
            // cb_money
            // 
            this.cb_money.AutoSize = true;
            this.cb_money.Location = new System.Drawing.Point(15, 188);
            this.cb_money.Name = "cb_money";
            this.cb_money.Size = new System.Drawing.Size(124, 29);
            this.cb_money.TabIndex = 4;
            this.cb_money.Text = "Unl Money";
            this.cb_money.UseVisualStyleBackColor = true;
            // 
            // cb_jump
            // 
            this.cb_jump.AutoSize = true;
            this.cb_jump.Location = new System.Drawing.Point(15, 223);
            this.cb_jump.Name = "cb_jump";
            this.cb_jump.Size = new System.Drawing.Size(112, 29);
            this.cb_jump.TabIndex = 5;
            this.cb_jump.Text = "Unl Jump";
            this.cb_jump.UseVisualStyleBackColor = true;
            // 
            // cb_invincible
            // 
            this.cb_invincible.AutoSize = true;
            this.cb_invincible.Location = new System.Drawing.Point(15, 259);
            this.cb_invincible.Name = "cb_invincible";
            this.cb_invincible.Size = new System.Drawing.Size(126, 29);
            this.cb_invincible.TabIndex = 6;
            this.cb_invincible.Text = "Invincibility";
            this.cb_invincible.UseVisualStyleBackColor = true;
            // 
            // Greak_Memories_of_Azur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 451);
            this.Controls.Add(this.groupBox1);
            this.Name = "Greak_Memories_of_Azur";
            this.Text = "Greak_Memories_of_Azur";
            this.Load += new System.EventHandler(this.Greak_Memories_of_Azur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox cb_onehithill;
        private Label lbl_process;
        private Label label1;
        public System.ComponentModel.BackgroundWorker bgworker;
        private CheckBox cb_invincible;
        private CheckBox cb_jump;
        private CheckBox cb_money;
        private CheckBox cb_arrows;
        private CheckBox cb_mana;
        private CheckBox cb_health;
    }
}