#include <cs50.h>
#include <stdio.h>

int square(int n) //prototype

int main(void) //void does not take input.
{
    int x = get_int("x: ");
    printf("%i\n", square(x));
}

int square(int n) //int n takes an input.
{
    return n * n;
}