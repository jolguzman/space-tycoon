using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

    public Button m_ShelterBtn;
    public Button m_WaterBtn;
    public Button m_ElectricityBtn;
    public Button m_expandBtn;
   
	// Use this for initialization
	void Start () {
        Button btn = m_ShelterBtn.GetComponent<Button>();
        
	}
	
	// Update is called once per frame
	void Update () {
        
        
	}

    // will retrive buildable items given the criteria selected
    void LoadItems()
    {

    }
    void TaskOnClick()
    {
        Debug.Log("you clicked on Shelter");
    }
}
