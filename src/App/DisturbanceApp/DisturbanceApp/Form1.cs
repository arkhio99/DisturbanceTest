using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisturbanceApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> sex = new Dictionary<string, int>
        {
            { "Ж", 1 },
            { "М", 2 },
        };

        private Dictionary<bool, int> isStudying = new Dictionary<bool, int>
        {
            { true, 1 },
            { false, 2 },
        };

        private Dictionary<bool, int> isWorking = new Dictionary<bool, int>
        {
            { true, 1 },
            { false, 2 },
        };

        private Dictionary<string, int> music = new Dictionary<string, int>
        {
            { "Классическая", 1 },
            { "Лёгкая (поп, рэп)", 2 },
            { "Умеренная (рок)", 4 },
            { "Я меломан", 3 },
        };

        private Dictionary<string, int> nervousPeriod = new Dictionary<string, int>
        {
            { "Раз в год и реже", 1 },
            { "Пару раз в год", 2 },
            { "Раз в месяц", 3 },
            { "Пару раз в месяц", 4 },
            { "Раз в неделю", 5 },
            { "Пару раз в неделю", 6 },
            { "Раз в день", 7 },
        };

        private Dictionary<bool, int> chronicWeak = new Dictionary<bool, int>
        {
            { true, 1 },
            { false, 2 },
        };

        private Dictionary<string, int> earning = new Dictionary<string, int>
        {
            { "Менее 15 тыс. руб", 1 },
            { "От 15 до 30 тыс. руб", 2 },
            { "От 30 до 60 тыс. руб", 3 },
            { "От 60 тыс. руб и более", 4 },
        };

        public Form1()
        {
            InitializeComponent();
            SexLB.Items.Clear();
            SexLB.Items.AddRange(sex.Keys.ToArray());
            MusicLB.Items.Clear();
            MusicLB.Items.AddRange(music.Keys.ToArray());
            NervousPeriodLB.Items.AddRange(nervousPeriod.Keys.ToArray());
            EarningLB.Items.Clear();
            EarningLB.Items.AddRange(earning.Keys.ToArray());
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            var answers = new Dictionary<string, double>
            {
                { "Age", (int)AgeNUD.Value },
                { "FreeTime", (int)FreeTimeNUD.Value },
                { "SleepTime", (int)SleepTimeNUD.Value },
                { "Sex", sex[(string)SexLB.SelectedItem] },
                { "IsStudying", isStudying[StudyingCB.Checked] },
                { "IsWorking", isWorking[WorkingCB.Checked] },
                { "Music", music[(string)MusicLB.SelectedItem] },
                { "NervousPeriod", nervousPeriod[(string)NervousPeriodLB.SelectedItem] },
                { "ChronicWeak", chronicWeak[ChronicWeakCB.Checked] },
                { "Earning", earning[(string)EarningLB.SelectedItem] }
            };

            var percent = Solver.Predict(answers) * 100;

            var resultForm = new ResultForm(percent);

            resultForm.Show();
        }
    }
}
