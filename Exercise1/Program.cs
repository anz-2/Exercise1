// See https://aka.ms/new-console-template for more information

/*1.შეადგინეთ სამკუთხედის კლასი, რომელშიც განსაზღვრულია ერთი და იგივე
სახელის მქონე 2 მეთოდი. პირველ მეთოდს 2 მთელრიცხვა პარამეტრი აქვს:
სამკუთხედის სიმაღლე და ფუძე და აბრუნებს  სამკუთხედის
ფართობს. მეორე მეთოდს 3 მთელრიცხვა პარამეტრი აქვს: სამკუთხედის
გვერდები და აბრუნებს სამკუთხედის პერიმეტრს. Program.cs ში 
შექმენით შესაბამისი ობიექტი და გამოიძახეთ ორივე მეთოდი. 
შექმენით ორი მეთოდი, რომელიც აბრუნებებს ორი რიცხვის ნამრავლს, 
პირველ მეთოდს პარამეტრებად გადაეცემა int ტიპის რიცხვები, 
ხოლო მეორე მეოთდს double ტიპის პარამეტრები
3.შექმენით Shape კლასი და განსაზღვრეთ მეთოდი რომელიც აბრუნებს 
მართკუთხედის პერიმეტრს, შექმენით Triangle კლასი რომელიც არის  
Shape კლასის შვილობილი კლასი, და პირველ გვერდსა და მეორე გვერდს 
მემკვიდრეობით იღებს მშობელი კლასიდან, გადაფარეთ მშობელი კლასის მეთოდი
და დააბრუნეთ სამკუთხედის პერიმეტრი.
*/

using Exercise1;

Triangle1 triangle1 = new Triangle1();
Console.WriteLine(triangle1.GetArea(7, 4));
Console.WriteLine(triangle1.GetPerimeter(2,5,7));


Multiply multiply = new Multiply();

int integer = (int)multiply.MultiplyNumbers(2, 6);
Console.WriteLine(integer);

double decimall = multiply.MultiplyNumbers(2.4, 43.5);
Console.WriteLine(decimall);

Shape shape = new Shape();
int rectanglePerimeter = shape.CalculatePerimeter(2, 4);
Console.WriteLine(rectanglePerimeter);

Triangle triangle = new Triangle();
int trianglePerimeter = triangle.CalculatePerimeter(34, 45);
Console.WriteLine(trianglePerimeter);