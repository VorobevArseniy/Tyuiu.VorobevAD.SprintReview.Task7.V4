namespace Tyuiu.VorobevAD.SprintReview.Task7.V4.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void buttonOpenReaders_VAD_Click(object sender, EventArgs e)
        {
            Hide();
            ReadersForm rf = new();
            rf.ShowDialog();
        }

        private void buttonOpenBooks_VAD_Click(object sender, EventArgs e)
        {
            Hide();
            BooksForm bf = new();
            bf.ShowDialog();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpenInfo_VAD_Click(object sender, EventArgs e)
        {
            FormAbout fa = new();
            fa.ShowDialog();
        }
    }
}
