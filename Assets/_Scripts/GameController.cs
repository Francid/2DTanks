using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;
	public Text livesLabel;
	public Text scoreLabel;
	public Text highScoreLabel;
	public Text gameOverLabel;
	public Button resetButton;

	// PRIVATE INSTANCE VARIABLES
	private int _scoreValue;
	private int _livesValue;

	//Access methods
	public int ScoreValue{
		get{ 
			return this._scoreValue;
		}
		set{ 
			this._scoreValue = value;
			this.scoreLabel.text = "Score: " + this._scoreValue;
		}
	}

	public int LivesValue{
		get{ 
			return this._livesValue;
		}
		set{ 
			this._livesValue = value;
			if (this._livesValue < 0) {
				this.highScoreLabel.text = "High Score: " + this._scoreValue;
				this.gameOverScene ();
			}
			this.livesLabel.text = "Lives: " + this._livesValue;
		}
	}
	
	// Use this for initialization
	void Start () {
		this.ScoreValue = 0;
		this.LivesValue = 3;
		this.gameOverLabel.gameObject.SetActive (false);
		this.resetButton.gameObject.SetActive (false);
		this.highScoreLabel.gameObject.SetActive (false);
		this._GenerateTanks ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// generate Tanks
	private void _GenerateTanks() {
		
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}

	private void gameOverScene(){

		this.scoreLabel.gameObject.SetActive (false);
		this.livesLabel.gameObject.SetActive (false);
		this.gameOverLabel.gameObject.SetActive (true);
		this.resetButton.gameObject.SetActive (true);
		this.highScoreLabel.gameObject.SetActive (true);

	}


	public void ResetButton(){
		Application.LoadLevel ("Main");
	}
}
