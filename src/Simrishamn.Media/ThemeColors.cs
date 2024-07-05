using System.Drawing;

namespace Simrishamn.Media;

public static class ThemeColors
{
    // Blue
    public static readonly Color Primary = Color.FromArgb(255, 0, 110, 199);
    public static readonly Color Primary80 = Color.FromArgb(255, 83, 132, 209);
    public static readonly Color Primary60 = Color.FromArgb(255, 123, 155, 218);
    public static readonly Color Primary40 = Color.FromArgb(255, 159, 179, 228);
    public static readonly Color Primary20 = Color.FromArgb(255, 192, 204, 237);

    // Yellow
    public static readonly Color Secondary = Color.FromArgb(255, 252, 201, 23);
    public static readonly Color Secondary80 = Color.FromArgb(255, 255, 210, 79);
    public static readonly Color Secondary60 = Color.FromArgb(255, 255, 218, 117);
    public static readonly Color Secondary40 = Color.FromArgb(255, 255, 227, 152);
    public static readonly Color Secondary20 = Color.FromArgb(255, 255, 236, 186);

    // Red
    public static readonly Color Tertiary = Color.FromArgb(255, 230, 13, 46);
    public static readonly Color Tertiary80 = Color.FromArgb(255, 242, 80, 77);
    public static readonly Color Tertiary60 = Color.FromArgb(255, 255, 144, 133);
    public static readonly Color Tertiary40 = Color.FromArgb(255, 255, 172, 162);
    public static readonly Color Tertiary20 = Color.FromArgb(255, 255, 200, 192);

    // Green
    public static readonly Color AlternateOne = Color.FromArgb(255, 51, 115, 33);
    public static readonly Color AlternateOne80 = Color.FromArgb(255, 87, 138, 69);
    public static readonly Color AlternateOne60 = Color.FromArgb(255, 120, 160, 104);
    public static readonly Color AlternateOne40 = Color.FromArgb(255, 154, 184, 140);
    public static readonly Color AlternateOne20 = Color.FromArgb(255, 187, 207, 177);

    // Orange
    public static readonly Color AlternateTwo = Color.FromArgb(255, 255, 158, 27);
    public static readonly Color AlternateTwo80 = Color.FromArgb(255, 255, 174, 75);
    public static readonly Color AlternateTwo60 = Color.FromArgb(255, 255, 190, 112);
    public static readonly Color AlternateTwo40 = Color.FromArgb(255, 255, 206, 148);
    public static readonly Color AlternateTwo20 = Color.FromArgb(255, 255, 222, 183);

    public static readonly Color AlternateThree = Color.FromArgb(255, 115, 115, 115);
    public static readonly Color AlternateThree80 = Color.FromArgb(255, 137, 137, 137);
    public static readonly Color AlternateThree60 = Color.FromArgb(255, 159, 159, 159);
    public static readonly Color AlternateThree40 = Color.FromArgb(255, 182, 182, 182);
    public static readonly Color AlternateThree20 = Color.FromArgb(255, 206, 206, 206);

    // Method to convert Color to Hexadecimal String
    public static string ToRgbHex(Color color)
    {
        return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
    }

    public static string ToRgbaHex(Color color)
    {
        return $"#{color.R:X2}{color.G:X2}{color.B:X2}{color.A:X2}";
    }
}
