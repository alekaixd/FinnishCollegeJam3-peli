using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarkkiCollect : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private int karkit = 20;
    public Text karkkiText;
    public int karkkiPerSec = 5;
    bool poistaKarkki = true;
    bool collectable = true;
    // Start is called before the first frame update
    void Start()
    {
        karkkiText.text = karkit.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(poistaKarkki == true)
        {
            StartCoroutine(KarkkiHimo());
        }
    }

    void CollectKarkki()
    {
        if(collectable == true)
        {
            spriteRenderer.sprite = newSprite;
            karkit += 5;
            karkkiText.text = karkit.ToString();
            collectable = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        CollectKarkki();
    }

    private IEnumerator KarkkiHimo()
    {
        poistaKarkki = false;
        Debug.Log("Tick! Tick! Tick!");
        karkit -= 1;
        karkkiText.text = (karkit).ToString();
        yield return new WaitForSeconds(karkkiPerSec);
        poistaKarkki = true;
    }
}
