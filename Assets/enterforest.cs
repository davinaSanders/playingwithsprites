using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "enterforest")]
public class enterforest : ScriptableObject
{
	[TextArea(10,14)] [SerializeField] string storyText;
	 //[SerializeField] State startingState;

	public string GetStateStory() 
 //
	{
	return storyText;
//
	}

}



