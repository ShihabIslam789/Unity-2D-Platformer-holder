using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
        
    
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.gameobject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries ++;
           cherriesText.text = "Cherries: " + cherries;
        }

   }


}
