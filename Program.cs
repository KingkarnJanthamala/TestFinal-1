using System;

class Program {
    static void Main(string[] args) {
        int NumOfCity = int.Parse(Console.ReadLine()); //NumOfCity คือจำนวนตัวแปรเมืองที่แสดงในแบบจำลอง
        int[] City = new int[NumOfCity]; //City คือหมายเลขประจำเมือง
        for (int i = 0 ; i < NumOfCity ; i++) {
           City[i] = int.Parse(Console.ReadLine());
           DetailOfCity(City);
        }
    }
    static void DetailOfCity(int[] City) { //DetailOfCity() คือฟังก์ชันรายละเอียดของเมือง
        string NameOfCity = Console.ReadLine(); //NameOfCity คือชื่อเมือง
        int NumOfContactCity = int.Parse(Console.ReadLine());//NumOfContactCity คือจำนวนเมืองที่ติดต่อ
        int[] ContactCity = new int[NumOfContactCity]; //ContactCity คือหมายเลขประจำเมืองที่ติดต่อ
        Contact(ContactCity , NumOfContactCity);
    }
    static void Contact(int[] ContactCity , int NumOfContactCity) { //Contact คือฟังก์ชันติดต่อในข้อ 1.2 1.3
      
    } 
}
