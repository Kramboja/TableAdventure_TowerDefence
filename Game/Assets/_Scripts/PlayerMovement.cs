using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


	private float speed 			= 10.0f;
	private float mouseSensivity 	= 10f;
	private float verticalRotation 	= 0;
	CursorLockMode wantedMode;

	private float upDownRange 		= 60f;
	
	void Awake()
	{
		Cursor.lockState = CursorLockMode.Locked;
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
			Cursor.lockState = CursorLockMode.None;
		else if(Input.GetKey(KeyCode.Escape))
			Cursor.lockState = CursorLockMode.Locked;
		
		float translationV 	= Input.GetAxis ("Vertical") 	* speed;
		float translationH	= Input.GetAxis ("Horizontal") 	* speed;
		
		translationV 		*= Time.deltaTime;
		translationH 		*= Time.deltaTime;
		
		transform.Translate (translationH, 0, translationV);
	}
}
