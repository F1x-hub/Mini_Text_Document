using System.Text;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SaveText> saveTexts = new List<SaveText>();
        List<string> casheTexts = new List<string>();
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string defoultSavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @$"\{Name}.txt";

            string text = richTextBox1.Text;
            File.WriteAllText(defoultSavePath, text);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                string text = richTextBox1.Text;
                File.WriteAllText(path, text);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File(*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string fileContent = File.ReadAllText(path);


                richTextBox1.Text = fileContent;

            }
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.White;
            richTextBox1.SelectionColor = Color.Black;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
            
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)
            {
                richTextBox1.Redo();
            }
        }
    }
}
