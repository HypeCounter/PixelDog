using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncontrole : MonoBehaviour {
	public GameObject barreiraPREfab;
	public GameObject barreiraPREfab2;
	public GameObject barreiraPREfab3;
	public GameObject barreiraPREfab4;
	public GameObject barreiraPREfab5;
	public GameObject barreiraPREfab6;
	public GameObject barreiraPREfab7;
	public GameObject barreiraPREfab8;
	public GameObject barreiraPREfab9;
	public GameObject barreiraPREfab10;
	public GameObject barreiraPREfab11;
	public GameObject barreiraPREfab12;
	public GameObject barreiraPREfab13;
	public GameObject barreiraPREfab14;
	public GameObject barreiraPREfab15;
	public GameObject barreiraPREfab16;
	public GameObject barreiraPREfab17;
	public GameObject barreiraPREfab18;
	public GameObject barreiraPREfab19;
	public GameObject barreiraPREfab20;
	public GameObject barreiraPREfab21;
	public GameObject barreiraPREfab22;
	public GameObject barreiraPREfab23;
	public GameObject barreiraPREfab24;
	public GameObject barreiraPREfab25;
	public GameObject barreiraPREfab26;
	public GameObject barreiraPREfab27;
	public GameObject barreiraPREfab28;
	public GameObject barreiraPREfab29;
	public GameObject barreiraPREfab30;
	public GameObject barreiraPREfab31;
	public GameObject barreiraPREfab32;
	public GameObject barreiraPREfab33;
	public GameObject barreiraPREfab34;
	public GameObject barreiraPREfab35;
	public GameObject barreiraPREfab36;
	public GameObject barreiraPREfab37;
	public GameObject barreiraPREfab38;
	public GameObject barreiraPREfab39;
	public GameObject barreiraPREfab40;
	public GameObject barreiraPREfab41;
	public GameObject barreiraPREfab42;
	public GameObject barreiraPREfab43;
	public GameObject barreiraPREfab44;
	public GameObject barreiraPREfab45;
	public GameObject barreiraPREfab46;
	public GameObject barreiraPREfab47;
	public GameObject barreiraPREfab48;
	public GameObject barreiraPREfab49;
	public GameObject barreiraPREfab50;

	public int contprancha;
	//objeto spawn
	public float rateSpawn;
	// intervalo
	public float currentTime;
	private int posicao;
	private float y;
	public int velocidade;
	public float posA;
	public float posB;
	public int contador;


	// Use this for initialization
	void Start () {
		currentTime = 0;
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		currentTime += Time.deltaTime;

		if (currentTime >= rateSpawn) {//verifica se tem ou nao spawn na tela
			
			currentTime = 0;
			velocidade = Random.Range (1, 5);
			contador++;


			if (contador < 10) {
				if (velocidade == 1) {
					rateSpawn = 2.7f;
				}

				if (velocidade == 2) {
					rateSpawn = 2.5f;
					
				}
				if (velocidade == 3) {
					rateSpawn = 2.3f;
				}
				if (velocidade == 4) {
					rateSpawn = 1.9f;
				}
				if (velocidade == 5) {
					rateSpawn = 1.5f;
				}
			}

			if (contador > 10 && contador < 30) {
				if (velocidade == 1) {
					rateSpawn = 1.9f;
				}

				if (velocidade == 2) {
					rateSpawn = 1.8f;

				}
				if (velocidade == 3) {
					rateSpawn = 1.5f;
				}
				if (velocidade == 4) {
					rateSpawn = 1.3f;
				}
				if (velocidade == 5) {
					rateSpawn = 1.1f;
				}
			
			}


			if (contador > 30) {
				if (velocidade == 1) {
					rateSpawn = 2f;
				}

				if (velocidade == 2) {
					rateSpawn = 1.2f;

				}
				if (velocidade == 3) {
					rateSpawn = 1.1f;
				}
				if (velocidade == 4) {
					rateSpawn = 1f;
				}
				if (velocidade == 5) {
					rateSpawn = 0.8f;
				}

			}

			posicao = Random.Range (1, 100);
			if (posicao > 50) {
				y = posA;
			
					
					
			} else {
				y = posB;
			}

			contprancha = Random.Range (1, 23);

			if (contprancha == 1) {

				GameObject tempPrefab = Instantiate (barreiraPREfab) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);
			} else if (contprancha == 2) {
				GameObject tempPrefab = Instantiate (barreiraPREfab2) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);

			} else if (contprancha == 3) {
				GameObject tempPrefab = Instantiate (barreiraPREfab3) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}  else if (contprancha == 4) {
				GameObject tempPrefab = Instantiate (barreiraPREfab4) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}  else if (contprancha == 5) {
				GameObject tempPrefab = Instantiate (barreiraPREfab5) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}   else if (contprancha == 6) {
				GameObject tempPrefab = Instantiate (barreiraPREfab6) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}	
			else if (contprancha == 7) {
				GameObject tempPrefab = Instantiate (barreiraPREfab7) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 8) {
				GameObject tempPrefab = Instantiate (barreiraPREfab8) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 9) {
				GameObject tempPrefab = Instantiate (barreiraPREfab9) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}

			else if (contprancha == 10) {
				GameObject tempPrefab = Instantiate (barreiraPREfab10) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}

			else if (contprancha == 11) {
				GameObject tempPrefab = Instantiate (barreiraPREfab11) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 12) {
				GameObject tempPrefab = Instantiate (barreiraPREfab12) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}

			else if (contprancha == 13) {
				GameObject tempPrefab = Instantiate (barreiraPREfab13) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 14) {
				GameObject tempPrefab = Instantiate (barreiraPREfab14) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 15) {
				GameObject tempPrefab = Instantiate (barreiraPREfab15) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 16) {
				GameObject tempPrefab = Instantiate (barreiraPREfab16) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 17) {
				GameObject tempPrefab = Instantiate (barreiraPREfab17) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 18) {
				GameObject tempPrefab = Instantiate (barreiraPREfab18) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 19) {
				GameObject tempPrefab = Instantiate (barreiraPREfab19) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 20) {
				GameObject tempPrefab = Instantiate (barreiraPREfab20) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
			else if (contprancha == 21) {
				GameObject tempPrefab = Instantiate (barreiraPREfab21) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);


			}
		
			else if (contprancha >= 22) {
				GameObject tempPrefab = Instantiate (barreiraPREfab22) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y);
			}
			//} else if (contprancha == 4) {
			//	GameObject tempPrefab = Instantiate (barreiraPREfab4) as GameObject;
			//	tempPrefab.transform.position = new Vector3 (transform.position.x, y);
			//	}

		
		}
		
	}
}

