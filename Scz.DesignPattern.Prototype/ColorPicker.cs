namespace Scz.DesignPattern.Prototype
{
    [System.Serializable]
    public class ColorPicker
    {
        public int Red { get; private set; }
        public int Green { get; private set; }

        public int Blue { get; private set; }

        public string Name { get; set; }
        public ColorPicker(int red,int green,int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }
    }
}