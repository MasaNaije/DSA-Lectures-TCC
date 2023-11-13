using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        { 
            Node node = new Node(val);
            if (First == null) {First = node; return; }
            Node move = First;
            while (move.Next != null) { move = move.Next; }
            move.Next = node;
        }
        public void RemoveKey(int key)
        {
            if(First==null) return;
            Node move = First;
            if (First.Data == key)
            {
                First=First.Next;
                move.Next = null;
                return;
            }
            while(move != null&&move.Next.Data!=key) { move=move.Next; }
            move.Next = move.Next.Next;
        }
        public void Merge(LinkedList other_list)
        {
            Node move = this.First;
            while (move.Next != null) { move = move.Next; }
            move.Next= other_list.First;
        }
        public void Reverse()
        {
            if (First == null || First.Next == null) return;
            Node prev= null,curr=First,next=null;
            while (curr!=null)
            {
                next=curr.Next;
                curr.Next = prev;
                prev = curr;
                curr= next;
            }
            First = prev;
        }
    }
}
