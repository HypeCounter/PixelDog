using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour {

  //  [SerializeField] private float aspect= 1.66f;
   // private float orthoSize = 5; 
	public Animator Anime;
	public Rigidbody2D PlayerRigidbody;
	public int JumpForce;
    public bool adsUmaVez = false;


    public bool slide;
    

	public Transform GroundCheck;
	public bool grounded;
	public LayerMask whatIsGround;

	public float timeTemp;
	public float slideTemp;
	public Transform  colisor;

	public AudioSource som;
	public AudioClip soundJump;
	public AudioClip soundSlide;

	public UnityEngine.UI.Text txtPontos;
	public static int pontuacao;


    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered



    //Use this for initialization
    void Start () {

        dragDistance = Screen.height * 15 / 100; //dragDistance is 15% height of the screen
        pontuacao = 0;
		PlayerPrefs.SetInt ("pontuacao", pontuacao);
       // Camera.main.projectionMatrix = Matrix4x4.Ortho(-orthoSize * aspect, orthoSize * aspect, -orthoSize, orthoSize, Camera.main.nearClipPlane, Camera.main.farClipPlane);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount == 1) // user is touching the screen with a single touch
        {
            Touch touch = Input.GetTouch(0); // get the touch
            if (touch.phase == TouchPhase.Began) //check for the first touch
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
            {
                lp = touch.position;  //last touch position. Ommitted if you use list

                //Check if drag distance is greater than 20% of the screen height
                if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {//It's a drag
                 //check if the drag is vertical or horizontal
                    if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                    {   //If the horizontal movement is greater than the vertical movement...
                        if ((lp.x > fp.x))  //If the movement was to the right)
                        {   //Right swipe
                          
                        }
                        else
                        {   //Left swipe
                        
                        }
                    }
                    else
                    {   //the vertical movement is greater than the horizontal movement
                        if (lp.y > fp.y && grounded == true)  //If the movement was up
                        {   //Up swipe
                            PlayerRigidbody.AddForce(new Vector2(0, JumpForce));
                            som.PlayOneShot(soundJump);
                            som.volume = 1f;
                            if (slide == true)
                            {
                                colisor.position = new Vector3(colisor.position.x, colisor.position.y + 0.4f, colisor.position.z);
                            }
                            slide = false;

                        }
                        else if(lp.y < fp.y && grounded == true && !slide)
                        {   //Down swipe
                            slide = true;
                            timeTemp = 0;
                            colisor.position = new Vector3(colisor.position.x, colisor.position.y - 0.4f, colisor.position.z);
                            som.PlayOneShot(soundSlide);
                            som.volume = 0.5f;
                        
                        }
                    }
                }
                else
                {   //It's a tap as the drag distance is less than 20% of the screen height
                   
                }
            }
        }

        txtPontos.text = pontuacao.ToString ();
		som.volume = 0.5f;
	//	}
		//VERIFICANDO O CHAO
		grounded = Physics2D.OverlapCircle (GroundCheck.position, 0.1f, whatIsGround);

     

		if (slide == true) {

			timeTemp += Time.deltaTime;

			if (timeTemp >= slideTemp)
			{
			colisor.position = new Vector3 (colisor.position.x, colisor.position.y + 0.4f, colisor.position.z);	
			slide = false;
			}
		}


		Anime.SetBool ("jump", !grounded);
		Anime.SetBool ("slide", slide);
	}

	void OnTriggerEnter2D(){
     
		PlayerPrefs.SetInt ("pontuacao", pontuacao);
		if (pontuacao > PlayerPrefs.GetInt ("recorde")) {
			PlayerPrefs.SetInt ("recorde", pontuacao);
		}
        if (adsUmaVez == false)
        {
            AdsUnity.instance.ShowAds();
            adsUmaVez = true;
        }
        Application.LoadLevel ("gameover");
	}

}
