// See https://aka.ms/new-console-template for more information

using CompositeClassess;

Console.WriteLine("\n\tComposite Classes, ahhhhhhhh the togetherness\n");

//in using any class the reference is: instancename.itemname

//create the kennel
List<Dog> kennel = new(); //also allowed new List<Dog>();

//create variable to hold instance of Owner
Owner owner = null;

//create instance of owner
owner = new Owner("Lowand", "Behold", "780-456-7890");

//create variable to hold instance of Dog
Dog theDog;

//create and load instance for Dog using default constructor and assignment statements
theDog = new Dog();
theDog.Name = "No";
theDog.Age = 14.6;
theDog.Breed = "Mixed";
theDog.DogOwner = owner;


//add dog to kennel
kennel.Add(theDog);

//create instance of dog using greedy constructor and embedded owner
theDog = new Dog("Bad", 7.2, "Poodle", new Owner("Charity", "Kase", "596-432-5678"));
kennel.Add(theDog);

//create instance of dog using greedy constructor and embedded owner and adding to a List<T>
kennel.Add(new Dog("Attack", 1.2, "Beagle", new Owner("Ima", "Stew-Dent", "613-111-2222")));

//create dog using object initializer
//this is different than the greedy constructor
//  the greedy constructor passes the values as arguments for a set of parameters
//object initialization uses the properties and assign values to the properties
//object initialization does NEED a default constructor to exist.
//object initialization does NOT NEED a greedy constructor to exist.
//NOTE instead of the () after the class name, it uses { ..... }
//order is not important

theDog = new Dog
{
    Age=5.3,
    DogOwner = new Owner {
        FirstName = "Pat",
        LastName = "Downe",
        Phone = "403-554-6677"
    },
    Name = "Boo",
    Breed = "BloodHound"
};
kennel.Add(theDog);

//find a dog to add stays at the kennel
string dogName = "Bad";
theDog = kennel.FirstOrDefault(aninstance => aninstance.Name.Equals(dogName));
//check if found
if (theDog == null)
{
    Console.WriteLine($"Dog named {dogName} has never been registered at our kennel");
}
else
{
    Stay visit;
    visit = new Stay(DateTime.Parse("2015-02-18"), DateTime.Parse("2015-02-26"));
    theDog.Visits.Add(visit);
    theDog.Visits.Add(new Stay(DateTime.Parse("2016-02-16"), DateTime.Parse("2016-02-24")));
    theDog.Visits.Add(new Stay
    {
        DateIn = DateTime.Parse("2020-02-16"),
        DateOut =DateTime.Parse("2020-02-24")
    });
}

DisplayKennel(kennel);

static void DisplayKennel(List<Dog> kennel)
{
    Console.WriteLine($"\n\tCurrent Kennel contents ({kennel.Count} dogs)\n");
    foreach (Dog dog in kennel)
    {
        Console.WriteLine("{0,-25} {1,10} {2,-20}",
                "Name: " + dog.Name, "Age: " + dog.Age, "Breed: " + dog.Breed);
        Console.WriteLine("{0,-26} {1,20}",
                "Owner: " + dog.DogOwner.FullName, "Phone: " + dog.DogOwner.Phone +"\n");
        if (dog.Visits.Count > 0)
        {
            Console.WriteLine("{0,-10} {1,-10}", "Date In", "Date Out");
            //this loop could also be done using foreach
            for (int visit = 0; visit < dog.Visits.Count; visit++)
            {
                Console.WriteLine("{0,-10} {1,-10}",
                        dog.Visits[visit].DateIn.ToShortDateString(),
                        dog.Visits[visit].DateOut.ToShortDateString());
            }
        }
        else
        {
            Console.WriteLine("\n\tThere are no visits at this time for this dog.");
        }
        Console.WriteLine();
    }
}
