﻿// See https://aka.ms/new-console-template for more information
for(int i = 1; i <= 255; i++ ){
    Console.WriteLine(i);
}


for(int i = 1; i <= 100; i++ ){
    if ( i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else if( i % 3 == 0){
        Console.WriteLine( "Fizz");
    }else if ( i % 5 == 0){
        Console.WriteLine("Buzz");
    } 
}