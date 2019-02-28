#include <stdio.h>

int main()
{
    int num1, num2;
    int sum, sub, mult, mod;
    float div;


    printf("Enter any two numbers: ");
    scanf("%d%d", &num1, &num2);


    sum = num1 + num2;
    sub = num1 - num2;
    mult=num1*num2;
    div=num1/num2;

    printf("SUM = %d\n", sum);
    printf("DIFFERENCE = %d\n", sub);
    printf("multy=%d",mult);

    return 0;
}


