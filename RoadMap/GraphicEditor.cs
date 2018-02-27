using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoadMap
{
    public partial class GraphicEditor : Form
    {
        GraphicEditorHelper Helper;

        public GraphicEditor()
        {
            InitializeComponent();
            Helper = new GraphicEditorHelper();
        }

        private void TopMenuButton_Click(object sender, EventArgs e)
        {
            foreach (var btn in TopMenu.Items)
                if (btn is ToolStripButton)
                    (btn as ToolStripButton).Checked = false;
            (sender as ToolStripButton).Checked = true;
            Helper.SetType((sender as ToolStripButton).Tag.ToString());
        }

        private void DrawingContest_MouseDown(object sender, MouseEventArgs e)
        {
            Helper.OnMouseDown();
            Helper.AddStartPoint(e.X, e.Y);
        }

        private void DrawingContest_MouseMove(object sender, MouseEventArgs e)
        {
            Invalidate();
            if (Helper.IsMouseDown())
            {
                Helper.AddEndPoint(e.X, e.Y);
                DrawingContest.Refresh();
                
            }
        }

        private void DrawingContest_MouseUp(object sender, MouseEventArgs e)
        {
            Helper.OnMouseUp();
            Helper.AddEndPoint(e.X, e.Y);
            DrawingContest.Refresh();
        }

        private void DrawingContest_Paint(object sender, PaintEventArgs e)
        {
            Helper.Draw(e.Graphics);
        }

        private void TopMenuSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.BMP)|*.BMP|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Helper.SaveFile(SaveFileDialog.FileName, SaveFileDialog.FilterIndex, DrawingContest);
            }
        }
    }
}
