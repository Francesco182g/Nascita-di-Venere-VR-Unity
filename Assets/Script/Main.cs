using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class Main : MonoBehaviour {
    public AudioClip musica;
    public AudioClip audioIntro;
    public AudioClip suonoOstacolo0;
    public AudioClip suonoOstacolo1;

   // public AudioClip descrizione;
    public AudioClip AentrataGrotta;
    public AudioClip Azefiroaura;
    public AudioClip AuscitaGrotta;
    public AudioClip Amusica2;
    public AudioClip Afine;

    public AudioClip AcolpoBarca;

    public AudioSource Smusic;
    public AudioSource SaudioIntro;
    public AudioSource Sostacolo0;
    public AudioSource Sostacolo1;
    public AudioSource SentrataGrotta;
    //public AudioSource Sdescrizione;
    public AudioSource Szefiroaura;
    public AudioSource SuscitaGrotta;
    public AudioSource Smusica2;
    public AudioSource Sfine;

    public AudioSource ScolpoBarca;

    public float speed;

    public CharacterController player;
    public GameObject barca;

    //CAMERA
    public GameObject camPlayer;
    public Quaternion quaternion;
    

    //MENU
    public GameObject graficaMenu;
    public GameObject SecondoMenu;
    public GameObject TerzoMenu;
    public static bool menub = true;
    public static bool play = false;
    public static bool cronomenu2 = false;

    //CARDBOARD
    public static bool cardbo = false;
    public static bool nocardbo = false;
    public static bool secondomenu = false;

    //COMANDI MOVIMENTO
    public static bool su = false;
    public static bool giu = false;
    public static bool destra = false;
    public static bool sinistra = false;
    //TOUCH
    private Vector2 fingerDown;
    private Vector2 fingerUp;
    public bool detectSwipeOnlyAfterRelease = false;

    public float SWIPE_THRESHOLD = 20f;
    //COMANDO RIPRISTINA GIROSCOPIO
    private bool centraGiro = false;
    public Button centroB; //COMANDO TOUCH CENTRALE

    //COMANDI TOUCH
    //public Button suB;
    //public Button giuB;
    //public Button destraB;
    //public Button sinistraB;



    public int tempo;

    public static bool start = false;
    public static bool passo1post = false;
  
    public static bool passo1 = false;
    public static bool passo2 = false;
    public static bool passo3 = false;
    public static bool passo4intro = false;
	public static bool passo4 = false;
	public static bool passo5 = false;
    public static bool passo6 = false; //Riparti dopo zefiro aura primavera
    public static bool passo7 = false;
    public static bool passo8 = false;
    public static bool passo9 = false;
    public static bool passo10 = false;

    public static bool passo11 = false;
    public static bool passo12 = false;
    public static bool passo13 = false;
    public static bool passo14 = false;
    public static bool passo15 = false;
    public static bool passo16 = false;



    //Pioggia Effetti
    public static bool PioggiaForte = false;
    public static bool attivaPioggiaForte = false;
    public GameObject pioggiaForte;
    public AudioSource SpioggiaForte;
    public AudioClip ApioggiaForte;

	// Use this for initialization
	void Start () {
        Smusic.clip = musica;
        SaudioIntro.clip = audioIntro;
        Sostacolo0.clip = suonoOstacolo0;
        Sostacolo1.clip = suonoOstacolo1;
        SentrataGrotta.clip = AentrataGrotta;
        Szefiroaura.clip = Azefiroaura;
        SuscitaGrotta.clip = AuscitaGrotta;
        Smusica2.clip = Amusica2;

        ScolpoBarca.clip = AcolpoBarca;
        Sfine.clip = Afine;

        SpioggiaForte.clip = ApioggiaForte; //Audio pioggia Forte Ostacolo 1 post

        Smusic.Play();
        player = GetComponent<CharacterController>();
        UnityEngine.XR.XRSettings.enabled = false;

        //StartCoroutine(Cronometro());

        //CAMERA E MOVIMENTI
        quaternion = Quaternion.Euler(4.161f, 2.27f, 0);
        Input.gyro.enabled = true; // GIROSCOPIO ATTIVO PER NO CARDBOARD
        
        //Bottoni TOUCH
        //suB.onClick.AddListener(VaiSu); //touch su
        //giuB.onClick.AddListener(VaiGiu); // touch giu
        //destraB.onClick.AddListener(VaiDestra); //touch destra
        //sinistraB.onClick.AddListener(VaiSinistra); //touch sinistra
        centroB.onClick.AddListener(CentraAvanti); //Centra la camera
    }

    /*
     * Metodi Menu
     */
    public static void attivaCardboard()
    {
        Debug.Log("MAIN: Attivo cardboard");
        UnityEngine.XR.XRSettings.enabled = true;
        menub = false; //Disattiva il menu
        cardbo = true; //Attiva la modalità Cardboard
        secondomenu = true; //Attiva il secondo Menu
    }

    public static void attivaNoCardboard()
    {
        Debug.Log("MAIN: Attivo NOcardboard");
        menub = false; //Disattiva il menu
        //play = true;   //Attiva il gioco
        cronomenu2 = true;
        UnityEngine.XR.XRSettings.enabled = false;
        nocardbo = true; //Disattiva la modalità Cardboard (Altre funzioni: attiva Giroscopio)
    }

    /*
    * Metodi Comandi Touch
     */
    public void CentraAvanti()
    {
        centraGiro = true;
        Debug.Log("Main: Centro la scena");
    }
    public static void VaiSu()
    {
        su = true;
        Debug.Log("Vado su");
    }

    public static void VaiGiu()
    {
        giu = true;
    }

    public static void VaiDestra()
    {
        destra = true;
    }

    public static void VaiSinistra()
    {
        sinistra = true;
    }

    /*
     * Metodi Passo passo
     */
    public static void attivaPasso1post()
    {
        passo1 = false;
        passo1post = true;
       // passo1eff = true;
    }

    public static void attivaPasso2()
    {
        Debug.Log("MAIN: Attivo Passo 2");
        passo1 = false;
        passo2 = true;
        PioggiaForte = true;
    }
	
	public static void attivaPasso4(){
		Debug.Log("Main: Attivo Passo 4");
		passo3 = false;
		passo4 = true;
        passo4intro = true;
    }
	
	public static void attivaPasso5(){
		Debug.Log("Main: Attivo Passo 5");
		passo4 = false;
        passo5 = true;
	}
 
    public static void attivaPasso8()
    {
        Debug.Log("Main: Attivo passo 8");
        passo8 = true;
    }

    public static void attivaPasso9()
    {
        Debug.Log("Main: Attivo passo 9");
        passo9 = true;
    }

    public static void attivaPasso10()
    {
        Debug.Log("Main: Attivo passo 10");
        passo10 = true;
        passo11 = true;
    }

    public static void attivaPasso11()
    {
        Debug.Log("Main: Attivo passo 11");
        passo11 = true;
    }

    public static void attivaPasso12()
    {
        Debug.Log("Main: Attivo passo 12");
        passo12 = true;
    }

    public static void attivaPasso13()
    {
        Debug.Log("Main: Attivo passo 13");
        passo13 = true;
    }

    public static void attivaPasso14()
    {
        Debug.Log("Main: Attivo passo 14");
        passo14 = true;
    }

    public static void attivaPasso15()
    {
        Debug.Log("Main: Attivo passo 15");
        passo15 = true;
        
    }


    // Update is called once per frame
    void Update() {
        //Menu start
        //COMANDI SOLO NOCARDBOARD
        if(cronomenu2 == true)
        {
            TerzoMenu.SetActive(true);
            StartCoroutine(Cronomenu2());
            cronomenu2 = false;
        }
        if(nocardbo == true)
        {

            //COMANDI TOUCH
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    fingerUp = touch.position;
                    fingerDown = touch.position;
                }

                //Detects Swipe while finger is still moving
                if (touch.phase == TouchPhase.Moved)
                {
                    if (!detectSwipeOnlyAfterRelease)
                    {
                        fingerDown = touch.position;
                        CheckSwipe();
                    }
                }

                //Detects swipe after finger is released
                if (touch.phase == TouchPhase.Ended)
                {
                    fingerDown = touch.position;
                    CheckSwipe();
                }
            }
        /*
        //COMANDI TOUCH
        if (Input.GetTouch(1).deltaPosition.x >0)
        {
            destra = true;
        }
        if (Input.GetTouch(1).deltaPosition.x < 0)
        {
            sinistra = true;
        }
        */
        camPlayer.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, 0);
   /* Blocco
            if (Input.touchCount == 2 || centraGiro == true)
            {
                centraGiro = false;
                Debug.Log("Reset Touch");
                camPlayer.transform.eulerAngles = new Vector3(4.161f, 2.27f, 0);
            }
    */
        }

        if (menub == false)
        {
            graficaMenu.SetActive(false);
            menub = true;
        }
        //SECONDO MENU
        if(secondomenu == true)
        {
            Debug.Log("MAIN: Inserisci telefono nel visore");
            secondomenu = false;
            SecondoMenu.SetActive(true);
            StartCoroutine(CronoCardboard());
        }
        if (Input.touchCount == 2 || centraGiro == true)
        {
            centraGiro = false;
            Debug.Log("Reset Touch");
            camPlayer.transform.eulerAngles = new Vector3(4.161f, 2.27f, 0);
        }

        if (destra == true & su==false & giu==false)
        {
            camPlayer.transform.Rotate(0, 3f, 0);
            destra = false;
        }
        if(sinistra == true & su==false & giu==false)
        {
            camPlayer.transform.Rotate(0, -3f, 0);
            sinistra = false;
        }
        if(su == true & destra==false & sinistra==false)
        {
          camPlayer.transform.Rotate(-2.5f, 0, 0);
            su = false;
        }
        if(giu == true & destra == false & sinistra == false )
        {
            camPlayer.transform.Rotate(2.5f, 0, 0);
            giu = false;
        }

        //Tastiera:
        if (Input.GetKey(KeyCode.RightArrow))
        {
            destra = true;
            sinistra = false;
            giu = false;
            su = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            sinistra = true;
            destra = false;
            giu = false;
            su = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            su = true;
            giu = false;
            destra = false;
            sinistra = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            giu = true;
            su = false;
            destra = false;
            sinistra = false;
        }



        //Logica di gioco
        if (play == true)
        {
            play = false;
            StartCoroutine(Cronometro());
        }

        if (start == true)
        {
            start = false;

            StartCoroutine(Cronometro2());
        }

        if (passo1 == true)
        {
            player.transform.Translate(Vector3.forward * 0.04f);
        }

        if (passo1post == true)
        {
            passo1 = false;
            player.transform.Translate(Vector3.forward * 0.10f);
        }

        if (passo2 == true)
        {
            passo1post = false;
            Sostacolo1.Play();
            passo2 = false;
            passo3 = true;
        }

        if (passo3 == true)
        {
            player.transform.Translate(Vector3.forward * 0.09f);
        }

        if (passo4intro == true)
        {
            passo4intro = false;
            SentrataGrotta.Play();
        }

        if (passo4 == true) {
            passo3 = false;
            player.transform.Translate(Vector3.forward * 0.035f);
            player.transform.Translate(Vector3.left * 0.0035f);
        }


        if (passo5 == true) {
            passo4 = false;
            passo5 = false;
            Szefiroaura.Play();
            StartCoroutine(Cronometro3()); // Cronometro Zefiro Aura Flora
        }

        if (passo6 == true)
        {
            player.transform.Translate(Vector3.forward * 0.08f);
        }

        if (passo7 == true)
        {
            passo7 = false;
            SuscitaGrotta.Play();
            Smusic.Stop();
            Smusica2.Play();
        }

        if (passo8 == true)
        {
            passo6 = false;
            player.transform.Translate(Vector3.forward * 0.15f);
        }

        if (passo9 == true)
        {
			passo8 = false;
            player.transform.Translate(Vector3.forward * 0.05f);
        }

        if (passo10 == true)
        {
            passo9 = false;
            passo10 = false;
            ScolpoBarca.Play();
         
            barca.transform.parent = null;
            barca.transform.Rotate(0, 90, 0);
            //barca.SetActive(false);
            //passo1 = false; //Momentaneo
        }

        if (passo11 == true)
        {
            player.transform.Translate(Vector3.up * 0.08f);
        }

        if (passo12 == true)
        {
            passo11 = false;
            player.transform.Translate(Vector3.forward * 0.09f);
        }

        if(passo13 == true)
        {
            passo12 = false;
            player.transform.Translate(Vector3.up * 0.09f);
        }

        if(passo14 == true)
        {
            passo13 = false;
            player.transform.Translate(Vector3.forward * 0.12f);
        }

        if(passo15 == true)
        {
            passo14 = false;
            //player.transform.Translate(Vector3.forward * 0.02f);
            Sfine.Play();
            passo15 = false;
        }

        if(passo16 == true)
        {
            //passo15 = false;
            //play parte finale
            
        }

        //Passi per EFFETTO PIOGGIA
        if (PioggiaForte == true)
        {
            StartCoroutine(CronoPioggiaForte());
            PioggiaForte = false;
        }

        if(attivaPioggiaForte == true)
        {
            SpioggiaForte.Play();
            pioggiaForte.SetActive(true);
            attivaPioggiaForte = false;
        }
	}
    /*
     * Comandi TOUCH
     */
        void CheckSwipe()
{
    //Check if Vertical swipe
    if (verticalMove() > SWIPE_THRESHOLD && verticalMove() > horizontalValMove())
    {
        //Debug.Log("Vertical");
        if (fingerDown.y - fingerUp.y > 0)//up swipe
        {
            OnSwipeUp();
        }
        else if (fingerDown.y - fingerUp.y < 0)//Down swipe
        {
            OnSwipeDown();
        }
        fingerUp = fingerDown;
    }

    //Check if Horizontal swipe
    else if (horizontalValMove() > SWIPE_THRESHOLD && horizontalValMove() > verticalMove())
    {
        //Debug.Log("Horizontal");
        if (fingerDown.x - fingerUp.x > 0)//Right swipe
        {
            OnSwipeRight();
        }
        else if (fingerDown.x - fingerUp.x < 0)//Left swipe
        {
            OnSwipeLeft();
        }
        fingerUp = fingerDown;
    }

    //No Movement at-all
    else
    {
        //Debug.Log("No Swipe!");
    }
}

