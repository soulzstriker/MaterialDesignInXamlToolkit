using System;
using System.Windows.Media;

namespace MaterialDesignColors
{
//Testing
    public class Hue
    {
        public Hue(string name, Color Newcolor, Color Newforeground)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            Name = name;
            Color = Newcolor;
            Foreground = Newforeground;
        }

        public string Name { get; }

        public Color Color { get; }

        public Color Foreground { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}