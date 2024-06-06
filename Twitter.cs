using System;

class Program {
  public static void Main (string[] args) {
    //Promt user to enter their message
    Console.WriteLine ("Enter Your Message: ");
    //Read user input and store it in variable message
    string message = Console.ReadLine();
    //Call postMessage method with user input and store the result in the variable result
    string result = postMessage(message);
    //Output result to console
    Console.WriteLine(result);
    }

  //Method to check messsage length. If 140 words or less, return "Posted". Otherwise, return "Rejected. Message is too long"
  public static string postMessage(string message)
  {
    if (message.Length <= 140){
      return "Posted";
    }
  else {
    return "Rejected. Message too long";
    }
  }
}