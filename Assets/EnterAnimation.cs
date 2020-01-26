using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnterAnimation : MonoBehaviour {
	public Button EnterButton;

	void Start () {
		Button btn = EnterButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
	}
}