using UnityEngine;

public class potatoscript : MonoBehaviour {
    public Player playermov;
    public AudioSource potatoPickUp;
    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Player" && playermov.tpskill == false) { potatoPickUp.Play(); Destroy(gameObject); }
    }//Pattis alma kodu farkl� olmas�n�n amac� e�er bir tane h�li haz�rda alm��sa ikinciyi almas�n� engellemek.
}
