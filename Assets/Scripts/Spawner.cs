using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spawner : MonoBehaviour {
	public GameObject[] units;

	public float spawnTime = 1f;
	bool isSoldier;

	Spawner spawn;



	
	private void Start() {
		//Debug.Log(soldier.cost+"");
	}
	
	

	public void createSoldier() {
		//Debug.Log(soldier.instance.cost+"");
		if (Main.instance.money >= 100)
		{
			Main.instance.money -= 100;
			Instantiate(units[0], transform.position, transform.rotation);
			isSoldier = true;
		}
	}

	public void createTank() {
		if (Main.instance.money >= 200)
		{
			Main.instance.money -= 200;
			Instantiate(units[1], transform.position, transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(SoldierCoroutine());
	}

	public IEnumerator SoldierCoroutine()
	{
		if (isSoldier == true){
			GameObject.Find("soldier").GetComponent<Button>().interactable = false;
        	yield return new WaitForSeconds(5);
			GameObject.Find("soldier").GetComponent<Button>().interactable = true;
			isSoldier = false;
		}
		
	}

	public IEnumerator TankCoroutine()
	{
		yield return new WaitForSeconds(3f);
		GameObject.Find("tank").GetComponent<Button>().interactable = true;
	}
	
	IEnumerator Example()
    {
		GameObject.Find("soldier").GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(5);
		GameObject.Find("soldier").GetComponent<Button>().interactable = true;
    }

}
