using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    //Singleton itself
    static GameManager instance;

    //Accessor for the singleton
    public static GameManager Instance
    { get{ return instance ?? ((instance = new GameManager())); } }

    private Character player;
    public Character Player
    {
        get
        {
            if (player != null)
                return player;
            else
                return player = GameObject.Find("Character").GetComponent<Character>();
        }
        set
        {
            player = value;
        }
    }

    //Because we only ever want one, we must make a PRIVATE constructor, not a public constructor
    private GameManager()
    {
        //Create a new object with a script of type Updater to update the GameManager
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }

    private void Update()
    {
        //Game logic would go here like managing time and level resets, etc
    }

    //Internal class used to update the GameManager since GameManager doesn't inherit from MonoBehaviour
    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }
}
