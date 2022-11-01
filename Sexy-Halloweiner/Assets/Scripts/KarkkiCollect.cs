using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarkkiCollect : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public int karkit;
    public Text karkkiText;
    // Start is called before the first frame update
    void Start()
    {
        karkkiText.text = karkit.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeSprite();
        }
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
        karkit += 5;
        karkkiText.text = karkit.ToString();
    }
}
