using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    private DataPersistenceManager dataPersistenceManager;
    public static GameObject First;
    public static GameObject Second;
    public static int Count;
    public static int Points;
    public static int matchStreak;
    public static int longestStreak;
    public static bool paused = false;
    public GameObject score;
    public GameObject streak;
    public GameObject CurrentLongestStreak;
    public static bool restart = true;
//---------------------Spots on Board---------------------
    public GameObject Spot1;
    public GameObject Spot2;
    public GameObject Spot3;
    public GameObject Spot4;
    public GameObject Spot5;
    public GameObject Spot6;
    public GameObject Spot7;
    public GameObject Spot8;
    public GameObject Spot9;
    public GameObject Spot10;
    public GameObject Spot11;
    public GameObject Spot12;
    public GameObject Spot13;
    public GameObject Spot14;
    public GameObject Spot15;
    public GameObject Spot16;
    public GameObject Spot17;
    public GameObject Spot18;
    public GameObject Spot19;
    public GameObject Spot20;
    public GameObject Spot21;
    public GameObject Spot22;
    public GameObject Spot23;
    public GameObject Spot24;
    public GameObject Spot25;
    public GameObject Spot26;
    public GameObject Spot27;
    public GameObject Spot28;
    public GameObject Spot29;
    public GameObject Spot30;
