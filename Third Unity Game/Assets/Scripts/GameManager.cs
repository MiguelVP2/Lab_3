using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public GameObject cat;
    public GameObject Player;
    public GameObject ending;
    // Start is called before the first frame update
    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

    }

    //public Vector2 getPos(){
        //print("gamemanager called");
        //positionNumber += 1;
        //return posList[(positionNumber - 1)];
    //}

    public void StopGame(){
        //npc.GetComponent<EnemyMovement>().StopMoving();
        //player.GetComponent<Player>().StopMoving();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            //nstance.Scene
            print("colided");
        }
    }
    
    void Start()
    {
        
    }

}
