using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RunView : View
{
    Microscope microscope;
    public RunView()
    {
        Manager.Instance.LoadScene(Define.SceneName_Run);
        Manager.Instance.microscope = new Microscope();
    }

    public void Init()
    {
        microscope = Manager.Instance.microscope;
        microscope.aim.av.Init();
    }
    public void Run()
    {
        microscope.aim.av.Run();
    }
    internal override void ExecuteRequest(string message, object args = null)
    {
        throw new NotImplementedException();
    }
}

