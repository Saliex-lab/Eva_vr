using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace EVA
{
    public class InputManager : MonoBehaviour
    {
        public TextAsset textJSON;

        [System.Serializable]
        public class Inputs
        {
            public string MainMenu;

            public string SelectVoid;
            
            public string Escape;

            public string DeleteGrabOne;
            public string DeleteGrabTwo;

            public string SelectObject;

            public string GrabObject;

            public string PinToWall;

            public string ButtonB;
            
            public string ManipulationModeOne;
            public string ManipulationModeTwo;

            public string DuplicateObject;



        }

        public Inputs myInputList;
        private void Awake()
        {
            myInputList = JsonUtility.FromJson<Inputs>(textJSON.text);
        }

        public OVRInput.Button getDownShortCut(string getShortCutJson)
        {
            string shortCut = convertAttributToString(getShortCutJson);

            switch (shortCut)
            {
                case "Start":
                    return OVRInput.Button.Start;
                case "PrimaryIndexTrigger":
                    return OVRInput.Button.PrimaryIndexTrigger;
                case "Two":
                    return OVRInput.Button.Two;
                case "PrimaryHandTrigger":
                    return OVRInput.Button.PrimaryHandTrigger;
                case "DeleteGrab":
                    return OVRInput.Button.SecondaryHandTrigger;
                case "SecondaryHandTrigger":
                    return OVRInput.Button.SecondaryHandTrigger;
                case "Four":
                    return OVRInput.Button.Four;
                case "One":
                    return OVRInput.Button.One;
                default:
                    return OVRInput.Button.Any;
            }
        }

        public KeyCode getDownShortCutKeyBoard(string getShortCutJson)
        {
            string shortCut = convertAttributToString(getShortCutJson);

            switch (shortCut)
            {
                case "Tab":
                    return KeyCode.Tab;
                case "LeftControl":
                    return KeyCode.LeftControl;
                case "Delete":
                    return KeyCode.Delete;
                case "Space":
                    return KeyCode.Space;
                case "LeftAlt":
                    return KeyCode.LeftAlt;
                case "D":
                    return KeyCode.D;
                default:
                    return KeyCode.None;
            }
        }

        public string convertAttributToString(string arg)
        {
            return (string)typeof(Inputs).GetField(arg).GetValue(myInputList);
        }

     /*   public OVRInput.Button getMultiShortCut(string arg)
        {
            string test = (string)typeof(Inputs).GetField(arg).GetValue(myInputList);
            Debug.Log("tettt"  +test);
           return OVRInput.Button.Any;
        }*/
    }
}