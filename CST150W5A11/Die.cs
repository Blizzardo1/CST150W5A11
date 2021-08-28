using System.Windows.Forms;

namespace CST150W5A11
{
    public partial class Die : UserControl
    {
        private int _sides;

        private int _number;
        private List<int> _previousRolls;

        public int Face => _number;

        /// <summary>
        /// Create new Die with number of <see cref="sides"/>
        /// </summary>
        /// <param name="sides">The number of sides to create. From a D4 to a D20 is only supported.</param>
        public Die(int sides = 6)
        {
            if (sides is < 4 or > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(sides), "The die must have anywhere from four to twenty sides.");
            }
            InitializeComponent();
            _sides = sides;
            _previousRolls = new();
        }

        /// <summary>
        /// Resets the Die to 1
        /// </summary>
        public void ResetDie()
        {
            _number = 1;
            dieLbl.Text = _number.ToString();
        }

        /// <summary>
        /// Rolls the die
        /// </summary>
        public void RollDie()
        {
            int rolls = Program.Random.Next(1, _sides * _sides * _sides);

            // Rolls the dice anywhere between 1 and the amount of sides cubed.
            // For example, 6^3 is a maximum of 216 rolls.
            for(int i = 0; i < rolls; i++)
            {
                _number = Program.Random.Next(1, _sides);
                
            }
            _previousRolls.Add(_number);
            dieLbl.Text = _number.ToString();
        }
    }
}
