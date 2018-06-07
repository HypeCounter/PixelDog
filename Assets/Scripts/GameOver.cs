using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public UnityEngine.UI.Text Pontos;
	public UnityEngine.UI.Text Recorde;



	// Use this for initialization
	void Start () {
		Pontos.text = PlayerPrefs.GetInt ("pontuacao").ToString ();
		Recorde.text = PlayerPrefs.GetInt ("recorde").ToString ();
        StartCoroutine(TimeBack());
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    IEnumerator TimeBack()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }

}
