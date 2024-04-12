using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class Spawner : MonoBehaviour
{
    public GameObject blockPrefab;
    public GameObject block;
    public GameObject squarePrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TestSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator TestSpawn()
    {
        yield return new WaitForSeconds(1f);
        var ctr = blockPrefab.GetComponent<Block>();
        int index = Random.Range(0, ctr.blocks.Count); // Tạo số nguyên từ 1 đến 9
        Debug.Log(ctr.blocks[index].name + ctr.blocks[index].transform.localPosition);
        var tempSquare = Instantiate(squarePrefab);
        tempSquare.transform.SetParent(block.transform);
        //tempSquare.GetComponent<RectTransform>().position = block.GetComponent<RectTransform>().position;
        tempSquare.GetComponent<RectTransform>().localScale = Vector3.one;
        transform.transform.localPosition = ctr.blocks[index].transform.localPosition;
    }
}
