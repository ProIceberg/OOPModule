using System;
using System.Windows.Forms;

namespace EU_Voting_Calculator
{
    internal class vScrollBar
    {
        internal DockStyle Dock;
        internal int Width;
        internal int Height;
        internal string Name;

        public static implicit operator vScrollBar(VScrollBar v)
        {
            throw new NotImplementedException();
        }
    }
}