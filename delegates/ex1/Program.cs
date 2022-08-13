using ex;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

class ex1
{
    static void MessageReceived(string message)
    {
        Console.WriteLine(message);
    }

    static void Main( string[] args)
    {
        
        Jedi r = new Jedi("oussa", 56);

        // initialization with valid values
        Console.WriteLine("My name is " + r.name + " /// " + "My midichloriancount is " + r.midiChlorianCount);

        // setting the name to oussaaee
        r.name = "oussaaee";
       
       // this will throw exception
       // r.midiChlorianCount = 0;

        // setting the int part to 22
        r.midiChlorianCount = 22;

        // checking my work
        Console.WriteLine("My name is " + r.name + " /// " + "My midichloriancount is " + r.midiChlorianCount  );

        // serialization part you can see in jedi.txt that the name is essmi and the midiChlorianCount is numero( in my native language)
        XmlSerializer serializer = new XmlSerializer(typeof(Jedi));
        FileStream stream = new FileStream("Jedi.txt", FileMode.Create);
        serializer.Serialize(stream, r);
        stream.Close();


        // part copied from the lab exercise
        XmlSerializer ser = new XmlSerializer(typeof(Jedi));
        FileStream fs = new FileStream("jedi.txt", FileMode.Open);
        Jedi clone = (Jedi)ser.Deserialize(fs);
        fs.Close();


        // you can check here that deserialization was done succefully
        Console.WriteLine("My name is " + clone.name + " /// " + "My midichloriancount is " + clone.midiChlorianCount);

        Console.WriteLine("output for the exercise 3 ");
        // Create the council
        JediCouncil council = new JediCouncil();
        council.CouncilChanged += MessageReceived;
        // Add two members to the council
        Jedi jedi1 = new Jedi();
        jedi1.name = "Yoda";
        jedi1.midiChlorianCount = 15000;
        council.Add(jedi1);
        Jedi jedi2 = new Jedi();
        jedi2.name = "Anakin Skywalker";
        jedi2.midiChlorianCount = 20000;
        council.Add(jedi2);

        council.Remove();
        council.Remove();

        Console.WriteLine("output for the exercise 4/// I added the previous two objects because the council is empty after ex3 ");
        council.Add(jedi1);
        council.Add(jedi2);

        List<Jedi> ts = council.GetStrongestMebers();

        foreach(Jedi j in ts)
        {
            Console.WriteLine(j);
        }
    }

}
