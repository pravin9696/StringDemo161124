namespace StringDemo161124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "GTH";
            //Console.WriteLine("s1 hashcode="+s1.GetHashCode());
            //Console.WriteLine("s1="+s1);
            //s1 = s1 + " pune, Maharashtra";
            //Console.WriteLine("s1 hashcode="+s1.GetHashCode());
            //Console.WriteLine("s1=" + s1);
            //string str1 ;
            //string str2 ;
            //Console.WriteLine("enter string 1 and stgring 2");
            //str1 = Console.ReadLine();
            //str2=Console.ReadLine();

           // int n = string.Compare(str1, str2);//0  or 1  or -1
                                               //Console.WriteLine("n="+n);
                                               //if (n>0)
                                               //{
                                               //    Console.WriteLine($"{str1} is greater");
                                               //}
                                               //else if(n<0)
                                               //{
                                               //    Console.WriteLine($"{str1} is smaller");
                                               //}
                                               //else
                                               //{
                                               //    Console.WriteLine($"{str1} and {str2} are equals");
                                               //}

            //int x= str1.CompareTo(str2);// 0  or 1  or -1

            // 0===>str1 ==str2
            // +1==> str1>str2
            //-1 ===> str1<str2

            //if (x>0)
            //{
            //    Console.WriteLine("str1 is greater");
            //}
            //else if (x<0)
            //{
            //    Console.WriteLine("str1 is smaller");
            //}
            //else
            //{
            //    Console.WriteLine("str1 and str2 are equals");
            //}

           //string str3= string.Concat(str1, str2);
           // Console.WriteLine("str1 length="+str1.Length);
           // Console.WriteLine("str2 length=" + str2.Length);
           // Console.WriteLine("str3="+str3);
           // Console.WriteLine("str3 length=" + str3.Length);

            //bool result=str1.Contains(str2);
            //Console.WriteLine(result);

            string str1="xyz";
            //char[] chaArray = new char[30];
            //str1.CopyTo(5,chaArray,3,6);
            //Console.WriteLine(chaArray);


            //// WAP to check string contain vowels or not
            //bool flag=false;
            //char[] chAr = str1.ToCharArray();
            //for (int i = 0; i < chAr.Length; i++) 
            //{
            //    if (chAr[i]=='a'|| chAr[i] == 'e'||chAr[i] == 'i'||chAr[i] == 'o'||chAr[i] == 'u')
            //    {
            //        flag = true;
            //        break;
            //    }
            //}
            //if (flag) 
            //{
            //    Console.WriteLine("string contains vowel");
            //}
            //else
            //{
            //    Console.WriteLine("String not containing vowel");
            //}

            //string ss1 = "mumbai pune";
            //string ss2 = "mumbai";
            //int n=ss1.IndexOf(ss2);//return -1==> not available     return >(-1)  ==> ss2 is vailable
            //Console.WriteLine("n="+n);
            //// WAP to find given string is available into string or not using indexof method

            ////if (n>-1)
            ////{
            ////    Console.WriteLine($"{ss2} is vailable in {ss1} string at index no {n}");
            ////}
            ////else
            ////{
            ////    Console.WriteLine($"{ss2} is not available into {ss1}");
            ////}
            //string result=ss1.Insert(2, "*#@");
            //Console.WriteLine("ss1="+ss1);
            //Console.WriteLine("result="+result);


           // string cities = "pune;nashik;nagar,mumbai";
           //string[]myCities=  cities.Split(';');
           // Console.WriteLine("length of mycities="+myCities.Length);
           // for (int i = 0; i < myCities.Length; i++)
           // {
           //     Console.WriteLine(myCities[i]);
           // }

           // string[] states = { "maharashtra", "bihar", "Andhra", "karnataka" };
           // string result = string.Join(";", states);
           // Console.WriteLine("result="+result);

            string strNew = "pune mumbai";
            Console.WriteLine(strNew.Length);//4
            string resultString = strNew.Trim();
            Console.WriteLine(resultString.Length);//4
        }
    }
}
