using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Microscope
{
    public Lens lens;
    public AimView aim;

    public Microscope()
    {
        lens = new Lens();
        aim = new AimView();
    }
}
