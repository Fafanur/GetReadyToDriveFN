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
			Debug.log("Goede Antwoord");
			quizManager.correct();
		}
		else
		{
			Debug.log("foute Antwoord");
			quizManager.correct();
		}
   }
}
