using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public Component damageCollider;
    private bool immunity = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject gameController = GameObject.Find("GameController");
        GameControllerScript controllScript = gameController.GetComponent<GameControllerScript>();
        
        Debug.Log("Hit");
        if(immunity == false)
        {
            Debug.Log("damage taken");
            controllScript.karkit -= 5;
            StartCoroutine(ImmunityFrames());
        }
        else
        {
            Debug.Log("Immune");
        }
    }

    private IEnumerator ImmunityFrames()
    {
        Debug.Log("Immunity Frames");
        immunity = true;
        yield return new WaitForSeconds(2);
        immunity = false;
    }
}
