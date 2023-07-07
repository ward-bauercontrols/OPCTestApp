using OPCLib.Models;
using OPCLib.Service;

namespace OPCUnitTest
{
   [TestClass]
   public class OPCLabsUnitTest
   {
      
      [TestMethod]
      public void GetAllTagsTest()
      {
         IOPCClient client = new OPCLabsClient();
         var resp1 = client.OpenConnection(TestHelpers.connStr);
         Assert.IsTrue(resp1.IsSuccess);
         var resp2 = client.GetAllTags();
         Assert.IsTrue(resp2.IsSuccess);
         Assert.IsTrue(resp2.Value.Count() > 0);
         var resp3 = client.CloseConnection();
         Assert.IsTrue(resp3.IsSuccess);
      }

      [TestMethod]
      public void GetTagValuesTest()
      {
         IOPCClient client = new OPCLabsClient();
         var resp1 = client.OpenConnection(TestHelpers.connStr);
         Assert.IsTrue(resp1.IsSuccess);
         var resp2 = client.GetAllTags();
         Assert.IsTrue(resp2.IsSuccess);
         Assert.IsTrue(resp2.Value.Count() > 0);
         var resp3 = client.GetTagValues(resp2.Value.ToList().OrderBy(g => new Guid()).Take(10).Select(f => f.Id).ToList());
         Assert.IsTrue(resp3.IsSuccess);
         Assert.IsTrue(resp3.Value.Count() > 0);
         var resp4 = client.CloseConnection();
         Assert.IsTrue(resp4.IsSuccess);
      }

      [TestMethod]
      public void GetWriteValuesTest()
      {
         IOPCClient client = new OPCLabsClient();
         var resp1 = client.OpenConnection(TestHelpers.connStr);
         Assert.IsTrue(resp1.IsSuccess);
         var resp2 = client.GetAllTags();
         Assert.IsTrue(resp2.IsSuccess);
         Assert.IsTrue(resp2.Value.Count() > 0);
         var resp3 = client.GetTagValues(resp2.Value.ToList().OrderBy(g => new Guid()).Take(10).Select(f => f.Id).ToList());
         Assert.IsTrue(resp3.IsSuccess);
         Assert.IsTrue(resp3.Value.Count() > 0);
         var resp4 = client.CloseConnection();
         Assert.IsTrue(resp4.IsSuccess);
      }

   }
}