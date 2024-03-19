using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class Nhom
    {
        private int nhomId;

        public Nhom() { }

        public Nhom(int nhomId)
        {
            this.nhomId = nhomId;
        }

        public int NhomId { get => nhomId; set => nhomId = value; }
    }
}
