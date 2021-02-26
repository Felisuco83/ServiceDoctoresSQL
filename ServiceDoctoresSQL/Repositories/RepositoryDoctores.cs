using ServiceDoctoresSQL.Data;
using ServiceDoctoresSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDoctoresSQL.Repositories
{
    public class RepositoryDoctores
    {
        private DoctoresContext context;
        //public RepositoryDoctores ()
        //{
        //    this.context = new DoctoresContext();
        //}
        public RepositoryDoctores(DoctoresContext context)
        {
            this.context = context;
        }
        public List<Doctor> GetDoctores()
        {
            return this.context.Doctores.ToList();
        }

        public Doctor BuscarDoctor(int idDoctor)
        {
            return this.context.Doctores.FirstOrDefault(x => x.IdDoctor == idDoctor);
        }
    }
}
