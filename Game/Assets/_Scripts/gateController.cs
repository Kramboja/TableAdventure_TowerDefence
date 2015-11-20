using UnityEngine;
using System.Collections;

public class gateController : MonoBehaviour {
	
	private Animator animator;

	void Awake()
	{
		animator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("Open gate");
			GetComponent<Animation>().Play("gateopen");
			//GetComponent<Animation>().CrossFade("GateOpen",.5f);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("close gate");
			GetComponent<Animation>().Play("gateclose");
		}
	}
}
