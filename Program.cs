using System;

void OutputArray(string[] input){
    Console.Write("[");
    for (int index=0;index<input.Length;index++){
        if (index!=input.Length-1)
            Console.Write("{0}, ", input[index]);
        else
            Console.Write("{0}", input[index]);
    }
    Console.WriteLine("]");
};

string[] SortSmall(string[] input){
    int count = 0;
    for (int index=0;index<input.Length;index++){
        if (input[index].Length<=3) count++;
    }
    string[] sorted = new string[count];
    int j = 0;
    for (int index=0;index<input.Length;index++){
        if (input[index].Length<=3){
            sorted[j] = input[index];
            j++;
        };
    }
    return sorted;
};

string test = "123";
int x = Convert.ToInt16(test);
Console.WriteLine("The input number is {0}", x);


Console.WriteLine("enter the number of elements to fill the matrix");
string raw = Console.ReadLine();
int n = Convert.ToInt32(raw);
string[] M = new string[n];
for (int i = 0;i<n;i++){
    Console.WriteLine("Enter element {0}:", i);
    M[i] = Console.ReadLine();
}

string[] sorted = SortSmall(M);

Console.WriteLine("Initial input array is:");
OutputArray(M);

Console.WriteLine("Sorted array is:");
OutputArray(sorted);

