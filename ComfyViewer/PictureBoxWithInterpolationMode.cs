namespace ComfyViewer
{
	public class PictureBoxWithInterpolationMode : System.Windows.Forms.PictureBox
	{
		public PictureBoxWithInterpolationMode()
			: this(System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear)
		{
		}

		public PictureBoxWithInterpolationMode(System.Drawing.Drawing2D.InterpolationMode mode)
		{
			this.InterpolationMode = mode;
			this.DoubleBuffered = true;
		}

		public System.Drawing.Drawing2D.InterpolationMode InterpolationMode { get; set; }

		protected override void OnPaint(System.Windows.Forms.PaintEventArgs paintEventArgs)
		{
			paintEventArgs.Graphics.InterpolationMode = InterpolationMode;
			base.OnPaint(paintEventArgs);
		}
	}
}
