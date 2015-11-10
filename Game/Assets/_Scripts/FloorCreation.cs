using UnityEngine;
using System.Collections;

public class FloorCreation : MonoBehaviour {

	private int rows = 25;
	private int lines = 25;
	public Transform Floor;
	public Transform Tree;
	private int baseSize = 3;
	
	// Use this for initialization
	void Awake () 
	{
		//maakt een veld aan van het aantal rows x het aantal lines
		for(int i = 0;i < lines; i++)
		{
			for(int j = 0; j < rows; j++)
			{
				Transform trans = (Transform)Instantiate(Floor, new Vector3(i*10f, -0.5f,j*10f), transform.rotation);
				trans.parent = transform;
				
				/*if(i >= lines/2 - baseSize && i <= lines/2 + baseSize)
				{
					if(j == rows/2 - baseSize || j == rows/2 + baseSize)
					{
						Transform cityWall = (Transform)Instantiate(wall, new Vector3(i*10,4,j*10), Quaternion.Euler(0,0,90*Random.Range(0,4)));
					}
				}
*/
				/*				if(j >= rows/2 - baseSize + 1 && j <= lines/2 + baseSize - 1)
				{
					if(i == lines/2 - baseSize || i == lines/2 + baseSize)
					{
						Transform cityWall = (Transform)Instantiate(wall, new Vector3(i*10,4,j*10), Quaternion.Euler(0,0,90*Random.Range(0,4)));
					}
				}
*/
				
				if(i < 3 || j < 4 || i > lines - 4 || j > rows - 4)
				{
					Transform tree = (Transform)Instantiate(Tree, new Vector3(Random.Range(-5, 5) + i * 10, 3f, Random.Range(-5, 5) + j * 10),Quaternion.Euler(0,Random.Range(1,360),0));
					tree.parent = transform;
				}
			}
		}
	}
}
