using UnityEngine;
using System.Collections;


public class AdManager : MonoBehaviour {

	public static AdManager instance;

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		AppLovin.InitializeSdk ();
		AppLovin.PreloadInterstitial ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ShowInterstitialAd(){

		Debug.Log ("Ads Showing");

		if (AppLovin.HasPreloadedInterstitial ()) {
			AppLovin.ShowInterstitial ();
		}
	}
}
