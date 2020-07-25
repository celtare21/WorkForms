using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class HoursOutOfBounds : Exception
    {
        public HoursOutOfBounds()
        {
            MessageBox.Show("Too many hours in a day! Lower the starting time!");
        }
    }
}
