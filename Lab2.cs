/* Question 1: 
Write the program to print the factorial number of the value getting from user? */
Console.Write("Enter any value: ");
int value = Convert.ToInt32(Console.ReadLine());
if(Factorial(value) == 0){
    Console.WriteLine($"Factorial of {value} doesn't exist!");
}else{
    Console.WriteLine($"Factorial of {value} is {Factorial(value)}");
}

int Factorial(int num){
    if (num == 0){
        return 1;
    }else if(num > 0){
        return Factorial(num - 1) * num;
    }else{
        return 0;
    }
}


/* Question 2: 
Print the following patterns using loop with C# getting the number of line from user:
a.	
    5
    45
    345
    2345
    12345 */
Console.Write("Enter a number of lines: ");
int num = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < num; i++){
    for(int j = 0; j < (i + 1); j++){
        Console.Write(num - i + j);
    }
    Console.WriteLine();
}

/* b.	
    1
    12
    123
    1234
    12345
    123456 */
Console.Write("Enter a number of lines: ");
int num2 = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= num; i++){
    for(int j = 0; j < i; j++){
        Console.Write(1 + j);
    }
    Console.WriteLine();
}

/* c.	
    * * * * * 
     * * * * 
      * * * 
       * * 
        *  */
Console.Write("Enter a number of lines: ");
int num3 = Convert.ToInt32(Console.ReadLine());
for (int i = num3; i >= 1; i--){
    for (int j = 0; j < num3 - i; j++){
        Console.Write(" ");
    }
    for (int k = 0; k < i; k++){
        Console.Write("* ");
    }
    Console.WriteLine();
}

/* d.  
    *
   **
  ***
 ****
*****
 ****
  ***
   **
    * */
Console.Write("Enter a number of lines (odd): ");
int num4 = Convert.ToInt32(Console.ReadLine());
if(num4 % 2 == 0){
    Console.WriteLine("Number must be ODD!\nI'm adding 1 to it!");
    num4 += 1;
}
for (int i = 1; i <= num4; i++){
    if (i < num4 / 2 + 1){
        for (int j = 0; j < (num4 / 2 + 1) - i; j++){
            Console.Write(" ");
        }
        for (int k = 0; k < i; k++)
        {
            Console.Write("*");
        }
    }else{
        for (int j = num4 / 2; j > num4 - i; j--){
            Console.Write(" ");
        }
        for (int k = 0; k <= num4 - i; k++){
            Console.Write("*");
        }
    }
    Console.WriteLine();
}

/* e.
* * * * * 
 * * * * 
  * * * 
   * * 
    * 
    * 
   * * 
  * * * 
 * * * * 
* * * * *  */
Console.Write("Enter a number of lines (equal): ");
int num5 = Convert.ToInt32(Console.ReadLine());
if(num5 % 2 != 0){
    Console.WriteLine("Number must be equal!\nI'm adding 1 to it!");
    num5 += 1;
}
num5 /= 2;
for (int i = num5; i >= 1; i--){
    for (int j = 0; j < num5 - i; j++){
        Console.Write(" ");
    }
    for (int k = 0; k < i; k++){
        Console.Write("* ");
    }
    Console.WriteLine();
}
for (int i = 1; i <= num5; i++){
    for (int j = 0; j < num5 - i; j++){
        Console.Write(" ");
    }
    for (int k = 0; k < i; k++){
        Console.Write("* ");
    }
    Console.WriteLine();
}

/* f. 
1 
2 3 
4 5 6 
7 8 9 10 
11 12 13 14 15  */
Console.Write("Enter a number of lines: ");
int num6 = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (int i = 0; i < num6; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(count++ + " ");
    }
    Console.WriteLine();
}

/* g. (it should be odd number)
   1
  212
 32123
4321234
 32123
  212
   1 */
Console.Write("Enter a number of lines (odd): ");
int num7 = Convert.ToInt32(Console.ReadLine());
if(num7 % 2 == 0){
    Console.WriteLine("Number must be ODD!\nI'm adding 1 to it!");
    num7 += 1;
}
for (int i = 1; i <= num7 / 2 + 1; i++){
    for (int j = 0; j < num7 / 2 + 1 - i; j++){
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write(i - j);
    }
    for (int j = 0; j < i - 1; j++)
    {
        Console.Write(j + 2);
    }
    Console.WriteLine();
}
for (int i = num7 / 2; i >= 0; i--){
    for (int j = 0; j < num7 / 2 + 1 - i; j++){
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write(i - j);
    }
    for (int j = 0; j < i - 1; j++)
    {
        Console.Write(j + 2);
    }
    Console.WriteLine();
}

/* h. (it should be odd number)
    * 
   *** 
  *****
 *******
*********
 *******
  *****
   ***
    *  */
