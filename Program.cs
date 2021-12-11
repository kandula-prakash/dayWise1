using System;

namespace stackBRP
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack st = new stack();
            //st.push(10);
            //st.push(20);
            //st.push(30);
            //st.push(40);
            //st.isEmpty();
            //st.size();
            //st.topElement();
            //st.pop();
            Queue q = new Queue();
            q.isEmpty();
            q.EnQueue(10);
            q.EnQueue(20);
            q.EnQueue(30);
            q.EnQueue(40);
            q.EnQueue(50);
            q.display();
            q.DeQueue();
            

        }
    }
}
