using UnityEngine;
using System.Collections;

public class GameStateManager : MonoBehaviour {

    public enum GameState : short {Start, Store, Play, Options, Lose};
    public GameState Game;

void Start()
{
        Game = GameState.Start;
}

// Update is called once per frame
void Update()
{
        switch (Game)
        {
            case GameState.Start:
            // Start code goes here
            break;

            case GameState.Store:
            // Store code goes here
            break;

            case GameState.Play:
            // Play code goes here
            break;

            case GameState.Options:
            // Options code goes here
            break;

            case GameState.Lose:
            // Lose code goes here
            break;

            default:
                Debug.Log("Game State Error, Invalid value in Game State");
                break;
        }
}
}
