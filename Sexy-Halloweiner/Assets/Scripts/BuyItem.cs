using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyItem : MonoBehaviour
{
    public float upgradedMoveSpeed = 7.5f;
    public TMP_Text PressE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        
        Debug.Log("Something entered buy zone!");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered buy zone!");
            
            if (Input.GetKeyDown(KeyCode.E) /*&& controllScript.karkit > 20)
            {
                
            }
        }
    }*/

    private void OnTriggerStay2D(Collider2D other)
    {
        GameObject gameController = GameObject.Find("GameController");
        GameControllerScript controllScript = gameController.GetComponent<GameControllerScript>();
        Debug.Log("player is in the buy zone");

        //Text text = Text.GetComponent<GameControllerScript>();
        PressE.text = "press E to buy";
        if (Input.GetKey(KeyCode.E)) 
        {
            Debug.Log("Pressed E");
            
            if(gameObject.CompareTag("SpeedBoost") && controllScript.karkit > 50)
            {
                controllScript.karkit -= 50;
                SpeedBoost();
                gameObject.SetActive(false);
                PressE.text = "";
            }
            if(gameObject.CompareTag("ForceField") && controllScript.karkit > 80)
            {
                Debug.Log("ForceField");
                gameObject.SetActive(false);
                PressE.text = "";
                controllScript.karkit -= 80;
                ForceField();
                
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        PressE.text = "";
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
        forcefield.circle.SetActive(true);
    }
}