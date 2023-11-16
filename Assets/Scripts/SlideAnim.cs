using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SlideAnim : MonoBehaviour
{

    public GameObject platePrefab;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            transform.DOMoveX(15.0f, 0.3f);
            Invoke("Pos", 0.5f);
            Invoke("SeconAnim", 0.5f);


        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            transform.DOMoveX(-15.0f, 0.3f);
            Invoke("SeconAnim", 0.5f);

        }
    }

    void Pos()
    {
        transform.position = new Vector3(-15, -3, 0);
    }

    void SeconAnim()
    {
        transform.DOMoveX(0.0f, 0.3f);
    }
}
