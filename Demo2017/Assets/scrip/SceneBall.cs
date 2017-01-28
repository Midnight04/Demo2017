using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneBall : MonoBehaviour {

	public Text txtScore;
	public Text txtAttack;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	int score = 0;
	int Attack = 0;
	public void DopushButton(){
		score++;
		Attack+= 2;
		txtScore.text = "Score :" + score.ToString ();
		txtAttack.text = "Attack :" + Attack.ToString ();
	}
	public void DoChangeScene (){
		SceneManager.LoadScene (1);
}
}
