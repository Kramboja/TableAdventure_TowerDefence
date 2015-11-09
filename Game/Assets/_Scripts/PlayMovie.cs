using UnityEngine;
using System.Collections;

public class PlayMovie : MonoBehaviour {

	void Start () 
	{
		Renderer r = GetComponent<Renderer>();
		MovieTexture movie = (MovieTexture)r.material.mainTexture;

		movie.Play();

		Invoke("StartGame",3f);
	}
	
	private void StartGame()
	{
		Application.LoadLevelAsync("Menu");
	}
}
