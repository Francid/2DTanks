using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	//Public Variable
	public EnemyController enemyController;
	public GameController gameController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.CompareTag("Enemy")){
			//Reset the position to default
			enemyController._Reset();
			gameController.LivesValue -= 1;
		}
	}
}
