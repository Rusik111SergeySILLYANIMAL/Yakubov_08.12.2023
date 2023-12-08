using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public int score = 0;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int health = 10;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player health:" + health);
        if (health <= 0){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
