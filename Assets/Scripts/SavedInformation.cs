using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedInformation : MonoBehaviour, IDataPersistence
{
    public static int totalgamesPlayed = 0;
    public static int totalgamesPlayedEasy = 0;
    public static int totalgamesPlayedNormal = 0;
    public static int totalgamesPlayedHard = 0;
    public static bool completedEasy = false;
    public static bool completedNormal = false;
    public static bool completedHard = false;
    public int gamesPlayed;
    public int gamesPlayedEasy;
    public int gamesPlayedNormal;
    public int gamesPlayedHard;
    public bool easyComplete;
    public bool normalComplete;
    public bool hardComplete;



    public void LoadData(GameData data)
    {
        gamesPlayed = totalgamesPlayed;
        gamesPlayedEasy = totalgamesPlayedEasy;
        gamesPlayedNormal = totalgamesPlayedNormal;
        gamesPlayedHard = totalgamesPlayedHard;
        easyComplete = completedEasy;
        normalComplete = completedNormal;
        hardComplete = completedHard;

        this.gamesPlayed = data.gamesPlayed;
        this.gamesPlayedEasy = data.gamesPlayedEasy;
        this.gamesPlayedNormal = data.gamesPlayedNormal;
        this.gamesPlayedHard = data.gamesPlayedHard;
        this.easyComplete = data.completedEasy;
        this.normalComplete = data.completedNormal;
        this.hardComplete = data.completedHard;

        totalgamesPlayed = this.gamesPlayed;
        totalgamesPlayedEasy = this.gamesPlayedEasy;
        totalgamesPlayedNormal = this.gamesPlayedNormal;
        totalgamesPlayedHard = this.gamesPlayedHard;
        completedEasy = this.easyComplete;
        completedNormal = this.normalComplete;
        completedHard = this.hardComplete;
    }

    public void SaveData(ref GameData data)
    {
        gamesPlayed = totalgamesPlayed;
        gamesPlayedEasy = totalgamesPlayedEasy;
        gamesPlayedNormal = totalgamesPlayedNormal;
        gamesPlayedHard = totalgamesPlayedHard;
        easyComplete = completedEasy;
        normalComplete = completedNormal;
        hardComplete = completedHard;
        data.gamesPlayed = this.gamesPlayed;
        data.gamesPlayedEasy = this.gamesPlayedEasy;
        data.gamesPlayedNormal = this.gamesPlayedNormal;
        data.gamesPlayedHard = this.gamesPlayedHard;
        data.completedEasy = this.easyComplete;
        data.completedNormal = this.normalComplete;
        data.completedHard = this.hardComplete;
    }
}
