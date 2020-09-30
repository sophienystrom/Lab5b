using System;

class MainClass {
  public static void Main (string[] args) {
   
  double counter = 1;
  double total = 0;
  Console.WriteLine("Enter the number of cars");
  double cars = Convert.ToDouble(Console.ReadLine());

  while (counter <= cars) 
  {
  Console.WriteLine ("Enter the distance covered by car #" + counter);
  double distance = Convert.ToDouble (Console.ReadLine());
  Console.WriteLine ("Enter the time taken by car #" + counter);
  double time = Convert.ToDouble (Console.ReadLine());
  var speed = distance/time;
  Console.WriteLine("The speed of car #" + counter + " is " + speed + " miles per hour");
  total = total + speed;
  counter++;
  }
 
 var average = total/7;
 Console.WriteLine ("The average speed of the cars is " + average + " miles per hour");
  
  }
}