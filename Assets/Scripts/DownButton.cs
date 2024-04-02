using UnityEngine;
using UnityEngine.UI;
public class DownButton : MonoBehaviour{
    public bool isPressed; 
    public Button btn ; 
    public void down(){
        isPressed = true; 
    }
    private void Update() {
        btn.onClick.AddListener(down);
    }
}
