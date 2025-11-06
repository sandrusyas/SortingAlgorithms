using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortNumbers
{
    public partial class Form1 : Form
    {
        private int[] array;
        private SortingVisualizer visualizer;


        public Form1()
        {
            InitializeComponent();
            visualizer = new SortingVisualizer(panel_ShowProcess);

            numericUpDown_SelectQuantity.Minimum = 5;
            numericUpDown_SelectQuantity.Maximum = 50;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            comboBox_SelectAlgorithm.SelectedIndex = -1;
            button_MakeArray.Enabled = false;
            button_Sort.Enabled = false;
            button_Clear.Enabled = false;
        }

        private void ComboBox_SelectAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateButtonsState();
        }

        private void NumericUpDown_SelectQuantity_ValueChanged(object sender, EventArgs e)
        {
            ValidateButtonsState();
        }

        private void ValidateButtonsState()
        {
            bool hasAlgorithm = comboBox_SelectAlgorithm.SelectedIndex != -1;
            bool hasQuantity = numericUpDown_SelectQuantity.Value > 0;

            button_MakeArray.Enabled = hasAlgorithm && hasQuantity;
            button_Sort.Enabled = false; 
        }

        private void button_MakeArray_Click(object sender, EventArgs e)
        {
            string input = textBox_NumbersBefore.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введіть числа через пробіл!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int expectedCount = (int)numericUpDown_SelectQuantity.Value;

            if (parts.Length != expectedCount)
            {
                MessageBox.Show($"Кількість введених чисел повинна дорівнювати {expectedCount}.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                array = parts.Select(p =>
                {
                    if (!int.TryParse(p, out int val) || val < 1 || val > 100)
                        throw new Exception();
                    return val;
                }).ToArray();
            }
            catch
            {
                MessageBox.Show("Введіть лише цілі числа від 1 до 100!",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string alg = comboBox_SelectAlgorithm.SelectedItem.ToString();

            if (alg == "Bubble sort")
                _ = visualizer.DrawCirclesAsync(array, -1, -1);
            else
                _ = visualizer.DrawBarsAsync(array, -1, -1);

            button_Sort.Enabled = true;
            button_Clear.Enabled = true;
        }

        private async void button_Sort_Click(object sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Спочатку створіть масив для сортування!",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            button_MakeArray.Enabled = false;
            button_Sort.Enabled = false;
            comboBox_SelectAlgorithm.Enabled = false;
            numericUpDown_SelectQuantity.Enabled = false;
            textBox_NumbersBefore.Enabled = false;
            button_Clear.Enabled = false;

            string algorithm = comboBox_SelectAlgorithm.SelectedItem.ToString();

            switch (algorithm)
            {
                case "Bubble sort":
                    await SortingAlgorithms.BubbleSortAsync(array, visualizer.DrawCirclesAsync);
                    break;
                case "Selection sort":
                    await SortingAlgorithms.SelectionSortAsync(array, visualizer.DrawBarsAsync);
                    break;
                case "Shuttle sort":
                    await SortingAlgorithms.ShuttleSortAsync(array, visualizer.DrawBarsAsync);
                    break;
            }

            textBox_NumbersAfter.Text = string.Join(" ", array);

            comboBox_SelectAlgorithm.Enabled = true;
            numericUpDown_SelectQuantity.Enabled = true;
            textBox_NumbersBefore.Enabled = true;
            button_MakeArray.Enabled = true;
            button_Clear.Enabled = true;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            using (Graphics g = panel_ShowProcess.CreateGraphics())
            {
                g.Clear(Color.White);
            }

            textBox_NumbersAfter.Clear();
            textBox_NumbersBefore.Clear();
            array = null;

            button_Sort.Enabled = false;

            button_MakeArray.Enabled = comboBox_SelectAlgorithm.SelectedIndex != -1;
        }
    }
}
