using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   

   public void PlayQuiz()

   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
   }

   public void AutoPech()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
   }

   public void Quitgame()

   {
       Application.Quit();
   }
}
