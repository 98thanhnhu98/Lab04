using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class program
    {
        public static List<Faculty> list = new List<Faculty>();
        public static List<Staff> list2 = new List<Staff>();
        public static List<Student> list3 = new List<Student>();
        public static void Main(string[] cmd)
        {
            Console.WriteLine("Nhap ten :");
            string name = Console.ReadLine();

            Console.WriteLine("Nhap so dien thoai :");
            string phone = Console.ReadLine();

            Console.WriteLine("Nhap tuoi :");
            int age = int.Parse(Console.ReadLine());

            if (age >= 19)
            {
                Console.WriteLine("Chon nghe cua ban");
                int chon = int.Parse(Console.ReadLine());
                if(chon == 1)
                {
                    try
                    {
                    Console.WriteLine("Nghe cua ban la Faculty");
                    Console.WriteLine("Chon cấp bậc của bạn :\n1. Senior\n2. Senior Lecture");
                    int c = int.Parse(Console.ReadLine());
                    int rank = 0;
                    int officeHours = 8;

                    if (c == 1){ rank = 1;}
                    else {rank = 2;}

                    Console.WriteLine("Nhập lương của bạn :");
                    float salary = float.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập Ngày bắt đầu làm (mm/dd/yyyy):");
                    DateTime JoiningDateTime = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Bộ phận hiện tại bạn đang làm :");
                    string de = "no department";
                    Faculty faculty = new Faculty(officeHours,de,salary,JoiningDateTime,name,phone,age);
                    list.Add(faculty);
                        foreach (Faculty emp  in list)
                        {
                            Console.WriteLine(emp);
                        }
                        faculty.CalculBonus();
                        faculty.CalculationVacation();
                    
                    }catch (IOException ex)
                {
                    Console.WriteLine(ex.InnerException);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                }
                finally
                {
                    Console.WriteLine("Next\n");
                }
            }
                else if(chon == 2)
                {
                    try
                    {
                        Console.WriteLine("Nghe cua ban la Staff");
                        Console.WriteLine("Nhập biệt danh của bạn :");
                        string titles = "null";
                        titles = Console.ReadLine();
                        Console.WriteLine("Nhập lương của bạn :");
                        float salarytwo = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập Ngày bắt đầu làm (mm/dd/yyyy):");
                        DateTime JoiningDateTime = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Bộ phận hiện tại bạn đang làm :");
                        string de = "no department";
                        Staff staff = new Staff(titles,de,salarytwo,JoiningDateTime,name,phone,age);
                        staff.ToString();
                        staff.CalculBonus();
                        staff.CalculationVacation();
                    }catch(IOException ex)
                    {
                        Console.WriteLine(ex.InnerException);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.InnerException);
                    }
                    finally
                    {
                        Console.WriteLine("Next\n");
                    }
                }
                else
                {
                    Console.WriteLine("Ban dang that nghiep ????");
                }
            }
            else
            {
                Console.WriteLine("Welcome Student");
                Console.WriteLine("Chon chuong trinh cua ban");
                Console.WriteLine("1. Business\n2.Computer Science\nOther. No service");
                int chon = int.Parse(Console.ReadLine());
                string rolle = "No Service";
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("you chose Business !!");
                        rolle = "Business";
                        break;
                    case 2:
                        Console.WriteLine("you chose Computer Science !!");
                        rolle = "Computer Science";
                        break;
                }
                Student e2 = new Student(rolle, name, phone, age);
                Console.WriteLine(e2);
            }
        }
    }
}
