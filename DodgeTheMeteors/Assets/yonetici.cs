using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici : MonoBehaviour
{
    public GameObject start;
    public GameObject goktasi;
    public GameObject boktasi;
    public Rigidbody2D body;
    
    

  

    public float zaman = 1f;
    public float zaman2 = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;
        InvokeRepeating("odeneme", 0f, zaman2);
        InvokeRepeating("GokTasiOlustur", 0f, zaman);
    }

    public void baslat()
    {
        
        start.SetActive(false);
        Time.timeScale = 1.0f;
        
        body.velocity = Vector2.up * (10f);
    }

    void odeneme()
    {
        GameObject yenitas = Instantiate(boktasi);
    }

    void GokTasiOlustur()
    {
        GameObject yenitas = Instantiate(goktasi);
    }
}
