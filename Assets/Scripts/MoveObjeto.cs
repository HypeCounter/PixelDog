using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjeto : MonoBehaviour {

	public float speed;
	private float x;

	public GameObject player;
	private bool pontuado;


	// Use this for initialization
	void Start () {
		player = GameObject.Find ("player") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {

		x = transform.position.x;
		x += speed * Time.deltaTime;

		transform.position = new Vector3 (x, transform.position.y);
		if (x <= -7) {
			Destroy (transform.gameObject);
		}

		if (x < player.transform.position.x && pontuado == false) {
			pontuado = true;
			Controle.pontuacao += 100;
		}
	}
}
