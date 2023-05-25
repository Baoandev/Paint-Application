namespace PaintApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.Pen_width = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.pick_color = new System.Windows.Forms.Button();
			this.Btn_triangle = new System.Windows.Forms.Button();
			this.Btn_clear = new System.Windows.Forms.Button();
			this.Btn_fill = new System.Windows.Forms.Button();
			this.Btn_line = new System.Windows.Forms.Button();
			this.Btn_rectangle = new System.Windows.Forms.Button();
			this.Btn_ellipse = new System.Windows.Forms.Button();
			this.Btn_erase = new System.Windows.Forms.Button();
			this.Btn_pencil = new System.Windows.Forms.Button();
			this.Btn_color = new System.Windows.Forms.Button();
			this.DrawingArea = new System.Windows.Forms.PictureBox();
			this.Btn_save = new System.Windows.Forms.Button();
			this.Btn_openfile = new System.Windows.Forms.Button();
			this.Btn_RemoveImg = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Pen_width)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1268, 30);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 654);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1268, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// Pen_width
			// 
			this.Pen_width.Location = new System.Drawing.Point(894, 57);
			this.Pen_width.Name = "Pen_width";
			this.Pen_width.Size = new System.Drawing.Size(72, 22);
			this.Pen_width.TabIndex = 10;
			this.Pen_width.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.Pen_width.ValueChanged += new System.EventHandler(this.Pen_width_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(900, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "Width";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// pick_color
			// 
			this.pick_color.BackColor = System.Drawing.Color.Black;
			this.pick_color.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pick_color.Location = new System.Drawing.Point(305, 31);
			this.pick_color.Name = "pick_color";
			this.pick_color.Size = new System.Drawing.Size(48, 48);
			this.pick_color.TabIndex = 1;
			this.pick_color.UseVisualStyleBackColor = false;
			this.pick_color.Click += new System.EventHandler(this.pick_color_Click);
			// 
			// Btn_triangle
			// 
			this.Btn_triangle.Image = global::PaintApp.Properties.Resources.Triangle_32px;
			this.Btn_triangle.Location = new System.Drawing.Point(607, 38);
			this.Btn_triangle.Name = "Btn_triangle";
			this.Btn_triangle.Size = new System.Drawing.Size(48, 41);
			this.Btn_triangle.TabIndex = 12;
			this.Btn_triangle.UseVisualStyleBackColor = true;
			this.Btn_triangle.Click += new System.EventHandler(this.Btn_triangle_Click);
			// 
			// Btn_clear
			// 
			this.Btn_clear.Image = global::PaintApp.Properties.Resources.icons8_broom_32;
			this.Btn_clear.Location = new System.Drawing.Point(769, 38);
			this.Btn_clear.Name = "Btn_clear";
			this.Btn_clear.Size = new System.Drawing.Size(48, 41);
			this.Btn_clear.TabIndex = 11;
			this.Btn_clear.UseVisualStyleBackColor = true;
			this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
			// 
			// Btn_fill
			// 
			this.Btn_fill.Image = global::PaintApp.Properties.Resources.icons8_fill_color_30;
			this.Btn_fill.Location = new System.Drawing.Point(445, 38);
			this.Btn_fill.Name = "Btn_fill";
			this.Btn_fill.Size = new System.Drawing.Size(48, 41);
			this.Btn_fill.TabIndex = 7;
			this.Btn_fill.UseVisualStyleBackColor = true;
			this.Btn_fill.Click += new System.EventHandler(this.Btn_fill_Click);
			// 
			// Btn_line
			// 
			this.Btn_line.Image = global::PaintApp.Properties.Resources.icons8_line_24;
			this.Btn_line.Location = new System.Drawing.Point(553, 38);
			this.Btn_line.Name = "Btn_line";
			this.Btn_line.Size = new System.Drawing.Size(48, 41);
			this.Btn_line.TabIndex = 6;
			this.Btn_line.UseVisualStyleBackColor = true;
			this.Btn_line.Click += new System.EventHandler(this.Btn_line_Click);
			// 
			// Btn_rectangle
			// 
			this.Btn_rectangle.Image = global::PaintApp.Properties.Resources.Rectangle_Stroked_32px;
			this.Btn_rectangle.Location = new System.Drawing.Point(661, 38);
			this.Btn_rectangle.Name = "Btn_rectangle";
			this.Btn_rectangle.Size = new System.Drawing.Size(48, 41);
			this.Btn_rectangle.TabIndex = 5;
			this.Btn_rectangle.UseVisualStyleBackColor = true;
			this.Btn_rectangle.Click += new System.EventHandler(this.Btn_rectangle_Click);
			// 
			// Btn_ellipse
			// 
			this.Btn_ellipse.Image = global::PaintApp.Properties.Resources.Circle_32px;
			this.Btn_ellipse.Location = new System.Drawing.Point(715, 38);
			this.Btn_ellipse.Name = "Btn_ellipse";
			this.Btn_ellipse.Size = new System.Drawing.Size(48, 41);
			this.Btn_ellipse.TabIndex = 4;
			this.Btn_ellipse.UseVisualStyleBackColor = true;
			this.Btn_ellipse.Click += new System.EventHandler(this.Btn_ellipse_Click);
			// 
			// Btn_erase
			// 
			this.Btn_erase.Image = global::PaintApp.Properties.Resources.Erase_32px;
			this.Btn_erase.Location = new System.Drawing.Point(823, 38);
			this.Btn_erase.Name = "Btn_erase";
			this.Btn_erase.Size = new System.Drawing.Size(48, 41);
			this.Btn_erase.TabIndex = 3;
			this.Btn_erase.UseVisualStyleBackColor = true;
			this.Btn_erase.Click += new System.EventHandler(this.Btn_erase_Click);
			// 
			// Btn_pencil
			// 
			this.Btn_pencil.Image = global::PaintApp.Properties.Resources.Edit_32px;
			this.Btn_pencil.Location = new System.Drawing.Point(499, 38);
			this.Btn_pencil.Name = "Btn_pencil";
			this.Btn_pencil.Size = new System.Drawing.Size(48, 41);
			this.Btn_pencil.TabIndex = 2;
			this.Btn_pencil.UseVisualStyleBackColor = true;
			this.Btn_pencil.Click += new System.EventHandler(this.Btn_pencil_Click);
			// 
			// Btn_color
			// 
			this.Btn_color.Image = global::PaintApp.Properties.Resources.unnamed__1_;
			this.Btn_color.Location = new System.Drawing.Point(237, 31);
			this.Btn_color.Name = "Btn_color";
			this.Btn_color.Size = new System.Drawing.Size(48, 48);
			this.Btn_color.TabIndex = 1;
			this.Btn_color.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.Btn_color.UseVisualStyleBackColor = true;
			this.Btn_color.Click += new System.EventHandler(this.Btn_color_Click);
			// 
			// DrawingArea
			// 
			this.DrawingArea.Location = new System.Drawing.Point(0, 100);
			this.DrawingArea.Name = "DrawingArea";
			this.DrawingArea.Size = new System.Drawing.Size(1268, 564);
			this.DrawingArea.TabIndex = 0;
			this.DrawingArea.TabStop = false;
			this.DrawingArea.Click += new System.EventHandler(this.DrawingArea_Click);
			this.DrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingArea_Paint);
			this.DrawingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseClick);
			this.DrawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseDown);
			this.DrawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseMove);
			this.DrawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseUp);
			// 
			// Btn_save
			// 
			this.Btn_save.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_save.Location = new System.Drawing.Point(1000, 12);
			this.Btn_save.Name = "Btn_save";
			this.Btn_save.Size = new System.Drawing.Size(88, 33);
			this.Btn_save.TabIndex = 14;
			this.Btn_save.Text = "SAVE";
			this.Btn_save.UseVisualStyleBackColor = true;
			this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click_1);
			// 
			// Btn_openfile
			// 
			this.Btn_openfile.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_openfile.Location = new System.Drawing.Point(1000, 51);
			this.Btn_openfile.Name = "Btn_openfile";
			this.Btn_openfile.Size = new System.Drawing.Size(88, 33);
			this.Btn_openfile.TabIndex = 15;
			this.Btn_openfile.Text = "OPEN";
			this.Btn_openfile.UseVisualStyleBackColor = true;
			this.Btn_openfile.Click += new System.EventHandler(this.Btn_openfile_Click);
			// 
			// Btn_RemoveImg
			// 
			this.Btn_RemoveImg.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_RemoveImg.Location = new System.Drawing.Point(1094, 51);
			this.Btn_RemoveImg.Name = "Btn_RemoveImg";
			this.Btn_RemoveImg.Size = new System.Drawing.Size(98, 33);
			this.Btn_RemoveImg.TabIndex = 16;
			this.Btn_RemoveImg.Text = "REMOVE";
			this.Btn_RemoveImg.UseVisualStyleBackColor = true;
			this.Btn_RemoveImg.Click += new System.EventHandler(this.Btn_RemoveImg_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1268, 676);
			this.Controls.Add(this.Btn_RemoveImg);
			this.Controls.Add(this.Btn_openfile);
			this.Controls.Add(this.Btn_save);
			this.Controls.Add(this.pick_color);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Btn_triangle);
			this.Controls.Add(this.Btn_clear);
			this.Controls.Add(this.Pen_width);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.Btn_fill);
			this.Controls.Add(this.Btn_line);
			this.Controls.Add(this.Btn_rectangle);
			this.Controls.Add(this.Btn_ellipse);
			this.Controls.Add(this.Btn_erase);
			this.Controls.Add(this.Btn_pencil);
			this.Controls.Add(this.Btn_color);
			this.Controls.Add(this.DrawingArea);
			this.Controls.Add(this.menuStrip1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Thái Bảo An - 21110365";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.Pen_width)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox DrawingArea;
		private System.Windows.Forms.Button Btn_color;
		private System.Windows.Forms.Button Btn_pencil;
		private System.Windows.Forms.Button Btn_erase;
		private System.Windows.Forms.Button Btn_ellipse;
		private System.Windows.Forms.Button Btn_rectangle;
		private System.Windows.Forms.Button Btn_line;
		private System.Windows.Forms.Button Btn_fill;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.NumericUpDown Pen_width;
		private System.Windows.Forms.Button Btn_clear;
		private System.Windows.Forms.Button Btn_triangle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button pick_color;
		private System.Windows.Forms.Button Btn_save;
		private System.Windows.Forms.Button Btn_openfile;
		private System.Windows.Forms.Button Btn_RemoveImg;
	}
}

