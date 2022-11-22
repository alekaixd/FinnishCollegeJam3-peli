using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{
    public bool FFActive = false;
    public GameObject circle;

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
        GameObject EnemyRB = GameObject.FindWithTag("Enemy");
        Rigidbody2D enemyRB = EnemyRB.GetComponent<Rigidbody2D>();
        enemyRB.constraints = RigidbodyConstraints2D.FreezePosition;
        Debug.Log("Enemy Frozen");
        FFActive = false;
        circle.SetActive(false);

        yield return new WaitForSeconds(5);

        enemyRB.constraints = RigidbodyConstraints2D.None;
        enemyRB.constraints = RigidbodyConstraints2D.FreezeRotation;

        yield return new WaitForSeconds(20);

        FFActive = true;
        circle.SetActive(true);
    }
}
