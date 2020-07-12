using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dayDisplay : MonoBehaviour
{
  public Text score;

  private int curDay = 0;

  // Start is called before the first frame update
  void Start()
  {
       curDay = GameObject.Find("Calendar").GetComponent<calendar>().day;

       score = GetComponent<Text>();
       score.text = "Day: " + curDay;
  }

  // Update is called once per frame
  void Update()
  {

  }
}
