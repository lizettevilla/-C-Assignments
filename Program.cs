// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Create an integer array with the values 0 through 9 inside.

int[] intArray = new int[] {0,1,2,3,4,5,6,7,8,9};

// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".

string[] namesArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};

// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true.

bool[] boolArray = new bool[10];
for (int i= 0; i < boolArray.Length; i++) {
    if(i % 2 == 0)
    {
        boolArray[i] = true;
    } else {
        boolArray[i] = false;
    }
 }

// Create a string List of ice cream flavors that holds at least 5 different flavors. 

List<string> Flavors = new List<string>();
Flavors.Add("Vanilla");
Flavors.Add("Chocolate");
Flavors.Add("Strawberry");
Flavors.Add("Oreo");
Flavors.Add("Mint Chocolate Chip");

// Output the length of the List after you added the flavors.

Console.WriteLine($"Length of Flavors List: {Flavors.Count}");


// Output the third flavor in the List.

Console.WriteLine($"Third Flavor in List: {Flavors[2]}");


// Now remove the third flavor using its index location.

Flavors.RemoveAt(2);


// Output the length of the List again. It should now be one fewer.

Console.WriteLine($"Length of Flavors List: {Flavors.Count}");


// Create a dictionary that will store string keys and string values.

Dictionary<string, string> MyDictionary = new Dictionary<string, string>();

// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
Random rand = new Random();
for(int i = 0; i < namesArray.Length; i++) {

MyDictionary.Add(namesArray[i], Flavors[rand.Next(0,Flavors.Count)]);
}

// Loop through the dictionary and print out each user's name and their associated ice cream flavor.
foreach(KeyValuePair<string, string> entry in MyDictionary) {
    Console.WriteLine($"{entry.Key} - {entry-Value}");
}