Console.Write("Enter a number of lines (odd): ");
int num8 = Convert.ToInt32(Console.ReadLine());
if(num8 % 2 == 0){
    Console.WriteLine("Number must be ODD!\nI'm adding 1 to it!");
    num8 += 1;
}
for (int i = 1; i <= num8 / 2 + 1; i++){
    for (int j = 0; j < num8 / 2 + 1 - i; j++){
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < i - 1; j++)
    {
        Console.Write('*');
    }
    Console.WriteLine();
}
for (int i = num8 / 2; i >= 0; i--){
    for (int j = 0; j < num8 / 2 + 1 - i; j++){
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < i - 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


/* Questions 3:
Write a program according to the following specification:
1)	Display a message asking the user to enter a student id between 0 and 9999999.
2)	Get the user input.
3)	Verify the student id. If the user input is bigger than 9999999 or less than 0, then
display an error message, and exit the program.
4)	Display the user input.
5)	Display a message asking the user to enter a password with the length between 6
and 20.
6)	Get the user input.
7)	Verify the password. If the password length is not between 6 and 20, exit the
program.
8)	Display the user input.
9)	Display a message asking the user to enter a string.
10)	Display the user input.
11)	Change the string to upper case.
12)	Display the new string.
13)	 Exit the program.
 */
Console.Write("Enter a student id between 0 and 9999999: ");
int studentID = Convert.ToInt32(Console.ReadLine());
if(studentID > 9999999 || studentID < 0){
    Console.WriteLine("Invalid input!\nExiting program...");
    Environment.Exit(0);
}else{
    Console.WriteLine($"Your Student ID is: {studentID}");
    Console.Write("Enter a password with the length between 6 and 20: ");
    string password = Console.ReadLine() ?? string.Empty;
    if(password.Length < 6 || password.Length > 20){
        Console.WriteLine("Incorrect length!\nExiting program...");
        Environment.Exit(0);
    }else{
        Console.WriteLine($"Your password is: {password}");
        Console.Write("Enter a string: ");
        string str = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Your string: {str}");
        Console.WriteLine($"New string: {str.ToUpper()}");
        Environment.Exit(0);
    }
}


/* Questions 4:
Write a C# code to sum all odd numbers from 15 to 100 using for loop then display the total sum. */
int sum = 0;
for(int i = 15; i < 100; i++){
    if(i % 2 != 0){
        sum += i;
    }
}
Console.WriteLine($"The sum of all odd numbers from 15 to 100 is {sum}");


/* Questions 5:
Write a program in C# Sharp to display the cube of the number up to given an integer. 
Test Data :
Input number of terms : 5 
Expected Output : 
Number is : 1 and cube of the 1 is :1 
Number is : 2 and cube of the 2 is :8 
Number is : 3 and cube of the 3 is :27 
Number is : 4 and cube of the 4 is :64 
Number is : 5 and cube of the 5 is :125 */
Console.Write("Input number of terms: ");
int num9 = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= num9; i++){
    Console.WriteLine($"Number is: {i} and cube of the {i} is: {Math.Pow(i, 3)}");
}


/* Questions 6:
Write a program in C# Sharp to find the sum of the series 1 + 11 + 111 + 1111 + .. n terms.  
Test Data : 
Input the number of terms : 5 
Expected Output :
1 + 11 + 111 + 1111 + 11111 + 
The Sum is : 12345 */
string value2 = "";
double sum2 = 0;
Console.Write("Input number of terms: ");
int num10 = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num10; i++)
    {
        value2 = "";
        for (int j = 0; j < i; j++)
        {
            value2 += "1";            
        }
        Console.Write(value2);
        sum2 += Convert.ToDouble(value2);
        if (i < num10)
            Console.Write(" + ");    
}
Console.WriteLine($"\nThe Sum is : {sum2}");


/* Questions 7:
Write a program in C# Sharp to read n numbers from keyboard and find their sum and average */
double num11 = 0;
double sum3 = 0;
double avg = 0;
int quantity = 0;

do{
    Console.Write("Enter a number ('0' - to exit): ");
    num11 = Convert.ToDouble(Console.ReadLine());
    sum3 += num11;
    avg = sum3 / quantity;
    if (num11 != 0){
        quantity++;
    }
} while (num11 != 0);
Console.WriteLine($"The sum is {sum3} and the avg {avg}");


/* Questions 8:
Write a program in C# Sharp to accept a grade and declare the equivalent description :  
Grade	Description
E	Excellent
V	Very Good 
G	Good
A	Average
F	Fail
Test Data : 
Input the grade :a
Expected Output :
You have chosen : Average */
Console.Write("Input the grade : ");
string grade = Console.ReadLine();
switch (grade.ToUpper())
{
    case "E":
        Console.WriteLine("You have chosen: Excellent");
        break;
    case "V":
        Console.WriteLine("You have chosen: Very Good");
        break;
    case "G":
        Console.WriteLine("You have chosen: Good");
        break;
    case "A":
        Console.WriteLine("You have chosen: Average");
        break;
    case "F":
        Console.WriteLine("You have chosen: Fail");
        break;
    default:
        Console.WriteLine("This grade doesn't exist!");
        break;
}


/* Questions 9:
Write a method that print 10 by 10 multiplication table. Make it readable  */
for(int i = 1; i <= 10; i++){
    for(int y = 0; y < 10; y++){
        int doubleDigitsNumber = i + y * i;
        if((i + y * i) > 9){
            Console.Write(doubleDigitsNumber + " ");
        }else{
            Console.Write($" {doubleDigitsNumber} ");
    }
    }
    Console.WriteLine();
}


/* Questions 10:
Write a program in C# Sharp to display the multiplication table of a given integer. 
Test Data :
Input the number (Table to be calculated) : 15 
Expected Output : 
15 X 1 = 15 
...
... 
15 X 10 = 150 */
Console.Write("Input the number (Table to be calculated): ");
int input = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= 10; i++){
    Console.WriteLine($"{input} x {i} = {input * i}");
}