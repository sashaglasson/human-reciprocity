using UnityEngine;
using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameObject whoWinsTextShadow, player1MoveText, player2MoveText, infoAll;

    public static GameObject player1, player2;

    public static int numSame, numForward, numBackward;

    public static int nofPlayers = 2;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;

    public static bool buttonPressed = false;

    // Use this for initialization
    void Start () {

        diceSideThrown = 0;
        player1StartWaypoint = 0;
        player2StartWaypoint = 0;
        gameOver = false;

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("P1Move");
        player2MoveText = GameObject.Find("P2Move");
        infoAll = GameObject.Find("InfoAll");
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
        infoAll.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {     
        if(Dice.whosTurn == 1){
            player1MoveText.gameObject.SetActive(true);
            player2MoveText.gameObject.SetActive(false);
        }else{
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
        }
// Player 2
        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            if(player2StartWaypoint+diceSideThrown == 3){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 24;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 12){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[45].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 45;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 32){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[48].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 48;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 41){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[62].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 62;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 49){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[68].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 68;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 61){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[80].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 80;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 73){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[91].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 91;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 39){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[2].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 2;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 86){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[36].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 36;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 88){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[52].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 52;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 97){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[40].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 40;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            player2.GetComponent<FollowThePath>().moveAllowed = false;            
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }
// ** PLAYER 1
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            //Debug.Log(player1StartWaypoint+diceSideThrown);
            if(player1StartWaypoint+diceSideThrown == 3){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 24;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 12){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[45].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 45;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 32){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[48].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 48;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 41){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[62].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 62;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 49){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[68].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 68;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 61){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[80].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 80;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 73){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[91].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 91;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 39){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[2].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 2;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 86){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[36].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 36;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 88){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[52].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 52;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 97){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[40].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 40;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            player1.GetComponent<FollowThePath>().moveAllowed = false;            
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }


        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Count)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;
            Thread.Sleep(1000);
            whoWinsTextShadow.gameObject.SetActive(false);
            infoAll.gameObject.SetActive(true);
            infoAll.GetComponent<Text>().text = " X: " + numSame + " Y: " + numForward + " Z: " + numBackward;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Count)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;
            Thread.Sleep(1000);
            whoWinsTextShadow.gameObject.SetActive(false);
            infoAll.gameObject.SetActive(true);
            infoAll.GetComponent<Text>().text = " X: " + numSame + " Y: " + numForward + " Z: " + numBackward;
        }

    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }

    public int GetPlayer1Location(){
        return player1.GetComponent<FollowThePath>().waypointIndex;
    }

    public int GetPlayer2Location(){
        return player2.GetComponent<FollowThePath>().waypointIndex;
    }

}
