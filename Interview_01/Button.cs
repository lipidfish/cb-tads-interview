using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_01
{
    public class Button
    {
        public string Style { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }

        public string Render()
        {
            return "<a class=\"btn btn-primary\"></a>";
        }

    }
}
