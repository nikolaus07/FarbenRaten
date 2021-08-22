using NUnit.Framework;

namespace StartMain
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void test_N_logger()
        {
            BasicsCS.Test_N_Logger.testLogger();
            Assert.Pass();

            // output in Nlogger.log
            // 2021 - 08 - 22 10:29:00.8856 | Info | das ist INFO-logger
            // 2021 - 08 - 22 10:29:00.9355 | Warn | das ist WARN-logger
            // 2021 - 08 - 22 10:29:00.9355 | Error | das ist ERROR-logger
            // 2021 - 08 - 22 10:29:00.9416 | Fatal | das ist FATAL-logger
        }
    }
}