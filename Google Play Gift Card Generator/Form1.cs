using System;
using System.Drawing;
using System.Windows.Forms;

namespace GooglePlayGiftCardGenerator
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();
        }

        private void UpdatePreviewButton_Click(object sender, EventArgs e)
        {
            Image image = new Bitmap(Properties.Resources.GiftCardFrame);

            Graphics g = Graphics.FromImage(image);
            g.DrawString(TitleBox.Text, new Font("Segoe UI", 35, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Gray, new PointF(139, 33));
            g.DrawString(ItemBox.Text, new Font("Segoe UI", 28, FontStyle.Bold, GraphicsUnit.Pixel), new SolidBrush(ColorTranslator.FromHtml("#9DA7A2")), new PointF(300, 83));
            g.DrawString(PromoCodeBox.Text, new Font("Segoe UI", 36, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Gray, new PointF(38, 217));
            if (IconPathBox.Text != "") g.DrawImage(new Bitmap(IconPathBox.Text), 40, 30, 90, 90);

            Preview.Image = image;
        }

        private void PicIconButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog PickIcon = new OpenFileDialog();
            PickIcon.RestoreDirectory = true;
            PickIcon.CheckFileExists = true;
            PickIcon.CheckPathExists = true;
            PickIcon.Multiselect = false;
            PickIcon.Title = "Pick an Icon";
            PickIcon.Filter = "Image Files (*.png, *.jpg, *.jpeg) |  *.png; *.jpg; *.jpeg;";

            if (PickIcon.ShowDialog() == DialogResult.OK)
                IconPathBox.Text = PickIcon.FileName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveCard = new SaveFileDialog();
            SaveCard.RestoreDirectory = true;
            SaveCard.FileName = TitleBox.Text + " - Gift Card.png";
            SaveCard.DefaultExt = "png";
            SaveCard.Title = "Let's Save Your Card!";

            if (SaveCard.ShowDialog() == DialogResult.OK)
                try
                {
                    Preview.Image.Save(SaveCard.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Card Saved as " + System.IO.Path.GetFileName(SaveCard.FileName), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't Save Your Card. " + ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}