using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VihollinenTekoaly : MonoBehaviour
{
    public GameObject player;
    public float speed;


    private float matka; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        matka = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;


        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);



    }
}
