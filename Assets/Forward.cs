using System.Collections;
using UnityEngine;

public class Forward : MonoBehaviour {

    public Forward() {}

    private void Start(){}

    private void OnMouseDown(){
        Debug.Log("Forward Button Pressed");
        GameControl.action = "Forward";
        string newMessage = GameControl.message;
        newMessage = newMessage + "6";
        GameControl.message = newMessage;
        Debug.Log("Send 6");
        MoveForward(2, 1);
    }

    public void InitiateMoveForward() {
        MoveForward(1, 2);
    }


    public void MoveForward(int nextTurn, int method){
        GameControl control = GameObject.Find("GameControl").GetComponent<GameControl>();
        GameControl.numForward =+ 1;
        int player1Location = control.GetPlayer1Location();
        int player2Location = control.GetPlayer2Location();
        Dice dice = GameObject.Find("Dice").GetComponent<Dice>();
        int whosTurn = dice.GetWhosTurn();
        int newLocation = 0;
        int newWho = 0;
        GameObject player;
        if(method == 1){
            newWho = 2;
            dice.coroutineAllowed = false;
            player = GameObject.Find("Player2");
            // player.GetComponent<FollowThePath>().sameSquare = true;
            // player.GetComponent<FollowThePath>().Move(3);
            //TODO: Make it move properly - when using move it just keeps updating which makes it keep moving which is not what we want
            //maybe stop trying to make it move properly
            //try and take code from the ladders and snakes???
            newLocation = player2Location + 3;
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[newLocation].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = newLocation;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            dice.player2Index =+ 3;
        }else{
            newWho = 1;
            dice.coroutineAllowed = false;
            player = GameObject.Find("Player1");
            // player.GetComponent<FollowThePath>().sameSquare = true;
            // player.GetComponent<FollowThePath>().Move(3);
            //TODO: Make it move properly - when using move it just keeps updating which makes it keep moving which is not what we want
            //maybe stop trying to make it move properly
            //try and take code from the ladders and snakes???
            newLocation = player1Location + 3;
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[newLocation].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = newLocation;
            player.GetComponent<FollowThePath>().waypointIndex +=1;
            dice.player1Index =+ 3;
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