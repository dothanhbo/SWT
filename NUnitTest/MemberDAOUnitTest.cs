using NUnit.Framework;

namespace NUnitTest
{
    public class MemberDAOUnitTest
    {
        //Để chạy test: chọn Test trên thanh taskbar, chọn run test
        // phím tắt chạy test: Ctrl R A



        // hàm nạy chạy đầu tiên khi vào test
        [SetUp]
        public void Setup()
        {
        }


        // một Test case cơ bản
        [Test]
        public void TestDemo()
        {
            // so sánh 2 giá trị cơ bản
            Assert.AreEqual(1, 1);

        }

        // TestCase với parameter truyền vào -> thử được nhiều data cũng lúc | Method cũng phải có parameter | số lượng parameter trên dưới phải giống nhau
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        public void TestCaseDemo(int a, int b)
        {
            // so sánh 2 giá trị 
            Assert.AreEqual(a, b);
        }

        // TestCase với parameter truyền vào đi kèm Expected luôn -> thử được nhiều data cùng lúc | Method cũng phải return giá trị
        // không cần Assert
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(2, ExpectedResult = 0)]

        public int TestCaseWithExeptedDemo(int a)
        {
            return a;
        }

        // Test xem có quăng lỗi ra không
        [Test]
        public void ExpectionDemo()
        {
            // thay method quăng lỗi thành method tương ứng
            // Assert.Throws<System.Exception>(() => MethodQuangLoi());
        }


        // Cơ bản nhiêu đó thôi. Viết code test từng method trong MemberDAO đi anh em =))
        // Tham khảo thêm tại https://docs.nunit.org/articles/nunit/writing-tests/attributes.html


    }
}