float verticalMove()
{
    return Mathf.Abs(fingerDown.y - fingerUp.y);
}

float horizontalValMove()
{
    return Mathf.Abs(fingerDown.x - fingerUp.x);
}

//////////////////////////////////CALLBACK FUNCTIONS/////////////////////////////
void OnSwipeUp()
{
    Debug.Log("Swipe UP");
        giu = true;
}

void OnSwipeDown()
{
    Debug.Log("Swipe Down");
        su = true;
}

void OnSwipeLeft()
{
    Debug.Log("Swipe Left");
        destra = true;
}

void OnSwipeRight()
{
    Debug.Log("Swipe Right");
        sinistra = true;
}

    /*
     * Temporizzatori
     */
    IEnumerator CronoCardboard()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            tempo += 1;
            if (tempo == 10)
            {
                Debug.Log("MAIN: Attivo Cardboard");
                play = true; //Fa partire il gioco
                SecondoMenu.SetActive(false);
                tempo = 0;
                break;
            }
        }
    }

    IEnumerator Cronomenu2()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            tempo += 1;
            if (tempo == 8)
            {
                Debug.Log("MAIN: Attivo Cardboard");
                play = true; //Fa partire il gioco
                TerzoMenu.SetActive(false);
                tempo = 0;
                break;
            }
        }
    }

    IEnumerator Cronometro()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            tempo += 1;
            if(tempo == 4)
            {
                Debug.Log("MAIN: Attivo Start");
                start = true;
                tempo = 0;
                SaudioIntro.Play();
                break;
            }
        }
    }

    IEnumerator Cronometro2()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            tempo += 1;
            if (tempo == 22)//61
            {
                Debug.Log("MAIN : Attivo Passo1");
                passo1 = true;
                tempo = 0;
                Sostacolo0.Play();
                break;
            }
        }
    }

    IEnumerator CronoPioggiaForte()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            tempo += 1;
            if (tempo == 3)//61
            {
                Debug.Log("MAIN : Attivo PioggiaForte");
                attivaPioggiaForte = true;
                tempo = 0;
                Sostacolo0.Play();
                break;
            }
        }
    }
    //Crono Voce Anna 
    IEnumerator Cronometro3()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            tempo += 1;
            if (tempo == 61)//61
            {
                Debug.Log("MAIN : Attivo Passo 6 e Passo 7");
                passo6 = true;
                passo7 = true;
                tempo = 0;
                break;
            }
        }
    }

}
