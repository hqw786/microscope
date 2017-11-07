using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RunView : View
{
    public RunView()
    {
        Manager.Instance.LoadScene(Define.SceneName_Run);
        Manager.Instance.microscope = new Microscope();
    }

    public void Init()
    {

    }

    internal override void ExecuteRequest(string message, object args = null)
    {
        throw new NotImplementedException();
    }
}

