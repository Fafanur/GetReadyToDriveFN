using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{

	public bool isCorrect = false;
	public QuizManager quizManager;
   public void Answer()
   {
   
		if(isCorrect)
		{
			Debug.Log("Goede Antwoord");
			quizManager.correct();
		}
		else
		{
			Debug.Log("foute Antwoord");
			quizManager.wrong();
		}
   }
}
