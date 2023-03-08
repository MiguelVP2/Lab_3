using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public List<GameObject> locs;
    private Queue<GameObject> qlocs;

    public float duration = 5;
    
    public string text;
    // Start is called before the first frame update
    void Start()
    {
         qlocs = new Queue<GameObject>();
        foreach (GameObject go in locs)
        {
            qlocs.Enqueue(go);
        }
        NextUp();
        
    }

    void NextUp()
    {
        GameObject pong = qlocs.Dequeue();
        StartCoroutine(LerpPosition(pong.transform.position));
        qlocs.Enqueue(pong);
    }

     public void StopMoving(){
        StopAllCoroutines();
    }

    public void StartMoving(){
        Start();
    }

    public void OnTriggerEnter2D(Collider2D collider2D) {
        print("Found..");
        if (collider2D.gameObject.CompareTag("Player")) {
            //GameManager.Instance.DialogShow(text);
            GameManager.Instance.StopGame();
        }
    }

    IEnumerator LerpPosition(Vector2 targetPosition)
    {
        float time = 0;
        Vector2 startPosition = transform.position;

        while (time < duration)
        {
            transform.position = Vector2.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
        NextUp();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
