using cernyjack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cernyjack.Services
{
    public interface IBusinessLogic
    {
        IList<Card> Deal(string userId = "");
        string GetUserId();
        void EndGame();


    }
}
