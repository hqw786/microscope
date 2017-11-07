using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

internal class Manager
{
    #region 单例
    public static readonly Manager Instance = new Manager();
    private Manager() 
    {
        print("Manager默认构造函数");
    }
    #endregion

    //异步加载
    AsyncOperation async;
    //状态机
    public StateMachine stateMachine = new StateMachine();
    //
    public Microscope microscope;
    //
    //
    //
    //
    //
    //
    //


    public void Init()
    {
        //切换状态
        //SetStateMachineState(State.Logo);
        //print("初始化完成，下一步切换状态到显示公司Logo");
        SetStateMachineState(State.Menu);
        print("菜单界面");
    }

    public void SetStateMachineState(State state)
    {
        stateMachine.SetState(state);
    }
    public void LoadScene(string name)
    {
        async = SceneManager.LoadSceneAsync(name);
        while (async.progress < 0.9f)
        {
            System.Threading.Thread.Sleep(100);
        }
        System.Threading.Thread.Sleep(3000);
    }
    public void print(string str)
    {
        Debug.Log(str);
    }
}
