using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireScore : MonoBehaviour
{
    //Déclaration du score
    public static int Score = 0;
    //Référence au Text mesh 3D
    public GameObject TexteScore;
    //Variable pour doubler le score ou nopn
    public static bool Double=false;
    
    void Update()
    {
        //On update toujours le score
        if(Score < 200){
            TexteScore.GetComponent<TextMesh>().text = Score.ToString();
        }
        //Si on atteint 200 de scores... on gagne!
        else{
            TexteScore.GetComponent<TextMesh>().text = "Gagné!";
        }
        

        
    }

}
