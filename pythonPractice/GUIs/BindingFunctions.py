from tkinter import *  #import all from tkinter.

root = Tk()

def printName():
    print("Hello my name is Bucky!")

button_1 = Button(root, text="Print my name", command=printName)
button_1.pack()

root.mainloop()