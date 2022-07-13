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
    public int playerOnePowerLevel;
    public int playerTwoPowerLevel;
    public int playerOneChanceToWin;
    public int playerTwoChanceToWin;
    public int randomNumber;
    
    private void Start()
    {
        {
            //// let's start by setting our player dancing stats to random numbers

            {
                
                {
                    //// playerOneStyle should be random between 1, 10              
                    //// returns random number between 1, 10
                    playerOneStyle = randomNumber = Random.Range(1, 10);
                }

                {
                    //// playerOneLuck should be random between 1, 4
                    /// returns random number between 1, 4
                    playerOneLuck = randomNumber = Random.Range(0, 4);
                }

                {
                    //// rhythm should be random between 1, 6
                    playerOneRhythm = randomNumber = Random.Range(0, 6);
                }

                {
                    //// style should be random between 1, 10
                    playerTwoStyle = randomNumber = Random.Range(0, 10);
                }

                {
                    //// luck should be random between 1, 4
                    playerTwoLuck = randomNumber = Random.Range(0, 4);
                }

                {
                    //// rhythm should be random between 1, 6
                    playerTwoRhythm = randomNumber = Random.Range(0, 6);
                }

                {
                    {
                        //// let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
                        //// this algorthim should be the same for each character to keep it fair.
                        playerOnePowerLevel = 10;
                        playerTwoPowerLevel = 10;
                    }

                    {
                        //// Debug out the two players, power levels.
                        Debug.Log(playerOnePowerLevel = 10);
                        Debug.Log(playerTwoPowerLevel = 10);
                    }
                
                }

                {
                    {
                        //// calculate the percentage chance of winning the fight for each character.
                        //// to do this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
                        playerOneChanceToWin = 50;
                        playerTwoChanceToWin = 50;
                    }

                    {
                        //// Debug out the chance of each character to win.
                        Debug.Log(playerOneChanceToWin = 50);
                        Debug.Log(playerTwoChanceToWin = 50);
                    }
                }

                {
                    {
                        //// We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.
                        playerOnePowerLevel = 50;
                        playerTwoPowerLevel = 50;
                    }

                    {
                        //// Debug out which character has won, which has lost, or if it's a draw.
                        Debug.Log("it's a draw");
                    }
                }
            }
            
        }

        //// Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
        Debug.Log("award a default amount");
    }
}
