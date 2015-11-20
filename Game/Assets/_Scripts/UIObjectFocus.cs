using UnityEngine;
using System.Collections;

public class UIObjectFocus : MonoBehaviour {

	public GameObject[] scrollObjects;

	private int scrollPosition;
	private int maxLength;

	void Start()
	{
		maxLength = 4;
	}

	void Update () 
	{
		if(Input.GetAxisRaw("Mouse ScrollWheel") > 0)
		{
			if(scrollPosition >= maxLength)
			{
				return;
			}
			scrollPosition++;
			transform.position = scrollObjects[scrollPosition].transform.position;
			myGlobals.currentPosition = scrollPosition;
		}
		else if(Input.GetAxisRaw("Mouse ScrollWheel") < 0)
		{
			if(scrollPosition <= 0)
			{
				return;
			}
			scrollPosition--;
			transform.position = scrollObjects[scrollPosition].transform.position;
			myGlobals.currentPosition = scrollPosition;
		}
	}
}
