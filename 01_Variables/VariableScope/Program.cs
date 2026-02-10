using System;

namespace VariableScope
{
    class Program
    {
        // Class-level variable (field) - accessible throughout the class
        static string globalMessage = "I'm accessible everywhere in this class";
        
        static void Main(string[] args)
        {
            // Local variable - only accessible within Main method
            int localNumber = 10;
            string localMessage = "I'm only accessible in Main";
            
            Console.WriteLine("=== Variable Scope Demo ===");
            Console.WriteLine($"Global message: {globalMessage}");
            Console.WriteLine($"Local number: {localNumber}");
            Console.WriteLine($"Local message: {localMessage}");
            
            // Block scope example
            if (true)
            {
                // Block-scoped variable - only accessible within this if block
                int blockNumber = 20;
                Console.WriteLine($"Block number: {blockNumber}");
                
                // Can access variables from outer scopes
                Console.WriteLine($"Accessing local from block: {localNumber}");
                Console.WriteLine($"Accessing global from block: {globalMessage}");
            }
            
            // This would cause an error - blockNumber is not accessible here
            // Console.WriteLine(blockNumber); // Uncomment to see the error
            
            // Call another method to demonstrate scope
            DemonstrateMethodScope();
        }
        
        static void DemonstrateMethodScope()
        {
            // This method can access the global variable
            Console.WriteLine($"From another method: {globalMessage}");
            
            // But cannot access local variables from Main
            // Console.WriteLine(localNumber); // This would cause an error
            
            // This method has its own local variables
            string methodMessage = "I'm local to DemonstrateMethodScope";
            Console.WriteLine($"Method message: {methodMessage}");
        }
    }
}