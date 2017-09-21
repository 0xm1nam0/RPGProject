using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterCreation : MonoBehaviour {
    public GameObject[] characterPrefabs;
    private GameObject[] characterGameObects;
    private int selectedIndex = 0;
    private int length;

    public InputField nameInput;

    // Use this for initialization
    void Start () {
        length = characterPrefabs.Length;
        characterGameObects = new GameObject[length];
        for(int i = 0; i < length; i++)
        {
            characterGameObects[i] = GameObject.Instantiate(characterPrefabs[i], transform.position, transform.rotation) as GameObject;
        }
        UpdateCharacterShow();
    }

    //更新所有角色的显示
    void UpdateCharacterShow()
    {
        characterGameObects[selectedIndex].SetActive(true);
        for (int i = 0; i < length; i++)
        {
            if (i != selectedIndex)
            {
                characterGameObects[i].SetActive(false);
            }
        }
    }

    public void OnNextButtonClick()
    {
        selectedIndex++;
        selectedIndex %= length;
        UpdateCharacterShow();
    }

    public void OnPrevButtonClick()
    {
        selectedIndex--;
        if(selectedIndex == -1)
        {
            selectedIndex = length - 1;
        }
        UpdateCharacterShow();
    }

    public void OnOkButtonClick()
    {
        PlayerPrefs.SetInt("selectedCharacterIndex", selectedIndex);
        PlayerPrefs.SetString("name", nameInput.text);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
