using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCons
{
    static class DrawerProvider
    {
        static IDrawer _drawer = new ConsoleDrawer();

        public static IDrawer Drawer { get { return _drawer; } }
    }
}
