// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//01 - Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
//string NumIsDivide () {

//    int num = 8;
//    bool isDivide = num % 3 == 0 && num % 7 == 0;

//    if (isDivide)
//    {

//        return "yes";
//    }
//    else
//    {        

//        return "no";
//    }



//}
//Console.WriteLine(NumIsDivide());


// 02 -  n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.


//int SumEvenNums()
//{
//    int n = 4;
//    int m = 6;
//    int sumNums = 0;
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sumNums = n + m;


//    }

//    return sumNums;
//}

//Console.WriteLine(SumEvenNums());



// 03 - Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//int OddNumbers()
//{
//    int n = 7;
//    int m = 13;
//    int sumOfOddNumbers = 0;

//    for (int i = n; i < m; i++)
//    {
//        if (n % 2 == 1)
//        {
//            sumOfOddNumbers += i;
//        }
//    }

//    return sumOfOddNumbers;
//}

//Console.WriteLine(OddNumbers());


//04 - Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin

//int OddNumbers()
//{
//    int n = 3;
//    int m = 5;
//    int sumOfOddNumbers = 0;

//    for (int i = n; i < m; i++)
//    {
//        if (n % 2 == 1)
//        {
//            sumOfOddNumbers = n + m;
//        }
//    }

//    return sumOfOddNumbers;
//}

//Console.WriteLine(OddNumbers());


//05 - Verilmish arrayin icindeki tek ededlerin cemini tapin.

//int SumOfOddNums(int[] nums)
//{
//    int sumOfNumbers = 0;

//    foreach (var item in nums)
//    {
//        if (item % 2 == 1)
//        {
//            sumOfNumbers += item;
//        }
//    }

//    return sumOfNumbers;
//}


//int[] nums = { 1, 3, 5, 6, 7, 9 };



//Console.WriteLine(SumOfOddNums(nums));


// 06 - Verilmish arrayin icindeki cut ededlerin sayini tapin.

//int SumOfEvenNums(int[] nums)
//{
//    int sumOfNumbers = 1;

//    foreach (var item in nums)
//    {
//        if (item % 2 == 0)
//        {
//            sumOfNumbers += item;
//        }
//    }

//    return sumOfNumbers;
//}


//int[] nums = { 1, 2, 3, 4 };



//Console.WriteLine(SumOfEvenNums(nums));



// 07 - Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//void FoundNumber()
//{
//    int n = 4;
//    int count = 0;

//    if (n < 2)
//    {
//        Console.WriteLine("Ne sade ne murekkeb");
//    }
//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (i % i == 0)
//            {
//                count++;
//                if (count == 3)
//                {
//                    break;
//                }
//            }
//        }

//        if (count == 2)
//        {
//            Console.WriteLine("Sade");
//        }
//        else
//        {
//            Console.WriteLine("Murekkeb");
//        }

//    }

//}

//FoundNumber();



//08 - n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.
//Meselen: Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.



//bool Fast_Power(int num)
//{

//    int count = 0;
//    bool elem = false;

//    for (int i = 2; i <= num; i *= 2)
//    {
//        count++;

//        if (i == num)
//        {
//            elem = true;
//            break;
//        }
//    }
//    return elem;
//}
//Console.WriteLine(Fast_Power(31));

// --------------------------


//int Fast_Power2(int num)
//{

//    int count = 0;

//    for (int i = 2; i <= num; i *= 2)
//    {
//        count++;    
//    }    

//    return count;
//}
//Console.WriteLine(Fast_Power2(32));



//09 - Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab: 18).

//int SumNumbers(int[] nums)
//{
//    int multiply = 1;

//    foreach (var item in nums)
//    {
//        multiply *= item;
//    }
//    return multiply;
//}

//int[] nums = { 1, 3, 55, 6, 33 };


//Console.WriteLine(SumNumbers(nums));



// 10 - Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.


//int SumOfSquereArray(int[] elems)
//{
//    int sum = 0;

//    foreach (int elem in elems)
//    {
//        if (elem % 2 == 0)
//        {
//            sum += elem;
//        }
//    }

//    return sum * sum;

//}

//int[] elems = { 1, 2, 3, 4, 5 };


//Console.WriteLine(SumOfSquereArray(elems));





// 11 - temp qebul eden method yazirsiz. Return type olan method olmalidir. Method temp 20den boyukdurse isti, kicikdirse soyuq,
// beraberdirse mulayim mesajlarini qaytarsin.

//string Temperatur (int temp)
//{
//    string temperatur;

//    if (temp >20)
//    {
//        temperatur = "istidi";
//    }
//    else if (temp == 20)
//    {
//        temperatur = "Normal";
//    }
//    else
//    {
//        temperatur = "Soyuqdur";
//    }
//    return temperatur;
//}

//Console.WriteLine(Temperatur(22));

// 12 - methoda a ve b ededleri gelecek, method a ve b arasindaki ededlerin sayini qaytarsin.

//int SumNumbers()
//{

//    int num1 = 5;
//    int num2 = 10;
//    int sum = 0;

//    if (num1 >= 0)
//    {
//        sum = num1 - num2;
//    }
//    else
//    {
//        sum = num2 - num1;
//    }

//    return sum;
//}
//Console.WriteLine(SumNumbers());


//  13 - method reqemlerden ibaret 2 array qebul edecek, her iki arrayin elementlerinin cemini geri qaytarsin

//int SumOfArray(int[] elems1, int[] elems2)
//{
//    int sum = 0;
//	foreach (int elem1 in elems1)
//	{
//		sum += elem1;
//	}
//	foreach (int elem2 in elems2)
//	{
//		sum += elem2;
//	}
//	return sum;
//}

//int[] elems1 = { 1, 2, 3, 4, 5 };
//int[] elems2 = { 9, 8, 7, 6 };

//Console.WriteLine(SumOfArray(elems1,elems2));


// 14 - methoda eded gelir, hemin method ededin kvadratini geriye qaytarsin.

//int SquereOfNumber ()
//{
//    int num = 10;


//    return num * num;

//}


//Console.WriteLine(SquereOfNumber());


//  15 - methoda eded gelir, hemin method 1-den gelen edede qeder olan cut ededlerin cemini geri qaytarsin.

//int SumEvenNumbers()
//{
//    int num = 4;
//    int sum = 0;
//    for (int i = 1; i <= num; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i;
//        }
//    }
//    return sum;

//}
//Console.WriteLine(SumEvenNumbers());


