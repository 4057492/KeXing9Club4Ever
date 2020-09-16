using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateM{
	public virtual void Enter(Statem statem){

	}
	public virtual void Execute(Statem statem){

	}
	public virtual void Exit(Statem statem){

	}
}

public class Statem : MonoBehaviour {

	public StateM currentState = null;

	void Start () {
	}

	void Update () {
		if (currentState != null) {
			currentState.Execute (this);
		}
	}

	public void ChangeState(StateM newState){
		currentState.Exit (this);
		currentState = newState;
		currentState.Enter (this);
	}
}
