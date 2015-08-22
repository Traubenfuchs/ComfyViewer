using System.Runtime.InteropServices;
namespace FapViewer
{
	public static class ExternalMethods
	{
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		[System.Runtime.InteropServices.DllImport("kernel32.dll")]
		[return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
		public static extern bool SetProcessWorkingSetSize(System.IntPtr process, System.UIntPtr minimumWorkingSetSize, System.UIntPtr maximumWorkingSetSize);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: System.Runtime.InteropServices.MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(System.IntPtr hWnd, System.IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);
	}
}
