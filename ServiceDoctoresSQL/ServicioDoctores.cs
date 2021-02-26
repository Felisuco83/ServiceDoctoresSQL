using ServiceDoctoresSQL.Models;
using ServiceDoctoresSQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDoctoresSQL
{
    public class ServicioDoctores: IServicioDoctores
    {
        private RepositoryDoctores repo;
        public ServicioDoctores(RepositoryDoctores repo)
        {
            this.repo = repo;
        }
        public Doctor BuscarDoctor(int idDoctor)
        {
            return this.repo.BuscarDoctor(idDoctor);
        }

        public List<Doctor> GetDoctores()
        {
            return this.repo.GetDoctores();
        }
    }
}
