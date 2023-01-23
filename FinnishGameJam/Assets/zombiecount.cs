using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class zombiecount : MonoBehaviour
{
    public TMP_Text Zombiecount;
    private float startTime;
    private bool finished = false;
    private randomSpawner rspawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count= rspawner.spawnCount;
        Zombiecount.text = count.ToString();
    }
}