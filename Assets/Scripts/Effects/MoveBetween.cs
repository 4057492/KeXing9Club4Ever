using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBetween : MonoBehaviour {
    public Vector3 range = Vector3.one;
    public Vector3 speed = Vector3.one;
    public bool ifX = true;
	public bool ifY = true;
	public bool ifZ = true;

	private float x;
	private float y;
    private float z;

    private Vector3 oriPos;

    void Start(){
        x = 0;
        y = 0;
        z = 0;
        oriPos = transform.position;
    }

    void Update()
    {
        if (ifX)
        {
            x = Mathf.PingPong(speed.x * Time.time, range.x);
        }
		if (ifY)
        {
            y = Mathf.PingPong(speed.y * Time.time, range.y);
        }
		if (ifZ)
        {
            z = Mathf.PingPong(speed.z * Time.time, range.z);
        }
        transform.position = oriPos + new Vector3(x, y, z);
    }

}
