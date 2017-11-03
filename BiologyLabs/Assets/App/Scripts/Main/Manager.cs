using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

internal class Manager
{
    #region 单例
    private static Manager instance;
    private static readonly object lockValue = new object();
    private Manager() 
    {
        Debug.Log("Manager默认构造函数");
    }

    public static Manager GetInstance()
    {
        if (instance == null)
        {
            return new Manager();
        }
        else
        {
            return instance;
        }
    }
    #endregion

    //状态机
    public StateMachine stateMachine = new StateMachine();

    public void Init()
    {
        //切换状态
        SetStateMachineState(State.Logo);
        Debug.Log("初始化完成，下一步切换状态到显示公司Logo");
    }

    public void SetStateMachineState(State state)
    {
        stateMachine.SetState(state);
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
