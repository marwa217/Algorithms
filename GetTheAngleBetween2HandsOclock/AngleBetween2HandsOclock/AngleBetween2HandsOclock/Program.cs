// See https://aka.ms/new-console-template for more information
/*
 * this Sol Solve The angle between 2 hands Oclock
 * 
 * inputs: user must insert 2 inputs :-
 * 1- for hours
 * 2- for minutes which the clock hand
 * *** Notes ***
 * we consider the clock is circle so one hour degree : 360/12= 30
 * so 1 Minutes degree : 360/ 60 = 6 because the Oclock contains 12 hour between 2 numbers = 5 min
 * so number of total mins in all Oclock = 12 *5 =60 
 * when hours = 12 
 */

Console.WriteLine("please enter the time in hours");
int.TryParse(Console.ReadLine(), out int h) ;

Console.WriteLine("please enter the time in minutes");
int.TryParse(Console.ReadLine(), out int mins);

int degreeInHour = 360 / 12;
int degreeInMin = 360 / 60; //degreeInHour/ 5

var hour = (h == 12)? 0: h;

var angle =  (degreeInMin * mins) - (degreeInHour * hour);
angle = (angle > 0) ? angle : angle * (-1);
Console.WriteLine("The angle between {0} and {1}  is = {2}", h,mins,angle);

Console.ReadKey();
