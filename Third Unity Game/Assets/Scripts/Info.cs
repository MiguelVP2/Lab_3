using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider2D) {
        print("Found..");
        if (collider2D.gameObject.CompareTag("Player")) {
            GameManager.Instance.DialogShow(text);
        }
    }

    public void OnTriggerExit2D(Collider2D collider2D){
        if(collider2D.gameObject.CompareTag("Player")){
            GameManager.Instance.DialogHide();
            print(text);
        }
    }
}
