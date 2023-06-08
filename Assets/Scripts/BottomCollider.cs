using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BottomCollider : MonoBehaviour
{
    [SerializeField] ChildEnter1 refChildEnter;
    [SerializeField] AudioSource audioData;

   public static bool b = false;
   
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("in");
        //collision.gameObject.SetActive(false);
        audioData = GetComponent<AudioSource>();
        audioData.Play();
        if (collision.gameObject.tag == "Finish")
        {
            if (b == false) 
            {
                refChildEnter.CollisionDeleteWord();
               b = true;
            }
          
        }
      
        gameObject.transform.GetComponentInChildren<ParticleSystem>().Play();

        /* if (livesIndex < 3)
      {
          lives[livesIndex].sprite = emptyLives;
          instantiatedWord.transform.position = spawnPositions.position;
          livesIndex++;
      }*/

    }

}
