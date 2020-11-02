using System;
using Cinnabarlab.Data;
using Xunit;

namespace Cinnabarlab.Tests
{
  public class UnitTest1
  {
    [Fact]
    public void QueryTest()
    {
      DataManager.QueryTest();
    }
    [Fact]
    public void ProcTest()
    {
      DataManager.ProcedureTest();
    }
  }
}
