using System;
using System.Collections;

public class CSTack
{
	public class CSTack
	{
		private int p_index;
		private ArrayList list;

		public CSTack()
		{
			list = new ArrayList();
			p_index = -1;
		}

		public int count
        {
			get { return list.Count; }
        }

		public void push(object item)
        {
			list.Add(item);
			p_index++;
        }

		public object pop()
        {
			object obj = list[p_index];
			list.RemoveAt(p_index);
			p_index--;
			return obj;
        }

		public void clear()
        {
			list.Clear();
			p_index = -1;
        }

		public peek()
        {
			return list[p_index];
        }


	}
	
}
