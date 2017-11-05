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
    }
    State state;
    public void Run()
    {
        switch(state)
        {
            case State.Init:
                {
                    Manager.Instance.Init();
                }
                break;
            case State.Logo:
                {
                    //切换到公司LOGO场景
                    if (Manager.Instance.companyLogoView == null)
                        Manager.Instance.companyLogoView = new CompanyLogoView();
                    else
                        Manager.Instance.companyLogoView.AnimIsDone();
                }
                break;
            case State.Logo2:
                {
                    if (Manager.Instance.cooperationLogoView == null)
                        Manager.Instance.cooperationLogoView = new CooperationLogoView();
                    else
                        Manager.Instance.cooperationLogoView.Run();
                }
                break;
            case State.Menu:
                {
                    if(Manager.Instance.menuView == null)
                    {
                        Manager.Instance.menuView = new MenuView();
                    }
                    //else
                    //{

                    //}
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
    }
}
