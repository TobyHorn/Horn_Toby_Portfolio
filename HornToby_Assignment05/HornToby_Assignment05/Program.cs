using System;

namespace HornToby_Assignment05
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			/*
			 * Toby Horn
			 * Assignment 05: Building a Code Repository
			 * 3/16/16 - 3/20/16
			 * Project and Portfolio I: Development
			 * Section 02
			*/

			//Asking user to choose which function to run
			Console.WriteLine("Please choose the number of the exercise you wish to run.\r\n1: SwapName\r\n2: Backwards\r\n3: AgeConvert\r\n4: TempConvert");
			//Capturing user's response
			string functionString = Console.ReadLine();
			//Declare the variable to hold the converted value
			int function;
			//Verifying user gave a proper response
			while (!int.TryParse(functionString, out function) || (function < 1) || (function > 4))
			{
				//Tell user what went wrong
				Console.WriteLine("Oops! You input an incorrect value.\r\nPlease don't leave blank, tell me the number of the exercise you wish to do!\r\n1: Swap given first and last name\r\n2: Reverse given sentence\r\n3: Convert given age from years into smaller values\r\n4: Convert temperature given");
				//Store the user's new answer
				functionString = Console.ReadLine();
			}
			//Creating function to run when user chooses exercise 1
			if (function == 1)
			{
				//Ask user for first name
				Console.WriteLine("Please tell me your first name.");
				//Capture user's first name
				string firstName = Console.ReadLine();
				//Validate user didn't leave blank
				while (string.IsNullOrWhiteSpace(firstName) || firstName == ("0") || firstName == ("1") || firstName == ("2") || firstName == ("3") || firstName == ("4") || firstName == ("5") || firstName == ("6") || firstName == ("7") || firstName == ("8") || firstName == ("9"))
				{
					//Tell the user what went wrong
					Console.WriteLine("Please do not leave this blank or input a number. Enter your first name.");
					//Capture new response
					firstName = Console.ReadLine();
				}

				//Ask user for last name
				Console.WriteLine("Now please tell me your last name.");
				//Capture user's first name
				string lastName = Console.ReadLine();
				//Validate user didn't leave blank
				while (string.IsNullOrWhiteSpace(lastName) || lastName == ("0") || lastName == ("1") || lastName == ("2") || lastName == ("3") || lastName == ("4") || lastName == ("5") || lastName == ("6") || lastName == ("7") || lastName == ("8") || lastName == ("9"))
				{
					//Tell the user what went wrong
					Console.WriteLine("Please do not leave this blank or input a number. Enter your last name.");
					//Capture new response
					lastName = Console.ReadLine();
				}
				//Read back what was capture from user and let them know what we plan to do next.
				Console.WriteLine("You've entered " + firstName + " " + lastName + "!\r\nNow let's reverse that.");
				//Capturing returned values for exercise 1
				string nameSwap = swapName(firstName, lastName);
				//Outputting final string for exercise 1
				Console.WriteLine("Your name backwards is " + nameSwap + "!");






				//Creating function to run when user chooses exercise 2
			}
			else if (function == 2)
			{
				//Asking user for information needed
				Console.WriteLine("Please give me a sentence with at least 6 words in it.");
				//Verifying user didn't leave blank and input 6+ words without numbers
				while (true)
				{
					//Capture user's corrected input
					string sentence = Console.ReadLine();
					//Validating that 6+ words were input
					if (sentence.Split (' ').Length > 5)
					{
						//Advising user what their sentence they input was
						Console.WriteLine ("The sentence you entered is \"" + sentence + "\"\r\nNow let's reverse that!");
						//Capturing returned values for exercise 2
						string words = backwards (sentence);
						//Letting user know final outcome for exercise 2
						Console.WriteLine ("Your sentence backwards is \"" + words + "\"!");
						break;
					}
					//Telling user what went wrong
					else
					{
						Console.WriteLine("Please do not leave blank, input a sentence that is at least 6 words long without using numbers!");
					}
				}






				//Creating function to run when user chooses exercise 3
			}
			else if (function == 3)
			{
				//Asking user for name
				Console.WriteLine("Please tell me your name.");
				//Capturing name
				string Exercise3Name = Console.ReadLine();
				//Validating user didn't leave blank
				while (string.IsNullOrWhiteSpace(Exercise3Name))
				{
					//Telling user what went wrong
					Console.WriteLine("Please do not leave blank, tell me your name!");
					//Capture user's corrected input
					Exercise3Name = Console.ReadLine();
				}
				//Advising user of their name input & asking for age
				Console.WriteLine("Hello " + Exercise3Name + "!\r\nNow will you please tell me your age (in years)?");
				//Capturing user's age input
				string ageYearsString = Console.ReadLine();
				//Creating variable to capture converted string
				double ageYears;
				//Verifying user input a number
				while (!double.TryParse(ageYearsString, out ageYears) || (ageYears <= 0))
				{
					//Tell user what went wrong
					Console.WriteLine("Your input was invalid!\r\nPlease tell me your age (in years) using numbers only!");
					//Capturing new values
					ageYearsString = Console.ReadLine();
				}
				//Advising user of their inputs& telling them what is going to happen next
				Console.WriteLine("Your name is " + Exercise3Name + " and you are " + ageYears + " years old!\r\nLet's convert that to smaller values now!");
				//Capturing returned values for days for exercise 3
				double days = 365;
				//Capturing returned value for hours for exercise 3
				double hours = 8766;
				//Capturing returned value for minutes for exercise 3
				double minutes = 525960;
				//Capturing returned value for seconds for exercise 3
				double seconds = 31557600;
				//Reassigning values to ageDays
				double ageDays;
				//Reassigning values to ageHours
				double ageHours;
				//Reassigning values to ageMinutes
				double ageMinutes;
				//Reassigning values to ageSeconds
				double ageSeconds;
				//Returning new values
				ageConvert(ageYears, days, hours, minutes, seconds, out ageDays, out ageHours, out ageMinutes, out ageSeconds);
				//Giving user final outputs
				//Days
				Console.WriteLine(Exercise3Name + ",\r\nYou are " + ageDays + " days old!\r\n");
				//Hours
				Console.WriteLine(Exercise3Name + ",\r\nYou are " + ageHours + " hours old!\r\n");
				//Minutes
				Console.WriteLine(Exercise3Name + ",\r\nYou are " + ageMinutes + " minutes old!\r\n");
				//Seconds
				Console.WriteLine(Exercise3Name + ",\r\nYou are " + ageSeconds + " seconds old!\r\n");






				//Creating function for exercise 4
			}
			else if (function == 4)
			{
				//Prompt user for Fahrenheit temperature
				Console.WriteLine("Please tell me the temperature in Fahrenheit");
				//Store user input
				string fTempString = Console.ReadLine();
				//Creating double to store converted value
				double fTemp;
				//Verifying user input numbers and didn't leave blank
				while (!double.TryParse(fTempString, out fTemp) || (fTempString == "-0"))
				{
					//Letting user know what went wrong
					Console.WriteLine("Please make sure that you input the temperature in numbers only and didn't leave blank!");
					//Storing user's new input
					fTempString = Console.ReadLine();
				}
				//Telling user what they entered and advising them what we are going to do next.
				Console.WriteLine("The Temperature you entered was " + fTemp + "! Now let's convert that to Celsius!");
				//Storing returned values
				double cTempConverted;
				double fTempConverted;
				//Returning values from Fahrenheit to Celsius conversion
				tempConvert(fTemp, out cTempConverted, out fTempConverted);
				//Giving user Fahrenheit to Celsius conversion and advising them of the next step we are going to take.
				Console.WriteLine("Your temperature in Celsius is " + cTempConverted + "!\r\nNow let's convert a temperature from Celsius to Fahrenheit");
				//Asking user for a Celcius temperature
				Console.WriteLine("Please tell me a temperature in Celcius");
				//Store user's input
				string cTempString = Console.ReadLine();
				//Creating double to store coverted values
				double cTemp;
				//Verifying user input numbers and didn't leave blank
				while (!double.TryParse(cTempString, out cTemp) || (cTempString == "-0"))
				{
					//Letting user know what went wrong
					Console.WriteLine("Pleas make sure that you input the temperature in numbers only and didn't leave blank!");
					//Storing user's new input
					cTempString = Console.ReadLine();
				}
				//Telling user what they input and advising them of the next step.
				Console.WriteLine("The Temperature you entered was " + cTemp + " ! Now let's convert that to Fahrenheit!");
				//Returning values from Celsius to Fahrenheit
				tempConvert(fTemp, out cTempConverted, out fTempConverted);
				//Giving user Celsius to Fahrenheit conversion
				Console.WriteLine("Your temperature in Fahrenheit is " + fTemp + "!");
			}


			//Used to keep CMD open on Windows OS
			Console.ReadLine();
		}

		//Function for Exercise 3
		public static string swapName(string firstName, string lastName)
		{
			//Reversing input names
			string reversedName = lastName + " " + firstName;
			//Return data to main method
			return reversedName;
		}

		//Function for Exercise 2
		public static string backwards(string sentence)
		{
			//Split words in the sentence
			string backwards = "";
			string[] splitWords = sentence.Split(' ');
			//Reverse split words
			Array.Reverse(splitWords);
			//Remake the sentence
			backwards = string.Join(" ", splitWords);
			//Return data to main method
			return backwards;
		}

		//Function for Exercise 3
		public static void ageConvert (double ageYears, double days, double hours, double minutes, double seconds, out double ageDays, out double ageHours, out double ageMinutes, out double ageSeconds){
			//Converting Years to smaller values
			ageDays = ageYears * days;
			ageHours = ageYears * hours;
			ageMinutes = ageYears * minutes;
			ageSeconds = ageYears * seconds;
		}

		//Function for exercise 4
		public static void tempConvert (double fTemp, out double cTempConverted, out double fTempConverted){
			//Creating and calculating values for Fahrenheit to Celsius conversion
			cTempConverted = (fTemp - 32) * 5 / 9;
			//Creating and calculating values for Celsius to Fahrenheit conversion
			fTempConverted = cTempConverted * 9 /5 + 32;
		}
	}
}