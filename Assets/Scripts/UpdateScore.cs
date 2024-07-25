using UnityEngine;
using UnityEngine.UI;
public class UpdateScore : MonoBehaviour{
    public Text Text; 
    public void ScoreChange(int score){
        Text.text = score.ToString();}}
