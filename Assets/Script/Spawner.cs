using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public GameObject player;
    public GameObject[] gold;
    public GameObject[] backdrobs;
    public GameObject Borg2;
    public GameObject Borg;

    private float backdrobspawntimer = 0.5f;
    private float goldspawntimer = 5.0f;
    private float borgspawntimer = 10.0f;
    private float borgspawntimer2 = 12.0f;
    


    // Update is called once per frame
    void Update() {
        goldspawntimer -= Time.deltaTime;
        borgspawntimer -= Time.deltaTime;
        borgspawntimer2 -= Time.deltaTime;
        backdrobspawntimer -= Time.deltaTime;

        if (goldspawntimer < 0.01)
        {
            spawngold();
        }
        if (backdrobspawntimer < 0.01)
        {
            spawnbackdrop();
        }
        if (borgspawntimer < 0.01)
        {
            spawnborg();
        }
        if (borgspawntimer2 < 0.01)
        {
            spawnborg2();
        }
    }
    void spawnborg()
    {
        Borg.transform.localScale = new Vector3(Random.Range(3, 10), Random.Range(3, 10),Random.Range(3, 6));
        Instantiate(Borg, new Vector3(player.transform.position.x + 30,
            Random.Range(3, 12), 0), Quaternion.identity);
        borgspawntimer = Random.Range(3.0f, 10.0f);
    }
    void spawnborg2()
    {
        
        Borg2.transform.localScale = new Vector3 (Random.Range(3, 5), Random.Range(3, 10), Random.Range(3, 10));
        Instantiate(Borg2, new Vector3(player.transform.position.x + 30,
            Random.Range(3, 12), 0), Quaternion.Euler(0,90,0));
        borgspawntimer2 = Random.Range(3.0f, 8.0f);
    }
    void spawngold()
    {
        Instantiate(gold[(Random.Range(0, gold.Length))], 
            new Vector3(player.transform.position.x + 30,
            Random.Range(2,5),0),Quaternion.identity);
        goldspawntimer = Random.Range(1.0f, 7.0f);
    }
    void spawnbackdrop()
    {
        Instantiate(backdrobs[(Random.Range(0, backdrobs.Length))],
            new Vector3(player.transform.position.x + 50, Random.Range(8, 30),
            Random.Range(8, 30)), Quaternion.Euler(0, 90, 0));
        backdrobspawntimer = Random.Range(8.0f, 20.0f);

    }

}
