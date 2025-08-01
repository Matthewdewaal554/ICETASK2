namespace TestIndex
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestYear()
        {
            IndexIceTask.Games game = new IndexIceTask.Games(259, 2018, "fortnite", "Battleroyal");
            Assert.AreEqual(2018, game["year"]);
            Assert.AreEqual(2018, game[1]);
        }
        [TestMethod]
        public void TestName()
        {
            IndexIceTask.Games game = new IndexIceTask.Games(12, 2009, "LOL", "MOBA");
            Assert.AreEqual("LOL", game["name"]);
            Assert.AreEqual("LOL", game[2]);
        }
        [TestMethod]
        public void TestDescription()
        {
            IndexIceTask.Games game = new IndexIceTask.Games(500, 2020, "Call of duty", "Action");
            Assert.AreEqual("Action", game["genre"]);
            Assert.AreEqual("Action", game[3]);

        }
        [TestMethod]
        public void TestPrice()
        {
            IndexIceTask.Games game = new IndexIceTask.Games(500, 2020, "Call of duty", "Action");
            Assert.AreEqual(500, game["price"]);
            Assert.AreEqual(500, game[0]);
        }
        [TestMethod]


        public void TestGenre()
        {
            IndexIceTask.Games game = new IndexIceTask.Games(500, 2020, "Call of duty", "Action");
            Assert.AreEqual("Action", game["genre"]);
            Assert.AreEqual("Action", game[3]);
        }
    }
}
