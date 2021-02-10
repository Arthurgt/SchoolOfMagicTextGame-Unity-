using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
   [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] string choice1;
    [SerializeField] string choice2;
    [SerializeField] string choice3;
    [SerializeField] string choice4;
    [SerializeField] State[] nextStates;

    public string getStateStory()
    {
        return storyText;
    }

    public State[] getNextStates()
    {
        return nextStates;
    }

    public string getChoice1()
    {
        return choice1;
    }

    public string getChoice2()
    {
        return choice2;
    }

    public string getChoice3()
    {
        return choice3;
    }

    public string getChoice4()
    {
        return choice4;
    }

}
