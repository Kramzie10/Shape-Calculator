namespace Shape_Calculator
{
    public partial class Form1 : Form
    {
        private ShapeCalculator calculator = new ShapeCalculator();
        public Form1()
        {
            InitializeComponent();
        }
        //Triangle
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox4.Text, out double baseLength) && double.TryParse(textBox5.Text, out double height))
            {
                double area = calculator.CalculateArea(baseLength, height, true);
                DisplayResult($"Triangle: {area}");
            }
            textBox4.Clear();
            textBox5.Clear();
        }
        //Rectangle
        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double length) && double.TryParse(textBox2.Text, out double width))
            {
                double area = calculator.CalculateArea(length, width);
                DisplayResult($"Rectangle: {area}");
            }
            textBox1.Clear();
            textBox2.Clear();
        }
        //Circle
        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double radius))
            {
                double area = calculator.CalculateArea(radius);
                DisplayResult($"Circle: {area:F2}");
            }
            textBox3.Clear();
        }
        //Clear
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox6.Clear();
        }
        //Results
        private void DisplayResult(string result)
        {
            listBox1.Items.Add(result);
            textBox6.Text = result;
        }
    }
}