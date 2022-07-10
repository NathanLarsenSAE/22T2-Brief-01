using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    public int playerOneStyle;
    public int playerTwoStyle;
    public int playerOneLuck;
    public int playerTwoLuck;
    public int playerOneRhythm;
    public int playerTwoRhythm;

    public string myFirstName = "Nathan";
    public string myLastName = "Larsen";
    public string playerOnePowerLevel;
    public string playerTwoPowerLevel;

    private void Start()
    {
        
        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
        int playerOneStyle = 5;
        // luck should be random between 0-4
        int playerOneLuck = 3;
        // ryhtm should be random between 1-6
        int playerOneRhythm = 4;
        // style should be random between 1-10
        int playerTwoStyle = 4;
        // luck should be random between 0-4
        int playerTwoLuck = 2;
        // ryhtm should be random between 1-6
        int playerTwoRhythm = 3;

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        playerOnePowerLevel = 12;
        playerTwoPowerLevel = 9; ;

        // Debug out the two players, power levels.
        Debug.Log(playerOnePowerLevel = 12);
        Debug.Log(playerTwoPowerLevel = 9);

        // calculate the percentage chance of winning the fight for each character.
        // to do this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        int totalPower = 21;
        int playerOneChanceToWin = 175;
        int playerTwoChanceToWin = 233;

        // Debug out the chance of each character to win.
        Debug.Log(totalPower = 21);
        Debug.Log(playerOneChanceToWin = 175);
        Debug.Log(playerTwoChanceToWin = 233);

        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.
        playerOnePowerLevel = playerTwoPowerLevel = "player one has won!";
        playerOnePowerLevel = playerTwoPowerLevel = "player one has lost!";
        playerTwoPowerLevel = playerOnePowerLevel = "player two has won!";
        playerTwoPowerLevel = playerOnePowerLevel = "player two has lost!";
        // Debug out which character has won, which has lost, or if it's a draw.
        Debug.Log(playerTwoPowerLevel > playerOnePowerLevel = "player two has won!");
        Debug.Log(playerOnePowerLevel !> playerTwoPowerLevel = "player one has lost!");

        // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
    }
}
