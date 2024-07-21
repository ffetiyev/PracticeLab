//static void TheBiggestProduct(int[] arr1)
//{
//    int max = 1;
//    int a = 1;
//    for (int j = 0; j < arr1.Length; j++)
//    {
//        if (arr1[j + 1] > arr1[j])
//            a = arr1[j + 1];

//    }
//    Console.WriteLine(a);



//    for (int i = 0; i < arr1.Length; i++)
//    {
//        if (arr1[i] % 2 == 0 && arr1[i] % 3 == 0)
//        {
//            max = arr1[i];
//        }

//    }
//    //   Console.WriteLine(max);
//}
//int[] arr1 = { 1, 2, 4, 9, 12, 18, 6 };
//TheBiggestProduct(arr1);



// 1, 3 , 4, 7 , 9, 12
//static int SumOfNumbers(int[] arr)
//{
//    int count = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        for (int j = 0; j<arr.Length; j++) {
//            if (arr[i] % j== 0)
//        {
//            count++;
//        } 

//        }

//    }

//}

//static void SimpleNumbers(int[] arr)
//{
//    int count = 0;
//    for (int i = 0;i < arr.Length; i++)
//    {


//    }

//}
//int[] arr = { 1, 3, 4, 7, 9, 12 };
//Console.WriteLine(SimpleNumbers(arr));




//static string parnumber(string word)
//{ 
//   string par="";

//  for (int i = 0; i < word.length; i++)
//    {
//        par=word.substring(i);
//    }

//  if (par==word) 
//    { 
//        return par; 
//    }

//}
//string word = "ana";
//console.writeline(parnumber(word))



//static int NumberOfSpaces(string sentence)
//{
//    int count = 0;
//    for (int i = 0; i <sentence.Length; i++)
//    {
//        if (sentence[i] == ' ')
//        {
//            count++;
//        }

//    }
//    return count;
//}

//string sentence = "salam PB402 ";
//Console.WriteLine(NumberOfSpaces(sentence));




//static int NumberOfText(string text, char ch)
//{
//    int count = 0;
//    for(int i=0; i < text.Length; i++)
//    {
//        if (text[i] == ch)
//        {
//            count++;
//        }
//    }
//    return count;

//}
//string text = "salam";
//char ch=  'a';

//Console.WriteLine(NumberOfText(text,ch));





//static float Result(int[] arr)
//{
//    int count1 = 0;
//    int sum1=0; 
//    int count2 = 0;
//    int sum2=0;
//    int count3 = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] %2== 0) {
//            count1++;
//            sum1=sum1 + arr[i];
//        }
//    }

//    for (int i = 0;i < arr.Length; i++)
//    {
//        for (int j = 0; j < arr.Length; j++)
//        {
//         if (arr[i] %j==0)
//        {
//               count3++;
               
//                if (count3 > 2)
//                {
//               sum2=sum2 + arr[i];
//                }
//        }
//        }
//    }
//    float result=(sum1 + sum2)/(count1+count2);
//    return result;
//}
//int[] arr = { 2, 4, 5, 7, 8, 9 };
//Console.WriteLine(Result(arr));




//static int Result(int[] arr)
//{
//    int max = 0;
//    int min = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        for (int j = 1; j< arr.Length; j++)
//        {
//            if (arr[i] > arr[j])
//            {
//                 max = arr[i];
              
//            }
//            else
//            {
//                break;
//            }
//        }
//    }

//    for (int i = 0; i < arr.Length; i++)
//    {
//        for (int j = 1; j < arr.Length; j++)
//        {
//            if (arr[i] < arr[j])
//            {
//                min = arr[i];
//                break;
//            }
//            else
//            {
//                break;
//            }
//        }
//    }
//    int result = max - min;
//    return result;

//}
//int[] arr = {  2, 4, 98, 1, 6, 33, 46 };
//Console.WriteLine(Result(arr));


//static double AverageNumber(int[] arr)
//{
//    int sum = 0;
//    int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] %5== 0) {
//            count++;
//            sum = sum + arr[i];
//        }
//    }
//     double result = sum / count;
//    return result;
//}
//int[] arr = { 2, 5, 15, 20, 7, 8 };

//Console.WriteLine(AverageNumber(arr));


//static int Ekob(int a, int b)
//{
//   int m = 0;
//    for (int i = 1; i < a*b; i++)
//   {
//     if (i % a == 0 && i % b == 0)
//      {
//            i = m;
//            break;
            
//      }
        
//   }

//    return m;
//}
//int a = 3;
//int b = 4;
//Console.WriteLine(Ekob(a, b));

static int Ebob(int a, int b)
{
    int max=1;
    for (int i = 2; i < a; i++)
    {
        if(a%i == 0 && b % i == 0)
        {
            max = i;
            break;
        }
        else
        {
            max = 1;
        }
    }
    return max;
}

int a = 3;
int b = 9;
Console.WriteLine(Ebob(a, b));