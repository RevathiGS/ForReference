using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;
using HealthCare_DAL;
using System.Data.Entity;
using System.Linq;
using System.Data;

namespace HealthCare_BLL
{
    public class States : IStates
    {
        IUnitOfWork unitOfWork;
        IStatesRepository _statesRepository;

        public States(IUnitOfWork unitOfWork, IStatesRepository _statesRepository)
        {
            this.unitOfWork = unitOfWork;
            this._statesRepository = _statesRepository;
        }

        public string GetStatesById(int id)
        {
            string state;
            state = _statesRepository.FirstOrDefault(x => x.Id == id).ToString();
            return state;
        }
    }

    public interface IStates
    {
        string GetStatesById(int id);
    }
}