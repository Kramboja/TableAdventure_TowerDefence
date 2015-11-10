using UnityEngine;
using System.Collections;

public class constantRotation : MonoBehaviour {

	private float speed;
	// Use this for initialization
	void Start () 
	{
		speed = 5;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float resultSpeed = speed * Time.deltaTime;
		transform.Rotate(0,resultSpeed,0);
	}
}
