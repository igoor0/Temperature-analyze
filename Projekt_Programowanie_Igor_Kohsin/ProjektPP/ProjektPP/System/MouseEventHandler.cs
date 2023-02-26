using System.Windows.Forms;

namespace System
{
    internal class MouseEventHandler
    {
        private Action<object, MouseEventArgs> chart1_MouseWheel;

        public MouseEventHandler(Action<object, MouseEventArgs> chart1_MouseWheel)
        {
            this.chart1_MouseWheel = chart1_MouseWheel;
        }
    }
}