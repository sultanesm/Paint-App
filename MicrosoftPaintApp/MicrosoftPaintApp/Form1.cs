using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MicrosoftPaintApp
{
    public partial class Form1 : Form
    {
        Stack<Bitmap> undoStack = new Stack<Bitmap>();
        Stack<Bitmap> redoStack = new Stack<Bitmap>();

        TextBox activeTextBox = null;
        bool isDraggingTextBox = false;
        Point textBoxOffset;

        bool isDrawing = false;
        Point lastPoint;
        Point currentPoint;

        Bitmap canvas;
        Graphics g;
        Pen currentPen = new Pen(Color.Black, 2);
        Font textFont = new Font("Arial", 14);

        enum ToolType
        {
            Pen,
            Rectangle,
            Ellipse,
            Text
         
        }

        ToolType currentTool = ToolType.Pen;

        public Form1()
        {
            InitializeComponent();
        }

        void SaveState()
        {
            undoStack.Push(new Bitmap(canvas));
            redoStack.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            pictureBoxCanvas.Image = canvas;

            g = Graphics.FromImage(canvas);
            g.Clear(Color.White);
        }

       
        private void pictureBoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
            SaveState();

        }

        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {

            if (!isDrawing) return;

            currentPoint = e.Location;

            if (isDrawing && currentTool == ToolType.Pen)
            {
                g.DrawLine(currentPen, lastPoint, e.Location);
                lastPoint = e.Location;
                pictureBoxCanvas.Invalidate();
            }
            else
            {
              
                pictureBoxCanvas.Invalidate();
            }
        }
        private void pictureBoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentTool == ToolType.Rectangle)
            {
                int x = Math.Min(lastPoint.X, e.X);
                int y = Math.Min(lastPoint.Y, e.Y);
                int width = Math.Abs(e.X - lastPoint.X);
                int height = Math.Abs(e.Y - lastPoint.Y);

                g.DrawRectangle(currentPen, x, y, width, height);


            }
            else if (currentTool == ToolType.Ellipse)
            {
                int x = Math.Min(lastPoint.X, e.Location.X);
                int y = Math.Min(lastPoint.Y, e.Location.Y);
                int width = Math.Abs(e.Location.X - lastPoint.X);
                int height = Math.Abs(e.Location.Y - lastPoint.Y);

                g.DrawEllipse(currentPen, x, y, width, height);
  

            }

            pictureBoxCanvas.Invalidate();
            isDrawing = false;
        }   

        private void BlackButton_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Black;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Red;
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Blue;
        }
        private void GreenButton_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Green;
        }

        private void PinkButton_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Pink;
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.White;
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Ellipse;
        }

        private void PenButton_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Pen;
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null) return;

            currentTool = ToolType.Text;
            CreateTextBox();
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e) 
        {
            if (!isDrawing) return;

            int x = Math.Min(lastPoint.X, currentPoint.X);
            int y = Math.Min(lastPoint.Y, currentPoint.Y);
            int width = Math.Abs(currentPoint.X - lastPoint.X);
            int height = Math.Abs(currentPoint.Y - lastPoint.Y);

            if (currentTool == ToolType.Rectangle)
            {
                e.Graphics.DrawRectangle(currentPen, x, y, width, height);
            }
            else if (currentTool == ToolType.Ellipse)
            {
                e.Graphics.DrawEllipse(currentPen, x, y, width, height);
            }
        }

        void CreateTextBox()
        {
            activeTextBox = new TextBox
            {
                Multiline = true,
                Width = 150,
                Height = 30,
                ForeColor = currentPen.Color,
                Location = new Point(
                    pictureBoxCanvas.Width / 2 - 75,
                    pictureBoxCanvas.Height / 2 - 15
                )
            };

            activeTextBox.KeyDown += TextBox_KeyDown;
            activeTextBox.MouseDown += TextBox_MouseDown;
            activeTextBox.MouseMove += TextBox_MouseMove;
            activeTextBox.MouseUp += TextBox_MouseUp;

            pictureBoxCanvas.Controls.Add(activeTextBox);
            activeTextBox.BringToFront();
            activeTextBox.Focus();
        }
        private void TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggingTextBox = true;
            textBoxOffset = e.Location;
        }

        private void TextBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDraggingTextBox) return;

            TextBox tb = sender as TextBox;
            tb.Left += e.X - textBoxOffset.X;
            tb.Top += e.Y - textBoxOffset.Y;
        }

        private void TextBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingTextBox = false;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            SaveState();

            g.DrawString(
                activeTextBox.Text,
                textFont,
                new SolidBrush(currentPen.Color),
                activeTextBox.Location
            );

            pictureBoxCanvas.Controls.Remove(activeTextBox);
            activeTextBox.Dispose();
            activeTextBox = null;

            pictureBoxCanvas.Invalidate();
            currentTool = ToolType.Pen;
            e.SuppressKeyPress = true;
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(new Bitmap(canvas));

                canvas = undoStack.Pop();
                g = Graphics.FromImage(canvas);
                pictureBoxCanvas.Image = canvas;
                pictureBoxCanvas.Invalidate();
            }
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(new Bitmap(canvas));

                canvas = redoStack.Pop();
                g = Graphics.FromImage(canvas);
                pictureBoxCanvas.Image = canvas;
                pictureBoxCanvas.Invalidate();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg|Bitmap Image (*.bmp)|*.bmp";
            sfd.Title = "Save Image";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName.EndsWith(".png"))
                    canvas.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                else if (sfd.FileName.EndsWith(".jpg"))
                    canvas.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                else
                    canvas.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }
    }
}
 