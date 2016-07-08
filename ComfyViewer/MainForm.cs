using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComfyViewer
{
	/// <summary>
	/// Designer content
	/// </summary>
	public partial class MainForm : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Button BT_CLOSE;
		public System.Windows.Forms.Button BT_DEL;
		public System.Windows.Forms.Button BT_KILLALL;
		public System.Windows.Forms.Button BT_L;
		public System.Windows.Forms.Button BT_R;
		public System.Windows.Forms.Button BT_SIZER;
		public PictureBoxWithInterpolationMode PB_IMG;

		public void InitializeComponent()
		{
			this.BT_L = new System.Windows.Forms.Button();
			this.BT_R = new System.Windows.Forms.Button();
			this.BT_KILLALL = new System.Windows.Forms.Button();
			this.BT_CLOSE = new System.Windows.Forms.Button();
			this.BT_DEL = new System.Windows.Forms.Button();
			this.BT_SIZER = new System.Windows.Forms.Button();
			this.PB_IMG = new ComfyViewer.PictureBoxWithInterpolationMode();
			((System.ComponentModel.ISupportInitialize)(this.PB_IMG)).BeginInit();
			this.SuspendLayout();
			//
			// BT_L
			//
			this.BT_L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BT_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BT_L.Location = new System.Drawing.Point(12, 521);
			this.BT_L.Name = "BT_L";
			this.BT_L.Size = new System.Drawing.Size(75, 75);
			this.BT_L.TabIndex = 0;
			this.BT_L.Text = "<";
			this.BT_L.UseVisualStyleBackColor = true;
			this.BT_L.Click += new System.EventHandler(this.BT_L_Click);
			//
			// BT_R
			//
			this.BT_R.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BT_R.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BT_R.Location = new System.Drawing.Point(93, 521);
			this.BT_R.Name = "BT_R";
			this.BT_R.Size = new System.Drawing.Size(75, 75);
			this.BT_R.TabIndex = 1;
			this.BT_R.Text = ">";
			this.BT_R.UseVisualStyleBackColor = true;
			this.BT_R.Click += new System.EventHandler(this.BT_R_Click);
			//
			// BT_KILLALL
			//
			this.BT_KILLALL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BT_KILLALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BT_KILLALL.Location = new System.Drawing.Point(255, 521);
			this.BT_KILLALL.Name = "BT_KILLALL";
			this.BT_KILLALL.Size = new System.Drawing.Size(75, 75);
			this.BT_KILLALL.TabIndex = 2;
			this.BT_KILLALL.Text = "close all";
			this.BT_KILLALL.UseVisualStyleBackColor = true;
			this.BT_KILLALL.Click += new System.EventHandler(this.BT_KILLALL_Click);
			//
			// BT_CLOSE
			//
			this.BT_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BT_CLOSE.Location = new System.Drawing.Point(694, 12);
			this.BT_CLOSE.Name = "BT_CLOSE";
			this.BT_CLOSE.Size = new System.Drawing.Size(75, 75);
			this.BT_CLOSE.TabIndex = 3;
			this.BT_CLOSE.Text = "close";
			this.BT_CLOSE.UseVisualStyleBackColor = true;
			this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
			//
			// BT_DEL
			//
			this.BT_DEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BT_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BT_DEL.Location = new System.Drawing.Point(694, 521);
			this.BT_DEL.Name = "BT_DEL";
			this.BT_DEL.Size = new System.Drawing.Size(75, 75);
			this.BT_DEL.TabIndex = 4;
			this.BT_DEL.Text = "delete";
			this.BT_DEL.UseVisualStyleBackColor = true;
			this.BT_DEL.Click += new System.EventHandler(this.BT_DEL_Click);
			//
			// BT_SIZER
			//
			this.BT_SIZER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BT_SIZER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BT_SIZER.Location = new System.Drawing.Point(174, 521);
			this.BT_SIZER.Name = "BT_SIZER";
			this.BT_SIZER.Size = new System.Drawing.Size(75, 75);
			this.BT_SIZER.TabIndex = 5;
			this.BT_SIZER.Text = "fit";
			this.BT_SIZER.UseVisualStyleBackColor = true;
			this.BT_SIZER.Click += new System.EventHandler(this.BT_SIZER_Click);
			//
			// PB_IMG
			//
			this.PB_IMG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.PB_IMG.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			this.PB_IMG.Location = new System.Drawing.Point(0, 0);
			this.PB_IMG.Margin = new System.Windows.Forms.Padding(0);
			this.PB_IMG.Name = "PB_IMG";
			this.PB_IMG.Size = new System.Drawing.Size(781, 608);
			this.PB_IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PB_IMG.TabIndex = 6;
			this.PB_IMG.TabStop = false;
			//
			// MainForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 608);
			this.ControlBox = false;
			this.Controls.Add(this.BT_SIZER);
			this.Controls.Add(this.BT_DEL);
			this.Controls.Add(this.BT_CLOSE);
			this.Controls.Add(this.BT_KILLALL);
			this.Controls.Add(this.BT_R);
			this.Controls.Add(this.BT_L);
			this.Controls.Add(this.PB_IMG);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(9000, 9000);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.PB_IMG)).EndInit();
			this.ResumeLayout(false);
		}
	}

	public partial class MainForm : System.Windows.Forms.Form
	{
		// defines how far away from the windows borders the cursor changes to resize
		public const int sizeCursorBoundry = 35;

		// list of files that can be displayed
		public System.Collections.Generic.List<string> fileList = new List<string>();

		// currently displayed file of the previous list, this is dumb and should be replaced with something smarter like a linked data structure I guess
		public int filePosition = 0;

		// when switching to an image it takes some time before ComfyViewer will create a thumbnail of the displayed image. This happens because thumbnail generation is very slow
		private System.Windows.Forms.Timer iconTimer = new System.Windows.Forms.Timer();

		// time before control elements become invisible after you move the cursor outside of the window
		public System.Windows.Forms.Timer invisTimer = new System.Windows.Forms.Timer();

		// GUI controls that can become invisible
		private List<Control> guiControls = new List<Control>();

		// used for creating a taskbar icon of the current image
		private MemoryStream lastMemoryStream = null;

		private Bitmap lastBm = null;

		// When an image can't be displayed the next one will be display, if something goes horribly wrong and 100 images in a row can't be displayed the program will terminate
		private long errorCount = 0;

		// height and width ratio of the currently displayed image: relevant for forced aspect ratio resize
		public double heightRatio = 0;

		public double widthRatio = 0;

		public MainForm()
		{
			InitializeComponent();
		}

		public MainForm(string[] args)
		{
			Task t = Task.Run(() =>
			{
				Regex regex = new Regex(@"(\.(jpg|png|gif|jpeg|bmp))$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
				int i = 0;
				IEnumerable<string> filesInDirectory = System.IO.Directory.EnumerateFiles(args[0].Substring(0, args[0].LastIndexOf(Path.DirectorySeparatorChar)));
				foreach (string filepath in filesInDirectory)
				{
					if (regex.IsMatch(filepath))
					{
						fileList.Add(filepath);
						if (filepath == args[0])
						{
							filePosition = i;
						}
						i++;
					}
				}
			});

			InitializeComponent();

			guiControls.Add(BT_CLOSE);
			guiControls.Add(BT_DEL);
			guiControls.Add(BT_KILLALL);
			guiControls.Add(BT_L);
			guiControls.Add(BT_R);
			guiControls.Add(BT_SIZER);

			SetVisibilityOfGuiControls(false);

			invisTimer.Tick += (a, b) =>
			{
				SetVisibilityOfGuiControls(false);
				invisTimer.Stop();
			};
			invisTimer.Interval = 800;

			this.PB_IMG.MouseDown += this.Action_LMouseDownAndMove;

			// allows negative y values (moving the window above the upper screen border)
			int lasty = 0;
			this.Move += (a, b) =>
			{
				if (this.Location.Y == 0)
				{
					this.Location = new Point(this.Location.X, lasty);
				}

				lasty = this.Location.Y;
			};

			this.PB_IMG.MouseMove += MouseMoveEventToMakeAndKeepGuiControlsVisible;

			foreach (Control c in guiControls)
			{
				c.MouseMove += MouseMoveEventToMakeAndKeepGuiControlsVisible;
			}

			// changes cursor to resize cursor give visual feedback
			this.PB_IMG.MouseMove += (a, e) =>
			{
				System.Drawing.Point mousePosition = this.PointToClient(System.Windows.Forms.Cursor.Position);

				if (mousePosition.X < sizeCursorBoundry)
				{
					if (mousePosition.Y < sizeCursorBoundry)
						this.PB_IMG.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
					else if (mousePosition.Y > this.Size.Height - sizeCursorBoundry)
						this.PB_IMG.Cursor = System.Windows.Forms.Cursors.SizeNESW;
					else
						this.PB_IMG.Cursor = System.Windows.Forms.Cursors.SizeWE;
				}
				else if (mousePosition.X > this.Size.Width - sizeCursorBoundry)
				{
					if (mousePosition.Y < sizeCursorBoundry)
						this.PB_IMG.Cursor = System.Windows.Forms.Cursors.SizeNESW;
					else if (mousePosition.Y > this.Size.Height - sizeCursorBoundry)
						this.PB_IMG.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
					else
						this.PB_IMG.Cursor = System.Windows.Forms.Cursors.SizeWE;
				}
				else if (mousePosition.Y < sizeCursorBoundry)
					this.PB_IMG.Cursor = System.Windows.Forms.Cursors.SizeNS;
				else if (mousePosition.Y > this.Size.Height - sizeCursorBoundry)
					this.PB_IMG.Cursor = System.Windows.Forms.Cursors.SizeNS;
				else
					this.PB_IMG.Cursor = System.Windows.Forms.Cursors.Default;
			};

			// mousewheel zoom
			// TODO: well defined stops including exactly 200%, 100% and 50%
			this.MouseWheel += (a, b) =>
			{
				if (b.Delta > 0)
				{
					this.Width = (int)Math.Round(this.Width * 1.1);
					this.Height = (int)Math.Round(this.Height * 1.1);
				}
				else if (b.Delta < 0)
				{
					this.Width = (int)Math.Round(this.Width * 0.9);
					this.Height = (int)Math.Round(this.Height * 0.9);
				}
			};

			iconTimer.Tick += (a, b) =>
			{
				ExternalMethods.DestroyIcon(this.Icon.Handle);
				IntPtr intPtr = lastBm.GetHicon();
				this.Icon = Icon.FromHandle(intPtr);
				iconTimer.Stop();
			};
			iconTimer.Interval = 2222;
			iconTimer.Stop();
			t.Wait();
			LoadImageFromPath(args[0]);
			this.PB_IMG.Focus();
		}

		public void SetVisibilityOfGuiControls(bool x)
		{
			foreach (Control c in guiControls)
			{
				c.Visible = x;
			}
		}

		// Go left and right via keyboard keys
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Left) GoLeft();
			else if (keyData == Keys.Right) GoRight();
			return true;
		}

		// I really can't remember what this method is supposed to do
		protected override void SetBoundsCore(int x, int y, int width, int height, System.Windows.Forms.BoundsSpecified specified)
		{
			ExternalMethods.SetWindowPos(this.Handle, (IntPtr)SpecialWindowHandles.HWND_TOP, x, y, width, height, SetWindowPosFlags.SWP_SHOWWINDOW);
		}

		// enforces fixed aspect ratio when resizing
		protected override void WndProc(ref Message message)
		{
			if (message.Msg == 0x214)
			{
				RectangleStruct rc = (RectangleStruct)System.Runtime.InteropServices.Marshal.PtrToStructure(message.LParam, typeof(RectangleStruct));
				int res = message.WParam.ToInt32();
				if (res < 3)
					rc.Bottom = rc.Top + (int)(heightRatio * this.Width / widthRatio);
				else if (res == 3 || res == 6)
					rc.Right = rc.Left + (int)(widthRatio * this.Height / heightRatio);
				else if (res == 4)
					rc.Left = rc.Right - (int)(widthRatio * this.Height / heightRatio);
				else if (res == 5)
					rc.Top = rc.Bottom - (int)(heightRatio * this.Width / widthRatio);
				else if (res == 7)
					rc.Left = rc.Right - (int)(widthRatio * this.Height / heightRatio);
				else if (res == 8)
					rc.Bottom = rc.Top + (int)(heightRatio * this.Width / widthRatio);

				System.Runtime.InteropServices.Marshal.StructureToPtr(rc, message.LParam, true);
			}
			base.WndProc(ref message);
		}

		// move anywhere +
		// extended resizing
		private void Action_LMouseDownAndMove(object sender, object e)
		{
			const int WM_NCLBUTTONDOWN = 0xA1;
			const int HT_CAPTION = 0x2;

			System.Drawing.Point mousePosition = this.PointToClient(System.Windows.Forms.Cursor.Position);
			ExternalMethods.ReleaseCapture(); // necessary for moving the window around & resizing

			// the following code sets the cursor
			if (mousePosition.X < sizeCursorBoundry)
			{
				if (mousePosition.Y < sizeCursorBoundry)
					ExternalMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, 13, 0);
				else if (mousePosition.Y > this.Size.Height - sizeCursorBoundry)
					ExternalMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, 16, 0);
				else
					ExternalMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, 10, 0);
			}
			else if (mousePosition.X > this.Size.Width - sizeCursorBoundry)
			{
				if (mousePosition.Y < sizeCursorBoundry)
					ExternalMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, 14, 0);
				else if (mousePosition.Y > this.Size.Height - sizeCursorBoundry)
					ExternalMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, 17, 0);
				else
					ExternalMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, 11, 0);
			}
			else if (mousePosition.Y < sizeCursorBoundry)
				ExternalMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, 12, 0);
			else if (mousePosition.Y > this.Size.Height - sizeCursorBoundry)
				ExternalMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, 15, 0);
			else
				ExternalMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // move the winow
		}

		private void BT_CLOSE_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.GetCurrentProcess().Kill();
		}

		private void BT_DEL_Click(object sender, System.EventArgs e)
		{
			int lastPos = filePosition;
			GoRight();
			System.IO.File.Delete(fileList[lastPos]);
		}

		private void BT_KILLALL_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process currentProcess = System.Diagnostics.Process.GetCurrentProcess();

			foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName(currentProcess.ProcessName))
			{
				if (currentProcess.Id != process.Id)
				{
					process.Kill();
				}
			}

			currentProcess.Kill();
		}

		private void BT_L_Click(object sender, System.EventArgs e)
		{
			GoLeft();
		}

		private void BT_R_Click(object sender, System.EventArgs e)
		{
			GoRight();
		}

		private void BT_SIZER_Click(object sender, System.EventArgs e)
		{
			this.Size = PB_IMG.Image.Size;
		}

		private void Go(Action next)
		{
			if (System.IO.File.Exists(fileList[filePosition]))
			{
				try
				{
					LoadImageFromPath(fileList[filePosition]);
					errorCount = 0;
				}
				catch (Exception ex) when (ex is OutOfMemoryException || ex is ArgumentException) // happens on Image.FromFile when used on certain invalid images
				{
					errorCount++;
					if (errorCount > 100)
					{
						Process.GetCurrentProcess().Kill();
					}
					next();
				}
			}
			else
			{
				next();
			}
		}

		private void GoLeft()
		{
			if (--filePosition < 0)
			{
				filePosition = fileList.Count - 1;
			}

			Go(GoLeft);
		}

		private void GoRight()
		{
			if (++filePosition > fileList.Count - 1)
			{
				filePosition = 0;
			}
			Go(GoRight);
		}

		private void LoadImageFromPath(string path)
		{
			if (lastMemoryStream != null)
			{
				lastMemoryStream.Close();
			}
			byte[] fileBytes = File.ReadAllBytes(path);
			lastMemoryStream = new MemoryStream(fileBytes);

			Bitmap bm = (Bitmap)Bitmap.FromStream(lastMemoryStream);
			PB_IMG.Image = bm;
			lastBm = bm;
			iconTimer.Stop();
			iconTimer.Start();

			this.widthRatio = PB_IMG.Image.Width;
			this.heightRatio = PB_IMG.Image.Height;
			this.Text = fileList[filePosition];
			if (this.heightRatio > 1200)
			{
				this.Height = 1200;
				this.Width = (int)(1200 / (this.heightRatio / this.widthRatio));
			}
			else
			{
				this.Height = (int)this.heightRatio;
				this.Width = (int)this.widthRatio;
			}
		}

		private void MouseMoveEventToMakeAndKeepGuiControlsVisible(object o, object e)
		{
			SetVisibilityOfGuiControls(true);
			invisTimer.Stop();
			invisTimer.Start();
		}
	}

	internal static class Program
	{
		//[System.STAThread]
		private static void Main(string[] args)
		{
			System.Windows.Forms.Application.Run(new MainForm(args));
		}
	}

	public struct RectangleStruct
	{
		public int Left;
		public int Top;
		public int Right;
		public int Bottom;
	}
}