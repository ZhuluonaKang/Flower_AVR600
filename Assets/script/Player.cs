using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Playere : MonoBehaviour
{
    public TMP_Text ui;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("bottle")){
            score++;
            //score+=1
            //score=score+1;

            ui.text = "score:" + score;
            Destroy(other.gameObject);
        }
    }
}
