using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL;
using Library.DAL.Interface;

namespace Library.BLL
{
    public class PartiesManager:Manager<PartyVO>
    {
        public PartiesManager()
            : base(DALManager.GetPartyDAO())
            { }

        public bool IsPartyNew(PartyVO vo)
        {
            List<PartyVO> allParties = GetAll();

            foreach (PartyVO party in allParties)
            {
                if (party.Id != vo.Id)
                {
                    if (party.Name == vo.Name)
                        return false;
                }
            }

            return true;
        }

    }
}
