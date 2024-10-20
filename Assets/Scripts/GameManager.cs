using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Game Objects")]
    [SerializeField] private Pin[] pins;
    [SerializeField] private GameObject ballPrefab;

    
    [Header("Game Status")]
    [SerializeField] private int throwCounter;
    [SerializeField] private int maxAmountOfFrame;
    [SerializeField] private int currentFrame;

    [Header("Score Settings")]
    [SerializeField] private int totalScore;
    [SerializeField] private int firstThrowScore;
    [SerializeField] private int secondThrowScore;

    // Start is called before the first frame update
    void Start()
    {
        currentFrame = 1;
        StartThrow();
        

    }

   public void BallOnPit()
    {
        throwCounter++;

      
        Invoke("StartThrow", 3);


    }

    // Update is called once per frame
   public void StartThrow()
    {
        CheckForFallenPins();

        if (throwCounter == 2 || firstThrowScore == 10)
        {
            StartNewFrame();
        }

        if (currentFrame > maxAmountOfFrame) //If It's Past Last Frame (>=)
        {
            return;
        }


        Instantiate(ballPrefab, transform.position, transform.rotation);
    }

    void StartNewFrame()
    {
        totalScore += firstThrowScore + secondThrowScore;
        firstThrowScore = 0;
        secondThrowScore = 0;

        throwCounter = 0;

        currentFrame++;
        
        RepositionPins();
        
    }
    
    void RepositionPins()
    {
        foreach(Pin p in pins)
        {
            p.gameObject.SetActive(true);
            p.ResetPinToOrgin();
        }
    }

    void CheckForFallenPins()
    {
        int score = 0;

        foreach(Pin pin in pins)
        {
            if(pin.IsPinFallen())
            {
                score++;
                //if (pin.gameObject.activeInHierarchy)
                pin.gameObject.SetActive(false);
            }
      
        }
        
        Debug.Log(score);
    }
}
