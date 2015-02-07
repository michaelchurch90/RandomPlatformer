using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour {
	BoxCollider2D trigger;
	Transform spawnLocation;
	Vector3 bounds;
	void Start()
	{
		trigger = GetComponent<BoxCollider2D> ();
		spawnLocation = GetComponent<Transform> ();



	}
	void OnTriggerEnter2D(Collider2D other)
	{
	

		trigger.enabled = false;
		Debug.Log ("Loading new Scene");
		int roomID = Random.Range (0, 2);
		UnityEngine.Object pPrefab = null;;

		if (roomID == 0) 
		{
			pPrefab = Resources.Load ("Rooms/FlatRoom");
		}
		if (roomID == 1) 
		{
			pPrefab = Resources.Load ("Rooms/UpStairsRoom");
			//pPrefab = Resources.Load ("Rooms/FlatRoom");
		}
	

		GameObject nextScreen = (GameObject)GameObject.Instantiate (pPrefab, spawnLocation.position, Quaternion.identity);
		
	}


}
