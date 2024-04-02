using UnityEngine;
using UnityEngine.UI;

public class LeftButton : MonoBehaviour{
    public bool isPressed; 
    public Button btn ; 
    public void left(){
        isPressed = true; }
    private void Update() {
        btn.onClick.AddListener(left);}}