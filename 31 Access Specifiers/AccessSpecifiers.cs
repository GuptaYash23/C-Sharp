using System;

namespace AccessSpecifierExample
{
    // Class with different access specifiers
    public class BaseClass
    {
        // Public member - Accessible from anywhere
        public string PublicField = "Public Field";

        // Private member - Accessible only within BaseClass
        private string PrivateField = "Private Field";

        // Protected member - Accessible within BaseClass and derived classes
        protected string ProtectedField = "Protected Field";

        // Internal member - Accessible within the same assembly
        internal string InternalField = "Internal Field";

        // Protected internal member - Accessible within the same assembly and derived classes in any assembly
        protected internal string ProtectedInternalField = "Protected Internal Field";

        // Private protected member - Accessible within BaseClass and derived classes in the same assembly
        private protected string PrivateProtectedField = "Private Protected Field";

        public void ShowBaseClassFields()
        {
            Console.WriteLine(PublicField);
            Console.WriteLine(PrivateField);
            Console.WriteLine(ProtectedField);
            Console.WriteLine(InternalField);
            Console.WriteLine(ProtectedInternalField);
            Console.WriteLine(PrivateProtectedField);
        }
    }

    // Derived class to show accessibility of protected, protected internal, and private protected members
    public class DerivedClass : BaseClass
    {
        public void ShowDerivedClassFields()
        {
            // Accessible because PublicField is public
            Console.WriteLine(PublicField);

            // Not accessible because PrivateField is private in BaseClass
            // Console.WriteLine(PrivateField); // This would cause a compile-time error

            // Accessible because ProtectedField is protected and this is a derived class
            Console.WriteLine(ProtectedField);

            // Accessible because InternalField is internal and we're in the same assembly
            Console.WriteLine(InternalField);

            // Accessible because ProtectedInternalField is protected internal
            Console.WriteLine(ProtectedInternalField);

            // Accessible because PrivateProtectedField is private protected and we're in the same assembly
            Console.WriteLine(PrivateProtectedField);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            DerivedClass derivedClass = new DerivedClass();

            Console.WriteLine("Accessing fields from BaseClass instance:");
            Console.WriteLine(baseClass.PublicField); // Accessible

            // Not accessible because PrivateField is private
            // Console.WriteLine(baseClass.PrivateField); // Compile-time error

            // Not accessible because ProtectedField is protected
            // Console.WriteLine(baseClass.ProtectedField); // Compile-time error

            Console.WriteLine(baseClass.InternalField); // Accessible because it's in the same assembly

            Console.WriteLine(baseClass.ProtectedInternalField); // Accessible within the same assembly

            // Not accessible because PrivateProtectedField is private protected
            // Console.WriteLine(baseClass.PrivateProtectedField); // Compile-time error

            Console.WriteLine("\nAccessing fields from DerivedClass instance:");
            derivedClass.ShowDerivedClassFields();
        }
    }
}
