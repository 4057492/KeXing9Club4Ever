using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : Statem {
	//0不动 -1向左 1向右
    public int moveDir = 0;
	public float maxSpeed = 2f;
	public float minSpeed = 0.1f;

	private Rigidbody rig;
	private Animator animator;

	//public GameObject particle;
	//public ParticleSystem pSystem = null;

	public float force = 50f;

	public Vector3 scaleLeft = Vector3.zero;
	private Vector3 scaleRight;

	// Use this for initialization
	void Start () {
        if (scaleLeft == Vector3.zero)
        {
            scaleLeft = transform.localScale;
        }
        scaleRight = new Vector3 (-scaleLeft.x, scaleLeft.y, scaleLeft.z);
		rig = GetComponent<Rigidbody> ();
		animator = GetComponent<Animator> ();
		/*if (particle != null) {
			pSystem = particle.GetComponent<ParticleSystem> ();
		}*/


		currentState = new Stay ();
	}
	bool ShouldAccelerate()
	{
        return (moveDir != 0 && Mathf.Abs(rig.velocity.x) <= maxSpeed);
    }
	
	void Accelerate()
	{
        rig.AddForce(new Vector3(moveDir * force, 0, 0));
    }

	bool ShouldMaintain()
	{
        return (Mathf.Abs(rig.velocity.x) > maxSpeed);
    }

	bool ShouldActStay()
	{
		return (Mathf.Abs(rig.velocity.x) <= minSpeed);
	}

	bool ShouldTurnLeft()
	{
        return (moveDir == -1 && transform.localScale != scaleLeft);
    }
		void TrunLeft()
	{
        transform.localScale = scaleLeft;
    }

	bool ShouldTurnRight()
	{
		return (moveDir == 1 && transform.localScale != scaleRight);
	}

	void TurnRight()
	{
        transform.localScale = scaleRight;
    }

	class Stay:StateM{
		public override void Enter(Statem statem){
			statem.GetComponent<CharacterControl> ().animator.Play ("stay");
		}
		public override void Execute(Statem statem){
			if(statem.GetComponent<CharacterControl> ().moveDir != 0 ){
				statem.ChangeState (new Move ());
			}
		}
		public override void Exit(Statem statem){
		}
	}

	class Move:StateM{
		public override void Enter(Statem statem){
			statem.GetComponent<CharacterControl> ().animator.Play ("walk");
		}
		public override void Execute(Statem statem){
			//加速 保持速度
			if (statem.GetComponent<CharacterControl> ().ShouldAccelerate()) {
                statem.GetComponent<CharacterControl>().Accelerate();
            }

			//静止 切换状态
			else if (statem.GetComponent<CharacterControl> ().ShouldActStay()) {
				/*if (statem.GetComponent<CharacterControl> ().pSystem != null) {
					statem.GetComponent<CharacterControl> ().pSystem.Play ();
				}*/
				statem.ChangeState (new Stay ());
			}
	
			//限制速度
			else if (statem.GetComponent<CharacterControl> ().ShouldMaintain()) {
				
			} 
			//转向
			if (statem.GetComponent<CharacterControl> ().ShouldTurnLeft()) {
                statem.GetComponent<CharacterControl>().TrunLeft();
            } 
			else if(statem.GetComponent<CharacterControl> ().ShouldTurnRight()){
                statem.GetComponent<CharacterControl>().TurnRight();
			}
		}
		public override void Exit(Statem statem){

		}
	}
}
/*
class Stay:StateM{
	public override void Enter(Statem statem){

	}
	public override void Execute(Statem statem){

	}
	public override void Exit(Statem statem){

	}
}
*/