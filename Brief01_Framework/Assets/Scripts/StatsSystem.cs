using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///// <summary>
///// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
///// calculating our dancing stats based on physical stats and our stat multipliers.
///// </summary>
public class StatsSystem : MonoBehaviour
{
    //// Our physical stats that determine our dancing stats.

    public int agility;

    public int intelligence;

    public int strength;

    //// Our variables used to determine our fighting power.

    public int styleMulti;

    public int luckMulti;

    public int rhythmMulti

    private void Start()
    {
        //// set out agility, strength and intelligence to a random number between zero and ten.
        //// BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        int strength = 0;
        int agility = 0;
        int intelligence = 0;
        //// Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log(strength = 0);
        Debug.Log(agility = 0);
        Debug.Log(intelligence = 0);

        //// let's create some float temporary variables to hold our multiplier values.
        //// create an agility multiplier.
        //// This should be set to 0.5f
        float agility rhythmMulti = 0.5f;
        // create a strength multiplier
        //// This should be set to 1
        float strength styleMulti = 1;
        //// create an intelligence multiplier
        //// This should be set to 2
        float intelligence luckMulti = 2;

        //// Debug out our current multiplier values
        Debug.Log(agilityRhythmMulti);
        Debug.Log(strengthStyleMulti);
        Debug.Log(intelligenceLuckMulti);
        


        //// now that we have some stats and our multiplier values let's calculate our style, luck and rhythm based on these values.
        //// style should be based off our strength and be converted at a rate of 1 : 1
        style = strengthStyleMulti = 1 * (10 / 10) = 0.1f + 5 = 5.1f; ;
        //// luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        luck = intelligenceLuckMulti = 2 * ((10 / 15) = 0.1f + 8) = 8.1f; ;
        //// rhythm should be based off our agility and be converted at a rate of 1 : 0.5f
        rhythm = agilityRhythmMulti = 0.5f * ((10 / 5) = 0.1f + 7) = 7.1f; ;

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log(style = strength * styleMulti = 5.1f);
        Debug.Log(luck = intelligence * luckMulti = 8.1f);
        Debug.Log(rhythm = agility * rhythmMulti = 7.1);

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;
        strength + additionalPoints = 15;
        intelligence + additionalPoints = 18;
        agility + additionalPoints = 17;

        //Debug out our new physical stat values
        Debug.Log(strength + additionalPoints = 15);
        Debug.Log(intelligence + additionalPoints = 18);
        Debug.Log(agility + additionalPoints = 17);

        //// let's recalculate our style, luck and rhythm as our initial stats have changed.
        style = strength * styleMulti = (15 * (10 / 10)) = 15.1f;
        luck = intelligence * luckMulti = (18 * (10 / 15)) = 20.7f;
        rhythm = agility * rhythmMulti = (17 * (10 / 5)) = 18.4f;

        //// Debug out our new dancing stat values
        Debug.Log(style = 15.1f);
        Debug.Log(luck = 20.7f);
        Debug.Log(rhythm = 18.4f);



    }
}
    
        
