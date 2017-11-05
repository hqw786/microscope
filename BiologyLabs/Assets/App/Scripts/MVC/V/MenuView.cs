using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


internal class MenuView : View
{

    public MenuView()
    {
        Manager.Instance.LoadScene(Define.SceneName_Menu);
    }

    internal override void ExecuteRequest(string message, object args = null)
    {
        throw new NotImplementedException();
    }
}
