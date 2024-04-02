using UnityEngine;
public class Music : MonoBehaviour{
   public AudioSource game; 
   public AudioSource lineClear; 
   public AudioSource GameOver; 
   public void StopMusic(){
    game.Stop();}
   public void Celebrate(){
    lineClear.Play();
    GameOver.Stop();}

   public void PlayGameOver(){
    GameOver.Play();}}
