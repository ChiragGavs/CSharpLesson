namespace MVCEFwebApp.Models
{
    public class RepositoryPatient
    {
        public static List<Patient> GetPatients()
        {
            HospitalDbContext hctx = new HospitalDbContext();
            var list = hctx.Patients.ToList();
            return list;
        }
        public static Patient GetPatientById(int id)
        {
            HospitalDbContext hoctx = new HospitalDbContext();
            var Patient = hoctx.Patients.Find(id);
            return Patient;
        }
        public static void AddNewPatient(Patient Patient)
        {
            HospitalDbContext hoctx = new HospitalDbContext();
            hoctx.Patients.Add(Patient);
            hoctx.SaveChanges();
        }

        public static void ModifyPatient(Patient patient)
        {
            HospitalDbContext hoctx = new HospitalDbContext();
            hoctx.Entry(patient).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            hoctx.SaveChanges();
        }
        public static void RemovePatient(int id)
        {
            HospitalDbContext hctx = new HospitalDbContext();
            Patient Patient = hctx.Patients.Find(id);
            hctx.Patients.Remove(Patient);
            hctx.SaveChanges();
        }
    }
}
