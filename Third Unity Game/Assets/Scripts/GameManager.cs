using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public GameObject cat;
    public GameObject cat2;
    public GameObject cat3;
    public GameObject cat4;
    public GameObject cat5;
    public GameObject cat6;
    public GameObject Player;
    public GameObject ending;
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string text;
    // Start is called before the first frame update
    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

    }

    public void DialogShow(string text) {
        dialogBox.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(TypeText(text));
    }

    public void DialogHide() {
        dialogBox.SetActive(false);
    }

    IEnumerator TypeText(string text) {
        dialogText.text = "";
        foreach (char c in text.ToCharArray()) {
            dialogText.text += c;
            yield return new WaitForSeconds(0.02f);
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
        //if(collision.gameObject.tag == "enemy")
        //{
            //nstance.Scene
            //print("colided");
        //}
    }

    public void OnTriggerEnter2D(Collider2D collider2D) {
        print("Found..");
        if (collider2D.gameObject.CompareTag("info")) {
            GameManager.Instance.DialogShow(text);
        }
        if (collider2D.gameObject.CompareTag("enemy")) {
            //SceneLoader.Instance.LoadScene("GameOver");
        }
    }

    void Start()
    {
        
    }

}
