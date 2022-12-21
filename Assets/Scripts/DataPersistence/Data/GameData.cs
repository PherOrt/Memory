using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int gamesPlayed;
    public int gamesPlayedEasy;
    public int gamesPlayedNormal;
    public int gamesPlayedHard;
    public bool completedEasy;
    public bool completedNormal;
    public bool completedHard;

    public Dictionary<string, bool> achievements;
    //the values defined in this constructor will be the default values
    // the game starts with when there's no data to load

    public GameData()
    {
        this.gamesPlayed = 0;
        this.gamesPlayedEasy = 0;
        this.gamesPlayedNormal = 0;
        this.gamesPlayedHard = 0;
        this.completedEasy = false;
        this.completedNormal = false;
        this.completedHard = false;
        //achievements = new Dictionary<string, bool>();
    }
}
