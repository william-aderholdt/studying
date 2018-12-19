#include <stdio.h>
#include <cs50.h> //defines variables which would be used in the library.

int main(void)
{
    string name = get_string("Name: ");
    printf("hello, world\n");
}


//clang hello.c -lccs50
//make hello == makes a program which already has the arguments for the compiler.