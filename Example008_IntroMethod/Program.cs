int max (int arg1,int arg2, int arg3)
{
    int result=arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
int a1 =15;
int b1 = 21;
int c1 = 39;
int a2 = 112;
int b2 = 223; 
int c2 = 33;
int a3 = 55;
int b3 = 223;
int c3 = 313;

int max1 = max(a1, b1, c1);
int max2 = max(a2, b2, c2);
int max3 = max(a3, b3, c3);
Console.WriteLine(max);