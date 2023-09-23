using System.Transactions;

namespace MVCEFwebApp.Models
{
    public class RepositoryDr
    {
        public static List<Doctor> GetDoctors()
        {
            HospitalDbContext hctx = new HospitalDbContext();
            var list  = hctx.Doctors.ToList();
            return list;
        }
        public static Doctor GetDoctorById(int id) {
            HospitalDbContext hoctx = new HospitalDbContext();
            var doctor = hoctx.Doctors.Find(id);
            return doctor; 
        }
        public static void AddNewDoctor(Doctor doctor) {
            HospitalDbContext hoctx = new HospitalDbContext();
            hoctx.Doctors.Add(doctor);
            hoctx.SaveChanges();
        }

        public static void ModifyDr(Doctor dr)
        {
            HospitalDbContext hoctx = new HospitalDbContext();
            hoctx.Entry(dr).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            hoctx.SaveChanges();
        }
        public static void Removedr (int id)
        {
            HospitalDbContext hctx =  new HospitalDbContext ();
            Doctor doctor = hctx.Doctors.Find(id);
            hctx.Doctors.Remove(doctor);
            hctx.SaveChanges ();
        }
    }
}
