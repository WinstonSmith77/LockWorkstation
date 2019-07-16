using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockWorkstation
{

    class Program
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool LockWorkStation();

        static void Main()
        {
           LockWorkStation();
        }
    }
}
