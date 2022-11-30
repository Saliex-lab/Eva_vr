using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public TextAsset textJSON;

    [System.Serializable]
    public class Inputs
    {
        public string test;
    }

    [System.Serializable]
    public class InputList
    {
        public Inputs[] input;
    }

    public InputList myInputList = new InputList();

    void Start()
    {
        myInputList = JsonUtility.FromJson<InputList>("InputManager.txt");
    }
}

