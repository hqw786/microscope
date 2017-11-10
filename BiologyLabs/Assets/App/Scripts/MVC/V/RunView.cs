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
    /// <summary>
    /// 初始化。场景加载完成之后
    /// </summary>
    public void Init()
    {
        microscope = Manager.Instance.microscope;
        microscope.aim.Init();
        //漫游实例
        Manager.Instance.roamPathManager = new RoamPathManager();
        Manager.Instance.roamManager = new RoamManager();
    }
    public void Run()
    {
        microscope.aim.Run();
    }
    internal override void ExecuteRequest(string message, object args = null)
    {
        throw new NotImplementedException();
    }
}

