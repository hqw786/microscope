using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    //Manager manager = Manager.GetInstance();
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
        Manager.GetInstance().SetStateMachineState(State.Init);
	}
	
	// Update is called once per frame
	void Update () {
        Manager.GetInstance().stateMachine.Run();
	}
}
