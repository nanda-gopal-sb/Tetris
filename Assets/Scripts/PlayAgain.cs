using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayAgain : MonoBehaviour
{
    public void restart(){
        SceneManager.LoadScene("Tetris");
    }
}