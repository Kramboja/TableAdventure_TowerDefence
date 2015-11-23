using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {
	
	void Awake () 
	{
		Destroy(this.gameObject,15);
	}
}
