using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    

    private void Start()
    {
        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
        int playerOneStyle = Random.Range(1, 10);
        Debug.Log(playerOneStyle);
        // luck should be random between 0-4
        int playerOneLuck =  Random.Range(0, 4);
        Debug.Log(playerOneLuck);
        // ryhtm should be random between 1-6
        int playerOneRyhtm =  Random.Range(1, 6);
        Debug.Log(playerOneRyhtm);
        // style should be random between 1-10
        int playerTwoStyle =  Random.Range(1, 10);
        Debug.Log(playerTwoStyle);
        // luck should be random between 0-4
        int playerTwoLuck =  Random.Range(0, 4);
        Debug.Log(playerTwoLuck);
        // ryhtm should be random between 1-6
        int playerTwoRyhtm =  Random.Range(1, 6);
        Debug.Log(playerTwoRyhtm);

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        int playerOnePowerLevel = (playerOneStyle + playerOneLuck + playerOneRyhtm)* 1000;
        int playerTwoPowerLevel = (playerTwoStyle + playerTwoLuck + playerTwoRyhtm)* 1000;


        // Debug out the two players, power levels.
        Debug.Log(playerOnePowerLevel);
        Debug.Log(playerTwoPowerLevel);
        // calculate the percentage chance of winning the fight for each character.
        // todo this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        string Percentage = ("%");
        float totalPower = (playerOnePowerLevel + playerTwoPowerLevel);
        float playerOneChanceToWin = (playerOnePowerLevel/ totalPower)*100;
        float playerTwoChanceToWin = (playerTwoPowerLevel/ totalPower)*100;
        

        // Debug out the chance of each character to win.
        Debug.Log(playerOneChanceToWin + Percentage);
        Debug.Log(playerTwoChanceToWin + Percentage);
        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.
        if (playerOnePowerLevel > playerTwoPowerLevel && playerOnePowerLevel > 9000)
        {
            Debug.Log("PLAYER ONE'S PWOER IS OVER 9000 !! ");
        }
        else if (playerOnePowerLevel > playerTwoPowerLevel)
        {
            Debug.Log("PLAYER ONE HAS HIGHER PWOER !! ");
        }
        else if (playerTwoPowerLevel > playerOnePowerLevel && playerTwoPowerLevel > 9000)
        {
            Debug.Log("PLAYER TWO'S PWOER IS OVER 9000 !! ");
        }
        else if (playerTwoPowerLevel > playerOnePowerLevel)
        {
            Debug.Log("PLAYER TWO HAS HIGHER PWOER !! ");
        }
        else
        {
            Debug.Log("It's evenly matched...");
        }
     
        // Debug out which character has won, which has lost, or if it's a draw.
        if (playerOnePowerLevel > playerTwoPowerLevel)
        {
            Debug.Log(" Player One Won!!");
        }
        else if (playerTwoPowerLevel > playerOnePowerLevel)
        {
            Debug.Log(" Player Two Won!!");
        }
        else
        {
            Debug.Log(" It's a Draw -_-' ");
        }
        // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
        // comment by Hasan: Default amount is 10 exp if it is a draw, if one player's cahnce is higher then the other then the higher chance of winning will get 20% exp more then the loser.
        float percentage1 = (playerOneChanceToWin );
        float percentage2 = (playerTwoChanceToWin );
        if (percentage1 > percentage2)
        {
            Debug.Log("Player One got " + ((10 * 0.2f) + 10)+ " exp" + " and player Two got 10 exp");
        }
        else if ((percentage2 > percentage1))
        {
            Debug.Log("Player Two got " + ((10 * 0.2f) + 10)+ " exp" + " and player One got 10 exp");
        }
        else
        {
            Debug.Log("Both players got 10 exp");
        }
    }



    // Update is called once per frame
    void Update()
    {
       

     
    }
}
        
