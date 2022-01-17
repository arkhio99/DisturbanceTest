
namespace DisturbanceApp
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
            this.CalcBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.AgeNUD = new System.Windows.Forms.NumericUpDown();
            this.SexLbl = new System.Windows.Forms.Label();
            this.SexLB = new System.Windows.Forms.ListBox();
            this.StudyingLbl = new System.Windows.Forms.Label();
            this.StudyingCB = new System.Windows.Forms.CheckBox();
            this.WorkingLbl = new System.Windows.Forms.Label();
            this.WorkingCB = new System.Windows.Forms.CheckBox();
            this.MusicLbl = new System.Windows.Forms.Label();
            this.MusicLB = new System.Windows.Forms.ListBox();
            this.FreeTimeLbl = new System.Windows.Forms.Label();
            this.FreeTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.SleepTimeLbl = new System.Windows.Forms.Label();
            this.SleepTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.NervousPeriodLbl = new System.Windows.Forms.Label();
            this.NervousPeriodLB = new System.Windows.Forms.ListBox();
            this.ChronicWeakLbl = new System.Windows.Forms.Label();
            this.ChronicWeakCB = new System.Windows.Forms.CheckBox();
            this.EarningLbl = new System.Windows.Forms.Label();
            this.EarningLB = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeTimeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepTimeNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcBtn
            // 
            this.CalcBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalcBtn.Location = new System.Drawing.Point(310, 860);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(191, 80);
            this.CalcBtn.TabIndex = 0;
            this.CalcBtn.Text = "Узнать уровень тревожности";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тест на тревожность";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeLbl.Location = new System.Drawing.Point(35, 109);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(191, 30);
            this.AgeLbl.TabIndex = 2;
            this.AgeLbl.Text = "Сколько вам лет?";
            // 
            // AgeNUD
            // 
            this.AgeNUD.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeNUD.Location = new System.Drawing.Point(483, 109);
            this.AgeNUD.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.AgeNUD.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.AgeNUD.Name = "AgeNUD";
            this.AgeNUD.Size = new System.Drawing.Size(150, 36);
            this.AgeNUD.TabIndex = 3;
            this.AgeNUD.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // SexLbl
            // 
            this.SexLbl.AutoSize = true;
            this.SexLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SexLbl.Location = new System.Drawing.Point(35, 177);
            this.SexLbl.Name = "SexLbl";
            this.SexLbl.Size = new System.Drawing.Size(99, 30);
            this.SexLbl.TabIndex = 4;
            this.SexLbl.Text = "Ваш пол";
            // 
            // SexLB
            // 
            this.SexLB.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SexLB.FormattingEnabled = true;
            this.SexLB.ItemHeight = 30;
            this.SexLB.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.SexLB.Location = new System.Drawing.Point(483, 173);
            this.SexLB.Name = "SexLB";
            this.SexLB.Size = new System.Drawing.Size(150, 34);
            this.SexLB.TabIndex = 5;
            // 
            // StudyingLbl
            // 
            this.StudyingLbl.AutoSize = true;
            this.StudyingLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudyingLbl.Location = new System.Drawing.Point(35, 239);
            this.StudyingLbl.Name = "StudyingLbl";
            this.StudyingLbl.Size = new System.Drawing.Size(141, 30);
            this.StudyingLbl.TabIndex = 6;
            this.StudyingLbl.Text = "Обучаетесь?";
            // 
            // StudyingCB
            // 
            this.StudyingCB.AutoSize = true;
            this.StudyingCB.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudyingCB.Location = new System.Drawing.Point(483, 247);
            this.StudyingCB.Name = "StudyingCB";
            this.StudyingCB.Size = new System.Drawing.Size(18, 17);
            this.StudyingCB.TabIndex = 7;
            this.StudyingCB.UseVisualStyleBackColor = true;
            // 
            // WorkingLbl
            // 
            this.WorkingLbl.AutoSize = true;
            this.WorkingLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkingLbl.Location = new System.Drawing.Point(35, 299);
            this.WorkingLbl.Name = "WorkingLbl";
            this.WorkingLbl.Size = new System.Drawing.Size(125, 30);
            this.WorkingLbl.TabIndex = 8;
            this.WorkingLbl.Text = "Работаете?";
            // 
            // WorkingCB
            // 
            this.WorkingCB.AutoSize = true;
            this.WorkingCB.Location = new System.Drawing.Point(483, 305);
            this.WorkingCB.Name = "WorkingCB";
            this.WorkingCB.Size = new System.Drawing.Size(18, 17);
            this.WorkingCB.TabIndex = 9;
            this.WorkingCB.UseVisualStyleBackColor = true;
            // 
            // MusicLbl
            // 
            this.MusicLbl.AutoSize = true;
            this.MusicLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MusicLbl.Location = new System.Drawing.Point(35, 364);
            this.MusicLbl.Name = "MusicLbl";
            this.MusicLbl.Size = new System.Drawing.Size(268, 30);
            this.MusicLbl.TabIndex = 10;
            this.MusicLbl.Text = "Какую музыку слушаете?";
            // 
            // MusicLB
            // 
            this.MusicLB.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MusicLB.FormattingEnabled = true;
            this.MusicLB.ItemHeight = 30;
            this.MusicLB.Location = new System.Drawing.Point(483, 360);
            this.MusicLB.Name = "MusicLB";
            this.MusicLB.Size = new System.Drawing.Size(282, 34);
            this.MusicLB.TabIndex = 11;
            // 
            // FreeTimeLbl
            // 
            this.FreeTimeLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FreeTimeLbl.Location = new System.Drawing.Point(35, 430);
            this.FreeTimeLbl.Name = "FreeTimeLbl";
            this.FreeTimeLbl.Size = new System.Drawing.Size(364, 100);
            this.FreeTimeLbl.TabIndex = 12;
            this.FreeTimeLbl.Text = "Сколько у вас свободного времени, не считая времени на сон в минутах?";
            // 
            // FreeTimeNUD
            // 
            this.FreeTimeNUD.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FreeTimeNUD.Location = new System.Drawing.Point(483, 458);
            this.FreeTimeNUD.Maximum = new decimal(new int[] {
            960,
            0,
            0,
            0});
            this.FreeTimeNUD.Name = "FreeTimeNUD";
            this.FreeTimeNUD.Size = new System.Drawing.Size(150, 36);
            this.FreeTimeNUD.TabIndex = 13;
            this.FreeTimeNUD.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // SleepTimeLbl
            // 
            this.SleepTimeLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SleepTimeLbl.Location = new System.Drawing.Point(35, 559);
            this.SleepTimeLbl.Name = "SleepTimeLbl";
            this.SleepTimeLbl.Size = new System.Drawing.Size(364, 69);
            this.SleepTimeLbl.TabIndex = 14;
            this.SleepTimeLbl.Text = "Сколько времени вы тратите на сон, в часах?";
            // 
            // SleepTimeNUD
            // 
            this.SleepTimeNUD.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SleepTimeNUD.Location = new System.Drawing.Point(483, 577);
            this.SleepTimeNUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.SleepTimeNUD.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SleepTimeNUD.Name = "SleepTimeNUD";
            this.SleepTimeNUD.Size = new System.Drawing.Size(150, 36);
            this.SleepTimeNUD.TabIndex = 15;
            this.SleepTimeNUD.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // NervousPeriodLbl
            // 
            this.NervousPeriodLbl.AutoSize = true;
            this.NervousPeriodLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NervousPeriodLbl.Location = new System.Drawing.Point(35, 662);
            this.NervousPeriodLbl.Name = "NervousPeriodLbl";
            this.NervousPeriodLbl.Size = new System.Drawing.Size(430, 30);
            this.NervousPeriodLbl.TabIndex = 16;
            this.NervousPeriodLbl.Text = "Как часто у вас бывают нервные срывы?";
            // 
            // NervousPeriodLB
            // 
            this.NervousPeriodLB.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NervousPeriodLB.FormattingEnabled = true;
            this.NervousPeriodLB.ItemHeight = 30;
            this.NervousPeriodLB.Location = new System.Drawing.Point(483, 658);
            this.NervousPeriodLB.Name = "NervousPeriodLB";
            this.NervousPeriodLB.Size = new System.Drawing.Size(282, 34);
            this.NervousPeriodLB.TabIndex = 17;
            // 
            // ChronicWeakLbl
            // 
            this.ChronicWeakLbl.AutoSize = true;
            this.ChronicWeakLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChronicWeakLbl.Location = new System.Drawing.Point(35, 731);
            this.ChronicWeakLbl.Name = "ChronicWeakLbl";
            this.ChronicWeakLbl.Size = new System.Drawing.Size(381, 30);
            this.ChronicWeakLbl.TabIndex = 18;
            this.ChronicWeakLbl.Text = "Есть ли у вас хронические болезни?";
            // 
            // ChronicWeakCB
            // 
            this.ChronicWeakCB.AutoSize = true;
            this.ChronicWeakCB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChronicWeakCB.Location = new System.Drawing.Point(483, 742);
            this.ChronicWeakCB.Name = "ChronicWeakCB";
            this.ChronicWeakCB.Size = new System.Drawing.Size(18, 17);
            this.ChronicWeakCB.TabIndex = 19;
            this.ChronicWeakCB.UseVisualStyleBackColor = true;
            // 
            // EarningLbl
            // 
            this.EarningLbl.AutoSize = true;
            this.EarningLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EarningLbl.Location = new System.Drawing.Point(35, 795);
            this.EarningLbl.Name = "EarningLbl";
            this.EarningLbl.Size = new System.Drawing.Size(250, 30);
            this.EarningLbl.TabIndex = 20;
            this.EarningLbl.Text = "Какой у вас заработок?";
            // 
            // EarningLB
            // 
            this.EarningLB.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EarningLB.FormattingEnabled = true;
            this.EarningLB.ItemHeight = 30;
            this.EarningLB.Location = new System.Drawing.Point(483, 795);
            this.EarningLB.Name = "EarningLB";
            this.EarningLB.Size = new System.Drawing.Size(282, 34);
            this.EarningLB.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 979);
            this.Controls.Add(this.EarningLB);
            this.Controls.Add(this.EarningLbl);
            this.Controls.Add(this.ChronicWeakCB);
            this.Controls.Add(this.ChronicWeakLbl);
            this.Controls.Add(this.NervousPeriodLB);
            this.Controls.Add(this.NervousPeriodLbl);
            this.Controls.Add(this.SleepTimeNUD);
            this.Controls.Add(this.SleepTimeLbl);
            this.Controls.Add(this.FreeTimeNUD);
            this.Controls.Add(this.FreeTimeLbl);
            this.Controls.Add(this.MusicLB);
            this.Controls.Add(this.MusicLbl);
            this.Controls.Add(this.WorkingCB);
            this.Controls.Add(this.WorkingLbl);
            this.Controls.Add(this.StudyingCB);
            this.Controls.Add(this.StudyingLbl);
            this.Controls.Add(this.SexLB);
            this.Controls.Add(this.SexLbl);
            this.Controls.Add(this.AgeNUD);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcBtn);
            this.MinimumSize = new System.Drawing.Size(818, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.AgeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeTimeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepTimeNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.NumericUpDown AgeNUD;
        private System.Windows.Forms.Label SexLbl;
        private System.Windows.Forms.ListBox SexLB;
        private System.Windows.Forms.Label StudyingLbl;
        private System.Windows.Forms.CheckBox StudyingCB;
        private System.Windows.Forms.Label WorkingLbl;
        private System.Windows.Forms.CheckBox WorkingCB;
        private System.Windows.Forms.Label MusicLbl;
        private System.Windows.Forms.ListBox MusicLB;
        private System.Windows.Forms.Label FreeTimeLbl;
        private System.Windows.Forms.NumericUpDown FreeTimeNUD;
        private System.Windows.Forms.Label SleepTimeLbl;
        private System.Windows.Forms.NumericUpDown SleepTimeNUD;
        private System.Windows.Forms.Label NervousPeriodLbl;
        private System.Windows.Forms.ListBox NervousPeriodLB;
        private System.Windows.Forms.Label ChronicWeakLbl;
        private System.Windows.Forms.CheckBox ChronicWeakCB;
        private System.Windows.Forms.Label EarningLbl;
        private System.Windows.Forms.ListBox EarningLB;
    }
}

