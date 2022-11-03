using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    public float upgradedMoveSpeed = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        Debug.Log("Something entered buy zone!");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered buy zone!");
            
            /*if (Input.GetKeyDown(KeyCode.E) /*&& controllScript.karkit > 20)
            {
                
            }*/
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        GameObject gameController = GameObject.Find("GameController");
        GameControllerScript controllScript = gameController.GetComponent<GameControllerScript>();
        Debug.Log("player is in the buy zone");
        if (Input.GetKey(KeyCode.Space)) 
        {
            Debug.Log("Pressed E");
            
            if(gameObject.CompareTag("SpeedBoost") && controllScript.karkit > 20)
            {
                controllScript.karkit -= 20;
                SpeedBoost();
                Destroy(gameObject);
            }
            if(gameObject.CompareTag("ForceField") && controllScript.karkit > 40)
            {
                Debug.Log("ForceField");
                Destroy(gameObject);
                controllScript.karkit -= 40;
                ForceField();
                
            }
        }
    }

    private void SpeedBoost()
    {
        GameObject Player = GameObject.Find("Player");
        Movement movementScript = Player.GetComponent<Movement>();
        movementScript.moveSpeed = upgradedMoveSpeed;
    }

    private void ForceField()
    {
        GameObject PlayerFF = GameObject.Find("Player");
        ForceField forcefield = PlayerFF.GetComponent<ForceField>();
        forcefield.FFActive = true;
    }
}