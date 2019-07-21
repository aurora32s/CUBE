using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class LoginSceneController : MonoBehaviour {

    public Button googleIcon;
    public Button facebookIcon;
    public Button kakaoIcon;
    public Button naverIcon;

	// Use this for initialization
	void Start () {

        Button btn1 = googleIcon.GetComponent<Button>();

        Screen.SetResolution(Screen.width, Screen.width / 2 * 3, true);

        btn1.onClick.AddListener(SetOnGoogleClicked);
        facebookIcon.onClick.AddListener(SetOnFacebookClicked);
        kakaoIcon.onClick.AddListener(SetOnKaKaoClicked);
        naverIcon.onClick.AddListener(SetOnNaverClicked);

    }
	
	// Update is called once per frame
	void Update () {

	}

    void SetOnGoogleClicked()
    {
        Debug.Log("Google Clicked");
    }

    void SetOnFacebookClicked()
    {
        Debug.Log("Google Clicked");
        //GUI.Box(new Rect(0, 0, Screen.width / 2, Screen.height / 2), "This is the text to be displayed");
    }

    void SetOnKaKaoClicked()
    {
        Debug.Log("Google Clicked");
    }

    void SetOnNaverClicked()
    {
        Debug.Log("Google Clicked");
    }
}
