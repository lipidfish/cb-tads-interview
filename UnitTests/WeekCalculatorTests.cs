using System.ComponentModel.DataAnnotations;
using Interview_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{

    /*  Requirements
        Write an algorithm that converts selections of days of the week into a string that describes the selection
        with the following output specifications:
            No selection: "none"
            Only weekend days selected: "Weekends"
            Only week days selected: "Week Days"
            All days selected: "Every Day"
            Else, a space delimited list of shortened names of the selected days. For example "Mon Tue Wed"
     */



    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void DescribeDays_None()
        {
            var selections = new DaySelections()
            {
                Sun = false,
                Mon = false,
                Tue = false,
                Wed = false,
                Thu = false,
                Fri = false,
                Sat = false,
            };

            const string expected = "None";
            var actual = WeekCalculator.DescribeDays(selections);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DescribeDays_Single()
        {
            var selections = new DaySelections()
            {
                Sun = true,
                Mon = false,
                Tue = false,
                Wed = false,
                Thu = false,
                Fri = false,
                Sat = false,
            };

            const string expected = "Every Sunday";
            var actual = WeekCalculator.DescribeDays(selections);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DescribeDays_Two()
        {
            var selections = new DaySelections()
            {
                Sun = true,
                Mon = true,
                Tue = false,
                Wed = false,
                Thu = false,
                Fri = false,
                Sat = false,
            };

            const string expected = "Sun Mon";
            var actual = WeekCalculator.DescribeDays(selections);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DescribeDays_Sun_Tues()
        {
            var selections = new DaySelections()
            {
                Sun = true,
                Mon = true,
                Tue = true,
                Wed = false,
                Thu = false,
                Fri = false,
                Sat = false,
            };

            const string expected = "Sun Mon Tue";
            var actual = WeekCalculator.DescribeDays(selections);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DescribeDays_Sun_Wed()
        {
            var selections = new DaySelections()
            {
                Sun = true,
                Mon = true,
                Tue = true,
                Wed = true,
                Thu = false,
                Fri = false,
                Sat = false,
            };

            const string expected = "Sun Mon Tue Wed";
            var actual = WeekCalculator.DescribeDays(selections);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DescribeDays_Sun_Thurs()
        {
            var selections = new DaySelections()
            {
                Sun = true,
                Mon = true,
                Tue = true,
                Wed = true,
                Thu = true,
                Fri = false,
                Sat = false,
            };

            const string expected = "Sun Mon Tue Wed Thu";
            var actual = WeekCalculator.DescribeDays(selections);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DescribeDays_Sun_Friday()
        {
            var selections = new DaySelections()
            {
                Sun = true,
                Mon = true,
                Tue = true,
                Wed = true,
                Thu = true,
                Fri = true,
                Sat = false,
            };

            const string expected = "Sun Mon Tue Wed Thu Fri";
            var actual = WeekCalculator.DescribeDays(selections);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DescribeDays_All()
        {
            var selections = new DaySelections()
            {
                Sun = true,
                Mon = true,
                Tue = true,
                Wed = true,
                Thu = true,
                Fri = true,
                Sat = true,
            };

            const string expected = "Every Day";
            var actual = WeekCalculator.DescribeDays(selections);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DescribeDays_Weekends()
        {
            var selections = new DaySelections()
            {
                Sun = true,
                Mon = false,
                Tue = false,
                Wed = false,
                Thu = false,
                Fri = false,
                Sat = true,
            };

            const string expected = "Weekends";
            var actual = WeekCalculator.DescribeDays(selections);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DescribeDays_Weekdays()
        {
            var selections = new DaySelections()
            {
                Sun = false,
                Mon = true,
                Tue = true,
                Wed = true,
                Thu = true,
                Fri = true,
                Sat = false,
            };

            const string expected = "Week Days";
            var actual = WeekCalculator.DescribeDays(selections);
            Assert.AreEqual(expected, actual);
        }


    }
}
