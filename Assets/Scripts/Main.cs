using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Main : MonoBehaviour {

	public static Main instance;
	public int level = 0;
	public int money = 0;
	public int waves = 0;
	public int waveCount = 0;
	private Text moneyTxt, levelTxt, waveTxt;

	// Use this for initialization
	void Start () {
		instance = this;
		moneyTxt = GameObject.Find("Canvas/money").GetComponent<Text>();
		levelTxt = GameObject.Find("Canvas/level").GetComponent<Text>();
		waveTxt = GameObject.Find("Canvas/wave").GetComponent<Text>();
		moneyTxt.text = "Money	" + money;
		levelTxt.text = "Level	" + level;
		waveTxt.text = "Wave	" + waves + " of " +  waveCount;
	}
	
	// Update is called once per frame
	void Update () {
		moneyTxt.text = "Money	" + money;
	}
}
