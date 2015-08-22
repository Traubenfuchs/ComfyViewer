﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ComfyViewer
{
	/// <summary>
	/// Designer content
	/// </summary>
	public partial class MainForm : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Button BT_L;
		public System.Windows.Forms.Button BT_R;
		public System.Windows.Forms.Button BT_KILLALL;
		public System.Windows.Forms.Button BT_CLOSE;
		public System.Windows.Forms.Button BT_DEL;
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
			this.BT_L.Text = "L";
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
			this.BT_R.Text = "R";
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
			this.BT_SIZER.Text = "Fit";
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
		public const int sizeCursorBoundry = 35;
		public double heightRatio = 0;
		public double widthRatio = 0;
		public int position = 0;
		public int lasty = 0;
		public System.Collections.Generic.List<string> fileList = null;
		public System.Windows.Forms.Timer invisTimer = new System.Windows.Forms.Timer();

		private List<Control> guiControls = new List<Control>();

		public MainForm()
		{
			InitializeComponent();
		}

		public MainForm(string[] args)
		{
			
			InitializeComponent();

			guiControls.Add(BT_CLOSE);
			guiControls.Add(BT_DEL);
			guiControls.Add(BT_KILLALL);
			guiControls.Add(BT_L);
			guiControls.Add(BT_R);
			guiControls.Add(BT_SIZER);

			SetVisibilityOfGuiControls(false);

			fileList = new System.Collections.Generic.List<string>();

			int i = 0;
			var validExtensions = new[] { "JPG", "JPEG", "BMP", "GIF", "PNG" };
			foreach (string filepath in System.IO.Directory.EnumerateFiles(args[0].Substring(0, args[0].LastIndexOf(Path.PathSeparator))))
			{
				string normalizedPath = filepath.ToUpper();
				if (validExtensions.Any(normalizedPath.EndsWith))
				{
					fileList.Add(filepath);
					if (filepath.Equals(args[0]))
						position = i;
					i++;
				}
			}

			invisTimer.Tick += (a, b) =>
			{
				SetVisibilityOfGuiControls(false);
				invisTimer.Stop();
			};
			invisTimer.Interval = 800;

			this.PB_IMG.MouseDown += this.Action_LMouseDownAndMove;

			// allows moving outside of screen bounds
			this.Move += (a, b) =>
			{
				if (this.Location.Y == 0)
					this.Location = new Point(this.Location.X, lasty);

				lasty = this.Location.Y;
			};

			this.PB_IMG.MouseMove += MouseMoveEventToMakeAndKeepGuiControlsVisible;

			foreach (Control c in guiControls)
				c.MouseMove += MouseMoveEventToMakeAndKeepGuiControlsVisible;

			// changes cursor to give visual feedback
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

			LoadImage(args[0]);
			//using (Image img = System.Drawing.Image.FromFile(args[0]))
			//{
				
			//	PB_IMG.Image = (Image)img.Clone();d
			//}
			this.Text = args[0];
			this.widthRatio = PB_IMG.Image.Width;
			this.heightRatio = PB_IMG.Image.Height;

			if ((int)this.heightRatio > 1200)
			{
				this.Height = 1200;
				this.Width = (int)(1200 / (this.heightRatio / this.widthRatio));
			}
			else
			{
				this.Height = (int)this.heightRatio;
				this.Width = (int)this.widthRatio;
			}
			this.PB_IMG.Focus(); ;
		}

		public void SetVisibilityOfGuiControls(bool x)
		{
			foreach (Control c in guiControls)
				c.Visible = x;
		}

		// Go left and right via keyboard keys
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Left) GoLeft();
			else if (keyData == Keys.Right) GoRight();
			return true;
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

		protected override void SetBoundsCore(int x, int y, int width, int height, System.Windows.Forms.BoundsSpecified specified)
		{
			ExternalMethods.SetWindowPos(this.Handle, (IntPtr)SpecialWindowHandles.HWND_TOP, x, y, width, height, SetWindowPosFlags.SWP_SHOWWINDOW);
		}

		private static long l = 0;

		private void MouseMoveEventToMakeAndKeepGuiControlsVisible(object o, object e)
		{
			SetVisibilityOfGuiControls(true);
			invisTimer.Stop();
			invisTimer.Start();
		}

		private void GoLeft()
		{
			if (--position < 0)
				position = fileList.Count - 1;

			Go(GoLeft);
		}

		private void GoRight()
		{
			if (++position > fileList.Count - 1)
				position = 0;
			Go(GoRight);
		}

		[System.Runtime.InteropServices.DllImport("user32")]
		public static extern bool DestroyIcon(IntPtr hIcon);

		private void LoadImage(string path)
		{
			var bytes = File.ReadAllBytes(path);
			var ms = new MemoryStream(bytes);
			var img = Image.FromStream(ms);
			ms = new MemoryStream(bytes);
			var bm = (Bitmap)Bitmap.FromStream(ms);

			PB_IMG.Image = img;

			DestroyIcon(this.Icon.Handle);

			this.Icon = Icon.FromHandle(bm.GetHicon());
		}

		private void Go(Action next)
		{
			if (System.IO.File.Exists(fileList[position]))
			{
				try
				{
					LoadImage(fileList[position]);
				}
				catch (OutOfMemoryException) // happens on Image.FromFile when used on certain invalid images
				{
					Go(next);
				}

				this.widthRatio = PB_IMG.Image.Width;
				this.heightRatio = PB_IMG.Image.Height;
				this.Text = fileList[position];
				if ((int)this.heightRatio > 1200)
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
			else
				Go(next);
		}

		// move anywhere +
		// extended resizing
		private void Action_LMouseDownAndMove(object sender, object e)
		{
			const int WM_NCLBUTTONDOWN = 0xA1;
			const int HT_CAPTION = 0x2;

			// moving and resizing
			//if (e.Button == System.Windows.Forms.MouseButtons.Left)
			//{
			System.Drawing.Point mousePosition = this.PointToClient(System.Windows.Forms.Cursor.Position);
			ExternalMethods.ReleaseCapture();
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
																					  //}
		}

		// BT ACTIONS
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
			this.Size = new Size((int)PB_IMG.Image.Width, (int)PB_IMG.Image.Height);
		}

		private void BT_KILLALL_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process currentProcess = System.Diagnostics.Process.GetCurrentProcess();

			foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName("ComfyViewer"))
				if (currentProcess.Id != process.Id)
					process.Kill();

			currentProcess.Kill();
		}

		private void BT_DEL_Click(object sender, System.EventArgs e)
		{
			string deletee = fileList[position];
			//PB_IMG.Image.Dispose();
			GoRight();
			System.IO.File.Delete(deletee);
		}

		private void BT_CLOSE_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.GetCurrentProcess().Kill();
		}
	}

	internal static class Program
	{
		[System.STAThread]
		private static void Main(string[] args)
		{
			System.Windows.Forms.Application.Run(new MainForm(args));
		}
	}
}