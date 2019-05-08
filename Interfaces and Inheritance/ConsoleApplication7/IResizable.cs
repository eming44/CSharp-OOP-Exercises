﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    interface IResizable
    {
        void Resize(int weightX, int weightY);
        void ResizeByX(int weightX);
        void ResizeByY(int weightY);
    }
}
