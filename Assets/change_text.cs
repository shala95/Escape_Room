using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class change_text : MonoBehaviour
{
    public TMP_Text testoScritta; // Riferimento al componente Text della scritta
    public int score = ScoreManager.globalScore;
    // Start is called before the first frame update
    private void Start()
    {
        // Controlla il valore della variabile e imposta il testo di conseguenza
        if (score < 3)
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12"){
                testoScritta.text = "Complimenti, hai completato il primo livello!  Non rilassarti, questo è solo l’inizio. Ti metteremo sempre di più sotto pressione per farti capire come si sentono le persone che hanno l’ansia.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23"){
                testoScritta.text = "Complimenti, hai completato il secondo livello! Non mollare perché manca poco per uscire dalla cava";
            } else {
                testoScritta.text = "Complimenti, hai completato il gioco nonostante le insidie a cui sei stato sottoposto! Hai provato cosa significhi essere sotto pressione, pensa a chi ha l’ansia tutti i giorni. Non dimenticare la lezione che hai imparato oggi.";
            }
        }
        else if (score < 6)
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12"){
                testoScritta.text = "Complimenti, hai completato il primo livello! Non rilassarti troppo da adesso il gioco si farà più duro…ma tranquillo, riceverai dei piccoli aiuti che ti permetteranno di affrontare i momenti in cui proverai ansia.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23"){
                testoScritta.text = "Complimenti, hai completato il secondo livello! Non mollare perché manca poco per uscire dalla cava";
            } else {
                testoScritta.text = "Complimenti, hai completato il gioco nonostante le insidie a cui sei stato sottoposto! Hai provato cosa significhi essere sotto pressione, pensa a chi ha l’ansia tutti i giorni. Non dimenticare la lezione che hai imparato oggi.";
            }
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12"){ 
                testoScritta.text = "Complimenti, hai completato il primo livello! Non preoccuparti se hai avuto qualche difficoltà, nei prossimi livelli sarai aiutato in modo da superare ogni difficoltà e uscire dalla cava.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23"){
                testoScritta.text = "Complimenti, hai completato il secondo livello! Non mollare perché manca poco per uscire dalla cava";
            } else {
                testoScritta.text = "Complimenti, hai completato il gioco nonostante le insidie a cui sei stato sottoposto! Hai provato cosa significhi essere sotto pressione, pensa a chi ha l’ansia tutti i giorni. Non dimenticare la lezione che hai imparato oggi.";
            }
        }
    }
}
