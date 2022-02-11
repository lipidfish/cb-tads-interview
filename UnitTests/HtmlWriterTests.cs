using Interview_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class HtmlWriterTests
    {
        [TestMethod]
        public void Button_OnRender_Works()
        {
            // TODO: make changes to the Button class that make the following test pass
            var button = new Button()
            {
                Text = "Something"
            };
            const string expected = "<a class=\"btn btn-primary\">Something</a>";
            Assert.AreEqual(expected, button.Render());
        }

        [TestMethod]
        public void Button_OnRender_Works_2()
        {
            // TODO: make changes to the Button class that make the following test pass
            var button = new Button()
            {
                Text = "Something Else"
            };
            const string expected = "<a class=\"btn btn-primary\">Something Else</a>";
            Assert.AreEqual(expected, button.Render());
        }


        [TestMethod]
        public void Button_OnRender_Id_Class_Works()
        {
            // TODO: make changes to the Button class that make the following test (and all previous tests) pass
            var button = new Button()
            {
                Id = "thisButton",
                Style = "display: none;",
                Text = "Something"
            };
            const string expected = "<a class=\"btn btn-primary\" id=\"thisButton\" style=\"display: none;\">Something</a>";
            Assert.AreEqual(expected, button.Render());
        }

        [TestMethod]
        public void Button_OnRender_Id_Class_Works_2()
        {
            // TODO: make changes to the Button class that make the following test (and all previous tests) pass
            var button = new Button()
            {
                Id = "thisButton2",
                Style = "display: none;",
                Text = "Something"
            };
            const string expected = "<a class=\"btn btn-primary\" id=\"thisButton2\" style=\"display: none;\">Something</a>";
            Assert.AreEqual(expected, button.Render());
        }

        [TestMethod]
        public void Button_OnRender_Id_Class_Works_3()
        {
            // TODO: make changes to the Button class that make the following test (and all previous tests) pass
            var button = new Button()
            {
                Id = "thisButton",
                Style = "display: none;",
                Text = "Something Else"
            };
            const string expected = "<a class=\"btn btn-primary\" id=\"thisButton2\" style=\"display: none;\">Something Else</a>";
            Assert.AreEqual(expected, button.Render());
        }


        [TestMethod]
        public void Button2_OnRender_Works()
        {
            // TODO: make changes to the Button2 class that make the following test (and all previous tests) pass
            var button = new Button2();
            // should be able to add the "Something" string through a property
            const string expected = "<button class=\"btn btn-primary\">Something</button>";
            Assert.AreEqual(expected, button.Render());
        }

        [TestMethod]
        public void Button2_OnRender_Works_2()
        {
            // TODO: make changes to the Button2 class that make the following test (and all previous tests) pass
            var button = new Button2();
            // should be able to add the "Something Else" string through a property
            const string expected = "<button class=\"btn btn-primary\">Something Else</button>";
            Assert.AreEqual(expected, button.Render());
        }


        [TestMethod]
        public void Button2_OnRender_Id_Class_Works()
        {
            // TODO: make changes to the Button2 class that make the following test (and all previous tests) pass
            var button = new Button2();
            // should be able to add the "Something" text, id attribute and style attribute through properties
            const string expected = "<button class=\"btn btn-primary\" id=\"thisButton\" style=\"display: none;\">Something</button>";
            Assert.AreEqual(expected, button.Render());
        }


        [TestMethod]
        public void Button2_OnRender_Id_Class_Works_2()
        {
            // TODO: make changes to the Button2 class that make the following test (and all previous tests) pass
            var button = new Button2();
            // should be able to add the "Something Else" text, id attribute and style attribute through properties
            const string expected = "<button class=\"btn btn-primary\" id=\"thisButton2\" style=\"display: none;\">Something Else</button>";
            Assert.AreEqual(expected, button.Render());
        }



        [TestMethod]
        public void Input_OnRender_Id_Class_Works()
        {
            // TODO: make changes to the Input class that make the following test (and all previous tests) pass
            var input = new Input()
            {
                Id = "thisInput",
                Style = "display: none;",
                Placeholder = "Default Text"
            };
            const string expected = "<input class=\"btn btn-primary\" id=\"thisInput\" style=\"display: none;\" placeholder=\"Default Text\"></input>";
            Assert.AreEqual(expected, input.Render());
        }

        [TestMethod]
        public void Input_OnRender_Id_Class_Works_2()
        {
            // TODO: make changes to the Input class that make the following test (and all previous tests) pass
            var input = new Input()
            {
                Id = "thisInput",
                Style = "display: none;",
                Placeholder = "Default Text 2"
            };
            const string expected = "<input class=\"btn btn-primary\" id=\"thisInput\" style=\"display: none;\" placeholder=\"Default Text 2\"></input>";
            Assert.AreEqual(expected, input.Render());
        }

    }
}
