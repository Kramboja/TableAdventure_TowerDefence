using UnityEngine;
using System.Collections;

public class FloorScript : MonoBehaviour 
{

	public bool canBuild;
	private Renderer rend;

	void Start () 
	{
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}

	void OnMouseEnter() 
	{
		if(canBuild && myGlobals.currentPosition != 0)
			rend.material = Resources.Load("Hammer") as Material;
	}

	void OnMouseExit() 
	{
		rend.material = Resources.Load("Floor") as Material;
	}

	void Update () 
	{
	
	}
}
