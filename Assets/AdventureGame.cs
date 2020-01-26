using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
	[SerializeField] Text textComponent;
	[SerializeField] enterforest insideForest;

	int[] oddNumbers = { 1, 3, 5, 7, 9 };

	enterforest state;
	//enterforest is from the class 
	//enterforest which creates types of states 


    // Start is called before the first frame update
    void Start() {
    	state = insideForest;
    	//In unity, insideForest actually corresponds to the scriptableobject 
    	//called insideForest1 which we generated in unity and dragged into the 
    	//game object which is linked to this script. 
    	//In the code, insideForest is a type of the class enterforest which is on the enterforest.cs
    	//and it has a getter available which returns the storytext property for this object. 
    	//
    	//Remember: all scripts need game objects attached to them except scriptable object 
    	//scripts. 

    	textComponent.text = state.GetStateStory();
    	Debug.Log("");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
