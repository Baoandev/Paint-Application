using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp   // Thái Bảo An - 21110365 - Hoàn thiện ngày 16/4
{

	public partial class Form1 : Form
	{
		private Point Start, End;
		private List<Triangle> trianglesList;
		Bitmap bm;
		Graphics g;
		bool isDrawing = false;
		Point px, py;
		Pen pen = new Pen(Color.Black, 1);
		Pen erase = new Pen(Color.White, 10);
		int x, y, sX, sY, cX, cY;
		ColorDialog cd = new ColorDialog();
		Color New_Color;
		bool isObjectSelected = false;

		public enum TOOL
		{
			SELECT,
			PEN,
			ERASER,
			FILLCOLOR,
			LINE,
			ELLIPSE,
			RECTANGLE,
			TRIANGLE
		}

		public TOOL curTool = TOOL.SELECT;
		public Form1()
		{
			InitializeComponent();
			DoubleBuffered = true;
			g = DrawingArea.CreateGraphics();
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
			bm = new Bitmap(DrawingArea.Width, DrawingArea.Height);
			g = Graphics.FromImage(bm);
			g.Clear(Color.White);
			DrawingArea.Image = bm;
			trianglesList = new List<Triangle>();
			pen.Width = (float)Pen_width.Value;
		}
		private void DrawingArea_MouseMove(object sender, MouseEventArgs e)
		{


			if (e.Button == MouseButtons.Left)
			{
				if (isDrawing)
				{
					if (curTool == TOOL.PEN)
					{
						px = e.Location;
						g.DrawLine(pen, px, py);
						py = px;
					}
					if (curTool == TOOL.ERASER)
					{
						px = e.Location;
						g.DrawLine(erase, px, py);
						py = px;
					}
				}
				if (curTool == TOOL.TRIANGLE)
				{
					End = e.Location;
					this.Invalidate();
				}

			}
			

			DrawingArea.Refresh();

			x = e.X;
			y = e.Y;
			sX = e.X - cX;
			sY = e.Y - cY;

		}

		private void DrawingArea_MouseUp(object sender, MouseEventArgs e)
		{
			isDrawing = false;

			sX = x - cX;
			sY = y - cY;

			if (curTool == TOOL.ELLIPSE)
			{
				g.DrawEllipse(pen, cX, cY, sX, sY);
			}
			if (curTool == TOOL.RECTANGLE)
			{
				g.DrawRectangle(pen, cX, cY, sX, sY);
			}
			if (curTool == TOOL.LINE)
			{
				g.DrawLine(pen, cX, cY, x, y);
			}
			if (curTool == TOOL.TRIANGLE)
			{

				End = e.Location;
				this.Invalidate();
				Point point1 = Start;
				Point point2 = new Point((Start.X + End.X) / 2, End.Y);
				Point point3 = End;
				g.DrawPolygon(pen, new Point[] { point1, point2, point3 });
			}
		}

		private void DrawingArea_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			if (isDrawing)
			{
				if (curTool == TOOL.ELLIPSE)
				{
					g.DrawEllipse(pen, cX, cY, sX, sY);

				}
				if (curTool == TOOL.RECTANGLE)
				{
					g.DrawRectangle(pen, cX, cY, sX, sY);
				}
				if (curTool == TOOL.LINE)
				{
					g.DrawLine(pen, cX, cY, x, y);
				}
				if (curTool == TOOL.TRIANGLE)
				{

					Point point1 = Start;
					Point point2 = new Point((Start.X + End.X) / 2, End.Y);
					Point point3 = End;
					g.DrawPolygon(pen, new Point[] { point1, point2, point3 });
				}
			}
		}

		private void DrawingArea_MouseDown(object sender, MouseEventArgs e)
		{
			isDrawing = true;
			Start = End = e.Location;
			py = e.Location;

			cX = e.X;
			cY = e.Y;

		}
		static Point set_Point(PictureBox pb, Point pt)
		{
			float px = 1f * pb.Width / pb.Width;
			float py = 1f * pb.Height / pb.Height;
			return new Point((int)(pt.X * px), (int)(pt.Y * py));
		}
		private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
		{
			Color cx = bm.GetPixel(x, y);
			if (cx == Old_Color)
			{
				sp.Push(new Point(x, y));
				bm.SetPixel(x, y, New_Color);
			}
		}
		public void Fill(Bitmap bm, int x, int y, Color New_Clr)
		{
			Color Old_Color = bm.GetPixel(x, y);
			Stack<Point> pixel = new Stack<Point>();
			pixel.Push(new Point(x, y));
			bm.SetPixel(x, y, New_Clr);
			if (Old_Color == New_Clr) { return; }

			while (pixel.Count > 0)
			{
				Point pt = (Point)pixel.Pop();
				if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
				{
					Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
					Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_Clr);
					Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
					Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_Clr);
				}
			}
		}
		private void Btn_color_Click(object sender, EventArgs e)
		{
			cd.ShowDialog();
			New_Color = cd.Color;
			DrawingArea.BackColor = cd.Color;
			pen.Color = cd.Color;
			pick_color.BackColor = cd.Color;
		}

		private void Btn_pencil_Click(object sender, EventArgs e)
		{
			curTool = TOOL.PEN;

		}

		private void DrawingArea_MouseClick(object sender, MouseEventArgs e)
		{
			if (curTool == TOOL.FILLCOLOR)
			{
				Point point = set_Point(DrawingArea, e.Location);
				Fill(bm, point.X, point.Y, New_Color);
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result;
			result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
			else
			{ 
				e.Cancel = true; 
			}
		}

		private void Btn_triangle_Click(object sender, EventArgs e)
		{
			curTool = TOOL.TRIANGLE;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pick_color_Click(object sender, EventArgs e)
		{

		}
		

	
		

		private void Btn_erase_Click(object sender, EventArgs e)
		{
			curTool = TOOL.ERASER;

		}

		private void Btn_save_Click_1(object sender, EventArgs e)  // nhập tên file output 
		{
			if (DrawingArea.Image != null)
			{
				var sdf = new SaveFileDialog();
				sdf.Filter = "Image(*.png)|*.png";
				if (sdf.ShowDialog() == DialogResult.OK)
				{
					Bitmap btm = bm.Clone(new Rectangle(0, 0, DrawingArea.Width, DrawingArea.Height), bm.PixelFormat);
					btm.Save(sdf.FileName, ImageFormat.Png);
					MessageBox.Show("Đã lưu ảnh");
				}
				else if (DrawingArea.Image == null)
				{
					MessageBox.Show("Hãy vẽ gì đó");
				}
			}
		}

		private void Btn_openfile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// tạo một đối tượng Image từ tệp được chọn
				Image image = Image.FromFile(openFileDialog.FileName);
				// tạo một PictureBox và thiết lập thuộc tính Image của nó
				PictureBox pictureBox = new PictureBox();
				pictureBox.Image = image;
				// thiết lập kích thước cho PictureBox dựa trên kích thước của hình ảnh
				pictureBox.Size = image.Size;
				// thêm PictureBox vào Controls của Panel
				DrawingArea.Controls.Add(pictureBox);
			}
		}

		private void Btn_RemoveImg_Click(object sender, EventArgs e)
		{
			if (DrawingArea.Controls.Count > 0)
			{
				PictureBox pictureBox = (PictureBox)DrawingArea.Controls[0];
				DrawingArea.Controls.Remove(pictureBox);
			}
		}

		private void DrawingArea_Click(object sender, EventArgs e)
		{

		}

		private void Btn_ellipse_Click(object sender, EventArgs e)
		{
			curTool = TOOL.ELLIPSE;

		}

		private void Btn_rectangle_Click(object sender, EventArgs e)
		{
			curTool = TOOL.RECTANGLE;

		}

		private void Btn_line_Click(object sender, EventArgs e)
		{
			curTool = TOOL.LINE;

		}

		private void Btn_fill_Click(object sender, EventArgs e)
		{
			curTool = TOOL.FILLCOLOR;

		}
		private void Btn_clear_Click(object sender, EventArgs e)
		{
			g.Clear(Color.White);
			DrawingArea.Image = bm;
			curTool = TOOL.SELECT;
			trianglesList.Clear();
		}
		private void Pen_width_ValueChanged(object sender, EventArgs e)
		{
			pen.Width = (float)Pen_width.Value;

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
