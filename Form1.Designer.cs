namespace GameTrainers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_trainersshow = new System.Windows.Forms.Label();
            this.lbl_trainerCount = new System.Windows.Forms.Label();
            this.cb_games = new System.Windows.Forms.ComboBox();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_launch = new System.Windows.Forms.Button();
            this.bgworker = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trainers will be shown in the dropdown list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Game to launch trainer";
            // 
            // lbl_trainersshow
            // 
            this.lbl_trainersshow.AutoSize = true;
            this.lbl_trainersshow.Location = new System.Drawing.Point(800, 226);
            this.lbl_trainersshow.Name = "lbl_trainersshow";
            this.lbl_trainersshow.Size = new System.Drawing.Size(116, 25);
            this.lbl_trainersshow.TabIndex = 2;
            this.lbl_trainersshow.Text = "Trainer Count";
            this.lbl_trainersshow.Click += new System.EventHandler(this.lbl_trainersshow_Click_1);
            // 
            // lbl_trainerCount
            // 
            this.lbl_trainerCount.AutoSize = true;
            this.lbl_trainerCount.Location = new System.Drawing.Point(932, 226);
            this.lbl_trainerCount.Name = "lbl_trainerCount";
            this.lbl_trainerCount.Size = new System.Drawing.Size(20, 25);
            this.lbl_trainerCount.TabIndex = 3;
            this.lbl_trainerCount.Text = "?";
            // 
            // cb_games
            // 
            this.cb_games.FormattingEnabled = true;
            this.cb_games.Location = new System.Drawing.Point(323, 112);
            this.cb_games.Name = "cb_games";
            this.cb_games.Size = new System.Drawing.Size(470, 33);
            this.cb_games.TabIndex = 4;
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(24, 236);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(112, 34);
            this.btn_quit.TabIndex = 5;
            this.btn_quit.Text = "QUIT";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_launch
            // 
            this.btn_launch.Location = new System.Drawing.Point(831, 110);
            this.btn_launch.Name = "btn_launch";
            this.btn_launch.Size = new System.Drawing.Size(112, 34);
            this.btn_launch.TabIndex = 6;
            this.btn_launch.Text = "LAUNCH";
            this.btn_launch.UseVisualStyleBackColor = true;
            this.btn_launch.Click += new System.EventHandler(this.btn_launch_Click);
            // 
            // bgworker
            // 
            this.bgworker.WorkerReportsProgress = true;
            this.bgworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgworker_DoWork);
            this.bgworker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgworker_ProgressChanged);
            this.bgworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgworker_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "version";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(323, 241);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(69, 25);
            this.lbl_version.TabIndex = 8;
            this.lbl_version.Text = "version";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 286);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_launch);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.cb_games);
            this.Controls.Add(this.lbl_trainerCount);
            this.Controls.Add(this.lbl_trainersshow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl_trainersshow;
        private Label lbl_trainerCount;
        private ComboBox cb_games;
        private Button btn_quit;
        private Button btn_launch;
        private System.ComponentModel.BackgroundWorker bgworker;
        private Label label3;
        private Label lbl_version;
    }
}