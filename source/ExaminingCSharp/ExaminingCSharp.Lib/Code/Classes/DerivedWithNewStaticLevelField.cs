using System;


namespace ExaminingCSharp.Lib
{
    public class DerivedWithNewStaticLevelField : BaseWithInstanceLevelProperty
    {
        #region Static

        public static readonly new string Name = "Name";

        #endregion
    }
}
