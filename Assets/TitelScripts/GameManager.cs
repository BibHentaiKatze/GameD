using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameStates
    {
        inTitel,
        paused,
        inGame
    };

    public GameStates state2 = GameStates.inTitel;

   


    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
        state2 = GameStates.inGame;

    }
        
        
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
