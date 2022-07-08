using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    // Start is called before the first frame update
    // Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        strength = 5;
        agility = 7;
        intelligence = 8;

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log(strength = 5);
        Debug.Log(agility = 7);
        Debug.Log(intelligence = 8);

        // let's create some float temporary variables to hold our multiplier values.
        float rhythmMulti = 0.5f;
        float styleMulti = 1;
        float luckMulti = 2;

        // create an agility multiplier.
        // This should be set to 0.5f
        // rhythm = agility * rhythmMulti = 0.5f

        // create a strength multiplier
        // This should be set to 1
        // style = strength * styleMulti = 1

        // create an intelligence multiplier should be set to 2
        // luck = intelligence * luckMulti = 2

        // Debug out our current multiplier values
        Debug.Log(rhythm = agility * rhythmMulti = 0.5f);
        Debug.Log(style = strength * styleMulti = 1);
        Debug.Log(luck = intelligence * luckMulti = 2);

        //// now that we have some stats and our multiplier values let's calculate our style, luck and rhythm based on these values.
        //// style should be based off our strength and be converted at a rate of 1 : 1
         style = strength * styleMulti = 1 * (10% divided by 10) = 0.1f

        //// luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        //luck = intelligence * luckMulti = 7 * (9% + 7) = 8.4f

        //// rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        //rhythm = agility * rhythmMulti = 8 * (2% + 8) = 8.2f

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log(style = strength * styleMulti = 5.5f);
        Debug.Log(luck  = intelligence * luckMulti = 8.4f);
        Debug.Log(rhythm = agility * rhythmMulti = 8.2f);

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;
        strength + additionalPoints = 6;
        agility  + additionalPoints = 8;
        intelligence + additionalPoints = 9;

        //Debug out our new physical stat values
        Debug.Log(strength + additionalPoints = 6);
        Debug.Log(agility + additionalPoints = 8);
        Debug.Log(intelligence + additionalPoints = 9);

        //// let's recalculate our style, luck and rhythm as our initial stats have changed.
        style = strength * styleMulti = 6 * (10% + 6) = 6.6f;
        luck = intelligence * luckMulti = 9 * (9% + 9) = 9.9f;
        rhythm = agility * rhythmMulti = 8 * (2% + 8) = 8.2f;

        //// Debug out our new dancing stat values
        Debug.Log(rhythm = 8.2f);
        Debug.Log(style = 6.6f)
        Debug.Log(luck = 9.9f);
    }
}
