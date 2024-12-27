using Tyuiu.VorobevAD.SprintReview.Task7.V4.Lib;

namespace Tyuiu.VorobevAD.SprintReview.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path1 = @"C:\Users\alemi\source\repos\Tyuiu.VorobevAD.SprintReview.Task7.V4\BooksTable.csv";
            FileInfo fileInfo = new FileInfo(path1);
            string path2 = @"C:\Users\alemi\source\repos\Tyuiu.VorobevAD.SprintReview.Task7.V4\ReadersTable.csv";
            FileInfo fileInfo2 = new FileInfo(path1);
            bool fileExist = fileInfo.Exists;
            bool fileExist2 = fileInfo2.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
            Assert.AreEqual(wait, fileExist2);
        }

        [TestMethod]
        public void ValidMinValue()
        {
            double[] matrix = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Assert.AreEqual(ds.FindMinValue(matrix), 1);
        }

        [TestMethod]
        public void ValidMaxValue()
        {
            double[] matrix = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Assert.AreEqual(ds.FindMaxValue(matrix), 14);
        }

        [TestMethod]
        public void ValidMiddleValue()
        {
            double[] matrix = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Assert.AreEqual(ds.FindMiddleValue(matrix), 7.5);
        }

        [TestMethod]
        public void ValidSumValue()
        {
            double[] matrix = { 1, 2, 3, 4, 5 };

            Assert.AreEqual(ds.FindSumValue(matrix), 15);
        }
    }
}