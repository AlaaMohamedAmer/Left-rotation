using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= new int[] {0,1,2,3,4};
            Left_rotation obj = new Left_rotation();
            obj.Left(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.ReadKey();
        }
    }
    public class Left_rotation
    {
        public void Left(int[] arr) 
        {
            int X = arr[0];
            for (int i = 0 ; i < arr.Length-1 ; i++) {
                arr[i] = arr[i+1];
            }
            arr[arr.Length-1] = X;
        }
    }
}
