﻿using JetBrains.ReSharper.FeaturesTestFramework.Intentions;
using NUnit.Framework;

namespace AsyncConverter.Tests
{
    [TestFixture]
    public class MathodToAsyncConverterTests : CSharpContextActionExecuteTestBase<MathodToAsyncConverter>
    {
        protected override string ExtraPath => "MathodToAsyncConverterTests";

        protected override string RelativeTestDataPath => "MathodToAsyncConverterTests";

        [TestCase("ReplaceToGenericTask.cs")]
        [TestCase("AddingUsing.cs")]
        [TestCase("ReplaceToTask.cs")]
        [TestCase("ReplaceMethod.cs")]
        [TestCase("ReplaceMethodWithParameter.cs")]
        [TestCase("ReplaceMethodWithCorrectChosenName.cs")]
        [TestCase("CorrectCompareParam.cs")]
        [TestCase("CorrectCompareReturnType.cs")]
        [TestCase("ReplaceMethodFromAnotherClass.cs")]
        [TestCase("ReplaceMethodFromAnotherClassThroughProp.cs")]
        [TestCase("ReplaceMethodAndMethodInParam.cs")]
        [TestCase("ReplaceMethodInChain.cs")]
        [TestCase("ReplaceFromCaller.cs")]
        [TestCase("ReplaceFromCallerWithResult.cs")]
        [TestCase("ReplaceFromAsyncCaller.cs")]
        [TestCase("RenameInInterface.cs")]
        [TestCase("ReplaceInBase.cs")]
        [TestCase("ReplaceInheritor.cs")]
        [TestCase("ReplaceFromResult.cs")]
        public void Test(string fileName)
        {
            DoTestFiles(fileName);
        }
    }
}