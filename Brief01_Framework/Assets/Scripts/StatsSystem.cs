using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///// <summary>
///// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
///// calculating our dancing stats based on physical stats and our stat multipliers.
///// </summary>
public class StatsSystem : MonoBehaviour
//Update is called one per frame
{
    // Our physical stats that determine our dancing stats.
    private float agility;
    private float intelligence;
    private float strength;
    private float additionalPoints;

    // Our variables used to determine our fighting power.
    private float rhythm;
    private float luck;
    private float style;
    private float styleMulti;
    private float luckMulti;
    private float rhythmMulti;

    private void Start()
    {
        //// set out agility, strength and intelligence to a random number between zero and ten.
        //// BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        strength = 5.0f;
        agility = 7.0f;
        intelligence = 8.0f;

        //// Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log(strength = 5.0f);
        Debug.Log(agility = 7.0f);
        Debug.Log(intelligence = 8.0f);

        // let's create some float temporary variables to hold our multiplier values.
        // create an agility multiplier this should be set to 0.5f
        agility = rhythmMulti = 0.5f;
        // create a strength multiplier this should be set to 1.0f
        strength = styleMulti = 1.0f;
        // create an intelligence multiplier this should be set to 2.0f
        intelligence = luckMulti = 2.0f;

        // Debug out our current multiplier values
        Debug.Log(agility = rhythmMulti = 0.5f);
        Debug.Log(strength = styleMulti = 1.0f);
        Debug.Log(intelligence = luckMulti = 2.0f);

        // now that we have some stats and our multiplier values let's calculate our style, luck and rhythm based on these values.
        // style should be based off our strength and be converted at a rate of 1 : 1
        style = strength = styleMulti = 5.1f;
        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        luck = intelligence = luckMulti = 8.3f;
        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5f
        rhythm = agility = rhythmMulti = 7.5f;

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log(style = strength = styleMulti = 5.1f);
        Debug.Log(luck = intelligence = luckMulti = 8.3f);
        Debug.Log(rhythm = agility = rhythmMulti = 7.5f);

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        additionalPoints = 10.0f;
        strength = 7.1f;
        intelligence = 10.3f;
        agility = 10.5f;

        //Debug out our new physical stat values
        Debug.Log(additionalPoints = 10.0f);
        Debug.Log(strength = 7.1f);
        Debug.Log(intelligence = 10.3f);
        Debug.Log(agility = 10.5f);

        // let's recalculate our style, luck and rhythm as our initial stats have changed.
        style = strength = styleMulti = 7.2f;
        luck = intelligence = luckMulti = 10.6f;
        rhythm = agility = rhythmMulti = 10.6f;

        //// Debug out our new dancing stat values
        Debug.Log(style = strength = styleMulti = 7.2f);
        Debug.Log(luck = intelligence = luckMulti = 10.6f);
        Debug.Log(rhythm = agility = rhythmMulti = 10.6f);
    }
}
    
        
