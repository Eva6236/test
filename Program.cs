    
int n = 30;
int m = 10;
int x = 10000;
int total = calculate (n,m,x);
System.Console.WriteLine(total);


int calculate(int n,int m, int x ) 
{
int total = 0;
int price = x;

for (int i = 1; i <= n; i++)
{
    total += price;

    if (i % m == 0)
    {
        x += 1000;
    }  
    
}
    
    return total;

}


