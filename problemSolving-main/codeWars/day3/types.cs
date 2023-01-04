// typeof(int) 

// It takes the Type and returns the Type of the arguement.


// GetType()

// This method of array class in c# gets the Type of the current instance 

// Type tp =variable.GetType();

// Equals(String,String) Method

// It is a string method used to determine whether two String objects have the same value or not.

// Syntax : 

// bool string.Equals(string str1 , string str2)

// str1.Equals(s2);



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     string str1 = "this is a string";
     double db1 = 20;
     string str2 = "this is a string";
     double db2 = 20;
     
     Type tp = str1.GetType();
     if(tp.Equals(typeof(string)));
     Console.Write("yes");
     
    }
}







