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

            // Programatically implement dice
            dice = new Die[2] {
                new() { Name ="Left", Location = new(200,100)},
                new() { Name = "Right", Location = new(356,100)}
            };

            // Easy Add the dice
            dice.ToList().ForEach(d => Controls.Add(d));

            // Easy Roll the dice to create random numbers
            dice.ToList().ForEach(d => d.RollDie());
        }

        private async void rollBtn_Click(object sender, EventArgs e)
        {
            _tries = 0;
            // Loop infinitely until all dice are equal to one.
            // Note the lack of constraints, this will be useful for future implementations
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