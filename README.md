 ## OOP (OBJECT ORİENTED PROGRAMİNG)
 
<img src="https://talentgrid.io/wp-content/uploads/2021/09/procedural-programming-vs-object-oriented-programming.png" width="500" height="300">

 
OOP (Object-Oriented Programming) is supported by many programming languages today.It is a programming technique that shortens software development processes, makes them systematic and regular.It simplifies the maintenance, modification, and debugging of code.Develops software with an object-oriented approach.C# is a programming language that uses this programmatic approach.
 
 ## CLASS
 
 <img src="https://javatutorial.net/wp-content/uploads/2014/11/class-object-featured-image.png" width="400" height="200">
 
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

## INHERITANCE
It is one of the OOP techniques. In fact, the codes can be developed more systematically, orderly and quickly in this way. Inheritance is used to establish and create a hierarchical structure between classes. In the base class, there are methods with common properties that subclasses will take, so we do not repeat the code.A class can only inherit from a single class. It cannot inherit from more than one class at the same time. When we want to use multiple inheritance, we use interfaces.

I was creating my base class here.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/%C4%B0nheritance/Model/BaseEntity/BaseProduct.cs).
Here, I inherited my derived class.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/%C4%B0nheritance/Model/Entities/Dishwasher.cs).

## ABSTRACTİON
Abstraction means defining basic tasks and defining details to a class or method.The concept of abstraction is to isolate the operation inside the class from the outside, that is, to hide it.More specifically, abstraction is the process of hiding implementation details and only showing functionality to the user.We use Abstract class-members and interfaces for abstraction.

## ABSTRACT CLASS AND ABSTRACT MEMBER
Abstract members specified in a base class must be overridden by inheriting classes.We can think of this as a signed contract, that is, we set a rule.The bodies of abstract methods or properties are not created in the class, but overridden in the class that inherits from it.They cannot be specified with private access specifiers.Classes containing abstract elements must have an abstract class.We cannot create objects from abstract classes, but we can create reference points.We cannot create objects from abstract classes, but we can create reference points.
 
 This is how I created my abstract class.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/Abstraction/Buisness/Repositories/Astract/BaseRepository.cs).
 Here too I showed how it is implemented in derived classes.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/Abstraction/Buisness/Repositories/Concrate/BooksRepository.cs).
 
 ## INTERFACE
 It is one of the biggest members of sustainable software. Another member is Abstract classes. When these two are used together, I think we can write more sustainable software. Classes get their common features from an abstract base class, and when they get their capabilities from an interface, we create better systems.It has a prescriptive feature like abstract classes, but in interfaces the situation is slightly different. Members of abstract classes that do not have abstract specifiers do not have to be overridden in subclasses. In interfaces, all methods in the interface must be in the inheriting class.
 
 This is how I created my interface.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/Interface/Buisness/Repositories/Interface/BookInterface.cs).
 
  Here too I showed how it is implemented in derived classes.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/Interface/Buisness/Repositories/Concrate/BooksRepository.cs).
  
  I created a more comprehensive and understandable interface in my project.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/WarGame_Project/Business/Repositories/Interface/Interface1.cs).
 
 ## DIFFERENCES OF ABSTRACT CLASS AND INTERFACE
 
 <img src="http://damrakoc.com/blog/wp-content/uploads/2017/07/OpMyR.png" width="300" height="150" >
 
 -A class can extend only one abstract class. A class can inherit from more than one interface.
 
 -Methods in abstract classes can have bodies or are marked abstract and override in the inheriting class. In interfaces, the body is definitely not found. The body is created in the inherited subclass.
 
 -Abstract classes can inherit from interface, provided they implement the interface. Interface can only inherit from interface.
 
 -Elements in abstract classes can take any access specifier. Public, private, protected.. They are not determined in the interface, they are determined in its subclass.
 
-Abstract classes can contain constructors. Does not include interfaces.

-Abstract classes can contain static members. Does not include interfaces.

-Abstract classes do not allow multiple inheritance. This is provided by interfaces in multiple inheritance subclasses.

-In abstract classes, only abstract elements must be overridden in subclasses. Unsigned members do not have to be in subclasses. In this way, code clutter is avoided by keeping only the common features in the subclasses. But all elements in Interface must be implemented in subclass.

-Abstract classes can also be written by writing common properties.We can say that there is a relationship between IS and A. We use interfaces when we want to add capabilities to classes. This is also called the Can-do relationship.
 
## POLYMORPHİSM 
The use of properties or methods that perform different operations but have the same name is called polymorphism. Polymorphism means "containing many forms". It is used for methods that have different operations even though they have the same name.In fact, we have started to use this approach until now. We have applied polymorphism by overriding our methods in a base class according to their own situation in subclasses.

 I showed this in my example.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/Polymorphism/GEOMETRIC_SHAPES.cs).
 
 ## STRUCT
If our project does not require as complex operations as class and encapsulates the data to be kept, we may prefer a struct structure in such cases.Properties can be assigned values even before the object is created. They are of value type. The created data is kept in the ramin stack area. Values must be given by default.

 I showed this in my example.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/Struct/Form1.cs).

## WAR GAME PROJECT
My sample project that I made using Oop principles. I wanted to do it according to the game operation plan.

You can view my project here.[GitHub Pages](https://github.com/oguzhanKomcu/CSharp_OOP_Fundamentals/blob/master/Polymorphism/GEOMETRIC_SHAPES.cs).
