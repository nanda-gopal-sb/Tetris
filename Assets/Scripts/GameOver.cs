using UnityEngine;
public class GameOver : MonoBehaviour{
    public bool GameisAlive = true;
    public CanvasGroup CV ; 
    public Pause pause;
    void Start() {
        CV.alpha = 0f;
	    CV.interactable = false;
	    CV.blocksRaycasts = false;}
    public void EndScreen(){
            Show();
            GameisAlive = false;
            pause.DiableButtons();
    }
    void Show(){
        CV.alpha = 1f;
	    CV.interactable = true;
        CV.blocksRaycasts = true;}}