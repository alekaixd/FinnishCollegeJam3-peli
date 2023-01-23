using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class KarkkiCollect : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite oldSprite;
    public bool collectable = true;
    public int respawnTime = 45;
    public AudioSource collectSound;

    
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameController = GameObject.Find("GameController");
        GameControllerScript controllScript = gameController.GetComponent<GameControllerScript>();
        
         
    }

    // Update is called once per frame
    void Update()
    {
        
        /*if(poistaKarkki == true)
        {
            StartCoroutine(KarkkiHimo());
            karkkiText.text = karkit.ToString();
        }*/
    }

    private int CollectKarkki()
    {
        GameObject gameController = GameObject.Find("GameController");
        GameControllerScript controllScript = gameController.GetComponent<GameControllerScript>();
        spriteRenderer.sprite = newSprite;
        Debug.Log("+10 karkkia");
        controllScript.karkit += 15;
        collectable = false;
        return controllScript.karkit;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        if(collectable == true)
        {
            try
            {
                collectSound.Play(0);
                CollectKarkki();
                StartCoroutine(RespawnKarkit());
            }
            catch
            {
                Debug.Log("error in try catch");
                CollectKarkki();
                StartCoroutine(RespawnKarkit());
            }
            
        }
    }

    private IEnumerator RespawnKarkit()
    {
        yield return new WaitForSeconds(respawnTime);
        spriteRenderer.sprite = oldSprite;
        collectable = true;
    }
    /*private IEnumerator KarkkiHimo()
    {
        poistaKarkki = false;
        Debug.Log("Tick! Tick! Tick!");
        yield return new WaitForSeconds(karkkiPerSec);
        karkit -= 1;
        yield return karkit;
        poistaKarkki = true;
    }*/
}
