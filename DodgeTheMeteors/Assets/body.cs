using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{
    public GameObject koruma;
    public SpriteRenderer ResimYeri;
    public Sprite[] Resimler;
    public GameObject ozelm;
    public GameObject meteor;
    public GameObject zemin;
    Rigidbody2D rigi;

    
    bool zipla=false;
    public float hiz = 3f;
    public float ziplamakuvveti = 3f;
    // Start is called before the first frame update
    void Start()
    {


        rigi= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(hiz * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-hiz * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            zipla = true;
        }

        //if (rigi.velocity.y<0)
        //{
        //    ResimYeri.sprite = Resimler[0];
        //}

        //if (rigi.velocity.y < 0)
        //{
        //    ResimYeri.sprite = Resimler[0];
        //}



    }

   

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag=="ozel")
        {
            koruma.SetActive(true);
            Debug.Log("Özel Meteora deðdi");
        }
        else if (collision.collider.tag == "zemin")
        {

            if (koruma.activeSelf == true)
            {
                rigi.velocity = Vector2.up * (ziplamakuvveti);
                koruma.SetActive(false);
            }
            else
            {
                Destroy(this);
            }

            
        }
        else if (koruma.activeSelf==true)
        {
            koruma.SetActive(false);
        }
        else
        {
            Debug.Log("Diðerlerine Deðidi");
             ResimYeri.sprite = Resimler[1];
            Destroy(this);
           
        }
       
    }


    private void FixedUpdate()
    {
        if (zipla)
        {

            rigi.velocity = Vector2.up*(ziplamakuvveti);
            zipla = false;
           
        }
    }
}
