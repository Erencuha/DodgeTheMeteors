using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goktasi : MonoBehaviour
{
    public float hiz = 300f;
    Rigidbody2D rigi;
    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        Vector2 yenipoz = new Vector2(Random.Range(-3, 16), 7);
        transform.position = yenipoz;

        rigi.AddForce(new Vector2(-1 * hiz, -1 * hiz));

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
