using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSingleton : MonoBehaviour
{
    public static PowerupSingleton instance;
    int score;
   
    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void YellowBell(int coinValue)
    {
        coinValue = coinValue * 2; //doubles the coin's value
        ScoreManager.instance.ChangeScore(coinValue);
        Debug.Log(score);
    }

    public float BlueBell(float moveSpeed)
    {
        moveSpeed = moveSpeed * 2.0f; //doubles the player's speed
        return moveSpeed;
    }

 
}
