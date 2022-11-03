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

    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player") && immunity == false)
        {
            GameObject ControllScript = GameObject.Find("GameController");
            ControllScript.gameObject.GetComponent<GameControllerScript>().karkit -= 10;
            StartCoroutine(ImmunityFrames());
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
