namespace Assets.Scripts.AStarSolucion
{
    internal class Node<>
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}