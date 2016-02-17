using System.Windows.Forms;
using SlimDX;
using SlimDX.DXGI;
using SlimDX.Windows;

namespace ClimbingGame
{
	static class Program
	{

		static void Main()
		{
			var testForm = new Form1();
			testForm.Show();

			//			var test1 = new Test1();
//			test1.Run();

			var test2 = new Test2(testForm);
			test2.Run();


		}
	}
}
