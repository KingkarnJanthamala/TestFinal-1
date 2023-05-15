using System;

class Program {
    static void Main(string[] args) {
        int NumOfCity = int.Parse(Console.ReadLine()); //NumOfCity คือจำนวนตัวแปรเมืองที่แสดงในแบบจำลอง
        int[] City = new int[NumOfCity]; //City คือเมือง
        for (int i = 0 ; i < NumOfCity ; i++) {
           City[i] = int.Parse(Console.ReadLine());
           DetailOfCity(City);
        }
    }
    static void DetailOfCity(int[] City) { //DetailOfCity() คือฟังก์ชันรายละเอียดของเมือง
        string NameOfCity = Console.ReadLine();
        int NumOfContactCity = int.Parse(Console.ReadLine());
        int[] ContactCity = new int[NumOfContactCity];
        Contact(ContactCity , NumOfContactCity);
    }
    static void Contact(int[] ContactCity , int NumOfContactCity) {
       while (true) {
        ContactCity[0] = int.Parse(Console.ReadLine());
       }

    } 
}
