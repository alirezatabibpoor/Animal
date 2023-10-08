using System.Runtime.InteropServices;
using Animal;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter an animal name:");
        Console.WriteLine("information : name , category , food , place , movment ");
        string animal = Console.ReadLine();
       cat c = new cat();
        dog d = new dog();
        horse h = new horse();
        cow co = new cow(); 
        roster_hen rh = new roster_hen();
        lion l = new lion();
       
        switch(animal)
        {
            case "cat":
                Console.WriteLine(c.describe());
                break;
            case "dog":
                Console.WriteLine(d.describe());
                break;
            case "horse":
                Console.WriteLine(h.describe());  
                break;
            case "cow":
                Console.WriteLine(co.describe());
                break;
            case "roster&hen":
                Console.WriteLine(rh.describe());
                break;
            case "lion":
                Console.WriteLine(l.describe());    
                break;
            default:
                Console.WriteLine("sorry we dont have information about this !!");
                break;



        }
        Console.ReadLine(); 
        
       
    }
    
 
}

