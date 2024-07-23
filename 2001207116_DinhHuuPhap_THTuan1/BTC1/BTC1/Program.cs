using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTC1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int[] arr = { 12, 23, 34, 45, 56, 67, 78, 89, 101, 200, 300, 400, 410, 420, 5, 6 };
                int sum = SumList(arr);
                Console.OutputEncoding = Encoding.UTF8;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Red;
            /* 
                Console.WriteLine("Tất cả phần tử ban đầu của mảng là: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($" {arr[i]}");
                }
                Console.WriteLine("");
               
            //4a. Tính tổng các phần tử của mảng
                Console.WriteLine($"4a. Tính tổng các phần tử của mảng 1 chiều a có n phần tử là số nguyên.\r\n {sum}");

                // 4b. Tính tổng các phần tử chẵn của mảng
                int evenSum = SumEvenElements(arr);
                Console.WriteLine($"4b. Tính tổng các phần tử chẵn của mảng 1 chiều a có n phần tử là số nguyên.\r\n {evenSum}");

                // 4c. Tính tích các phần tử ở vị trí chẵn của mảng
                int productEvenIndices = ProductEvenIndices(arr);
                Console.WriteLine($"4c. Tính tích các phần tử ở vị trí chẵn của mảng 1 chiều a có n phần tử là số nguyên.\r\n {productEvenIndices}");

                // 4d. Xuất các phần tử có đúng 2 chữ số của mảng
                Console.WriteLine("4d. Xuất các phần tử có đúng 2 chữ số của mảng 1 chiều a có n phần tử là số nguyên.\r");
                PrintTwoDigitElements(arr);
                Console.WriteLine("");
                // 7.1. Tìm vị trí của phần tử lớn nhất trong mảng
                int maxIndex = FindMaxIndex(arr);
                Console.WriteLine($"7.1.Vị trí của phần tử lớn nhất trong mảng {maxIndex} (Giá trị: {arr[maxIndex]})");
                // 7.2. Tính a^n
                int a = 2;
                int n = 10;
                long result = Power(a, n);
                Console.WriteLine($"7.2. Tính a^n {a}^{n} = {result}");
                // 7.3. Tìm phần tử trung bình của mảng
                double median = FindMedian(arr);
                Console.WriteLine($"7.3.Phần tử trung bình của mảng là {median}");
                Console.WriteLine("");
            */


            //
            //8. Thuật toán Merge Sort
            /*
             Console.WriteLine("Mảng ban đầu:");
             PrintArray(arr);

             MergeSort(arr, 0, arr.Length - 1);

             Console.WriteLine("8.Thuật toán Merge Sort: Mảng sau khi sắp xếp:");
             PrintArray(arr);
             */
            //9. Thuật toán QuickSort
            Console.WriteLine("Sử dụng 1 trong 2 giải thuật QuickSort hay Merge Sort để sắp xếp");
                Console.WriteLine("Mảng ban đầu:");
                PrintArray(arr);
                QuickSort(arr, 0, arr.Length - 1);
                Console.WriteLine("9.Thuật toán QuickSort: Mảng sau khi sắp xếp:");
                PrintArray(arr);
                Console.ReadKey();
            }
            public static int SumList(int[] arr)    //Dung de quy thay vong for
            {
                return SumList(arr, 0, arr.Length - 1);
            }

            public static int SumList(int[] arr, int left, int right)//Dung de quy de tinh left va right sau do cong leftsum va rightsum 
            {
                if (left == right)
                    return arr[left];

                int mid = (left + right) / 2;
                int leftSum = SumList(arr, left, mid);
                int rightSum = SumList(arr, mid + 1, right);

                return leftSum + rightSum;
            }

            // 4b. Tính tổng các phần tử chẵn của mảng
            public static int SumEvenElements(int[] arr)
            {
                return SumEvenElements(arr, 0, arr.Length - 1);
            }
            public static int SumEvenElements(int[] arr, int left, int right)
            {
                if (left == right)
                    return arr[left] % 2 == 0 ? arr[left] : 0;

                int mid = (left + right) / 2;
                int leftEvenSum = SumEvenElements(arr, left, mid);
                int rightEvenSum = SumEvenElements(arr, mid + 1, right);

                return leftEvenSum + rightEvenSum;
            }


            // 4c. Tính tích các phần tử ở vị trí chẵn của mảng
            public static int ProductEvenIndices(int[] arr)
            {
                return ProductEvenIndices(arr, 0, arr.Length - 1);
            }
            public static int ProductEvenIndices(int[] arr, int left, int right)
            {
                if (left == right)
                    return left % 2 == 0 ? arr[left] : 1;

                int mid = (left + right) / 2;
                int leftProduct = ProductEvenIndices(arr, left, mid);
                int rightProduct = ProductEvenIndices(arr, mid + 1, right);

                return leftProduct * rightProduct;
            }

            // 4d. Xuất các phần tử có đúng 2 chữ số của mảng
            public static void PrintTwoDigitElements(int[] arr)
            {
                PrintTwoDigitElements(arr, 0, arr.Length - 1);
            }
            public static void PrintTwoDigitElements(int[] arr, int left, int right)
            {
                if (left == right)
                {
                    if (arr[left] >= 10 && arr[left] <= 99 || arr[left] <= -10 && arr[left] >= -99)
                        Console.Write($" {arr[left]}");
                    return;
                }

                int mid = (left + right) / 2;
                PrintTwoDigitElements(arr, left, mid);
                PrintTwoDigitElements(arr, mid + 1, right);

            }
            // 7.1. Tìm vị trí của phần tử lớn nhất trong mảng
            public static int FindMaxIndex(int[] arr)
            {
                return FindMaxIndex(arr, 0, arr.Length - 1);
            }

            private static int FindMaxIndex(int[] arr, int left, int right)
            {
                if (left == right)
                    return left;

                int mid = (left + right) / 2;
                int leftMaxIndex = FindMaxIndex(arr, left, mid);
                int rightMaxIndex = FindMaxIndex(arr, mid + 1, right);

                if (arr[leftMaxIndex] > arr[rightMaxIndex])
                    return leftMaxIndex;
                else if (arr[rightMaxIndex] > arr[leftMaxIndex])
                    return rightMaxIndex;
                else
                    return Math.Min(leftMaxIndex, rightMaxIndex); // Trả về vị trí nhỏ nhất nếu giá trị bằng nhau
            }

            // 7.2. Tính a^n
            public static long Power(int a, int n)
            {
                if (n == 0)
                    return 1;
                long halfPower = Power(a, n / 2);
                long fullPower = halfPower * halfPower;
                if (n % 2 != 0)
                    fullPower *= a;
                return fullPower;
            }

            // 7.3. Tìm phần tử trung bình của mảng
            public static double FindMedian(int[] arr)
            {
                int n = arr.Length;
                int[] sortedArr = (int[])arr.Clone();
                Array.Sort(sortedArr);

                if (n % 2 == 1)
                    return sortedArr[n / 2];
                else
                    return (sortedArr[n / 2 - 1] + sortedArr[n / 2]) / 2.0;
            }
            // 8.Thuật toán sắp xếp Merge Sort
            /*
             * Chia: chia mảng thành hai mảng con.
                Trị: Sắp xếp đệ quy từng mảng con
                Gộp: Gộp 2 mảng con để tạo thành mảng được sắp xếp
             */
            public static void MergeSort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int mid = (left + right) / 2;
                    // Sắp xếp đệ quy từng mảng con
                    MergeSort(arr, left, mid);
                    MergeSort(arr, mid + 1, right);
                    // Gộp hai mảng con lại
                    Merge(arr, left, mid, right);
                }
            }
            // Hàm gộp hai mảng con lại thành một mảng được sắp xếp
            public static void Merge(int[] arr, int left, int mid, int right)
            {
                int n1 = mid - left + 1;
                int n2 = right - mid;

                int[] leftArray = new int[n1];
                int[] rightArray = new int[n2];

                Array.Copy(arr, left, leftArray, 0, n1);
                Array.Copy(arr, mid + 1, rightArray, 0, n2);

                int i = 0, j = 0;
                int k = left;

                while (i < n1 && j < n2)
                {
                    if (leftArray[i] <= rightArray[j])
                    {
                        arr[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = rightArray[j];
                        j++;
                    }
                    k++;
                }
                // Sao chép các phần tử còn lại của leftArray (nếu có)
                while (i < n1)
                {
                    arr[k] = leftArray[i];
                    i++;
                    k++;
                }

                // Sao chép các phần tử còn lại của rightArray (nếu có)
                while (j < n2)
                {
                    arr[k] = rightArray[j];
                    j++;
                    k++;
                }
            }

            // Hàm in mảng
            public static void PrintArray(int[] arr)
            {
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            //9. Thuật toán sắp xếp Quick Sort
            /*
             */
            // Hàm Quick Sort
            public static void QuickSort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    // Phân hoạch mảng và lấy vị trí pivot
                    int pivotIndex = Partition(arr, left, right);

                    // Sắp xếp đệ quy mảng con bên trái pivot
                    QuickSort(arr, left, pivotIndex - 1);

                    // Sắp xếp đệ quy mảng con bên phải pivot
                    QuickSort(arr, pivotIndex + 1, right);
                }
            }

            // Hàm phân hoạch mảng
            public static int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[right]; // Chọn phần tử cuối làm pivot
                int i = left - 1;

                for (int j = left; j < right; j++)
                {
                    if (arr[j] <= pivot)
                    {
                        i++;
                        Swap(arr, i, j);
                    }
                }
                Swap(arr, i + 1, right);
                return i + 1;
            }

            // Hàm hoán đổi hai phần tử
            public static void Swap(int[] arr, int i, int j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }


        }
}
