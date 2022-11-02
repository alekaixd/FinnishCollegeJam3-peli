using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour
{
    private float lastUpdate = 0.0f;
    public int karkit = 1000;
    public Text karkkiText;
    // Start is called before the first frame update
    void Start()
    {
        karkkiText.text = karkit.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastUpdate >= 1f)
        {
            karkit -= 1;
            lastUpdate = Time.time;
        }
        karkkiText.text = karkit.ToString();
    }
}
