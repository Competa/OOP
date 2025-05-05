static bool Write() //The method is declared with a return type of bool (static bool Write()), but its body doesn't return any value. Every non-void method must return a value of the declared type. The error is not that there are no parameters or that it "should be" a bool, but that the method's signature promises a bool return while the implementation doesn't provide one.
{
½    Console.WriteLine("test Updated Text output from function.");
}
static void MyFunction(string label, params int[] args, bool showLabel) //hThe error isn't that there are no parameters—there are three—but rather that the params keyword must be applied to the last parameter in the parameter list. In your method, params int[] args is followed by the bool showLabel parameter, which isn’t allowed. To fix this, either remove params or reorder the parameters so that the params parameter is last.ere is the second error, params need to be rempved.
{
    if (showLabel)
        Console.WriteLine(label);
    foreach (int i in args)
    Console.WriteLine($"{i}");
}