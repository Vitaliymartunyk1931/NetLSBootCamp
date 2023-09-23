using System;
using System.Runtime.InteropServices;

public static class MemoryAddress
{
    public static string Get(object a)
    {
        try
        {
            GCHandle handle = GCHandle.Alloc(a, GCHandleType.Pinned);
            IntPtr pointer = GCHandle.ToIntPtr(handle);
            handle.Free();
            return "0x" + pointer.ToString("X");
        }
        catch (Exception ex)
        {
            return "Error: " + ex.Message;
        }
    }
}

struct MyStruct
{
    public int Value;
}

class Program
{
    static void Main()
    {
        int value1 = 13;
        int value2 = 13;
        MyStruct struct1 = new MyStruct { Value = 13 };
        MyStruct struct2 = new MyStruct { Value = 13 };

        string address1 = MemoryAddress.Get(value1);
        string address2 = MemoryAddress.Get(value2);
        string address3 = MemoryAddress.Get(struct1);
        string address4 = MemoryAddress.Get(struct2);

        Console.WriteLine("Memory Address for value1: " + address1);
        Console.WriteLine("Memory Address for value2: " + address2);
        Console.WriteLine("Memory Address for struct1: " + address3);
        Console.WriteLine("Memory Address for struct2: " + address4);
    }
}
