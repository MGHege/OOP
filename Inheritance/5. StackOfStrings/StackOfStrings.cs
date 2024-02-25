namespace CustomStack
{
    public class StackOfStrings:Stack<string>
    {
        public bool IsEmpty()
        { return Count == 0; }
        public Stack<string> AddRenge(IEnumerable<string> collection)
        {
            foreach (string item in collection)
            {
                this.Push(item);
            }
            return this;
        }
    }
}