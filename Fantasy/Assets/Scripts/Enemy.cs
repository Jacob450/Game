using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Enemy : MonoBehaviour
{
    private TMP_Text text;
    private Atrributes stats;
   
    // Start is called before the first frame update
    void Start()
    {
        text = transform.GetComponentInChildren<TMP_Text>();
        stats = GetComponent<Atrributes>();
    }

    // Update is called once per frame
    void Update()
    {
        ShowHealth();
        CheckIfDead();


    }

    private void CheckIfDead()
    {
        if(stats.health == 0)
        {
            Destroy(this.gameObject);
        }
    }

    //Enemys can take Damage
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            stats.SubtractHealth(1);
        }
    }

    //Shows Enemy Health
    private void ShowHealth()
    {
        text.text = "Health: " + stats.GetHealth().ToString();
    }
}
