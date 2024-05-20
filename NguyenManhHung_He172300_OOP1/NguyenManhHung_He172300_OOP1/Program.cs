namespace NguyenManhHung_He172300_OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee hung = new PartTimeEmployee("Nguyen Manh Hung",5,8);
            Employee thuy = new PartTimeEmployee("Hoang Ngoc Thuy", 4, 8);
            Employee thang = new PartTimeEmployee("Vu Cong Thang", 3, 8);
            Employee vu = new PartTimeEmployee("Nguyen Trong Vu", 5, 6);
            Employee trang = new PartTimeEmployee("Cao Thi Quynh Trang", 7, 8);
            Employee nv1 = new FullTimeEmployee("Nguyen Van A", 7);
            Employee nv2 = new FullTimeEmployee("Nguyen Van B", 8);
            Employee nv3 = new FullTimeEmployee("Nguyen Van C", 9);
            Employee nv4 = new FullTimeEmployee("Nguyen Van D", 10);
            Employee nv5 = new FullTimeEmployee("Nguyen Van E", 6);
            Employee nv6 = new FullTimeEmployee("Nguyen Van F", 7);

            List<Employee> list1 = new List<Employee>();
            list1.Add(hung);
            list1.Add(thuy);
            list1.Add(thang);
            list1.Add(vu);
            list1.Add(trang);
            List<Employee> list2 = new List<Employee>();
            list2.Add(nv1);
            list2.Add(nv2);
            list2.Add(nv3);
            list2.Add(nv4);
            list2.Add(nv5);
            list2.Add(nv6);

            // Nhan Vien co luong cao nhat trong part time
            Console.WriteLine((list1.MaxBy(em => em.calculateSalary()) as Employee).toString());
            // Nhan Vien co luong cao nhat trong full time
            Console.WriteLine((list2.MaxBy(em => em.calculateSalary()) as Employee).toString());

            // tim kiem nhan vien theo ten
            string name = "nguyen";
            List<Employee> resultList = list1
                .Concat(list2) 
                .Where(emp => emp.name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList(); 

            foreach (Employee emp in resultList)
            {
                Console.WriteLine(emp.toString());
            }
                

        }
    }
}
