using Xunit;
// using System.Collections.Generic;

namespace FindReplace.Objects
{
  public class RPSHandsTest
  {
    // [Fact]
    // public void FindsAndReplaces_FindTargetWordAndReplace_WorldWithUniverse()
    // {
    //   //Arrange
    //   FindsReplaces testObj = new FindsReplaces();
    //
    //   //Act
    //   string[] testArray1 = new string[]{"hello", "universe"};
    //   string [] test = testObj.FindsAndReplaces("hello world", "world", "universe");
    //
    //   //Assert
    //   Assert.Equal(test, testArray1);
    // }
    [Fact]
    public void FindsAndReplaces_FindTargetWordAndReplace_LadyWithDog()
    {
      //Arrange
      FindsReplaces testObj = new FindsReplaces();

      //Act
      string test1 = "hello you amazing dog";
      string test = testObj.FindsAndReplaces("hello you amazing lady", "lady", "dog");

      //Assert
      Assert.Equal(test, test1);
    }
  }
}
