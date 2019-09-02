namespace BabatyeInventory
{
    public class sqlcommand : cmd
    {
        private string v1;
        private string text;
        private char v2;
        private DAL dAL;

        private sqlcommand(string v1, string text, char v2, DAL dAL)
        {
            this.v1 = v1;
            this.text = text;
            this.v2 = v2;
            this.dAL = dAL;
        }
    }
}