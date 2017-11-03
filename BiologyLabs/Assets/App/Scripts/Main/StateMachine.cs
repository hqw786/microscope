using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public enum State
{
    Init,
    Logo,
    Logo2,
    Menu,
    Run,
    End
}
internal class StateMachine
{
    public StateMachine()
    {
        state = State.Init;
        Debug.Log(state + "StateMachine默认构造函数");
    }
    State state;
    public void Run()
    {
        Debug.Log(state);
        switch(state)
        {
            case State.Init:
                {
                    Manager.GetInstance().Init();
                }
                break;
            case State.Logo:
                {
                    //切换到公司LOGO场景
                    new CompanyLogoView();
                }
                break;
            case State.Logo2:
                {

                }
                break;
            case State.Menu:
                {

                }
                break;
            case State.Run:
                {

                }
                break;
            case State.End:
                {

                }
                break;
        }
    }

    public void SetState(State state)
    {
        this.state = state;
        Debug.Log(state);
    }
}
