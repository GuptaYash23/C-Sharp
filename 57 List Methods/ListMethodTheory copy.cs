/* Additional methods of the List

List<T> class can accept null as a valid value for reference types and it also allows duplicate elements

For example:

---------------------------------------------------------------------------------------
List<string> names = new List<string>(); 
names.Add("Yash");
names.Add("Rahul");
names.Add("Shubham");
names.Add("Varun");
names.Add(null);
names.Add("Yash");

foreach(string item in names)
{
  Console.WriteLine(item);
}
---------------------------------------------------------------------------------------

Output:

---------------------------------------------------------------------------------------
Yash
Rahul
Shubham
Varun

Yash
---------------------------------------------------------------------------------------

List<T> class is not sorted by default and elements are accessed by zero-based index

Example:

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(22);
num.Add(55);
num.Add(11);
num.Add(44);
num.Add(33);

foreach(int number in num)
{
  Console.WriteLine(number);      // 22 55 11 44 33
}

num.Sort();   // Sorting List

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 44 55
}

---------------------------------------------------------------------------------------

Methods of List<T>

- Add() - Adds an object to the end of the List<T>

- AddRange() - Adds the element of the specified collection to the end of the List<T> (It takes the same datatype of the list)

For example:

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(22);
num.Add(55);
num.Add(11);
num.Add(44);
num.Add(33);

foreach(int number in num)
{
  Console.WriteLine(number);      // 22 55 11 44 33
}

num.AddRange(num);   // Using Add Range

foreach(int number in num)
{
  Console.WriteLine(number);      // 22 55 11 44 33 22 55 11 44 33
}
---------------------------------------------------------------------------------------

- Insert() - Inserts an element into the List<T> at the specified index

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(33);
num.Add(44);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 33 44 55 66
}

num.Insert(22,1);   // Using Insert to Add 22 to 1 index

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 44 55 66
}
---------------------------------------------------------------------------------------

- InsertRange() - Inserts the elements of a collection in to the List<T> at the specified index

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(33);
num.Add(44);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 33 44 55 66
}

num.InsertRange(1,num);   // Using Insert to Add num from index 1 

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 11 33 44 55 66 33 44 55 66
}
---------------------------------------------------------------------------------------

- Remove() - Removes the first occurrence of a specific object from the List<T>

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(22);
num.Add(33);
num.Add(22);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 22 55 66
}

num.Remove(22);          // Removes the first entry of 22 

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 33 22 55 66
}
---------------------------------------------------------------------------------------

- RemoveAt() - Removes the element at the specified index of the List<T>

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(22);
num.Add(33);
num.Add(22);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 22 55 66
}

num.RemoveAt(1);          // Removes the entry at 1 index 

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 33 22 55 66
}
---------------------------------------------------------------------------------------

- RemoveRange() - Removes a range of elements from the List<T> [RemovesRange(index,number of elements)]

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(22);
num.Add(33);
num.Add(22);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 22 55 66
}

num.RemoveRange(2,3);          // Removes 3 elements starting from 2nd index

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 66
}
---------------------------------------------------------------------------------------

- RemoveAll() - Removes all the elements that match the conditions defined by the specific predicate(lambda expression)

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(22);
num.Add(33);
num.Add(22);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 22 55 66
}

num.RemoveAll(number => number>30 );    // Removes all the numbers greater than 30

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 66
}
---------------------------------------------------------------------------------------

- .Contains() - Determines whether an element is in the List<T>

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(22);
num.Add(33);
num.Add(22);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 22 55 66
}

Console.WriteLine(num.Contains(11));     // True
Console.WriteLine(num.Contains(100));    // False

int numberToFind = 22;
Console.WriteLine(num.Exists(n => n == numberToFind));
---------------------------------------------------------------------------------------

.Reverse() - Reverses the order of the elements in the List<T> or a portion of it

.Sort() - Sorts the order of the elements in the List<T>

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(22);
num.Add(33);
num.Add(44);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 44 55 66
}

num.Reverse();

foreach(int number in num)
{
  Console.WriteLine(number);      // 66 55 44 33 22 11
}
---------------------------------------------------------------------------------------

- .IndexOf() - Returns zero-based index of the first occurrence of a value in the List<T>

- .IndexOf(element, startindex) -  Returns the index of a particular element starting from the startindex

- .LastIndexOf() - Returns the zero-based index of the last occurrence of a value in the List<T>

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(22);
num.Add(33);
num.Add(44);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 44 55 66
}

Console.WriteLine(num.IndexOf(33));   // 2
Console.WriteLine(num.IndexOf(100));  // -1
---------------------------------------------------------------------------------------

- .Clear() - Removes all elements from the List<T>

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(22);
num.Add(33);
num.Add(44);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 44 55 66
}

num.Clear();

foreach(int number in num)
{
  Console.WriteLine(number);      // 
}
---------------------------------------------------------------------------------------

- .Find() - Searches for an element that matches the conditions defined by the specific predicate, and returns the first occurrence within the entire List<T>.

- .FindLast() - Searches for an element that matches the conditions defined by the specified predicate and returns the last occurrence within the entire List<T>

- .FindAll() - Retrieves all the elements that match the conditions defined by the specified predicate.

- .FindIndex() - Searches for an element that matches the conditions defined by a specified predicate, and returns the zero-based index of the first occurrence within the List<T> or a portion of it. This method returns -1 if an item that matches the condition is not found

- .FindLastIndex() - Searches for an element that matches the conditions defined by a specified predicate, and returns the zero-based index of the last occurrence within the List<T> or a portion of it.

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(22);
num.Add(33);
num.Add(44);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 44 55 66
}

Console.WriteLine(num.Find(number => number>30));  // 33

Console.WriteLine(num.FindLast(number => number>30));  // 66

List<int> temp = num.FindAll(number => number>30); 

foreach(int item in temp)
{
  Console.WriteLine(item);      // 33 44 55 66
}

Console.WriteLine(num.FindIndex(number => number==33));  // 2

Console.WriteLine(num.FindLastIndex(number => number>=33));  // 5
---------------------------------------------------------------------------------------

- .ToArray() - Copies the elements of the List<T> to a new array(fixed length)

- .ToList() - Copies the elements of the array to a new List (System.Linq library required)

---------------------------------------------------------------------------------------
List<int> num = new List<int>();

num.Add(11);
num.Add(22);
num.Add(33);
num.Add(44);
num.Add(55);
num.Add(66);

foreach(int number in num)
{
  Console.WriteLine(number);      // 11 22 33 44 55 66
}

int[] numarray = num.ToArray();

foreach(int number in numarray)
{
  Console.WriteLine(number);      // 11 22 33 44 55 66
}

List<int> newlist = numarray.ToList();

foreach(int number in newlist)
{
 Console.WriteLine(number);      // 11 22 33 44 55 66
}
---------------------------------------------------------------------------------------
*/