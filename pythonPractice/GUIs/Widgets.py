from tkinter import *  #import all from tkinter.

root = Tk()

one = Label(root, text="One", bg="red", fg="white")
one.pack()
two = Label(root, text="Two", bg="red", fg="white")
two.pack(fill=X) #grows with X axis
three = Label(root, text="Three", bg="red", fg="white")
three.pack(side=LEFT, fill=Y) #grows with Y axis

root.mainloop()