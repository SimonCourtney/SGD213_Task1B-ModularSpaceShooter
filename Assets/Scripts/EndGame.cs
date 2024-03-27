using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class EndGame : MonoBehaviour
{
    public GameObject endTextObject;
    public static EndGame instance;
    // Start is called before the first frame update
    void Start()
    {
        endTextObject.SetActive(false);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void endGame()
    {
        endTextObject.SetActive(true);
    }
}
