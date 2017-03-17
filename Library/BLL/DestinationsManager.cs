using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL;

namespace Library.BLL
{
    public class DestinationsManager : Manager<DestinationVO>
    {
        public DestinationsManager()
            : base(DALManager.GetDestinationDAO())
        {
        }

        public bool IsDestinationNew(DestinationVO dest)
        {
            List<DestinationVO> Destinations = GetAll();

            foreach (DestinationVO d in Destinations)
            {
                if (!(d.Id == dest.Id))
                {
                    if (dest.Name == d.Name)
                        return false;
                }
            }

            return true;
        }

    }
}
