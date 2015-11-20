using UnityEngine;
using System.Collections;

public class wallStartScript : MonoBehaviour {

	public Material[] blocks;

	void Awake()
	{
		GetComponent<Renderer>().material = blocks[Random.Range(0,blocks.Length)];

	}
}
