using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            if (start > end) return -1;
            int m1 = start + ((end - start) / 3);
            int m2 = end - ((end - start) / 3);
            if (key == arr[m1]) return m1;
            if (key == arr[m2]) return m2;
            if (key >= arr[start] && key < arr[m1]) return TernarySearch(arr, key, start, m1);
            if (key > arr[m1] && key < arr[m2]) return TernarySearch(arr, key, m1 + 1, m2);
            return TernarySearch(arr, key, m2 + 1, end);
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            int mid = (end + start) / 2;
            if (start > end) return -1;

            if (is_first == true)
            {
                if (key == arr[mid])
                {
                    if (mid != 0 && arr[mid] == arr[mid - 1])
                        return BinarySearchForCalculatingRepeated(arr, key, is_first, start, mid - 1);
                    return mid;
                }
                if (key > arr[mid])
                {
                    return BinarySearchForCalculatingRepeated(arr, key, is_first, mid, end);
                }
                if (key < arr[mid])
                {
                    return BinarySearchForCalculatingRepeated(arr, key, is_first, start, mid);
                }
            }
            else
            {
                if (key == arr[mid])
                {
                    if (mid != 0 && arr[mid] == arr[mid + 1])
                        return BinarySearchForCalculatingRepeated(arr, key, is_first, mid + 1, end);
                    return mid;
                }
                if (key > arr[mid])
                {
                    return BinarySearchForCalculatingRepeated(arr, key, is_first, mid, end);
                }
                if (key < arr[mid])
                {
                    return BinarySearchForCalculatingRepeated(arr, key, is_first, start, mid);
                }
            }
            return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == key) count++;
            return count;
        }
    }
}
