using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour, IDataPersistence
{
[SerializeField] private string id;
[ContextMenu("Generate guid for id")]
private void GenerateGuid()
{
    id = System.Guid.NewGuid().ToString();
}
 public Sprite CardFront;
 public static Sprite CardBack;
 public Image CurrentSprite;
 public static bool unlocked = false;

 public void LoadData(GameData data)
 {

 }
 public void SaveData(ref GameData data)
 {
    
 }
 void Update()
 {
    ImageChange();
 }
    public void ImageChange()
    {
        if(SavedInformation.completedEasy == true && id == "7c59052e-00e9-4456-980e-422a3039fbe1")
        {
            CurrentSprite.sprite = CardFront;
        }
        if(SavedInformation.completedNormal == true && id == "66753e95-3e3c-49dc-92b6-b7ced5ce1303")
        {
            CurrentSprite.sprite = CardFront;
        }
        if(SavedInformation.completedHard == true && id == "c7e55764-6c9a-4e3a-86a7-b8bfd09e326d")
        {
            CurrentSprite.sprite = CardFront;
        }
        if(SavedInformation.totalgamesPlayedEasy >= 5 && id == "1e708dca-f892-4e15-b693-65b23d088ca3")
        {
            CurrentSprite.sprite = CardFront;
        }
        if(SavedInformation.totalgamesPlayedNormal >= 5 && id == "8527b823-8130-4562-9490-899fc0c64548")
        {
            CurrentSprite.sprite = CardFront;
        }
        if(SavedInformation.totalgamesPlayedHard >= 5 && id == "651c8625-0663-4f7e-bec4-9853240f6315")
        {
            CurrentSprite.sprite = CardFront;
        }
        if(SavedInformation.totalgamesPlayedEasy >= 15 && id == "8ef89fe4-a42c-4830-8963-fc6d79e59b76")
        {
            CurrentSprite.sprite = CardFront;
        }
        if(SavedInformation.totalgamesPlayedNormal >= 15 && id == "3dc4bc2b-b34f-4fff-8773-c5025fdaec9e")
        {
            CurrentSprite.sprite = CardFront;
        }
        if(SavedInformation.totalgamesPlayedHard >= 15 && id == "5299b1a0-d88a-4cdf-8d9d-8be58a434aa2")
        {
            CurrentSprite.sprite = CardFront;
        }
    }
}
