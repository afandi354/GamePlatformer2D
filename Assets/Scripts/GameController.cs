using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public int total_coin = 0; // digunakan untuk mencatat coin
	public Text coinLabel; // Digunakan untuk menampilkan coin

	private static GameController instance;
	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddCoin(){
		total_coin++;
		coinLabel.text = "Emas : " + total_coin.ToString ();
	}

	public static GameController GetInstance(){
		return instance;
	}
}
