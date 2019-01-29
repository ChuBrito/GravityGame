using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApplication : MonoBehaviour
{
    [SerializeField]
    GameObject model;
    [SerializeField]
    GameObject controller;

    private void Start()
    {
        model.GetComponent<GameModel>();
        controller.GetComponent<GameController>();
    }
}
