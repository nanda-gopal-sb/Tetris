using UnityEngine;
using UnityEngine.UI;
public class RotateButton : MonoBehaviour{
    public bool isPressed; 
    public Button btn ; 
    public void Rotate(){
        isPressed = true; 
    }
    private void Update() {
        btn.onClick.AddListener(Rotate);}}