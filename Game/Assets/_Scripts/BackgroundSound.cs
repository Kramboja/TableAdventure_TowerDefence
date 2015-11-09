using UnityEngine;
using System.Collections;

public class BackgroundSound : MonoBehaviour {

	void Awake () 
	{
		DontDestroyOnLoad(transform.gameObject);
	}
}
