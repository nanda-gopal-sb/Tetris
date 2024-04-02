using UnityEngine;
using UnityEngine.UI;

public class RightButton : MonoBehaviour{
    public bool isPressed; 
    public Button btn ; 
    public void right(){
        isPressed = true; }
    private void Update() {
        btn.onClick.AddListener(right);}}