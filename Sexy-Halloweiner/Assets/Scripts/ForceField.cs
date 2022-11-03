using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{
    public bool FFActive = false;
    public GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FFActive == true)
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (FFActive == true)
        {
            if (other.CompareTag("Enemy"))
            {
                Debug.Log("Enemy in area");
                StartCoroutine(FreezeEnemy(circle));
            }
        }
    }

    private IEnumerator FreezeEnemy(GameObject circle)
    {
        GameObject EnemyRB = GameObject.FindGameObjectWithTag("Enemy");
        Rigidbody2D enemyRB = EnemyRB.GetComponent<Rigidbody2D>();
        enemyRB.constraints = RigidbodyConstraints2D.FreezePosition;
        Debug.Log("Enemy Frozen");
        FFActive = false;
        /*circle.SetActive = false;*/
        yield return new WaitForSeconds(5);
        enemyRB.constraints = RigidbodyConstraints2D.None;
    }
}
