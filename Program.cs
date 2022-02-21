using System;

namespace film21
{
    class Program
    {
        static void Main(string[] args)
        {
          
            person person1 = new person();
            person1.setname("javad");
            person1.setlastname("javad");
            person1.setage(12);
            person1.setavg(19f);
            person1.setter(122,21,18f);
            person1.printpersonInfo();

            person person2 = new person();
            person2.setpersonId(123);
            person2.setname("mahdi");
            person2.setlastname("aghee");
            person2.setage(56);
            person2.setavg(20f);
            person2.printpersonInfo();
            //Console.WriteLine(person2.getpersonid());
            //Console.WriteLine(person2.getlastname());
            //Console.WriteLine(person2.getage());
            //Console.WriteLine(person2.getname());
            //Console.WriteLine(person2.getavg());
            //یا
            Console.WriteLine(person2.getpersonid()+" "+ person2.getlastname()+" "+person2.getage()+ " "+person2.getname()+ " "+person2.getavg());

            //person1.personId = 12;
            //person2.personId = 14;
            //person1.printpersonInfo();
            //person2.printpersonInfo();


        }

    }
    class person
    {
        //public  int personId;
        //  public string firstname;
        int personId;
        string firstname;
        string lastname;
        int age;
        float avg;
        //public void printpersonInfo()
        //{
        //    Console.WriteLine("id:{0} ", personId);
        //}

        public void printpersonInfo()
        {
            Console.WriteLine("id:{0} \tname:{1}\tlastname:{2}\tage:{3}\tavg:{4}", personId, firstname, lastname, age, avg);
        }
        public void setpersonId(int id)
        {
            personId = id;
        }
        public int getpersonid()
        {
            return personId;

        }
        public void setname(string name)
        {
            firstname = name;
        }
        public string getname()
        {
            return firstname;

        }
        public void setlastname(string lastname)
        {
            this.lastname = lastname;
        }
        public string getlastname()
        {
            return lastname;

        }
        public void setage(int age)
        {
            this.age = age;
        }
        public int getage()
        {
            return this.age;

        }
        public void setavg(float avg)
        {
            this.avg = avg;
        }
        public float getavg()
        {
            return this.avg;

        }
        public void setter(int id,string name,string family,int age,float avg)
        {
            personId = id;
            firstname = name;
            lastname = family;
            this.age = age;
            this.avg = avg;
        }
        public void setter(int id, int age, float avg)
        {
            personId = id;
            this.age = age;
            this.avg = avg;
        }
    }


}
