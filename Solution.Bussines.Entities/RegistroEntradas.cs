using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Solution.Bussines.Entities
{
    public partial class RegistroTiemposParqueo
    {
        public const string EntitySetName = "RegistroTiemposParqueo";


        [Browsable(false)]
        public Carros CarrosRel
        {
            get
            {
                Carros res = null;
                if (this.Carros != null)
                { 
                    res = this.Carros; 
                }
                else
                {
                    this.CarrosReference.Load();
                    if (this.Carros != null)
                    { 
                        res = this.Carros; 
                    }
                }

                return res;
            }
            set
            {
                this.Carros.EntityKey =
                    new EntityKey("RegistroEntradasEntities.Carros", "Id", value);
            }
        }

    }
}
