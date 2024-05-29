namespace tp1_2.Models.Repositories
{
    public class EmployeRepository : IRepository<Employe>
    {
        List<Employe> lemployes;
        public EmployeRepository()
        {
            lemployes = new List<Employe>()
{
new Employe {Id=1,Name="Sofien ben ali", Departement= "comptabilité",Salary=1000},
new Employe {Id=2,Name="Mourad triki", Departement= "RH",Salary=1500},
new Employe {Id=3,Name="ali ben mohamed", Departement= "informatique",Salary=1700},
new Employe {Id=4,Name="tarak aribi", Departement= "informatique",Salary=1100}
};
        }

        public void Add(Employe e)
        {
            lemployes.Add(e);
        }
        public Employe FindByID(int id)
        {
            var emp = lemployes.FirstOrDefault(a => a.Id == id);
            return emp;
        }
        public void Delete(int id)
        {
            var emp = FindByID(id);
            lemployes.Remove(emp);
        }
        public IList<Employe> GetAll()
        {
            return lemployes;
        }
        public void Update(int id, Employe newemployee)
        {
            var emp = FindByID(id);
            emp.Name = newemployee.Name;
            emp.Departement = newemployee.Departement;
            emp.Salary = newemployee.Salary;
        }

        public List<Employe> Search(string term)
        {
            throw new NotImplementedException();
        }
    }
}
