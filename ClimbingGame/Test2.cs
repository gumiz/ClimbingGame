using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using SlimDX.Windows;

namespace ClimbingGame
{
	public class Test2
	{
		private Form _form;
		private Bitmap[] _src;
		private Bitmap _bmp;

		public Test2(Form form)
		{
			_form = form;
			_src = new Bitmap[25];
			for (var i = 0; i < 24; i++)
			{
				var name = $"d:/_projects/ClimbingGame/trunk/ClimbingGame/img/ball{i+1:D2}.png";
				_src[i] = new Bitmap(name);
			}
			_bmp = new Bitmap(100, 100, PixelFormat.Format32bppPArgb);
		}

		public void Run()
		{
			var index = 0;
			MessagePump.Run(_form, () =>
			{
				var grap = _form.CreateGraphics();
				grap.Clear(Color.Black);
				grap.DrawImage(_src[index++], new Rectangle(0, 0, _bmp.Width, _bmp.Height));
				System.Threading.Thread.Sleep(50);
				if (index == 24) index = 0;
			});

		}
	}
}