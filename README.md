 
 ## OOP (OBJECT ORİENTED PROGRAMİNG)
 
OOP (Object-Oriented Programming) is supported by many programming languages today.It is a programming technique that shortens software development processes, makes them systematic and regular.It simplifies the maintenance, modification, and debugging of code.Develops software with an object-oriented approach.C# is a programming language that uses this programmatic approach.
 
 ## CLASS
 
 The object phenomenon in OOP is almost the same as in everyday life.Objects consist of a main class and are separated according to their properties.For example, a bicycle is an object. It has certain properties. By defining these properties in a bike class, we can produce many bike objects.In C#, we actually work with many embedded classes. For example, Random, button , Texbox etc.You can learn about the example and operation of the Oop "class" topic here.
 
 You can check this page [GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/CLASS/Bike.cs).
 
 ## CONSTRUCTOR
 
 It is a method that works by ourselves or by default when creating the class. When an object is created, the constructor is called automatically.It does not return a value.It does the situations we want and finishes it when the class is created.You can find examples and more information on the subject in the examples I made.
 
 You can see how the constructor method is created here. [GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/CONSTRUCTOR/Television.cs).
 
 You can see how it works when we create an object here. [GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/CONSTRUCTOR/ConstructorExample.cs).

 ## PROPERTY
It is a structure that takes value through the get and set methods when defining a member of the class. While calling the value on it with get, we can assign a value to it with set.

You can see my property example here. [GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/WarGame_Project/Model/Entities/Concrete/User.cs).

 ## ENCAPSULATİON
Encapsulation is the restricted and controlled opening of my areas that are closed to external access, using the get and set methods of the property.Encapsulation can be used, for example, so that even those working in a bank cannot see all the information of the customers. For example, we can close the data entry with the get method and only show the  data to the user.

You can see my example of encapsulation here.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/WarGame_Project/Model/Entities/Concrete/User.cs).

## STATİC CLASS AND STATİC MEMBER
Static elements are class members that I can call directly with the class name without generating any objects from the class.(classname+"."+"StatikMemberName")
Static elements keep the value assigned to them last as long as the application is running.Static members and stratic classes are created directly in the ramin heap region when the program is started. Thus, we can access and process faster.Static members cannot contain non-static class elements.
Non-static methods or elements cannot be created within static classes. Logically, static classes cannot access a non-static element because it resides directly in the ramin heap region and cannot access an uncreated class element either.Defining classes as static is not a requirement, it's just an approach that improves readability.

You can see how it was created here.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/Static_Class/Unit_converter.cs).

An example for usage[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/Static_Class/Static_Class_Example.cs).

## CONST
It is an expression that we use when we want to use the value of a variable in a way that cannot be changed as a constant.Its value is assigned in the row where it is defined.For example, if we are using constant values of Pi in our program, it will be very useful to use const. In this way, less memory space will be used.

I've shown a use case here.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/Static_Class/Unit_converter.cs).

