using System;
using System.Linq;
using System.Text;

namespace CS007_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String loichao; //null
            string ten = "Anh Thu";
            loichao = "Xin chao";

            string thongbao = loichao + " " + ten;
            thongbao += " !";
            Console.WriteLine(thongbao);

            string thongbao1;
            thongbao1 = "Hoc ve chuoi ky tu \"String\"";// \": dau ngoac kep; \\:\ ; \t:tab; \r: dau dong ; \n: xuong dong 
            Console.WriteLine(thongbao1);

            string thongbao2;
            
            //dau @ in ra chuoi giong het trong dau ngoac kep
            thongbao2 = @"Xin chao          Anh Thu
            Anh Thu de thuong 
            :)";
            Console.WriteLine(thongbao2);
            
            //dau $ chen bieu thuc vao chuoi
            int x = 2017;
            string thongbao3 = $"Xin chao {x}";//{x,10}: chua 10 khoang trong de in gia tri x, canh le phai, muon canh trai : {x, -10}
            string thongbao4 = $"Xin chao {x + 4}";
            Console.WriteLine(thongbao3);
            Console.WriteLine(thongbao4);
            
            string name = "Nguyen Thi Anh Thu";
            string gioitinh = "Nu";
            string thongbao5 = $@"
            Ho va ten: {name, -10}
            Nam sinh: {x, -10}
            Gioi tinh: {gioitinh, -10}";
            Console.WriteLine(thongbao5);

            string thongbao6 = "AnhThu xin chao cac ban";
            int dodai = thongbao6.Length;
            
            Console.WriteLine(dodai);
            
            for (int i = 0; i < dodai; i++)
            {
                char kytu = thongbao6[i];
                Console.Write(kytu);
            }
            Console.WriteLine();

            // foreach (var kytu in thongbao6)
            // {
            //     Console.Write(kytu);               
            // }

            //Trim() cat bo ki tu khoang trang o dau va cuoi cua chuoi
            //Trim('???') cat bo ki tu dac biet o dau va cuoi cua chuoi
            //TrimStart('???') cat bo ki tu dac biet o dau cua chuoi
            //TrimEnd('???') cat bo ki tu dac biet o cuoi cua chuoi
            string thongbao7 = "   Anh Thu de thuong";
            string thongbao8 = "###Anh Thu say hello##";
            string a = thongbao7.Trim();
            string b = thongbao8.Trim('#');// cat bo khoang trang o dau va cuoi chuoi
            string c = thongbao8.TrimEnd('#');
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine(thongbao7.ToLower());
            Console.WriteLine(thongbao7.ToUpper());

            Console.WriteLine("===================================");

            String thongbao9 = "Nguyen Thi Anh Thu xin chao";

            Console.WriteLine(thongbao9.Replace("xin chao", "chao mung"));

            thongbao9 =thongbao9.Insert(10, " 2021");
            Console.WriteLine(thongbao9);
            thongbao9 = thongbao9.Remove(23, 4);// bo 4 ki tu sau vi tri 23 cua chuoi
            Console.WriteLine(thongbao9);
            thongbao9 = thongbao9.Substring(4, 8);
            Console.WriteLine(thongbao9);

            
            string[] cacchuoicon = thongbao.Split(' ');
            foreach (var s in cacchuoicon)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();
            
            string[] chuoicon = {"Hoc", "Lap", "Trinh", "Rat", "Kho"};
            string noichuoi = string.Join(' ', chuoicon);
            Console.Write(noichuoi);   

            Console.WriteLine("\n==============================");

            //cap phat bo nho cho doi tuong stringbuild, tat ca cac phep toan ve chuoi se duco thuc hien tren doi tuong stringBuilder ma khong tao ra doi tuong moi nen it ton hieu nang
            StringBuilder thongbao10 = new StringBuilder();
            thongbao10.Append("Xin");
            Console.WriteLine(thongbao10);
            thongbao10.Append(" chao cac ban");
            Console.WriteLine(thongbao10);
            thongbao10.Replace("Xin chao", "Chao mung");
            Console.WriteLine(thongbao10);
            string ketqua = thongbao10.ToString();

            Console.WriteLine("Ket qua la: {0}", ketqua);
        }

    }
}
