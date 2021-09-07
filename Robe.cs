using System;
using System.Collections.Generic;

namespace Quest
{
    public class Robe
    {
        public List<string> Colors = new List<string>();
        public int robeLength { get; set; } 
    }
}


// Add a new immutable property to the Adventurer class called ColorfulRobe. The type of this property should be Robe.
// Add a new constructor parameter to the Adventurer class to accept a Robe and to set the ColorfulRobe property.
// Add a new method to the Adventurer class called GetDescription. This method should return a string that contains the adventurer's name and a description of their robe.
// In Program.cs create a new instance of the Robe class and set its properties.
// Pass the new Robe into the constructor of the Adventurer.
// Before the adventurer starts their challenge, call the GetDescription method and print the results to the console.