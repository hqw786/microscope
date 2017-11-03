using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


internal class CompanyLogoView : View
{

    public CompanyLogoView()
    {
        //加载CompanyLogo场景
        Manager.GetInstance().LoadScene(Define.SceneName_Logo1);
    }
    internal override void ExecuteRequest(string message, object args = null)
    {
        
    }
}
