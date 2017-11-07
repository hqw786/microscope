using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Microscope
{
    Lens lens;
    Aim aim;

    public Microscope()
    {
        lens = new Lens();
        aim = new Aim();
    }
}
