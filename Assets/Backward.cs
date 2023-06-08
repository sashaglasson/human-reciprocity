using System.Collections;
using UnityEngine;

public class Backward : MonoBehaviour {

    public Backward() {}

    private void Start(){}


    private void OnMouseDown(){
        MoveBackward();
    }

    public void MoveBackward(){
        GameControl.numBackward =+ 1;
        GameControl control = GameObject.Find("GameControl").GetComponent<GameControl>();
        int player1Location = control.GetPlayer1Location();
        int player2Location = control.GetPlayer2Location();
        Dice dice = GameObject.Find("Dice").GetComponent<Dice>();
        int whosTurn = dice.GetWhosTurn();
        int newLocation = 0;
        int newWho = 0;
        GameObject player;
        if(whosTurn == 2){
            dice.coroutineAllowed = false;
            player = GameObject.Find("Player2");
            newLocation = player2Location - 3;
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[newLocation].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = newLocation;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            dice.player2Index =- 3;
            newWho = 2;
        }else{
            dice.coroutineAllowed = false;
            player = GameObject.Find("Player1");
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[newLocation].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = newLocation;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            dice.player1Index =- 3;
            newWho = 1;
        }
        if(newLocation == 3){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[24].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 24;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        if(newLocation == 12){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[45].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 45;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        if(newLocation == 32){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[48].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 48;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        if(newLocation == 41){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[62].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 62;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        if(newLocation == 49){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[68].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 68;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        if(newLocation == 61){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[80].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 80;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        if(newLocation == 73){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[91].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 91;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        if(newLocation == 39){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[2].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 2;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        if(newLocation == 86){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[36].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 36;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        if(newLocation == 88){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[52].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 52;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        if(newLocation == 97){
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[40].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = 40;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            GameControl.MovePlayer(newWho);
        }
        dice.coroutineAllowed = true;
    }

}