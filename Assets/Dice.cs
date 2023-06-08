using System.Collections.Generic;
using System.Linq;
using System.Collections;
using UnityEngine;
using System;

public class Dice : MonoBehaviour
{

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    public static int whosTurn = 1;
    public bool coroutineAllowed = true;

    public bool diceRolled = false;

    public int player1Index = 0;
    public int player2Index = 0;

    private int[] ladders = new int[] {3,12,32,41,49,61,73};

    private int[] snakes = new int[] {39,86,88,97};

    public Dice() {}


    // Use this for initialization
    private void Start()
    {
        whosTurn = 1;
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
    }

    private void OnMouseDown()
    {
        diceRolled = true;
        // Disable the dice when it's the robot player
        if(whosTurn == 2) {
            return;
        }


        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
            GetComponent<AudioSource>().Play();
        
    }

    public void ActualRoll() {
        if (GameControl.gameOver || !coroutineAllowed) return;

        StartCoroutine("RollTheDice");
        GetComponent<AudioSource>().Play();
    }

    public IEnumerator RollTheDice()
    {   
    
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = UnityEngine.Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.01f);
        }

        diceRolled = false;

       //GameControl control = GameObject.Find("GameControl").GetComponent<GameControl>();
        GameObject player1 = GameObject.Find("Player1");
        GameObject player2 = GameObject.Find("Player2");
        int player1Count = player1.GetComponent<FollowThePath>().waypointIndex;
        int player2Count = player2.GetComponent<FollowThePath>().waypointIndex;

        int lower;
        int lowerLocation;
        int higherLocation;
        if(player1Count < player2Count){
            lower = 1;
            lowerLocation = player1Count;
            higherLocation = player2Count;
        }else{
            lower = 2;
            lowerLocation = player2Count;
            higherLocation = player1Count;
        }
        
        int difference = Math.Abs(player1Count - player2Count);
        int finalDiceSide = 1;
        int currentLocation;
        if(whosTurn == 1){
            currentLocation = player1Count;
        }else{
            currentLocation = player2Count;
        }


        if(difference > 15){
            if(lower == whosTurn){
                int toLadder = ladders.OrderBy(x => Math.Abs((long) x - lowerLocation)).First();
                int distance = toLadder - lowerLocation;
                if(0 < distance && distance < 7){
                    finalDiceSide = distance + 1;
                }else{
                    finalDiceSide = UnityEngine.Random.Range(4,7);
                }
            }else{
                int toSnake = snakes.OrderBy(x => Math.Abs((long) x - higherLocation)).First();
                int distance = toSnake - higherLocation;
                if(0 < distance && distance < 7){
                    finalDiceSide = distance + 1;
                }else{
                    finalDiceSide = UnityEngine.Random.Range(1,4);
                }
            }
        }else if(player1Count == 0 || player2Count == 0){
            finalDiceSide = UnityEngine.Random.Range(1,6);
        }else if(0 < difference && difference < 7){
            if(lower == whosTurn){
                finalDiceSide = difference;
            }else{
                finalDiceSide = UnityEngine.Random.Range(1,6);
            }
        }else{
            finalDiceSide = UnityEngine.Random.Range(1,6);
        }

        // This is the thing that displays the number on screen 
        rend.sprite = diceSides[finalDiceSide - 1];
        GameControl.diceSideThrown = finalDiceSide;

        if(whosTurn == 1) {
            player1Index += finalDiceSide;
        } else {
            player2Index += finalDiceSide;
        }


        if (whosTurn == 1){
            whosTurn = 2;
            GameControl.MovePlayer(1);
        }else if (whosTurn == 2){
            whosTurn = 1;
            GameControl.MovePlayer(2);
        }

        coroutineAllowed = true;

    }

    public int GetWhosTurn(){
        return whosTurn;
    }

    public void SetWhosTurn(int turn){
        whosTurn = turn;
    }

    public IEnumerable WaitForDiceRoll(){
        while(!diceRolled){
            yield return new WaitForSeconds(1);
        }
        diceRolled = false;
    }
    
}