//---------------------Cards in Deck----------------------
    public GameObject Card1;
    public GameObject Card1Match;
    public GameObject Card2;
    public GameObject Card2Match;
    public GameObject Card3;
    public GameObject Card3Match;
    public GameObject Card4;
    public GameObject Card4Match;
    public GameObject Card5;
    public GameObject Card5Match;
    public GameObject Card6;
    public GameObject Card6Match;
    public GameObject Card7;
    public GameObject Card7Match;
    public GameObject Card8;
    public GameObject Card8Match;
    public GameObject Card9;
    public GameObject Card9Match;
    public GameObject Card10;
    public GameObject Card10Match;
    public GameObject Card11;
    public GameObject Card11Match;
    public GameObject Card12;
    public GameObject Card12Match;
    public GameObject Card13;
    public GameObject Card13Match;
    public GameObject Card14;
    public GameObject Card14Match;
    public GameObject Card15;
    public GameObject Card15Match;
    List <GameObject> deck = new List<GameObject>(); //Hard Deck
    List <GameObject> normalDeck = new List<GameObject>(); //Normal Deck
    List <GameObject> easyDeck = new List<GameObject>(); //Easy Deck
    List <GameObject> randomdeckeasy = new List<GameObject>();
    List <GameObject> randomdecknormal = new List<GameObject>();
    List <GameObject> randomdeckhard = new List<GameObject>();
    List <GameObject> spots = new List<GameObject>();

    List<T> RandomizedDeck<T>(List<T> inputList, int count)
    {
        List<T> outputList = new List<T>();
            for(int i = 0; i < count; i++)
            {
                int index = Random.Range(0, inputList.Count);
                outputList.Add(inputList[index]);
                inputList.Remove(inputList[index]);
            }
            return outputList;
    }
    public static void NewBoard(List<GameObject> randomdeck, List<GameObject> spots){
        for(var i = 0; i<randomdeck.Count; i++){
            GameObject playedCard = Instantiate(randomdeck[i], new Vector3(0, 0, 0), Quaternion.identity);
            playedCard.name = playedCard.name.Replace("(Clone)","");
            //Debug.Log(spots[i].name);
            playedCard.transform.SetParent(spots[i].transform,false);
        }
    }

    // Start is called before the first frame update

    void Start()
    {
        Spot1  = GameObject.Find("CardSpot1");
        Spot2  = GameObject.Find("CardSpot2");
        Spot3  = GameObject.Find("CardSpot3");
        Spot4  = GameObject.Find("CardSpot4");
        Spot5  = GameObject.Find("CardSpot5");
        Spot6  = GameObject.Find("CardSpot6");
        Spot7  = GameObject.Find("CardSpot7");
        Spot8  = GameObject.Find("CardSpot8");
        Spot9  = GameObject.Find("CardSpot9");
        Spot10 = GameObject.Find("CardSpot10");
        Spot11 = GameObject.Find("CardSpot11");
        Spot12 = GameObject.Find("CardSpot12");
        Spot13 = GameObject.Find("CardSpot13");
        Spot14 = GameObject.Find("CardSpot14");
        Spot15 = GameObject.Find("CardSpot15");
        Spot16 = GameObject.Find("CardSpot16");
        Spot17 = GameObject.Find("CardSpot17");
        Spot18 = GameObject.Find("CardSpot18");
        Spot19 = GameObject.Find("CardSpot19");
        Spot20 = GameObject.Find("CardSpot20");
        Spot21 = GameObject.Find("CardSpot21");
        Spot22 = GameObject.Find("CardSpot22");
        Spot23 = GameObject.Find("CardSpot23");
        Spot24 = GameObject.Find("CardSpot24");
        Spot25 = GameObject.Find("CardSpot25");
        Spot26 = GameObject.Find("CardSpot26");
        Spot27 = GameObject.Find("CardSpot27");
        Spot28 = GameObject.Find("CardSpot28");
        Spot29 = GameObject.Find("CardSpot29");
        Spot30 = GameObject.Find("CardSpot30");

        deck.Add(Card1);
        deck.Add(Card2);
        deck.Add(Card3);
        deck.Add(Card4);
        deck.Add(Card5);
        deck.Add(Card6);
        deck.Add(Card7);
        deck.Add(Card8);
        deck.Add(Card9);
        deck.Add(Card10);
        deck.Add(Card11);
        deck.Add(Card12);
        deck.Add(Card13);
        deck.Add(Card14);
        deck.Add(Card15);
        deck.Add(Card1Match);
        deck.Add(Card2Match);
        deck.Add(Card3Match);
        deck.Add(Card4Match);
        deck.Add(Card5Match);
        deck.Add(Card6Match);
        deck.Add(Card7Match);
        deck.Add(Card8Match);
        deck.Add(Card9Match);
        deck.Add(Card10Match);
        deck.Add(Card11Match);
        deck.Add(Card12Match);
        deck.Add(Card13Match);
        deck.Add(Card14Match);
        deck.Add(Card15Match);

        normalDeck.Add(Card1);
        normalDeck.Add(Card2);
        normalDeck.Add(Card3);
        normalDeck.Add(Card4);
        normalDeck.Add(Card5);
        normalDeck.Add(Card6);
        normalDeck.Add(Card7);
        normalDeck.Add(Card8);
        normalDeck.Add(Card9);
        normalDeck.Add(Card10);
        normalDeck.Add(Card1Match);
        normalDeck.Add(Card2Match);
        normalDeck.Add(Card3Match);
        normalDeck.Add(Card4Match);
        normalDeck.Add(Card5Match);
        normalDeck.Add(Card6Match);
        normalDeck.Add(Card7Match);
        normalDeck.Add(Card8Match);
        normalDeck.Add(Card9Match);
        normalDeck.Add(Card10Match);

        easyDeck.Add(Card1);
        easyDeck.Add(Card2);
        easyDeck.Add(Card3);
        easyDeck.Add(Card4);
        easyDeck.Add(Card5);
        easyDeck.Add(Card6);
        easyDeck.Add(Card1Match);
        easyDeck.Add(Card2Match);
        easyDeck.Add(Card3Match);
        easyDeck.Add(Card4Match);
        easyDeck.Add(Card5Match);
        easyDeck.Add(Card6Match);

        spots.Add(Spot1);
        spots.Add(Spot2);
        spots.Add(Spot3);
        spots.Add(Spot4);
        spots.Add(Spot5);
        spots.Add(Spot6);
        spots.Add(Spot7);
        spots.Add(Spot8);
        spots.Add(Spot9);
        spots.Add(Spot10);
        spots.Add(Spot11);
        spots.Add(Spot12);
        spots.Add(Spot13);
        spots.Add(Spot14);
        spots.Add(Spot15);
        spots.Add(Spot16);
        spots.Add(Spot17);
        spots.Add(Spot18);
        spots.Add(Spot19);
        spots.Add(Spot20);
        spots.Add(Spot21);
        spots.Add(Spot22);
        spots.Add(Spot23);
        spots.Add(Spot24);
        spots.Add(Spot25);
        spots.Add(Spot26);
        spots.Add(Spot27);
        spots.Add(Spot28);
        spots.Add(Spot29);
        spots.Add(Spot30);

        randomdeckeasy = RandomizedDeck(easyDeck, easyDeck.Count);
        randomdecknormal = RandomizedDeck(normalDeck, normalDeck.Count);
        randomdeckhard = RandomizedDeck(deck, deck.Count);
    }

    void Update()
    {
        if(Count == 2){
            StartCoroutine(displayDelay()); //Starts a timer when Count equals 2, the count goes up when a card is selected.
        }
        if(restart == true && SceneManager.GetActiveScene().name == "MainGame(easy)"){
            GameObject card;
            GameObject cardmatch;
            for(var i = 0; i<=15; i++){
                card = GameObject.Find("Card" + i);
                cardmatch = GameObject.Find("Card" + i + "Match");
                Destroy(card);
                Destroy(cardmatch);
            }
            restart = false;
            Count = 0;
            paused = false;
            Points = 0;
            matchStreak = 0;
            longestStreak = 0;
            First = null;
            Second = null;
            NewBoard(randomdeckeasy,spots);
        }
        if(restart == true && SceneManager.GetActiveScene().name == "MainGame(normal)"){
            GameObject card;
            GameObject cardmatch;
            for(var i = 0; i<=15; i++){
                card = GameObject.Find("Card" + i);
                cardmatch = GameObject.Find("Card" + i + "Match");
                Destroy(card);
                Destroy(cardmatch);
            }
            restart = false;
            Count = 0;
            paused = false;
            Points = 0;
            matchStreak = 0;
            longestStreak = 0;
            First = null;
            Second = null;
            NewBoard(randomdecknormal,spots);
        }
        if(restart == true && SceneManager.GetActiveScene().name == "MainGame(hard)"){
            GameObject card;
            GameObject cardmatch;
            for(var i = 0; i<=15; i++){
                card = GameObject.Find("Card" + i);
                cardmatch = GameObject.Find("Card" + i + "Match");
                Destroy(card);
                Destroy(cardmatch);
            }
            restart = false;
            Count = 0;
            paused = false;
            Points = 0;
            matchStreak = 0;
            longestStreak = 0;
            First = null;
            Second = null;
            NewBoard(randomdeckhard,spots);
        }
    }

    IEnumerator displayDelay(){

        if((First.name ) == (Second.name + "Match") || (First.name + "Match") == (Second.name)){ //Compares the names of the two selected card names if they match player waits 5 seconds. Then 1 point is added to the score and cards are destroyed.
            Count = 0;
            
            yield return new WaitForSeconds(.3f); //  .3f equals 3 tenths of a second.
            Points = Points + 1;
            matchStreak = matchStreak + 1;

            if(longestStreak<matchStreak){
                longestStreak = matchStreak;
                CurrentLongestStreak.GetComponent<UnityEngine.UI.Text>().text = longestStreak.ToString();
            }

            Debug.Log("Points = " + Points);
            Destroy(First);
            Destroy(Second);
            score.GetComponent<UnityEngine.UI.Text>().text = Points.ToString();
            streak.GetComponent<UnityEngine.UI.Text>().text = matchStreak.ToString();
            paused = false;

            if(Points == 15 && SceneManager.GetActiveScene().name == "MainGame(hard)"){
                Points = 0;
                matchStreak = 0;
                score.GetComponent<UnityEngine.UI.Text>().text = Points.ToString();
                streak.GetComponent<UnityEngine.UI.Text>().text = matchStreak.ToString();
                SavedInformation.totalgamesPlayed = SavedInformation.totalgamesPlayed + 1;
                SavedInformation.totalgamesPlayedHard = SavedInformation.totalgamesPlayedHard + 1;
                SavedInformation.completedHard = true;
                DataPersistenceManager.gamesaved = true;
                randomdeckhard = RandomizedDeck(randomdeckhard, randomdeckhard.Count);
                NewBoard(randomdeckhard, spots);
            }
            if(Points == 10 && SceneManager.GetActiveScene().name == "MainGame(normal)"){
                Points = 0;
                matchStreak = 0;
                score.GetComponent<UnityEngine.UI.Text>().text = Points.ToString();
                streak.GetComponent<UnityEngine.UI.Text>().text = matchStreak.ToString();
                SavedInformation.totalgamesPlayed = SavedInformation.totalgamesPlayed + 1;
                SavedInformation.totalgamesPlayedNormal = SavedInformation.totalgamesPlayedNormal + 1;
                SavedInformation.completedNormal = true;
                DataPersistenceManager.gamesaved = true;
                //Debug.Log("Completed Normal = " + SavedInformation.completedNormal); //<-------------------DebugLog
                randomdecknormal = RandomizedDeck(randomdecknormal, randomdecknormal.Count);
                NewBoard(randomdecknormal, spots);
            }
            if(Points == 6 && SceneManager.GetActiveScene().name == "MainGame(easy)"){
                Points = 0;
                matchStreak = 0;
                score.GetComponent<UnityEngine.UI.Text>().text = Points.ToString();
                streak.GetComponent<UnityEngine.UI.Text>().text = matchStreak.ToString();
                SavedInformation.totalgamesPlayed = SavedInformation.totalgamesPlayed + 1;
                SavedInformation.totalgamesPlayedEasy = SavedInformation.totalgamesPlayedEasy + 1;
                SavedInformation.completedEasy = true;
                DataPersistenceManager.gamesaved = true;
                //Debug.Log("Saved Game = " + DataPersistenceManager.gamesaved);
                //Debug.Log("Total Games Played = " + SavedInformation.totalgamesPlayed);
                randomdeckeasy = RandomizedDeck(randomdeckeasy, randomdeckeasy.Count);
                NewBoard(randomdeckeasy, spots);
            }
            
        }
        else //If card names do not match player waits 5 seconds and the cards will change back face down.
        {
            Count = 0;
            yield return new WaitForSeconds(.3f); //  .3f equals 3 tenths of a second.

            First.GetComponent<Image>().sprite = CardFlip.CardBack;
            Second.GetComponent<Image>().sprite = CardFlip.CardBack;
            //yield return new WaitForSeconds(1);
            paused = false;   
            matchStreak = 0;
            streak.GetComponent<UnityEngine.UI.Text>().text = matchStreak.ToString();

        }
    }
}
