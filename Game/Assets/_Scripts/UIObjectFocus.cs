using UnityEngine;
using System.Collections;

public class UIObjectFocus : MonoBehaviour {

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
			transform.Translate(173,0,0);
		}
		else if(Input.GetAxisRaw("Mouse ScrollWheel") < 0)
		{
			if(scrollPosition <= 0)
			{
				return;
			}
			scrollPosition--;
			transform.Translate(-173,0,0);

		}

		if (Input.GetMouseButton(0))
		{
			Debug.Log("StartEventBasedOnInput");
		}
	}
}
