using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mid_1
{
     class TestStudent
    {
        List<Student> listStudent = new List<Student>();
        public void AddStudent()
        {
            Student st = new Student();
            Console.WriteLine("Nhap id: ");
            st.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten: ");
            st.Name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            st.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ngay sinh: ");
            st.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap lop: ");
            st.Class = Console.ReadLine();
            Console.WriteLine("Nhap diem mon thu 1: ");
            st.Mark1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem mon thu 2: ");
            st.Mark2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem mon thu 3: ");
            st.Mark3 = Convert.ToDouble(Console.ReadLine());
            listStudent.Add(st);

        }
        public void ShowListStudent()
        {
            if (listStudent.Count > 0)
            {
                foreach (var st in listStudent)
                {
                    ShowStudent(st);
                }
            }
            else
            {
                Console.WriteLine("Danh sach hoc sinh trong");
            }
        }
        public void ShowStudent(Student st)
        {
            Console.WriteLine("ID :" + st.Id);
            Console.WriteLine("Name: " + st.Name);
            Console.WriteLine("Tuoi: " + st.Age);
            Console.WriteLine("Ngay sinh: " + st.DateOfBirth);
            Console.WriteLine("Lop: " + st.Class);
            Console.WriteLine("Diem mon thu 1: " + st.Mark1);
            Console.WriteLine("Diem mon thu 2: " + st.Mark2);
            Console.WriteLine("Diem mon thu 3: " + st.Mark3);
            Console.WriteLine("Diem trung binh :" + st.mark_AVG());
        }
        public void GetStudent(string name)
        {
            bool check = false;
            foreach(var item in listStudent)
            {
                if(item.Name == name)
                {
                    check = true;
                    ShowStudent(item);
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine("Khong tin thay hoc sinh co ten tuong ung");
            }
        }
        public void EditInfoStudent(int id)
        {
            bool check = false;
            if(listStudent.Count > 0)
            {
                foreach(var item in listStudent)
                {
                    if(item.Id == id)
                    {
                        check = true;
                        Console.Write("Nhap id moi: ");
                        item.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap ten moi: ");
                        item.Name = Console.ReadLine();
                        Console.Write("Nhap so tuoi moi:");
                        item.Age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap ngay sinh moi: ");
                        item.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Nhap lop moi: ");
                        item.Class = Console.ReadLine();
                        Console.Write("Nhap diem mon thu 1: ");
                        item.Mark1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhap diem mon thu 2: ");
                        item.Mark2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhap diem mon thu 3: ");
                        item.Mark3 = Convert.ToDouble(Console.ReadLine());
                    }
                }
                if (!check)
                {
                    Console.WriteLine("Khong co hoc sinh nao co ID ma ban da nhap");
                }
            }
            else
            {
                Console.WriteLine("Danh sach khong co hoc sinh nao ca");
            }
        
        }
        public void DeleteStudentById(int id)
        {
            bool check = false;
            if(listStudent.Count > 0)
            {
                foreach(var item in listStudent)
                {
                    if(item.Id == id)
                    {
                        check = true;
                        listStudent.Remove(item);
                        Console.WriteLine("Da xoa hoc sinh co id " + id);
                        break;
                    }
                }
                if (!check)
                {
                    Console.WriteLine("Khong co hoc sinh nao co id ma ban da nhap");
                }
            }
            else
            {
                Console.WriteLine("Danh sach khong co hoc sinh nao ca");
            }
        }
        public void SortByMarkAVG()
        {
            int count = listStudent.Count;
            if(count > 0)
            {
                for(int i = 0;i< count; i++)
                {
                    for(int j = i + 1; j < count; j++)
                    {
                        if (listStudent[i].mark_AVG() > listStudent[j].mark_AVG())
                        {
                            Student temp = listStudent[i];
                            listStudent[i] = listStudent[j];
                            listStudent[j] = temp;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Khong the sap sep danh sach trong");
            }
        }
    }
}
