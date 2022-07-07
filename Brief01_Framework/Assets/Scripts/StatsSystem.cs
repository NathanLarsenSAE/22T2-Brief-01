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
        strength = 0;
        agility = 0;
        intelligence = 0;

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log(strength = 0);
        Debug.Log(agility = 0);
        Debug.Log(intelligence = 0);

        // let's create some float temporary variables to hold our multiplier values.
        float rhythmMulti = 0.5f;
        float styleMulti = 1;
        float luckMulti = 2;

        // create an agility multiplier should be set to 0.5
        rhythm = agility * rhythmMulti = 0.5f;

        // create a strength multiplier should be set to 1
        style = strength * styleMulti = 1;

        // create an intelligence multiplier should be set to 2
        luck = intelligence * luckMulti = 2;

        // Debug out our current multiplier values
        Debug.Log(rhythm = agility * rhythmMulti = 0.5f);
        Debug.Log(style = strength * styleMulti = 1);
        Debug.Log(luck = intelligence * luckMulti = 2);

        // now that we have some stats and our multiplier values let's calculate our style, luck and rhythm based on these values.
        // style should be based off our strength and be converted at a rate of 1 : 1
        style = strength * styleMulti = 1;

        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        luck = intelligence * luckMulti = 2 : 3;

        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        rhythm = agility * rhythmMulti = 0.5f : 0.7f;

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log(rhythm = agility * rhythmMulti = 0.5f: 0.7f);
        Debug.Log(style = strength * styleMulti = 1);
        Debug.Log(luck  = intelligence * luckMulti = 2 : 3);
        
        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;
        agility  + additionalPoints = 1.5f;
        strength + additionalPoints = 2;
        intelligence + additionalPoints = 4;

        //Debug out our new physical stat values
        Debug.Log(agility = 1.5f);
        Debug.Log(strength = 2);
        Debug.Log(intelligence = 4);

        //// let's recalculate our style, luck and rhythm as our initial stats have changed.
        int additionalPoints = 10;
        rhythm + additionalPoints = 1.5f : 1.7f;
        style + additionalPoints = 2;
        luck + additionalPoints = 3 : 4;

        //// Debug out our new dancing stat values
        Debug.Log(rhythm = 1.5f : 1.7f);
        Debug.Log(style = 2);
        Debug.Log(luck = 3 : 4);
    }
}
