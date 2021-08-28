using System.Windows.Forms;

namespace CST150W5A11
{
    public partial class Form1 : Form
    {
        private Die[] dice;
        private int _tries = 0;

        public Form1()
        {
            InitializeComponent();
            dice = new Die[2] {
                new() { Name ="Left", Location = new(200,100)},
                new() { Name = "Right", Location = new(356,100)}
            };

            dice.ToList().ForEach(d => Controls.Add(d));
            dice.ToList().ForEach(d => d.RollDie());
        }

        private async void rollBtn_Click(object sender, EventArgs e)
        {

            _tries = 0;
            while (true)
            {
                if (dice.All(d => { d.RollDie(); return d.Face == 1; }))
                    break;
                _tries++;
                await Task.Delay(1);
            }
            MessageBox.Show($"It took {_tries} rolls before snakeyes were rolled!");
        }
    }
}