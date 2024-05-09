namespace Task2
{
    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var node11 = new ListNode();
            node11.val = 1;
            var node12 = new ListNode();
            node12.val = 2;
            node11.next = node12;
            var node13 = new ListNode();
            node13.val = 1;
            node12.next = node13;
            var node14 = new ListNode();
            node14.val = 1;
            node13.next = node14;

            var node21 = new ListNode();
            node21.val = 1;
            var node22 = new ListNode();
            node22.val = 5;
            node21.next = node22;
            var node23 = new ListNode();
            node23.val = 8;
            node22.next = node23;

            while(true)
            {
                //Console.WriteLine()
            }

        }
    }
}
