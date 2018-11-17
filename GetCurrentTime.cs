using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCurrentTime : MonoBehaviour {

    private string url = "https://www.tutounity.fr/upload/currenttime.php";
    private string timeData;
    private string currentTime;
    private string currentDate;

	void Start () {
        // Affichage de la date et l'heure au lancement du jeu
        StartCoroutine("GetDateTime");
	}
	
	public IEnumerator GetDateTime()
    {
        // récupération des infos de la page internet
        WWW www = new WWW(url);
        yield return www;

        // récupération des infos terminée, séparation de la date et l'heure
        timeData = www.text;
        string[] finalTime = timeData.Split('/');

        // assignation des variables date et heure
        currentDate = finalTime[0];
        currentTime = finalTime[1];

        // affichage de la date et heure dans la console
        Debug.Log("Date actuelle : " + currentDate);
        Debug.Log("Heure actuelle : " + currentTime);
    }

}
