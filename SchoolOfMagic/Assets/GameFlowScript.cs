using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFlowScript : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] Text choice1;
    [SerializeField] Text choice2;
    [SerializeField] Text choice3;
    [SerializeField] Text choice4;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        storyText.text = state.getStateStory();
        choice1.text = state.getChoice1();
        choice2.text = state.getChoice2();
        choice3.text = state.getChoice3();
        choice4.text = state.getChoice4();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
        ManageChoices();
    }

    private void ManageState()
    {
        State[] nextStates = state.getNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            state = nextStates[3];
        }
        storyText.text = state.getStateStory();
    }

    private void ManageChoices()
    {
        choice1.text = state.getChoice1();
        choice2.text = state.getChoice2();
        choice3.text = state.getChoice3();
        choice4.text = state.getChoice4();
    }
}
