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
    public CompanyLogoView companyLogoView;
    public CooperationLogoView cooperationLogoView;
    public MenuView menuView;
    public RunView runView;


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
                    if (companyLogoView == null)
                        companyLogoView = new CompanyLogoView();
                    else
                        companyLogoView.AnimIsDone();
                }
                break;
            case State.Logo2:
                {
                    if (cooperationLogoView == null)
                        cooperationLogoView = new CooperationLogoView();
                    else
                        cooperationLogoView.Run();
                }
                break;
            case State.Menu:
                {
                    if(menuView == null)
                    {
                        menuView = new MenuView();
                    }
                    //else
                    //{

                    //}
                }
                break;
            case State.Run:
                {
                    if(runView == null)
                    {
                        runView = new RunView();
                    }
                    else
                    {
                        runView.Run();
                    }
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
