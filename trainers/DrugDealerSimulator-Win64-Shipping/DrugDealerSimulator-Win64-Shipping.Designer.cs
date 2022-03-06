namespace GameTrainers.trainers.DrugDealerSimulator_Win64_Shipping
{
    partial class DrugDealerSimulator_Win64_Shipping
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_searchAob = new System.Windows.Forms.Label();
            this.lbl_AoBAddy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_enableAob = new System.Windows.Forms.CheckBox();
            this.lbl_process = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_process);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 643);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SETTINGS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(17, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 128);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PLAYER OPTIONS";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(210, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Unl Money (BackPack)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_searchAob);
            this.groupBox2.Controls.Add(this.lbl_AoBAddy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cb_enableAob);
            this.groupBox2.Location = new System.Drawing.Point(17, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AOB INFORMATION";
            // 
            // lbl_searchAob
            // 
            this.lbl_searchAob.AutoSize = true;
            this.lbl_searchAob.Location = new System.Drawing.Point(15, 99);
            this.lbl_searchAob.Name = "lbl_searchAob";
            this.lbl_searchAob.Size = new System.Drawing.Size(115, 25);
            this.lbl_searchAob.TabIndex = 5;
            this.lbl_searchAob.Text = "AoB Address";
            // 
            // lbl_AoBAddy
            // 
            this.lbl_AoBAddy.AutoSize = true;
            this.lbl_AoBAddy.Location = new System.Drawing.Point(288, 52);
            this.lbl_AoBAddy.Name = "lbl_AoBAddy";
            this.lbl_AoBAddy.Size = new System.Drawing.Size(44, 25);
            this.lbl_AoBAddy.TabIndex = 4;
            this.lbl_AoBAddy.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // cb_enableAob
            // 
            this.cb_enableAob.AutoSize = true;
            this.cb_enableAob.Location = new System.Drawing.Point(15, 48);
            this.cb_enableAob.Name = "cb_enableAob";
            this.cb_enableAob.Size = new System.Drawing.Size(165, 29);
            this.cb_enableAob.TabIndex = 0;
            this.cb_enableAob.Text = "Enable AoBScan";
            this.cb_enableAob.UseVisualStyleBackColor = true;
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
            // DrugDealerSimulator_Win64_Shipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 682);
            this.Controls.Add(this.groupBox1);
            this.Name = "DrugDealerSimulator_Win64_Shipping";
            this.Text = "DrugDealerSimulator_Win64_Shipping";
            this.Load += new System.EventHandler(this.DrugDealerSimulator_Win64_Shipping_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private Label lbl_searchAob;
        private Label lbl_AoBAddy;
        private Label label2;
        private CheckBox cb_enableAob;
        private Label lbl_process;
        private Label label1;
    }
}