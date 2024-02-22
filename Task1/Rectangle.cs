public class Rectangle
{
    public int width;
    public int height;
    public string color;

    public int GetArea ()
    {
        return width/height;
    }

    public int GetPerimeter()
    {
        return 2*(width+height);
    }

}