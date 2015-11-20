using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildScript : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	private int gold;
	public Text goldText;

	private GameObject target;
	public GameObject[] buildings;

	void Awake()
	{
		gold = 300;
		goldText.text = "" + gold.ToString();
	}

	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			if(myGlobals.currentPosition > 0)
			{
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if(Physics.Raycast(ray, out hit))
				{
					target = hit.collider.gameObject;

					if(target.GetComponent<FloorScript>().canBuild)
					{
						Debug.Log("Build object and dissable boolean here.");
						target.GetComponent<FloorScript>().canBuild = false;
						gold -= 150;
						Instantiate(buildings[myGlobals.currentPosition - 1],new Vector3(target.transform.position.x,target.transform.position.y + 5, target.transform.position.z),Quaternion.identity);
					}
					else
					{
						Debug.Log("Unable to build here");
					}
				}
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Gold")
		{
			UpdateGold(Random.Range(1,20));
			Destroy(other.gameObject);
		}
	}

	void UpdateGold(int amount)
	{
				gold += amount + 10;
				goldText.text = "" + gold.ToString();
	}
}