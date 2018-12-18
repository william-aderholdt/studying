// Integer arthmetic

#include <cs.50.h>
#include <stdio.h>

int main(void)
{
    // Prompt user for x
    int x = get_int("x: ");

    // Prompt user for y
    int y = get_int("y: ");

    // Perform arithmetic
    printf("%i plus %i is %i\n", x, y, x + y);
    
    // Can also -,*,/,%
}