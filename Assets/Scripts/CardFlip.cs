using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CardFlip : MonoBehaviour
{
 
 public Sprite CardFront;
 public Sprite OriginalBack;
 public static Sprite CardBack;
 public Image CurrentSprite;
 public static bool picked = false;
 public bool flipped;

    void Start()
    {
        flipped = false;
    }
    public void ImageChange()
    {
        if(GamePlay.Count == 1 && GamePlay.paused == false && GamePlay.First.name != gameObject.name)
        {
            CurrentSprite.sprite = CardFront;
            GamePlay.Count = GamePlay.Count + 1;
            GamePlay.Second = gameObject;

            // Debug.Log("Count = " + GamePlay.Count);
            // Debug.Log("-------------------------------------------");
            // Debug.Log("Second Cards Name = " + GamePlay.Second.name);
            // Debug.Log("-------------------------------------------");
            // Debug.Log("Points = " + GamePlay.Points);
            GamePlay.paused = true;
            
        }

        if(GamePlay.Count == 0 && GamePlay.paused == false) 
        {
            CardBack = CurrentSprite.sprite;
            CurrentSprite.sprite = CardFront;
            GamePlay.Count = GamePlay.Count + 1;
            GamePlay.First = gameObject;
            

            // Debug.Log("Count = " + GamePlay.Count);
            // Debug.Log("-------------------------------------------");
            // Debug.Log("First Cards Name = " + GamePlay.First.name);
            // Debug.Log("-------------------------------------------");
            // Debug.Log("Points = " + GamePlay.Points);
            //picked = true;
            
        }
        
        if(SceneManager.GetActiveScene().name == "Title")
        {
            if(flipped == false)
            {
                CurrentSprite.sprite = OriginalBack;
                
                flipped = true;
                Debug.Log("Flipped = " + flipped);
            }
            else if(flipped == true)
            {
                
                CurrentSprite.sprite = CardFront;
                flipped = false;
                Debug.Log("Flipped = " + flipped);
            }
        }
    }
}
