using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    
   [SerializeField] Text textComponent;
   [SerializeField] State startingState;

   State state;


    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }
    private void ManageState()
    {
        //var can be used if the variable declared and initialized
        //can substiture var for State[]
        var nextStates = state.GetNextStates();

        for (int index = 0; index < nextStates.Length; index++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
            else if(Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = startingState;
            }
        }
        //else if (Input.GetKeyDown(KeyCode.))
        textComponent.text = state.GetStateStory();
    }
}
