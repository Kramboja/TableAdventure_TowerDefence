using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


	private float speed 			= 5.0f;
	private float mouseSensivity 	= 10f;
	private float verticalRotation 	= 0;

	private float upDownRange 		= 60f;
	
	void Awake()
	{
		Screen.lockCursor = true;
	}

	void Update () 
	{
		if (Input.anyKey)
			buttonPressed ();
		
		float rotHorizontal = Input.GetAxis ("Mouse X") * mouseSensivity;
		transform.Rotate (0, rotHorizontal, 0);
		
		verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSensivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -upDownRange, upDownRange);
		
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);
	}
	
	private void buttonPressed()
	{	
		if (Input.GetKey(KeyCode.Escape) && Screen.lockCursor)
			Screen.lockCursor = false;
		else
			Screen.lockCursor = true;
		
		float translationV 	= Input.GetAxis ("Vertical") 	* speed;
		float translationH	= Input.GetAxis ("Horizontal") 	* speed;
		
		translationV 		*= Time.deltaTime;
		translationH 		*= Time.deltaTime;
		
		transform.Translate (translationH, 0, translationV);
	}
}
