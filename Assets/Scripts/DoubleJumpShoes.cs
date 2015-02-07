using UnityEngine;
using System.Collections;

public class DoubleJumpShoes : MonoBehaviour {


	Transform leftFoot;
	Transform playerLeftFoot;
	Transform rightFoot;
	Transform player;
	void Start()
	{
		leftFoot = GetComponentInChildren<Transform> ().Find ("PlayerAtlas_ShoeLeft");
	}


	void OnTriggerEnter2D(Collider2D other)
	{
	
		player = other.GetComponentInParent<Transform>();
		//transform.localScale = new Vector3 (1, 1, 1);

		playerLeftFoot = player.Find ("PlayerAtlas_LegLeft/PlayerAtlas_FootLeft");

		playerLeftFoot = leftFoot;
		leftFoot.parent = playerLeftFoot;


		//transform.localScale.y = 1;
	}
}
