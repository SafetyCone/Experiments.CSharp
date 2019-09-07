using System;

using ExaminingCSharp.Lib;


namespace ExaminingCSharp
{
    public static class Demonstrations
    {
        public static void SubMain()
        {
            //Demonstrations.ShowErrorSiteForDerivedClassStaticNewField();
        }

        /// <summary>
        /// Shows that an error occurs when trying the access the hidden instance-level base-class property of a derived-class instance that has the same name as a static-level field of the derived-class.
        /// 
        /// A frequently encountered scenario is wanting a derived-class to have a member with the same name as a member in base-class.
        /// This is especially common when the derived-class member is static-level, and the base-class member is instance-level (for example, "Name").
        /// </summary>
        private static void ShowErrorSiteForDerivedClassStaticNewField()
        {
            Console.WriteLine($"{nameof(DerivedWithNewStaticLevelField)}.{nameof(DerivedWithNewStaticLevelField.Name)}: {DerivedWithNewStaticLevelField.Name}");

            var derivedClassInstance = new DerivedWithNewStaticLevelField();

            // Error accessing "Name" at instance level.
            // Error	CS0176	Member 'DerivedWithNewStaticLevelField.Name' cannot be accessed with an instance reference; qualify it with a type name instead
            //Console.WriteLine($"{nameof(derivedClassInstance)}.{nameof(derivedClassInstance.Name)}: {derivedClassInstance.Name}");

        }
    }
}
