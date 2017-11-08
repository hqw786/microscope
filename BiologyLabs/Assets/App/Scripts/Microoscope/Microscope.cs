using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Microscope
{
    public Lens lens;
    public Aim aim;

    public Microscope()
    {
        lens = new Lens();
        aim = new Aim();
    }
}
