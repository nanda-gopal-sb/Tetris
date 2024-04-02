using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private bool isPaused = false; 
    public Sprite pause; 
    public Sprite Resume; 
    public Button PauseButton;
    public Button RotateButton;
    public Button DownButton;
    public Button LeftButton;
    public Button RightButton; 
    public void onClick(){
        if(isPaused){
            Time.timeScale = 1 ; 
            PauseButton.image.sprite = pause;
            RotateButton.interactable = true;
            DownButton.interactable = true;
            LeftButton.interactable = true;
            RightButton.interactable = true;
            isPaused = false; 
        }
        else{
            Time.timeScale = 0 ; 
            PauseButton.image.sprite = Resume;
            RotateButton.interactable = false;
            DownButton.interactable = false;
            LeftButton.interactable = false;
            RightButton.interactable = false;
            isPaused = true;  
        }
    }
    public void DiableButtons(){
            RotateButton.interactable = false;
            DownButton.interactable = false;
            LeftButton.interactable = false;
            RightButton.interactable = false;
            PauseButton.interactable = false;
    }
}