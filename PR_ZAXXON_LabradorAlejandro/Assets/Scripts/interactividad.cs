using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class interactividad : MonoBehaviour
{
    [SerializeField] Vector3 PlayerPosition = new Vector3(0f, 0f, 0f);
    public float speed;
    [SerializeField] Rigidbody rb;
    private float rotateY;
    [SerializeField] float fuerza;
    [SerializeField] GameObject nave;
    //[SerializeField] ParticleSystem explosion;
    [SerializeField] GameObject explosion;


    //variables
    //movimienti
    [SerializeField] AudioClip explosionAudio;



    //limites
    float limitR = 9f;
    float limitL = -9f;
    float limitUp = 30f;
    float limitDown = 0.5f;

    //variable bool limite
    bool inLimitY = false;
    bool inLimitX = false;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = PlayerPosition;
        

    }
    private void FixedUpdate()
    {
       // RotarFuerzas();
    }

    // Update is called once per frame
    void Update()
    {   
        
        PlayerMovement();
        rotation();
        
    }
    void rotation()
    {
        

        float rot = Input.GetAxis("rotacion") * 2f;

        transform.Rotate(Vector3.back * Time.deltaTime * rot * speed);
    }

    void RotarFuerzas()
    {
        float rotateY = Input.GetAxis("Vertical");
        rb.AddTorque(Vector3.back * fuerza * rotateY);
    }


    void PlayerMovement()
    {

        float posX = transform.position.x;
        float posY = transform.position.y;
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        //despX
        if (inLimitX)
        {
            transform.Translate(Vector3.right * desplX * Time.deltaTime * speed, Space.World);
        }

        if(posX > limitR && desplX > 0)
        {
            inLimitX = false;
        }
        else if (posX < limitL && desplX < 0)
        {
            inLimitX = false;

        }
        else
        {
            inLimitX = true;
        }
        //desplY
        if (inLimitY)
        {
            transform.Translate(Vector3.up * desplY * Time.deltaTime * speed, Space.World);

        }

        if (posY > limitUp && desplY > 0)
        {
            inLimitY = false;
        }
        else if (posY < limitDown && desplY < 0)
        {
            inLimitY = false;

        }
        else
        {
            inLimitY = true;
        }
       

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            Instantiate(explosion, transform.position, transform.rotation);

            //explosion.Play();
            Destroy(nave);
            


            
        }

        Invoke("LoadSceneGO", explosionAudio.length + 1);
        
    }

    void LoadSceneGO()
    {
        SceneManager.LoadScene("Game over");
    }




}
