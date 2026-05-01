namespace MicrosoftPaintApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.BlackButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.PinkButton = new System.Windows.Forms.Button();
            this.WhiteButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.PenButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.TextButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // BlackButton
            // 
            this.BlackButton.BackColor = System.Drawing.Color.Black;
            this.BlackButton.Location = new System.Drawing.Point(21, 202);
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(25, 23);
            this.BlackButton.TabIndex = 1;
            this.BlackButton.UseVisualStyleBackColor = false;
            this.BlackButton.Click += new System.EventHandler(this.BlackButton_Click);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Red;
            this.RedButton.Location = new System.Drawing.Point(52, 202);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(25, 23);
            this.RedButton.TabIndex = 2;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.Blue;
            this.BlueButton.Location = new System.Drawing.Point(21, 231);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(25, 23);
            this.BlueButton.TabIndex = 3;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GreenButton.Location = new System.Drawing.Point(52, 231);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(25, 23);
            this.GreenButton.TabIndex = 4;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // PinkButton
            // 
            this.PinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PinkButton.Location = new System.Drawing.Point(21, 260);
            this.PinkButton.Name = "PinkButton";
            this.PinkButton.Size = new System.Drawing.Size(25, 23);
            this.PinkButton.TabIndex = 5;
            this.PinkButton.UseVisualStyleBackColor = false;
            this.PinkButton.Click += new System.EventHandler(this.PinkButton_Click);
            // 
            // WhiteButton
            // 
            this.WhiteButton.Location = new System.Drawing.Point(52, 260);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(25, 23);
            this.WhiteButton.TabIndex = 6;
            this.WhiteButton.UseVisualStyleBackColor = true;
            this.WhiteButton.Click += new System.EventHandler(this.WhiteButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RectangleButton.Location = new System.Drawing.Point(7, 63);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(87, 30);
            this.RectangleButton.TabIndex = 7;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = false;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Location = new System.Drawing.Point(97, 12);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(691, 426);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCanvas_Paint);
            this.pictureBoxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseDown);
            this.pictureBoxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseMove);
            this.pictureBoxCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseUp);
            // 
            // PenButton
            // 
            this.PenButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PenButton.Location = new System.Drawing.Point(7, 21);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(87, 29);
            this.PenButton.TabIndex = 8;
            this.PenButton.Text = "Pen";
            this.PenButton.UseVisualStyleBackColor = false;
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(7, 108);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(87, 26);
            this.CircleButton.TabIndex = 9;
            this.CircleButton.Text = "Circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // TextButton
            // 
            this.TextButton.Location = new System.Drawing.Point(7, 149);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(87, 26);
            this.TextButton.TabIndex = 11;
            this.TextButton.Text = "Text";
            this.TextButton.UseVisualStyleBackColor = true;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(7, 304);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(84, 23);
            this.undoButton.TabIndex = 12;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Location = new System.Drawing.Point(7, 333);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(84, 23);
            this.redoButton.TabIndex = 13;
            this.redoButton.Text = "Redo";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 401);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.TextButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.PenButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.WhiteButton);
            this.Controls.Add(this.PinkButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.BlackButton);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Button BlackButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button PinkButton;
        private System.Windows.Forms.Button WhiteButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button TextButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button saveButton;
    }
}

