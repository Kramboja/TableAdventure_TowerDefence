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
			GetComponent<Animation>().Play("gateopen");
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			GetComponent<Animation>().Play("gateclose");
		}
	}
}
