using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoveSphere : MonoBehaviour
{
    public float speed;
    private int count = 0;
    public TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        countText.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerInput;
        playerInput.x = Input.GetAxis("Horizontal");
        playerInput.y = Input.GetAxis("Vertical");
        transform.localPosition += new Vector3(playerInput.x * speed, 0f, playerInput.y * speed);

    }

    private void OnTriggerEnter(Collider other){
        count += 1;
        countText.text = count.ToString();
        other.gameObject. SetActive(false);
    }
    
}
