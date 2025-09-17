namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //throw new System.NotImplementedException();
    }

    private void button1_Click(object sender, EventArgs e)
    { 
        lappland.Visible = true;
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        lappland.Visible = false;        
    }
}