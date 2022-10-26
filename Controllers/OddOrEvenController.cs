// Amardeep Mann
// 10-26-22
// Odd Or Even - Endpoint
// Pull in variables via URL for our Odd Or Even API project
// Peer reviewed by

using Microsoft.AspNetCore.Mvc;

namespace MannAOddOrEven.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    [HttpGet]

    public string OddOrEvenDefault() {
    int num = 10;
    string type;
    if (num % 2 == 0) {
      type = "even";
    } else {
      type = "odd";
    }
    return $"{num} is an {type} number.";
  }

    [HttpGet]
    [Route("{num}")]

    public string OddOrEven(string num) {
      int convertNum;
      bool isNumValid = Int32.TryParse(num, out convertNum);
      string result = "Please enter a valid integer.";
      string type = "";
      if (isNumValid)
      {
        if (convertNum % 2 == 0) {
          type = "even";
        } else {
          type = "odd";
        }
        result = $"{num} is an {type} number.";
      }
      return result;
    }
}