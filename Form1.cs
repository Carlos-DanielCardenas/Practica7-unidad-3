namespace Practica7__unidad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rangoinferior, rangosuperior, suma = 0;

            rangoinferior = int.Parse(textBox1.Text);
            rangosuperior = int.Parse(textBox2.Text);
            for (int i = rangoinferior; i <= rangosuperior; i++)
            {
                listBox1.Items.Add(i);
                suma = suma + 1;
            }
            textBox3.Text=suma.ToString();
        }
    }
}