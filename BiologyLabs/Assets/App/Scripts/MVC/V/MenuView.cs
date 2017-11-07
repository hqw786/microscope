using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


internal class MenuView : View
{
    Button button;
    public MenuView()
    {
        Manager.Instance.LoadScene(Define.SceneName_Menu);
        RegisterRequestEvent(Define.MSG_C_Run, new Menu_GoRunScene_Command().Execute);
    }
    internal void Init()
    {
        GameObject g = GameObject.Find("/Canvas/Button");
        Manager.Instance.print(g.ToString());
        if (g != null)
        {
            button = g.GetComponent<Button>();
            button.onClick.AddListener(ButtonOnClick);
        }
    }
    private void ButtonOnClick()
    {
        Manager.Instance.SetStateMachineState(State.Run);
    }

    internal override void ExecuteRequest(string message, object args = null)
    {
        throw new NotImplementedException();
    }

    
}
